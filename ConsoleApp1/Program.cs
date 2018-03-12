using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                                 
                Console.WriteLine("Starting Main - Getting Directories");

                string[] myfiles = System.IO.Directory.GetFiles("c:\\users\\sullivp\\desktop");

                Console.WriteLine(myfiles[0]);
                System.Threading.Thread.Sleep(5000);

                Console.WriteLine("Ending...");
                 
        }
    }
}
