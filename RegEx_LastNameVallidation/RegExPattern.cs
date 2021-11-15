using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx_LastNameVallidation
{
    class RegExPattern
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
    }
}
