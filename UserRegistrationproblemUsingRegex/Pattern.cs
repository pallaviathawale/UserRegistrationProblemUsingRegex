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
        public static string Regex_Rule = "^[A-Z][A-Za-z]{3,9}$";

        public bool validatePinCode(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }
    }
}

