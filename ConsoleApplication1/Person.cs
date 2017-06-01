using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void PersonDelegate(string name,int age);
    class Person
    {
        private string v1;
        private int v2;

        public Person()
        {

        }
      

        public Person(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
