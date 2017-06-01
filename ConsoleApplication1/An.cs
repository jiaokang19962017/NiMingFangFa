using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate int an(int number);
    public delegate int pn(int x,params int[] arrayint);
    public delegate int otherdelegate(int number);

    class An
    {
        public int GetResult(int number)
        {
            return number + 2;
        }
    }
}
