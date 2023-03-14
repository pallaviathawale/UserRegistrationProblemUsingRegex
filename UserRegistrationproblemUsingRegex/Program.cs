namespace UserRegistrationproblemUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            if (pattern.validatePinCode("+91 7218533707"))//Valid phon number
            //if (pattern.validatePinCode("+91 7218533399"))//invalid phon number
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