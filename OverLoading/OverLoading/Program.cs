using  System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    class Program
    {
        //برنامج لاستخدام نفس اسم الداله مع اختلاف نوع ترجيعها و معاملاتها ..... و يسمى هذا العمل بالحمل الزائد او 
        // Overloading
        // Overloading means (use the same function name but different return ,recieve types
        //-----------------------------------------------------------------------------------------------
        // ---------------- داله لايجاد اصغر قيمه صحيحه
        //------ تستقبل مصفوفه صحيحه و تختبر القيمه الصغيره فيها و ترجعها كقيمه صحيحه 

        public static int miniNum(int[] myVal)
        {
            int myMini=myVal[0];              // -- نضع اول عنصر من المصفوفه في هذا المتغير , ليكون هذا المتغير هو المقارن للارقام التاليه
            for(int i=1; i< myVal.Length; i++)
            {
                if (myVal[i] < myMini) myMini = myVal[i];   // شرط للمقارنه بين ما في داخل المتغير و العدد الحالي في المصفوفه و اذا هذا تحقق الشرط يكون هو الذي في المتغير للمقارنه التاليه

            }
            return myMini;
        }
        //-----------------------------------------------------------------------------------------------
        // -------------------- نفس اسم الداله ولكن لايجاد اصغر قيمه عشريه 
        //------ تستقبل مصفوفه عشريه و تختبر القيمه الصغيره فيها و ترجعها كقيمه عشريه 
        public static double miniNum(double[] myVal)  
        {
            double myMini = myVal[0];
            for (int i=1; i< myVal.Length; i++)
            {
                if (myVal[i] < myMini) myMini = myVal[i];

            }
            return myMini;
        }
//-----------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int[] myIntArr = new  int[10]{ 11, 3, 6, 8, 5, 7, 6, 2, 41, 1 };
            //  you can define the Array like first or the second يمكنك تعريف المصفوقه بالطريقتين 
            double[] myDoubleArr = { 11.5, 5.3, 3.1, 8.2, 5.1, 7.4, 2.3, 3.7, 41.6, 8.9 };

            Console.WriteLine($"The Minimum Val Int Function is : {miniNum(myIntArr)} ");
            Console.WriteLine("");
            Console.WriteLine($"The Minimum Val Int Function is : {miniNum(myDoubleArr)} ");
            Console.ReadKey();
        }
    }
}
