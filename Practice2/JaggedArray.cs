using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class JaggedArray
    {


        static void Main(string[] args)
        {

            // declare a jagged array (an array of arrays)
            int[][] jaggedArr = new int[3][];

            //initialize by size 
            jaggedArr[0] = new int[5];
            jaggedArr[1] = new int[3];
            jaggedArr[2] = new int[2];

            //inititialize with values
            jaggedArr[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArr[1] = new int[] { 1, 2, 3 };
            jaggedArr[2] = new int[] { 1, 2};


            // declare and initialize
            int[][] jaggedArr2 = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {15,2}
            };

            Console.WriteLine("The value in the center of the first array of jaggedArr2 is: {0}.\n" +
                "The value of the first number in the second array of jaggedArr2 is: {1}\n\n", jaggedArr2[0][2], jaggedArr2[1][0]);

            for(int i = 0; i < jaggedArr2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for (int j = 0; j < jaggedArr2[i].Length; j++)
                {
                    Console.WriteLine("Value {0}", jaggedArr2[i][j]);
                }
            }




            Console.ReadKey();


        }




    }
}
