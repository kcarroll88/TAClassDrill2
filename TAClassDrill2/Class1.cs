using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAClassDrill2
{
    public class Numbers
    {
        public void intOne(int num1)
        {
            int result = num1 + 20;
            Console.WriteLine("The two numbers together are : {0}", result);
            return;
        }
        public void intOne(decimal num2)
        {
            decimal result = num2 + 12.20m;
            Console.WriteLine("The two numbers together are : {0}", result);
            return;
        }
        public void intOne(string num3)
        {
            int result = Convert.ToInt32(num3 + 12);
            Console.WriteLine("The two numbers together are : {0}", result);
            return;
        }
    }
}
