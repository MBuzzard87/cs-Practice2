using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // DictionaryPractice dp = new DictionaryPractice();

            // StackDemo sd = new StackDemo();

            // QueueDemo qd = new QueueDemo();

            // Debugging debug = new Debugging();

            Radio radio = new Radio(true, "Sony");
            radio.ListenRadio();
            radio.SwitchOff();
            radio.ListenRadio();



            Console.ReadKey();
        }
        
    }
}
