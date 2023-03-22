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
        
         public static string Regex_Rule = "^([a-zA-Z0-9]+[.-])*[a-zA-Z0-9]+[@][A-Za-z]+[.][a-zA-Z]{2,3}[,]([.,][a-z]{2})*$"; 
        

        public bool validateEmail(string inputString)
        {
            return Regex.IsMatch(inputString, Regex_Rule);
        }

       
    }
}

