using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class MinimumVall
    {

        static void Main(string[] args)
        {
            int minNum = MinVal(1, 2, 3, 4, 100, -2);
            Console.WriteLine("The minimum is: {0}", minNum);
            Console.ReadKey();
        }


        public static int MinVal(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach(int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }



            return min;
        }

    }
}
