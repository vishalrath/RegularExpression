using System;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to User Registration");
            RegularExpressionfinal registration = new RegularExpressionfinal();
            registration.FirstName();

            Console.WriteLine("Welcome to User Registration LastName");
            RegularExpressionfinal registration1 = new RegularExpressionfinal();
            registration1.LastName();

            Console.WriteLine("Welcome to User Registration EmailValidattion");
            RegularExpressionfinal registration2 = new RegularExpressionfinal();
            registration1.ValidEmail();

            Console.WriteLine("Welcome to User Registration MObilelValidattion");
            RegularExpressionfinal registration3 = new RegularExpressionfinal();
            registration.ValidNumber();

            Console.WriteLine("Welcome to User Registration PasswordValidattion1");
            RegularExpressionfinal Password = new RegularExpressionfinal();
            Password.ValidPassword1();

            Console.WriteLine("Welcome to User Registration PasswordValidattion2");
            RegularExpressionfinal Password2 = new RegularExpressionfinal();
            Password2.ValidPassword2();

            Console.WriteLine("Welcome to User Registration PasswordValidattion3");
            RegularExpressionfinal passuc7 = new RegularExpressionfinal();
            passuc7.ValidationPassword();


            Console.WriteLine("Welcome to User Registration PasswordValidattion");
            RegularExpressionfinal pass = new RegularExpressionfinal();
            pass.CompleteValidationPassword();

            Console.WriteLine("Welcome to User Registration MailValidattion");
            RegularExpressionfinal pass1 = new RegularExpressionfinal();
            pass.CompleteMailFormat();

            //Console.WriteLine("Welcome to User Registration");
            //Console.WriteLine("\n Please enter  First Name--");
            //string firstName = Console.ReadLine();
            //RegularExpressionfinal.FirstName(firstName);                                          //taking user input and passing it in first name method of regular exp class
            //Console.ReadLine();
        }
    }
}
