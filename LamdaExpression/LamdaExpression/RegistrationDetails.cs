using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaUserRegistration
{
    public class UserRegistrationDetails
    {
        //UC1
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        //UC2
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        //UC3 and UC9
        public static string Regex_Email = "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$";
        //UC4
        public static string Regex_MobileNumber = "^[1-9][0-9][ ]?[6-9][0-9]{9}$";
        //UC5 to UC8
        public static string Regex_Password = "^[A-Za-z]{6,}[A-Z]{1,}[0-9]{1,}[-~!@#$%^*()_+{}:|?`;',]{1,}$";

        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionType.EMPTY_FIRSTNAME, "Name should not be empty.");
                }
                else if (Regex.IsMatch(firstName, Regex_FirstName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Name should not be null.");
            }
        }
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, Regex_LastName))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Last name should not be empty.");
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, Regex_Email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EmailId, "Email should not be empty.");

            }
        }
        public bool ValidateMobileNumber(string mobile)
        {
            try
            {
                if (Regex.IsMatch(mobile, Regex_MobileNumber))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NO, "Mobile number should not be empty.");

            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (Regex.IsMatch(password, Regex_Password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Password should not be empty.");
            }
        }
        public string CheckMultipleEmail(string Mail1, string Mail2, string Mail3, string Mail4, string Mail5)
        {
            UserRegistrationDetails Mail = new UserRegistrationDetails();
            bool MailEntry1 = Mail.ValidateEmail(Mail1);
            bool MailEntry2 = Mail.ValidateEmail(Mail2);
            bool MailEntry3 = Mail.ValidateEmail(Mail3);
            bool MailEntry4 = Mail.ValidateEmail(Mail4);
            bool MailEntry5 = Mail.ValidateEmail(Mail5);
            if (MailEntry1 && MailEntry2 && MailEntry3 && MailEntry4 && MailEntry5)
                return "succesfull";
            else
                return "fail";
        }

    }
}