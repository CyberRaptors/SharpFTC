using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFTC.Core.Exceptions
{
    public class SharpFTCInternalException : Exception
    {
        public SharpFTCInternalException(string err) : base(err) { }
    }
}
