using System;
using System.Runtime.Serialization;

namespace NotificadorBG.Forms.Exceptions
{
    public class LoginDomainException : Exception
    {
        public LoginDomainException()
        {
        }

        public LoginDomainException(string message) : base(message)
        {
        }

        public LoginDomainException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LoginDomainException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
