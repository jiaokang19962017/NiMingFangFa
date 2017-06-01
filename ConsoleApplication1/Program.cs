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
            otherdelegate other2 =  x => { return x + 1; };
            otherdelegate other3 = x =>  x + 1;
            otherdelegate2 ot = (x, y) => { x = (int)Math.Pow(x, 4);y *= 2; return x + y + 1; };
            Console.WriteLine(other2(7));
            Console.WriteLine(ot(3,9));
        }
    }
}
