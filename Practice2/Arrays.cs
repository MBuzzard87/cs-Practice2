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

            Console.WriteLine("The dimensions of threeDeeArr is: {0}D \n", dimensions);


            foreach(int item in twoDeeArr)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine("\n\n***** Even Numbers in twoDeeArr *****");
            for(int i = 0; i < twoDeeArr.GetLength(0); i++)
            {
                for(int j = 0; j < twoDeeArr.GetLength(1); j++)
                {
                    if(twoDeeArr[i,j] % 2 == 0)
                    {
                        Console.Write(twoDeeArr[i, j] + " ");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
            }


            Console.WriteLine("\n\n");
            for(int i = 0, j = 2; i < twoDeeArr.GetLength(0); i++, j--)
            {
                Console.WriteLine(twoDeeArr[i, j]);
            }


            Console.ReadKey();
            
        }
    }
}
