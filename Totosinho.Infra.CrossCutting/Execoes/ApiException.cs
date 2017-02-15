using System;
using System.Runtime.Serialization;

namespace Totosinho.Infra.CrossCutting.Execoes
{
    [Serializable]
    public class ApiException : Exception
    {
        public int CodeException { get; set; }
        
        public ApiException(int codeExeption, string message)
            : base(message)
        {
            CodeException = codeExeption;            
        }
        
        protected ApiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }                
            

        public override string StackTrace
        {
            get { return ""; }
        }       
    }
}