using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisLambdaExpression
{
    class RegistrationException :Exception
    {
        public enum ExceptionType
        {
            ENTERD_NULL_EXCEPTION,
            ENTERD_EMPTY_EXCEPTION,
            IVALID_INPUT,
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_PASSWORD,
            INVALID_EMAIL_ID,
            INVALID_MOBILE_NUMBER,
            INVALID_EMAILLIST
        }


        ExceptionType type;
        readonly string message;

        public RegistrationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}

