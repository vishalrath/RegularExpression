using System;

namespace RegEx_PasswordVallidaathion4
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

            RegExPattern mobile = new RegExPattern();
            mobile.Validation();
            Console.ReadLine();
            RegExPattern Mail = new RegExPattern();
            mobile.Validation();

            RegExPattern Pass1 = new RegExPattern();
            Pass1.PAsswordValidation();


            RegExPattern Pass2 = new RegExPattern();
            Pass2.PAsswordValidation2();
            RegExPattern Pass3 = new RegExPattern();
            Pass2.PAsswordValidation3();

            RegExPattern Pass4 = new RegExPattern();
            Pass4.PAsswordValidation3();
        }
    }
}
