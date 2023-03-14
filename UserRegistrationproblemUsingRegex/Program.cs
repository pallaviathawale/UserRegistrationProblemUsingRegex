namespace UserRegistrationproblemUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            if (pattern.validatePinCode("Athawale"))//Valid name
            //if (pattern.validatePinCode("athawale"))//invalid name
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