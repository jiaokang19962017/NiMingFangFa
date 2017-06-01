using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  an a = delegate (int x) { return x + 2; };
              Console.WriteLine(a(9));*/

            //lambda表达式
            otherdelegate other1 = (int x) => { return x + 1; };
        }
    }
}
