using System;

namespace Game
{
    public class TicTacToe
    {
        public static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static int player = 1; //'X' is 1, 'O' is 0

        public static int choice;

        public static void Main(string[] args)
        {
        }

        public static void CreateBoard()
        {
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");
        }

        public static char CurrentPlayer()
        {
            if (player % 2 == 1)
                return 'X';

            return 'O';
        }

        public static void ChangePlayer()
        {
            player++;
        }

        public static void MakeMove(string input)
        {
            int num;

            if (int.TryParse(input, out num))
            {
                choice = int.Parse(input);


                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                        arr[choice] = 'O';

                    else
                        arr[choice] = 'X';

                    player++;
                }
            }
            else
                Console.Write("You did not enter a valid choice.");
        }

        public static bool SpaceInUse(int space)
        {
                if (arr[space] == 'X' || arr[space] == 'O')
                    return true;

                return false;
        }
    }
}