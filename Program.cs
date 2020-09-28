using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Start_Position = 0;
            Random randObj = new Random();
            int dieNumber = randObj.Next(1, 7);
            Console.WriteLine("Die Number is {0}",dieNumber);
        }
    }
}
