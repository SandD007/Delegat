using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingWithTheDelegates
{
    public delegate int PowHandler(int x, int y);

    public delegate bool ResultHandler(int x);

    public delegate void ShowHandler(ResultHandler t);
}
