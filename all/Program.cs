using System;
using System.Linq;

namespace all
{
    internal class Program
    {
        static void Main()
        {
            int[] IntArray = { 11, 22, 33, 44, 55};
            var Result = IntArray.All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result); // true

            int[] IntArray2 = { 11, 22, 33, 44,5, 55 };
            var Result2 = IntArray2.All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result2); // false


            //checking multiple conditions
            var Result3 = IntArray2.All(x => x > 1 && x > 2);
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result3); // false



        }
    }
}
