using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DotBase.Web
{
    public static class UrlExtensions
    {
        // TBD:
        // private static readonly string PATTERN = @"(ftp|https?)://[^\s]+";
        // private static readonly string PATTERN = @"(https?|ftp|file)\://[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*";
        private static readonly string PATTERN = @"(https?|ftp|file)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?";
        private static readonly Regex urlRx = new Regex(PATTERN, RegexOptions.IgnoreCase);

        //public static bool IsURL(string strUrl)
        //{
        //    return urlRx.IsMatch(strUrl);
        //}
        public static bool IsURL(this string me)
        {
            return urlRx.IsMatch(me);
        }

    }
}
