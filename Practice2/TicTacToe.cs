using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class TicTacToe
    {

        static char[,] playField =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };


        static void Main(string[] args)
        {
            SetField();
            Console.ReadKey();
        }

        public static void SetField()
        {
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", playField[0,0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("       |       |       ");
        }

        public static void playGame()
        {

        }

    }
}
