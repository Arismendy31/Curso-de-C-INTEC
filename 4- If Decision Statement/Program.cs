using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_If_Decision_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st Way

            Console.WriteLine("Marisa's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a car!";
            else if (userValue == "2")
                message = "You won a boat:";
            else if (userValue == "3")
                message = "You won a dog!";
            else
            {
                message = "Sorry we didn't understand. ";
                //message = message + "You Lose";
                message += "You Lose.";
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}