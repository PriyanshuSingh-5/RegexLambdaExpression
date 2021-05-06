using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegisLambdaExpression
{
    public class RegexPattern
    {
        public const string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public const string PhoneNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";
        public const string Password = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";

        //Using Lambda Expressions
        public bool ValidateFirstName(string firstName)
        {
            try
            {
                return RegexPattern.Equals(FirstName, FirstName);
            }
            catch (RegistrationException)
            {
                throw new RegistrationException(RegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name,Name should be first letter capital");
            }
        }
        public bool ValidateLastName(string lastName)
        {
            try
            {
                return RegexPattern.Equals(LastName, lastName);
            }
            catch (RegistrationException)
            {
                throw new RegistrationException(RegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name,Name should be first letter capital");
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                return RegexPattern.Equals(Email, email);
            }
            catch (RegistrationException)
            {
                throw new RegistrationException(RegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name,Name should be first letter capital");
            }
        }
        public bool ValidateMobile(string phoneNumber)
        {
            try
            {
                return RegexPattern.Equals(PhoneNumber, phoneNumber);
            }
            catch (RegistrationException)
            {
                throw new RegistrationException(RegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name,Name should be first letter capital");
            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                return RegexPattern.Equals(Password, password);
            }
            catch (RegistrationException)
            {
                throw new RegistrationException(RegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name,Name should be first letter capital");
            }
        }
        public static bool ValidateEmailList(string email)
        {
            try
            {
                String emailPattern = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$";
                Regex obj = new Regex(emailPattern);
                return obj.IsMatch(email);
            }
            catch (RegistrationException)
            {
                throw new RegistrationException(RegistrationException.ExceptionType.INVALID_EMAILLIST, "Invalid Email.Email should be in format");
            }

        }
    


        //Using Lambda Expressions
        public bool ValidateFirstName(string firstName) => (Regex.IsMatch(firstName, FirstName));
        public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, LastName));
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, Email));
        public bool ValidateMobile(string mobNumber) => (Regex.IsMatch(mobNumber, PhoneNumber));
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, Password));

    }
}