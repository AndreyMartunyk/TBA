using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TheBestAdventure
{
    class LessThenZeroPointException : Exception
    {

        public LessThenZeroPointException(string message = "Одна из координат точки меньше 0!!!")
            : base(message)
        {
        }

        public LessThenZeroPointException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected LessThenZeroPointException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
