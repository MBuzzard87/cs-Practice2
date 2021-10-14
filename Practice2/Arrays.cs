using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Arrays
    {
        

        static void Main(string[] args)
        {
            // declare 2D Array
            string[,] matrix;

            // declare 3D Array
            int[,,] threeD;

            int[,] twoDeeArr = new int[,]
            {
            {1,2,3},
            {4,5,6},
            {7,8,9}
            };

            Console.WriteLine("The middle value in the 2D array is {0}\n\n", twoDeeArr[0, 1]);

            int[,,] threeDeeArr = new int[,,]
            {
                {
                    {000,001},
                    {010,011},
                    {020, 021}
                },
                {
                    {100,101},
                    {110,111},
                    {120,121}
                }
            };

            Console.WriteLine("The value of threeDeeArr[1,2,0] is {0}\n\n", threeDeeArr[1,2,0]);

            int dimensions = threeDeeArr.Rank;

            Console.WriteLine("The dimensions of threeDeeArr is: ", dimensions);

            Console.ReadKey();
            
        }
    }
}
