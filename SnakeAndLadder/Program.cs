using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC-3 Player then checks for a option there are no play ,ladder or snake
            
            int Start_Position = 0, ran = 0, choice = 0;
            
            //constant declaration
            const int NOPLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;

            //Random function to generate random number
            Random random = new Random();

            //Considering range from 1 to 6 i.e below 7
            ran = random.Next(1, 7); 

            Console.WriteLine("Rolled Dice");
            Console.WriteLine("Number got: " + ran);

            choice = random.Next(0, 3);
            Console.WriteLine("Player Choice: " + choice);

            switch (choice)
            {
                case NOPLAY:
                    Console.WriteLine("Position: {0}", Start_Position);
                    break;
                case LADDER:
                    Start_Position = Start_Position + ran;
                    Console.WriteLine("Position: {0}", Start_Position);
                    break;
                case SNAKE:
                    Start_Position = Start_Position - ran;
                    Console.WriteLine("Position: {0}", Start_Position);
                    break;
            }

            Console.ReadLine();
        }
    }
}
