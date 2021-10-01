using System;
using System.Runtime.Serialization;

namespace Toxiproxy.Net
{
    [Serializable]
    public class ToxiProxyException : Exception
    {
        public ToxiProxyException()
        {
        }

        public ToxiProxyException(string message) : 
            base(message)
        {
        }

        public ToxiProxyException(string message, Exception inner) : 
            base(message, inner)
        {
        }

        protected ToxiProxyException(SerializationInfo info, StreamingContext context) : 
            base(info, context)
        {
        }

        public int Status { get; set; }
    }
}