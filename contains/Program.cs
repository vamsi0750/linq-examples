using System;
using System.Linq;
namespace contains
{
    internal class Program
    {
        static void Main()
        {
            //contain will check collection or data source specfied element is there or not 

            int[] IntArray = { 11, 22, 33, 44, 55 };

            var IsExistsMS = IntArray.Contains(33); // true

            bool is1Exist = IntArray.AsEnumerable().Contains(1);// false



        }
    }
}
