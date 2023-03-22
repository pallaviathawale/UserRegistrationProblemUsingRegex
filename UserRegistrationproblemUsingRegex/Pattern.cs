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
        
         public static string Regex_Rule = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$"; //UC6-at least one numeric Number
        

        public bool Inputvalidate(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }

       
    }
}

