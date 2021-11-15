using System;

namespace RegEx_PasswordValidation2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            RegEXPattern registration = new RegEXPattern();
            registration.FirstName();

            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("\n Please enter  First Name--");
            string firstName = Console.ReadLine();
            RegEXPattern.FirstName(firstName);                                          //taking user input and passing it in first name method of regular exp class
            Console.ReadLine();

            Console.WriteLine("Hello World!");
            RegEXPattern registration1 = new RegEXPattern();
            registration.LastName();

            RegEXPattern mobile = new RegEXPattern();
            mobile.Validation();
            Console.ReadLine();
            RegEXPattern Mail = new RegEXPattern();
            mobile.Validation();

            RegEXPattern Pass1 = new RegEXPattern();
            Pass1.PAsswordValidation();


            RegEXPattern Pass2 = new RegEXPattern();
            Pass2.PAsswordValidation2();
        }
    }
}
