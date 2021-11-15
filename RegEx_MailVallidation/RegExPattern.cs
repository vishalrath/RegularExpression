using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx_MailVallidation
{
    class RegEXPattern
    {
        public static void FirstName(string name)                   //declair para method
        {
            string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3
            Regex regex = new Regex(firstName);
            if (regex.IsMatch(name))                               //calling the Regex class's functions
            {
                Console.WriteLine(name + " is valid");
            }
            else
                Console.WriteLine(name + " is invalid. Please check your name amd start is capital letter.");
        }

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




        string[] inputs1 = { "Rathod", "Jadhav", "rat", "chavhan", "abc" };
        string pattern1 = "^[A-Z]{1}[a-zA-Z]{2,}$";            //this regular exp shows that first letter must be capital, and minimum letter must be 3


        public void LastName()
        {
            Regex regex = new Regex(pattern1);
            Console.WriteLine("last name   Validation ");
            foreach (string word in inputs1)
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
        string[] Inputs = { "91 9986522051", "01 6886531051", "918686531051", "91 86865310", "91 6223344556", "91 868653105112" };
        string mobileNoPattern = "[1-9]{2}[ ]{1}[0-9]{10}";

        public void Validation()
        {
            Regex regex = new Regex(mobileNoPattern);
            Console.WriteLine(" Mobile Validation ");
            foreach (string word in Inputs)
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

        string[] MAilInputs = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in" };
        string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";


        public void MAilValidation()
        {
            Regex regex = new Regex(emailPattern);
            Console.WriteLine(" Mail Validation ");
            foreach (string word in MAilInputs)
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

        
    }
}
