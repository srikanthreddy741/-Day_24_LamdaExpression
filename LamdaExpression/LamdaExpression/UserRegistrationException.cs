using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaUserRegistration
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            Empty_Message,
            NULL_Message
        }
        private readonly ExceptionType type;

        public UserRegistrationException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}