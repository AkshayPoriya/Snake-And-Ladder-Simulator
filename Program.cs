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
            Random randObj = new Random();

            int dieNumber = randObj.Next(1, 7);
            Console.WriteLine("Die Number is {0}",dieNumber);
            int option = randObj.Next(1, 4);
            Console.WriteLine("Option is {0}", option);
            switch (option)
            {
                case No_Play:
                    break;
                case Ladder:
                    currentPosition += dieNumber;
                    break;
                case Snake:
                    currentPosition -= dieNumber;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Current Position is {0}",currentPosition);
        }
    }
}
