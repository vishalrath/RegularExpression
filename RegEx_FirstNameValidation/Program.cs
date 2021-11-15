using System;

namespace RegEx_FirstNameValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            RegExUc1 registration = new RegExUc1();
            registration.FirstName();

            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("\n Please enter  First Name--");
            string firstName = Console.ReadLine();
            RegExUc1.FirstName(firstName);                                          //taking user input and passing it in first name method of regular exp class
            Console.ReadLine();
        }
    }
}
