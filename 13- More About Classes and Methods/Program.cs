using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_More_About_Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            

            Console.ReadLine();
        }

    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

                public static void MyMethod() 
        {
            Console.WriteLine("Called the static MyMethod");
            //Console.WriteLine(Make);
        }
    }
}
