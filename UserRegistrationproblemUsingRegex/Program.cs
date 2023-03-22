namespace UserRegistrationproblemUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            //Eamil-Samples
            //if (pattern.validateEmail("abc@yahoo.com,")) //valid 
            //if (pattern.validateEmail("abc-100@yahoo.com,"))//valid
            //if (pattern.validateEmail("abc.100@yahoo.com")) //valid
            if (pattern.validateEmail("abc111@abc.com,"))//
            
            {
                    Console.WriteLine("Valid");
                }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
    
}