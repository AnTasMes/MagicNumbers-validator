using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Validator.Web.Annotations
{
    /// <summary>
    /// Lista ignorisanih ekstenzija
    /// Ako je ekstenzija u listi, preskoci proveru za taj fajl
    /// </summary>
    public class IgnoredExtensions : Attribute
    {
        public string[] ignoredExtensions;

        public IgnoredExtensions(string[] ignoredExtensions)
        {
            this.ignoredExtensions = ignoredExtensions;
        }
    }
}
