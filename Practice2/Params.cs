using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Params
    {


        static void Main(string[] args)
        {
            ParamsMethod("Hi,", " My", " name is", " Mike.");
            Console.ReadKey();
        }

        private static void ParamsMethod(params string[] sentence)
        {
            foreach(string s in sentence)
            {
                Console.Write(s);
            }
        }

    }
}
