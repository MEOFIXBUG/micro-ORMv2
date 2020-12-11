using System;
using System.Runtime.Serialization;

namespace micro_ORM.ORM.Core.Exceptions
{
    [Serializable]
    public class MicroORMException : Exception, ISerializable
    {
        public string ErrorCode
        {
            get
            {
                return errorCode;
            }
        }
        private string errorCode;

        public MicroORMException(string errorCode, string message) : base(message)
        {
            this.errorCode = errorCode;
        }
    }
}