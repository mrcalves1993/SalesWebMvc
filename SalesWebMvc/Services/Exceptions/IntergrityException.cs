using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntergrityException : ApplicationException
    {
        public IntergrityException(string message) : base(message)
        {
        }
    }
}
