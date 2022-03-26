using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FinalProject_GalatekAutomation.Utils
{
    [Serializable]
    internal class BrowserTypeException : Exception
    {
        public BrowserTypeException()
        {
        }

        public BrowserTypeException(string message) : base("Unsupported browser type " + message)
        {

        }

        public BrowserTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BrowserTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
