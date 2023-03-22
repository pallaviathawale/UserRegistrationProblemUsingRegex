namespace UserRegistrationproblemUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            //if (pattern.Inputvalidate("pallav2@"))//invalid password
           if (pattern.Inputvalidate("Pallav22")) //valid 
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