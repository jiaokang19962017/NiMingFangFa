using System;
using System.Collections;
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
           /* otherdelegate other1 = (int x) => { return x + 1; };
            otherdelegate other2 =  x => { return x + 1; };
            otherdelegate other3 = x =>  x + 1;
            otherdelegate2 ot = (x, y) => { x = (int)Math.Pow(x, 4);y *= 2; return x + y + 1; };
            Console.WriteLine(other2(7));
            Console.WriteLine(ot(3,9));
            */
      /*      PersonDelegate pd = (array, p) =>
           {
               for (int i = 0; i < p.; i++)
               {
                   string name = p[i].Name;
                   array.Add(name);
               }
               return array.Count;
           };*/


            /*    ArrayList arrayList = new ArrayList() { "张三", "李四" };
                Person[] person = { new Person("王五", 18), new Person("赵刘", 19) };*/

            Func<Person, int[], List<string>, int> func2 = (x, y, z) =>
              {
                  return 0;
              };
            Person person = new Person("张三",15);
            int[] arrInt = { 1, 2, 3, 4, 5, 6 };
            List<string> ls = new List<string>();
            ls.Add("jack");
            ls.Add("tom");
            ls.Add("json");
            int result = func2(person, arrInt, ls);
            Console.WriteLine(result);
        }
    }
}
