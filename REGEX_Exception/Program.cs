using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_Exception
{
    public class Program
    {
       
            public static void Main(string[] args)
            {
            string firstName = "John";
            string lastName = "Doe";
            string email = "john.doe@example.com";
            string mobile = "91 9919819801";
            string password = "Passw0rd!";

            try
            {
                bool isValid = ValidateUser(firstName, lastName, email, mobile, password);
                Console.WriteLine("User details are valid.");
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine("Invalid user details: " + ex.Message);
            }
        }
    }
    }
