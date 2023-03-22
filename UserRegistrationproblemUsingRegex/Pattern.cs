using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationproblemUsingRegex
{
    internal class Pattern
    {
        // public static string Regex_Rule = "^[9][1][ ][6-9][0-9]{9}$";// phon number
        // public static string Regex_Rule = "^[A-Za-z]{6}[0-9][!@#$%^&]@$";//password
        public static string Regex_Rule = "^[a-zA-Z0-9]{8,}$";//UC5-8characters
        // public static string Regex_Rule = "^(?=.*[A-Z]).{8,}$"; //UC6-at least one uppar case
        //  public static string Regex_Rule = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9!@#$%_]{8,}$";//UC7-one numeric number
       // public static string Regex_Rule = "^^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%_])[a-zA-Z0-9!@#$%_]{8,}$"; //UC8-At least one special characters
        // public static string Regex_Rule = "^.{0,7}|[^A-Z]|[^0-9]$"

        public bool Inputvalidate(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }

       
    }
}

