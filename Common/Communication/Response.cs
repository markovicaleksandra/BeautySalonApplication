using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    [Serializable]
    public class Response
    {
        public object Result { get; set; }
        public Exception Exception { get; set; }
        public Response() { }

        public Response(object result)
        {
            Result = result;
        }

        public Response(Exception exception)
        {
            Exception = exception;
        }
    }
}
