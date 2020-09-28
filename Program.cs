using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Start_Position = 0;
            const int No_Play = 1;
            const int Ladder = 2;
            const int Snake = 3;
            int currentPosition = Start_Position;
            int winningPosition = 100;
            Random randObj = new Random();
            int noOfMoves = 0;

            while (currentPosition < winningPosition)
            {
                int dieNumber = randObj.Next(1, 7);
                Console.WriteLine("Die Number is {0}", dieNumber);
                int option = randObj.Next(1, 4);
                Console.WriteLine("Option is {0}", option);
                switch (option)
                {
                    case No_Play:
                        break;
                    case Ladder:
                        if(currentPosition+dieNumber<=winningPosition)
                            currentPosition += dieNumber;
                        break;
                    case Snake:
                        currentPosition -= dieNumber;
                        if (currentPosition < Start_Position)
                            currentPosition = Start_Position;
                        break;
                    default:
                        break;
                }
                noOfMoves++;
            }
            Console.WriteLine("Current Position is {0}", currentPosition);
            Console.WriteLine("Total moves used {0}", noOfMoves);
        }
    }
}
