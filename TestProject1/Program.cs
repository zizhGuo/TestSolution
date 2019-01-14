using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
 * 
 ***/

namespace TestProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(10);
            test.Print();
            Console.WriteLine();
        }
    }
    class Test {
        int tom;
        public Test(int a) {
            tom = a;
        }
        public void Print()
        {
            Console.WriteLine("Tom = " + tom);
        }

    }
}
