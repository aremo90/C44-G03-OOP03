using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Q3
{
    [Flags]
    internal enum Permission : byte
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
    }
}
