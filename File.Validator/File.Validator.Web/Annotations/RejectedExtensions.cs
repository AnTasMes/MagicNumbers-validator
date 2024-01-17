using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Validator.Web.Annotations
{
    /// <summary>
    /// Blacklist ekstenzija
    /// Ako je ekstenzija u listi, ocekuje se greska
    /// </summary>
    public class RejectedExtensions : Attribute
    {
        public string[] rejectedExtensions;

        public RejectedExtensions(string[] rejectedExtensions)
        {
            this.rejectedExtensions = rejectedExtensions;
        }
    }
}
