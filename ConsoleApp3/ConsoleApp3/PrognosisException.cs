using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PrognosisException : Exception
    {
        public PrognosisException() { }
        public PrognosisException(string message) : base(message) { }
        public PrognosisException(string message, Exception inner) : base(message, inner) { }
        protected PrognosisException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public override string ToString()
        {
            return "Prognosis failed";
        }
    }
}
