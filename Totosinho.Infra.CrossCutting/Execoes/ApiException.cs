using System;
using System.Runtime.Serialization;

namespace Totosinho.Infra.CrossCutting.Execoes
{
    [Serializable]
    public class ApiException : Exception
    {
        public ApiException(int codeExeption, string message)
            : base(message)
        {
            CodeException = codeExeption;
        }

        protected ApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public int CodeException { get; set; }


        public override string StackTrace
        {
            get { return ""; }
        }
    }
}