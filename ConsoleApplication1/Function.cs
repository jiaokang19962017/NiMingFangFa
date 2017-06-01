using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 有参数,无返回值
    /// </summary>
    class Function
    {
        public void GetDate(int num,int num2)
        {
            Console.WriteLine("action");
        }

        /// <summary>
        /// 没有参数,有返回值
        /// </summary>
        /// <returns></returns>
        public string GetDateTime()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
