using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_For_Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
          
            for (int i = 0; i < 10; i++)
            {
                
                if (7 == i) 
                {
                    Console.WriteLine("Found Seven!");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
        }
    }
}