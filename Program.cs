using System.Text.RegularExpressions;

namespace RegexPracticeProblem
{
    public static class Pattern
    {
        public static string FirstName = "^[A-Z][a-z]{4}$";
        public static string LastName = "^[A-Z][a-b]{3}$";
        public static string EmailId = "^[a-z]{5}[.][a-z]{4}[@][a-z]{2}[.][a-z]{2}[.][a-z]{2}$";
        public static string PhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
        public static string Password = "^[A-Z][a-z]{8}[@][0-9]{3}";
    }
        class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Name");
            Regex uc1 = new Regex(Pattern.FirstName);
            Console.WriteLine(uc1.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter the Last Name");
            Regex uc2 = new Regex(Pattern.LastName);
            Console.WriteLine(uc2.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter the EmailId");
            Regex uc3 = new Regex(Pattern.EmailId);
            Console.WriteLine(uc3.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter the PhoneNumber");
            Regex uc4 = new Regex(Pattern.PhoneNumber);
            Console.WriteLine(uc4.IsMatch(Console.ReadLine()));

            Console.WriteLine("Enter the Password");
            Regex uc5 = new Regex(Pattern.Password);
            Console.WriteLine(uc5.IsMatch(Console.ReadLine()));
        }
    }
}
