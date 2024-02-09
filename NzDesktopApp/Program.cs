using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NzDesktopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            
            int myNum1 = 15;

            int myNum2 = 10;

            int sum = myNum1 + myNum2;
            int sub = myNum1 - myNum2;
            Console.WriteLine("Sum is", sum);
            Console.WriteLine(sub);
            Console.Read();

        }
    }
}
