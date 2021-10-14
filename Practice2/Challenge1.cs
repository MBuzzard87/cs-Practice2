using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Challenge1
    {
        static string type;
/*
        static void Main(string[] args)
        {

            stringJawn();

            Console.ReadKey();

        }
*/
        static void stringJawn()
        {
            bool valid = false;
            

            Console.WriteLine("Enter a value: ");
            string inputVal = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered." +
                "\n---- Press 1 for String" +
                "\n---- Press 2 for Integer" +
                "\n---- Press 3 for Boolean" +
                "\n\nEnter: ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch(inputType)
            {
                case 1:
                    valid = isAString(inputVal);
                    type = "String";
                    break;

                case 2:
                    int intVal;
                    valid = int.TryParse(inputVal, out intVal);
                    type = "Integer";
                    break;
                case 3:
                    bool booJawn = false;
                    valid = bool.TryParse(inputVal, out booJawn);
                    type = "Boolean";
                    break;
                default:
                    type = "";
                    Console.WriteLine("\n*****Restart the program and select 1 String, 2 Integer or 3 Boolean*****\n\n");
                    break;
            }

            Message(valid);



        }

        static void Message(bool valid)
        {
            if (valid)
            {
                Console.WriteLine("The value you entered is a valid {0}", type);
            } else
            {
                Console.WriteLine("The value you entered is invalid");
            }
        }

        static bool isAString(string inputVal)
        {
            foreach(char c in inputVal)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
