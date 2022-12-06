

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class SelectStatement
    {

        public static void IfElseLoop()
        {
            var num1 = 15;
            var num2 = 10;

            if (num1<num2)
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }
            else if (num2<num1)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else
            {
                Console.WriteLine("Both number are equal");
            }


        }

        

        public static void SelectCase()
        {
            Console.WriteLine("Press 1 for One");
            Console.WriteLine("Press 2 for Two");
            Console.WriteLine("Press 3 for Three");
            

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    {
                        Console.WriteLine("You have selected One");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You have selected Two");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You have selected Three");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You have not selected a valid option");
                        break;
                    }
            }
        }
      
   
    }
}

