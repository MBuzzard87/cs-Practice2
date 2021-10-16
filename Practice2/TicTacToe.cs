using System;

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

        
        static char currentPlayer = 'O';
        static bool game = true;
        static int numTurns = 0;
        static char again = '?';
        

/*
        static void Main(string[] args)
        {


            while(game)
            {
                if(!NewGame())
                {
                    break;
                }
                Console.Clear();
                SetField();
                PlayGame();

                
                KeepPlaying();
                
            }
            
            Console.ReadKey();
        }
*/
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


        

        public static void PlayGame()
        {
            
            if(currentPlayer.Equals('O'))
            {
                Console.WriteLine("Player 1, pick an available square");
            } else
            {
                Console.WriteLine("Player 2, pick an available square");
            }

            
            char choice;
            string input = Console.ReadLine();
            bool success = char.TryParse(input, out choice);
            if(success && choice >= '1' && choice <= '9')
            {
                UpdateTable(choice, currentPlayer);
                    
            } else
            {
                Console.WriteLine("\nPlease enter a number 1-9\n\n");
                PlayGame();
            }

            
        }


        public static void UpdateTable(char num, char player)
        {
            bool available = false;
            switch(num)
            {
                case '1':
                    if(!playField[0, 0].Equals('O') && !playField[0, 0].Equals('X'))
                    {
                        playField[0, 0] = player;
                        available = true;
                    }                     
                    break;
                case '2':
                    if (!playField[0, 1].Equals('O') && !playField[0, 1].Equals('X'))
                    {
                        playField[0, 1] = player;
                        available = true;
                    }
                    
                    break;
                case '3':
                    if (!playField[0, 2].Equals('O') && !playField[0, 2].Equals('X'))
                    {
                        playField[0, 2] = player;
                        available = true;
                    }
                   
                    
                    break;
                case '4':
                    if (!playField[1, 0].Equals('O') && !playField[1, 0].Equals('X'))
                    {
                        playField[1, 0] = player;
                        available = true;
                    }
                   
                    
                    break;
                case '5':
                    if (!playField[1, 1].Equals('O') && !playField[1, 1].Equals('X'))
                    {
                        playField[1, 1] = player;
                        available = true;
                    }
                    
                    break;
                case '6':
                    if (!playField[1, 2].Equals('O') && !playField[1, 2].Equals('X'))
                    {
                        playField[1, 2] = player;
                        available = true;
                    }
                    
                    break;
                case '7':
                    if (!playField[2, 0].Equals('O') && !playField[2, 0].Equals('X'))
                    {
                        playField[2, 0] = player;
                        available = true;
                    }
                   
                    
                    break;
                case '8':
                    if (!playField[2, 1].Equals('O') && !playField[2, 1].Equals('X'))
                    {
                        playField[2, 1] = player;
                        available = true;
                    }
                    
                    break;
                case '9':
                    if (!playField[2, 2].Equals('O') && !playField[2, 2].Equals('X'))
                    {
                        playField[2, 2] = player;
                        available = true;
                    }
                    
                    break;
            }
            if(!available)
            {
                Console.WriteLine("That square is taken.\n");
                PlayGame();
            }
            
        }

        public static void SwitchPlayer()
        {
            
            if (currentPlayer == 'O')
            {
                currentPlayer = 'X';
            } else
            {
                currentPlayer = 'O';
            }
        }


        public static void KeepPlaying()
        {
           
            if (playField[0,0] == 'O' && playField[0, 1] == 'O' && playField[0, 2] == 'O' || playField[1, 0] == 'O' && playField[1, 1] == 'O' && playField[1, 2] == 'O' ||
                playField[2, 0] == 'O' && playField[2, 1] == 'O' && playField[2, 2] == 'O' || playField[0, 0] == 'O' && playField[1, 0] == 'O' && playField[2, 0] == 'O' ||
                playField[1, 0] == 'O' && playField[1, 1] == 'O' && playField[1, 2] == 'O' || playField[0, 2] == 'O' && playField[1, 2] == 'O' && playField[2, 2] == 'O' ||
                playField[0, 0] == 'O' && playField[1, 1] == 'O' && playField[2, 2] == 'O' || playField[0, 2] == 'O' && playField[1, 1] == 'O' && playField[2, 0] == 'O')
            {
                Console.Clear();
                SetField();
                Console.WriteLine("\nPlayer 1 wins!!! Would you like to play again? Please enter Y to continue or hit any key then enter to exit.");
                string input = Console.ReadLine();
                if (input.Equals("Y"))
                {
                    numTurns = 0;
                    again = 'Y';
                } else
                {
                    again = 'N';
                }

            }

            if (playField[0, 0] == 'X' && playField[0, 1] == 'X' && playField[0, 2] == 'X' || playField[1, 0] == 'X' && playField[1, 1] == 'X' && playField[1, 2] == 'X' ||
                playField[2, 0] == 'X' && playField[2, 1] == 'X' && playField[2, 2] == 'X' || playField[0, 0] == 'X' && playField[1, 0] == 'X' && playField[2, 0] == 'X' ||
                playField[1, 0] == 'X' && playField[1, 1] == 'X' && playField[1, 2] == 'X' || playField[0, 2] == 'X' && playField[1, 2] == 'X' && playField[2, 2] == 'X' ||
                playField[0, 0] == 'X' && playField[1, 1] == 'X' && playField[2, 2] == 'X' || playField[0, 2] == 'X' && playField[1, 1] == 'X' && playField[2, 0] == 'X')
            {
                Console.Clear();
                SetField();
                Console.WriteLine("\nPlayer 2 wins!!!  Would you like to play again? Please enter Y to continue or hit any key then enter to exit.");
                string input = Console.ReadLine();
                if (input.Equals("Y"))
                { 
                    again = 'Y';
                } else
                {
                    again = 'N';
                }
                
                
            }

            numTurns++;
            SwitchPlayer();
            
            
            
        }

        public static bool NewGame()
        {

            bool startOver = true;

            char[,] ticTacToe =
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' }
            };


            if (numTurns == 9)
            {
                Console.WriteLine("It's a tie!!!  Would you like to play again??? Please enter Y to continue or hit any key then enter to exit.");
                string input = Console.ReadLine();
                if (input.Equals("Y")) {
                    playField = ticTacToe;
                    currentPlayer = 'O';
                    numTurns = 0;
                } else
                {
                    Console.WriteLine("Thank you for playing!!!");
                    startOver = false;
                }
            }

            if (again.Equals('Y'))
            {
                playField = ticTacToe;
                currentPlayer = 'O';
                again = '?';
                numTurns = 0;
                
            } else if(again.Equals('N'))
            {
                Console.WriteLine("Thank you for playing!!!");
                startOver = false;
            }


            return startOver;

            
            


        }
    }
}
