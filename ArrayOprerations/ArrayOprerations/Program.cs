using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOprerations
{
   class Program
    {
        static void ArrayStuff(int[,] myArray)
        {
             Console.WriteLine($"The dimantion of this array is {myArray.Rank}");
            Console.WriteLine($"The Length of this array is {myArray.Length}");
           // Console.WriteLine($"The Length of this array is {myArray.}"); 
           for (int i=0;i< (myArray.Length/2);i++)
                for(int j=0;j<2;j++)
                Console.WriteLine($"{myArray[i,j]}");
        }

        static void Main(string[] args)
        {
            int[] myArr = new[] { 4, 5, 23, 8, 5, 8, 12, 65, 87, 90 }; // one Dim
            /*  int[][] numbers = {
                                  new int[] { 2, 3, 4 },
                                  new int[] { 5, 6, 7, 8, 9 }
                                 };
                                 */
          //  int[,] numbers = new int[6, 2]  { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 } }; // two Dim .... mor than one raw is two Dim
          //Or
            int[,] numbers =   { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 }, { 11, 12 } };

            ArrayStuff(numbers);
            Console.ReadKey();

          //  ArrayStuff(myArr);
          //  Console.ReadKey();

        }
    }
}
