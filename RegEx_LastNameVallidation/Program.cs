using System;

namespace RegEx_LastNameVallidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RegExPattern registration = new RegExPattern();
            registration.FirstName();

            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("\n Please enter  First Name--");
            string firstName = Console.ReadLine();
            RegExPattern.FirstName(firstName);                                          //taking user input and passing it in first name method of regular exp class
            Console.ReadLine();

            Console.WriteLine("Hello World!");
            RegExPattern registration1 = new RegExPattern();
            registration.LastName();

           
        }
    }
}
