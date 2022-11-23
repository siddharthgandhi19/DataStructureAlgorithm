using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureAlgorithm
{
    public class UserInput
    {
        public void ReplaceString()
        {
            string input = "Hello <<name>>, We have your fullname as <<full name>> in our system. your contact number is 91-xxxxxxxxxx";
            Console.WriteLine("Enter Name");
            string name=Console.ReadLine();
            input = input.Replace("<<name>>", name);

            Console.WriteLine("Enter Full Name");
            string fullName = Console.ReadLine();
            input = input.Replace("<<full name>>", fullName);

            Console.WriteLine("Enter Mobile Number");
            string mobile = Console.ReadLine();
            input = input.Replace("xxxxxxxxxx", mobile);

            Console.WriteLine(input);
        }
    }
}
