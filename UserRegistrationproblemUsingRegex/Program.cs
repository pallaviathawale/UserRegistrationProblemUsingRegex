namespace UserRegistrationproblemUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            if (pattern.validatePinCode("Pallavi"))//Valid name
            //if (pattern.validatePinCode("pallaviathawale"))//invalid name
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