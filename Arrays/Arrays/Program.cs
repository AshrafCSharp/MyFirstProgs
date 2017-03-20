using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[4] { 5, 6, 7, 8 };
            // OR int[] myArray =  { 5, 6, 7, 8 };
            int[,] myArray2 = new int[2, 4]
                        {
                            { 5, 6, 7, 8 }, { 1, 2, 3, 4 }
                        };
            // This is 3D dimintional
            int[,,] myArray3 = new int[2, 2, 3]
                        {
                            {
                                {1,2,3 }, {4,5,6 }
                            },
                             { 
                                {7,8,9 }, {10,11,12 }
                            } 
                            
                        };
            
           // print Array value for dimintion 1D
            foreach (int Ash in myArray)
                Console.Write(Ash +" ");
            Console.ReadKey();

            // print Array value for dimintion 2D
            for (int i=0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myArray2[i,j]+" ");
                Console.WriteLine("");
            }
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            // print Array value for dimintion 3D
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                        Console.Write(myArray3[i,j, k] + " ");
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
