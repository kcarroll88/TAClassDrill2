using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAClassDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num1 = new Numbers();
            num1.intOne(12);

            Numbers num2 = new Numbers();
            num2.intOne(12.20m);

            Numbers num3 = new Numbers();
            num3.intOne("3");

            Console.ReadLine();
        }
    }
}
