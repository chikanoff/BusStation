using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation.BLL.Exceptions
{
    public class ValidateException : Exception
    {
        public string Property { get; set; }
        public ValidateException(string message, string prop) : base(message)
        {
            Property = prop;
        }
    }
}
