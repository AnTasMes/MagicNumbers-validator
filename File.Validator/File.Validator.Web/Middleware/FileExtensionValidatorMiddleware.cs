using File.Validator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using File.Validator.Web.Annotations;

namespace File.Validator.Web.Middleware
{
    public class FileExtensionValidatorMiddleware
    {
        private readonly RequestDelegate _next;

        public FileExtensionValidatorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Poziva metodu middleware-a.
        /// Potreban je routing za endpoint.
        /// Pozivanje ove metode nezavisno nije preporuceno.
        /// </summary>
        /// <param name="context">Preuzima HTTPContext iz HTTP request-a koji se prosledi pre middleware-a</param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {

            if (!context.Request.HasFormContentType)
            {
                await _next(context);
                return;
            }

            IFormCollection? form = null;

            try
            {
                // Izvlacimo formu iz konteksta
                form = await context.Request.ReadFormAsync();
            }
            catch (Exception)
            {

                // Ako forma ne moze da se izvuce, nije moguce pronaci fajl.
                await _next(context);
                return;
            }

            // Ako forme nema, nastavi dalje
            if (form == null)
            {
                await _next(context);
                return;
            }

            // Preuzimanje atributa za naglasene ekstenzije
            Endpoint? endpoint = null;

            try
            {
                // Endpoint nije moguce naci ako ne postoji routing middleware pre ovog.
                // Potrebna je registracija app.UseRouting(); da bi pristup anotacijama bio moguc.
                endpoint = context.Features.Get<IEndpointFeature>()?.Endpoint;
            }
            catch (Exception) { }

            RejectedExtensions? rejectedExtensions = null;
            IgnoredExtensions? ignoredExtensions = null;
            AllowedOnlyExtensions? allowedOnlyExtensions = null;
            if (endpoint != null)
            {
                rejectedExtensions = endpoint?.Metadata.GetMetadata<RejectedExtensions>();
                ignoredExtensions = endpoint?.Metadata.GetMetadata<IgnoredExtensions>();
                allowedOnlyExtensions = endpoint?.Metadata.GetMetadata<AllowedOnlyExtensions>();
            }

            // Prodji kroz sve fajlove prosledjene kroz formu
            foreach (var file in form.Files)
            {
                // Izvuci ekstenziju
                string ext = Path.GetExtension(file.FileName).ToLower().Replace(".", "");

                // Ako ekstenzija ne pripada dozvoljenim ekstenzijama
                if (allowedOnlyExtensions != null && !allowedOnlyExtensions.allowedOnlyExtensions.Contains(ext))
                {
                    Unauthorized(context, $"File with this extension (.{ext}) is not allowed.");
                    return;
                }

                // Ako postoji zabranjena ekstenzija, prekini proces
                if (rejectedExtensions != null && rejectedExtensions.rejectedExtensions.Contains(ext))
                {
                    // Vrati unauthorized
                    Unauthorized(context, $"File with this extension (.{ext}) not allowed.");
                    return;
                }

                // Ako postoji neka ignorisana ekstenzija, nju preskoci
                if (ignoredExtensions != null && ignoredExtensions.ignoredExtensions.Contains(ext))
                    continue;


                // Proveri da li fajl ima vrednost
                if (file != null && file.Length > 0)
                {
                    // Procitaj vrednost fajla
                    using (var reader = new MemoryStream())
                    {
                        file.CopyTo(reader);

                        if (!FileValidator.isValidExtension(reader, ext))
                        {
                            // Vrati unauthorized
                            Unauthorized(context, $"File with this extension (.{ext}) is not valid.");
                            return;
                        }
                    }
                }
            }

            await _next(context);
        }

        /// <summary>
        /// Postavla StatusCode na 401 - Unauthorized
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        private async void Unauthorized(HttpContext context, string message)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync(message);
        }
    }
}
