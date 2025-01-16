using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Working_with_Dates_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
           

            DateTime myBirthday = new DateTime(2004, 12, 31);
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
