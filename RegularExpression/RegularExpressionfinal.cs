using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class RegularExpressionfinal
    {
        //public static void FirstName(string name)                   //declair para method
        //{
        //    string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3
        //    Regex regex = new Regex(firstName);
        //    if (regex.IsMatch(name))                               //calling the Regex class's functions
        //    {
        //        Console.WriteLine(name + " is valid");
        //    }
        //    else
        //        Console.WriteLine(name + " is invalid. Please check your name amd start is capital letter.");
        //}

        string[] inputs = { "visha", "Vishal", "Vis", "XYz", "Abc" };
        string pattern = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3

        public void FirstName()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine(" First Name Validation ");
            foreach (string word in inputs)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }

        // Uc2 LAstName RegularExpression
        string[] inputLname = { "Rathod", "Rat", "JAdhao", "Rao", "Abc" };
        string pattern1 = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3

        public void LastName()
        {
            Regex regex = new Regex(pattern1);
            Console.WriteLine(" Last Name Validation ");
            foreach (string word in inputLname)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }

        // Uc3 VAlidation Email RegularExpression
        string[] emailInputs = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in" };
        string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
        public void ValidEmail()
        {
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(" Email Validation ");
            foreach (string word in emailInputs)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }
        // Uc4 VAlidation Mobilenumber RegularExpression
        string[] InputsNum = { "91 9986522051", "01 6886531051", "918686531051", "91 86865310", "91 6223344556", "91 868653105112" };
        string mobileNoPattern = "[1-9]{2}[ ]{1}[0-9]{10}";

        public void ValidNumber()
        {
            Regex regex = new Regex(mobileNoPattern);
            Console.WriteLine(" Mobile Number Validation ");
            foreach (string word in InputsNum)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }

        // Uc5 Rule1 VAlidation Password MinMimun 8 Char Of small letter RegularExpression
        string[] passwordInputs = { "vishalfh", "bdhdb", "Vishal", "Vishalrathod", "rathodab" };
        string passPattern = "^[a-z]{8}$";
        public void ValidPassword1()
        {
            Regex regex = new Regex(passPattern);
            Console.WriteLine(" Password  Validation ");
            foreach (string word in passwordInputs)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }
        // Uc6 Rule VAlidation Password MinMimun 8 Char Of small letter Adding One UpperCase RegularExpression
        string[] passinput = { "Vishalhi", "abcvsdcv", "xyzYzvab", "Vishalrathod", "abcds", "Abcdsgx", "rajubhaI" };
        string PassPattern1 = "^(?=.*[A-Z])[a-zA-Z]{8}$";

        public void ValidPassword2()
        {
            Regex regex = new Regex(PassPattern1);
            Console.WriteLine(" Password  Validation ");
            foreach (string word in passinput)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }
        }

        // Uc7 Rule VAlidation Password MinMimun 8 Char Of small letter Adding One UpperCase And Adding 1 number RegularExpression

        string[] InputsPPass = { "Vishalh1", "abc1sdcv", "xyzYzv3b", "Vishalrathod", "abcds", "Abcds0x", "raju8haI" };
        string passPattern3 = "^(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8}$";
        public void ValidationPassword()
        {
            Regex regex = new Regex(passPattern3);
            Console.WriteLine(" password Validation ");
            foreach (string word in InputsPPass)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }


        // Uc8 Rule VAlidation Password MinMimun 8 Char Of small letter Adding One UpperCase And Adding 1 number adding 1 special symbol RegularExpression

        string[] iInputPassValid = { "Vish@lh1", "abc1sd&v", "$yzYzv3b", "Vishal1ath@d", "abcds", "#Abcds0x", "raj^8haI", "hvfcg5*" };
        string ValidPattern = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}$";

        public void CompleteValidationPassword()
        {
            Regex regex = new Regex(ValidPattern);
            Console.WriteLine(" password Validation ");
            foreach (string word in iInputPassValid)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "---> valid");
                }
                else
                {
                    Console.WriteLine(word + "---> invalid");
                }
            }

        }

        //uc 9
        string[] patternmail1 = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in"};
            string ValidetionMail = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";  // Regex exp  should have at least one Uppercase,number,special char password 
        public void CompleteMailFormat()
        {
            Regex regex = new Regex(ValidetionMail);
            foreach (string word in patternmail1)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + "-- > Valid");

                }
                else
                    Console.WriteLine(word + "-- > InValid");

            }
        }
    }
}

