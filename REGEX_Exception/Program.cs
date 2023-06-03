using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEX_Exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  Validate first name
                Console.WriteLine("Enter First Name:");
                string firstName = Console.ReadLine();
                ValidateFirstName(firstName);

                //  Validate last name
                Console.WriteLine("Enter Last Name:");
                string lastName = Console.ReadLine();
                ValidateLastName(lastName);

                //  Validate email
                Console.WriteLine("Enter Email:");
                string email = Console.ReadLine();
                ValidateEmail(email);

                //  Validate mobile number
                Console.WriteLine("Enter Mobile Number:");
                string mobileNumber = Console.ReadLine();
                ValidateMobileNumber(mobileNumber);

                //  Validate password
                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine();
                ValidatePassword(password);

                Console.WriteLine("All inputs are valid!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input: " + ex.Message);
            }
        }

        static void ValidateFirstName(string firstName)
        {
            // First name starts with a capital letter and has a minimum of 3 characters
            if (string.IsNullOrEmpty(firstName) || firstName.Length < 3 || !char.IsUpper(firstName[0]))
            {
                throw new Exception("First name is invalid.");
            }
        }

        static void ValidateLastName(string lastName)
        {
            // Last name starts with a capital letter and has a minimum of 3 characters
            if (string.IsNullOrEmpty(lastName) || lastName.Length < 3 || !char.IsUpper(lastName[0]))
            {
                throw new Exception("Last name is invalid.");
            }
        }

        static void ValidateEmail(string email)
        {
            // Email has 3 mandatory parts (abc, bl, and co) and 2 optional parts (xyz and in)
            // with precise @ and . positions
            if (string.IsNullOrEmpty(email) || !email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is invalid.");
            }
        }

        static void ValidateMobileNumber(string mobileNumber)
        {
            // Mobile number format: Country code followed by a space and 10-digit number
            if (string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length != 13 || !mobileNumber.StartsWith("91 ") || !IsNumeric(mobileNumber.Substring(3)))
            {
                throw new Exception("Mobile number is invalid.");
            }
        }

        static void ValidatePassword(string password)
        {
            // Password rules:
            // Rule 1: Minimum 8 characters
            // Rule 2: Should have at least 1 uppercase letter
            // Rule 3: Should have at least 1 numeric digit
            // Rule 4: Has exactly 1 special character

            if (string.IsNullOrEmpty(password) || password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsDigit) || password.Count(char.IsSymbol) != 1)
            {
                throw new Exception("Password is invalid.");
            }
        }

        static bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
    }

