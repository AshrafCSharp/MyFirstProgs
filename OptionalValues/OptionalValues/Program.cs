using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalValues
{
    class Program
    {
        static void PrintVals(string name="Ashraf Ben",int myVal=7)
        {
            Console.WriteLine($"The Name is {name}  The Value is {myVal}");
        }
        static void Main(string[] args)
        {
            string name = "Walid Ben";
            int myVal = 20;
            PrintVals();
            PrintVals(name);
            PrintVals(name, myVal);
            PrintVals(name: "Ayham", myVal: 50);
            // PrintVals( , myVal);   statement Error
            Console.ReadKey();
        }
    }
}
