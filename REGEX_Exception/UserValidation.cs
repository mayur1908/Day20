using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_Exception
{
        public class UserValidation
        {
            // Lambda function to validate the first name
            private static Func<string, bool> validateFirstName = (firstName) =>
            {
                // First name should start with a capital letter and have a minimum length of 3 characters
                return Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]{2,}$");
            };

            // Lambda function to validate the last name
            private static Func<string, bool> validateLastName = (lastName) =>
            {
                // Last name should start with a capital letter and have a minimum length of 3 characters
                return Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z]{2,}$");
            };

            // Lambda function to validate the email
            private static Func<string, bool> validateEmail = (email) =>
            {
                // Email should have 3 mandatory parts and 2 optional parts with precise @ and . positions
                return Regex.IsMatch(email, @"^[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$");
            };

            // Lambda function to validate the mobile number
            private static Func<string, bool> validateMobile = (mobile) =>
            {
                // Mobile number should follow the predefined format: Country code followed by a space and 10-digit number
                return Regex.IsMatch(mobile, @"^\d{2}\s\d{10}$");
            };

            // Lambda function to validate the password
            private static Func<string, bool> validatePassword = (password) =>
            {
                // Password should pass all the predefined rules
                // Rule 1: Minimum 8 characters
                // Rule 2: Should have at least 1 uppercase letter
                // Rule 3: Should have at least 1 numeric digit
                // Rule 4: Should have exactly 1 special character
                return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8}$");
            };

        }
    }
