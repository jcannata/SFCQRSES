using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Common.DDD
{
    [Serializable]
    public class AggregateRootException : Exception
    {
        public AggregateRootException() { }
        public AggregateRootException(string message) : base(message) { }
        
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        protected AggregateRootException
        (
            SerializationInfo info,
            StreamingContext context) : base(info, context) {}
    }
}