using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Params
    {

/*
        static void Main(string[] args)
        {

            int age = 34;
            string name = "Mike";
            bool isEmployed = true;
            char gender = 'M';


            ParamsMethod("Hi,", " My", " name is", " Mike.");

            ParamsMethod2(name,age,isEmployed,gender);

            Console.ReadKey();
        }
*/
        private static void ParamsMethod(params string[] sentence)
        {
            foreach(string s in sentence)
            {
                Console.Write(s);
            }
            Console.Write("\n");
        }

        private static void ParamsMethod2(params object[] jawns)
        {
            foreach(object o in jawns)
            {
                Console.WriteLine(o);
            }
        }

    }
}
