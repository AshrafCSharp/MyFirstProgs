using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalVariable
{
    class Program
    {
        static string myVal="I'm a GLOBAL Variable";  // how to creat a GLOBAL Varible 

        static void printString()
        {
            Console.WriteLine($"Print Var From (printString Function) {myVal}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Print Var From (Main) {myVal}");
            printString();    // call printString Fun to print the same Global variable 

            Console.ReadKey();

        }
    }
}
