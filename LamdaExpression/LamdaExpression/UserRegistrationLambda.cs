using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaUserRegistration
{
    public class LambdaExpression
    {
        public void Validate()
        {
            string[] RegexPattern = new string[6];

            RegexPattern[0] = "^[A-Z][A-Za-z]{2,}$";

            RegexPattern[1] = "^[A-Z][A-Za-z]{2,}$";

            RegexPattern[2] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

            RegexPattern[3] = "^[1-9]{2}[ ][0-9]{10}$";

            RegexPattern[4] = "^[A-Za-z]{6,}[A-Z]{1,}[0-9]{1,}[-~!@#$%^*()_+{}:|?`;',]{1,}$";

            RegexPattern[5] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

            string[] UserInput = new string[6];

            Console.Write("Enter First Name :");
            UserInput[0] = Console.ReadLine();


            Console.Write("Enter Last Name :");
            UserInput[1] = Console.ReadLine();


            Console.Write("Enter  Email Id : ");
            UserInput[2] = Console.ReadLine();


            Console.Write("Enter the Phone Number : ");
            UserInput[3] = Console.ReadLine();


            Console.Write("Enter Password : ");
            UserInput[4] = Console.ReadLine();

            Console.Write("Enter Sample Email Id : ");
            UserInput[5] = Console.ReadLine();

            Console.WriteLine("LambdaExpression");

            for (int i = 0; i < 6; i++)
            {
                Func<string, bool> nameValidater = UserInput => Regex.IsMatch(UserInput, RegexPattern[i]);
                bool result = nameValidater(UserInput[i]);
                Console.WriteLine(($"{i + 1} {UserInput[i]} : {result}"));
            }
        }
    }
}