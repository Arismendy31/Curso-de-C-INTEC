using System;
using System.IO;
using System.Net;


namespace _15_Understanding_Namespace_and_Working_with_the_.Net_Class_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            System.Console.WriteLine(reply);
            //Needs the using System.IO; to work. Saves the file onto the computer.
            File.WriteAllText(@"C:\Lesson17\WriteTxt.txt", reply);
            Console.ReadLine();
        }
    }
}