using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace niaps_ver_1._0
{
    public class niapsValidation
    {
        public static bool checkForEmail(string email)
        {
            bool IsValid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
            {
                IsValid = true;
            }
            return IsValid;
        }
    }
}
