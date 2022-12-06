using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class IterationStatement
    {
        public static  void ForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static  void WhileLoop()
        {
            var number = 0;
            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        public static  void DoWhileLoop()
        {
            var number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        public static void ForEachLoop()
        {
            string[] list = { "Adam", "Eve", "Holly" };
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
  
