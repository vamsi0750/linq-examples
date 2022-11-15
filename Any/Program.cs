using System;
using System.Linq;

namespace Any
{
    internal class Program
    {
        static void Main()
        {
            //We can use any in two ways
            // 1. to check collection or data source has any data or not
            // 2. check whether at least one of the elements of a data source satisfies a given condition or not

            //1
            int[] IntArray = { 11, 22, 33, 44, 55 };
            var ResultMS = IntArray.Any();  //return true


            //2
            int[] IntArray2 = { 11, 22, 33, 44, 55 };
            var ResultMS2 = IntArray2.Any(x=>x > 5);  //return true

            //2
            int[] IntArray3 = { 11, 22, 33, 44, 55 };
            var ResultMS3 = IntArray3.Any(x => x > 100);  //return false

        }
    }
}
