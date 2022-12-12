using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserDetails
    {
        public static void FirstName()
        {
            Console.WriteLine("Enter your FirstName");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            Iteration(userInput, regexCondition);
        }
        public static void LastName()
        {
            Console.WriteLine("Enter your Last Name");
            string userInput = Console.ReadLine();
            string regexCondition = "^[A-Z]{1}[a-z]{3,}$";
            Iteration(userInput, regexCondition);
        }
        public static void Email()
        {
            Console.WriteLine("Enter your Email ID");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            Iteration(userInput, regexCondition);
        }
        public static void MobileNo()
        {
            Console.WriteLine("Enter your Mobile Number");
            string userInput = Console.ReadLine();
            string regexCondition = "^[9]{1}[1]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
            Iteration(userInput, regexCondition);
        }
        public static void PasswordMin8Char()
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^[a-zA-Z0-9]{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void PasswordMin8CharAnd1UpperCase()
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^(?=.*[A-Z]).{1,}[a-zA-Z0-9]{7,}$";
            Iteration(userInput, regexCondition);
        }
        public static void UpperCaseAndNumeric() 
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "^(?=.*[A-Z]).{1,}(?=.*[0-9]).{1,}[a-zA-Z0-9]{6,}$";
            Iteration(userInput, regexCondition);
        }
        public static void Password1SpecialChar()
        {
            Console.WriteLine("Enter your Password");
            string userInput = Console.ReadLine();
            string regexCondition = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
            Iteration(userInput, regexCondition);
        }
        public static void ClearEmailSample()
        {
            string[] userInput = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                "abc@1.com","abc@gmail.com.com","abc+100@gmail.com",
                                "abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com",
                                "abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            foreach (string input in userInput)
            {
                if (Regex.IsMatch(input, regexCondition))
                {
                    Console.WriteLine($"{input} --> Valid");
                }
                else
                {
                    Console.WriteLine($"{input} --> Invalid");
                }
            }
        }
        public static void Iteration(string userInput, string regexCondition)
        {
            if (Regex.IsMatch(userInput, regexCondition))
            {
                Console.WriteLine("Validated successfully!\n");
            }
            else
            {
                Console.WriteLine("Entered Details are not in required format.Please try again!\n");
            }
        }
    }
}
