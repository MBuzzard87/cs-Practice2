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

        static char player1 = 'O';
        static char player2 = 'X';


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


        public static bool Player1()
        {
            Console.WriteLine("Player 1, pick an available square");
            string input = Console.ReadLine();
            char choice;
            bool success = char.TryParse(input, out choice);
            if(success)
            {
                if(choice >= '1' && choice <= '9')
                {
                    UpdateGame(choice);
                }
            } else
            {
                Console.WriteLine("Please enter a number 1-9");
            }

            return true;
        }


        public static void UpdateGame(char num)
        {
            switch(num)
            {
                case '1':
                    playField[0, 0] = '0';
                    break;
                case '2':
                    playField[0, 1] = '0';
                    break;
                case '3':
                    playField[0, 2] = '0';
                    break;
                case '4':
                    playField[1, 0] = '0';
                    break;
                case '5':
                    playField[1, 1] = '0';
                    break;
                case '6':
                    playField[1, 2] = '0';
                    break;
                case '7':
                    playField[2, 0] = '0';
                    break;
                case '8':
                    playField[2, 1] = '0';
                    break;
                case '9':
                    playField[2, 2] = '0';
                    break;
            }
        }


    }
}
