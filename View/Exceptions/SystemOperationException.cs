using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Exceptions
{
    public class SystemOperationException : Exception
    {
        public SystemOperationException() : base("Server couldn't process request!")
        {
        }

        public SystemOperationException(string message):base(message)
        {

        }
    }
}
