using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace File.Validator.Web.Middleware
{
    /// <summary>
    /// Ekstenzija za IApplicationBuilder da bi se koristila FileExtensionValidatorMiddleware
    /// Pozvati ispod app.UseRouting(); u Program.cs, ako postoji.
    /// Ako ne postoji app.UseRouting();, pozvati prvo to.
    /// 
    /// Pogledati FileValidatorTestAPI za primer
    /// </summary>
    public static class FileExtensionValidatorMiddlewareExtension
    {
        public static IApplicationBuilder UseFileValidation(
        this IApplicationBuilder builder)
        {

            return builder.UseMiddleware<FileExtensionValidatorMiddleware>();
        }
    }
}
