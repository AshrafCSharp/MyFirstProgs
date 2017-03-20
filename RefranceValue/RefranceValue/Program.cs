using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefranceValue
{
    class Program
    {
        static void myFuncCheck(ref int myVale)
        {
            // ref = it mean any change happens on this parameter it will must effected at Main func
            //ref=   اي تغيير يحصل لهذا البراميتر في هذه الداله سوف يتأثر نفس البراميتر في الداله الرئيسيه

            myVale += 1;

        }

        static void Main(string[] args)
        {
            int myReadKey;
            Console.Write("Please Enter the No. To test if the prameter will effict or not : ");
            myReadKey = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"This is you prameter Before call Func: {myReadKey}");
            myFuncCheck(ref myReadKey);

            Console.WriteLine($"This is you prameter After call Func: {myReadKey}");
            Console.ReadKey();
        }
    }
}
