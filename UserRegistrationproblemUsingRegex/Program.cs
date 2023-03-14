namespace UserRegistrationproblemUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            if (pattern.validatePinCode("abc.xyz@bl.co.in"))//Valid email
            //if (pattern.validatePinCode("abc.xyz@gmail.com.in1"))//invalid name
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