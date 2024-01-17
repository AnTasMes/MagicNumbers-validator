using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Validator.Web.Annotations
{
    /// <summary>
    /// Whitelist ekstenzija
    /// Ako ekstenzija nije u listi, ocekuje se greska
    /// </summary>
    public class AllowedOnlyExtensions : Attribute
    {
        public string[] allowedOnlyExtensions;

        public AllowedOnlyExtensions(string[] allowedOnlyExtensions)
        {
            this.allowedOnlyExtensions = allowedOnlyExtensions;
        }
    }
}
