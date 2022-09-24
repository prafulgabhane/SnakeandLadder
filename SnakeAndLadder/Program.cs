using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // UC-5
            // Ensure that player gets to exact winning position 100

            int Start_Position = 0, r = 0, choice = 0, count = 0;
            const int NOPLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;

            Random random = new Random();
            
            while (Start_Position < 100)
            {
                r = random.Next(1, 7); //range from 1 to 6
                Console.WriteLine("Number got: {0}", r);
                choice = random.Next(0, 3); //range from choice 0 to 2 i.e (0, 1 , 2)
                Console.WriteLine("Player Choice: {0}", choice); 
                
                switch (choice)
                {
                    case NOPLAY: //case 0
                        Console.WriteLine("Position: {0}", Start_Position);
                        break;
                    case LADDER: //case 1
                        Start_Position = Start_Position + r;
                        if (Start_Position > 100)
                            Start_Position = Start_Position - r;
                        else if (Start_Position == 100)
                            Console.WriteLine("Position Reached: {0}", Start_Position);
                        Console.WriteLine("Position: {0}", Start_Position);
                        break;
                    case SNAKE: //case 2
                        Start_Position = Start_Position - r;
                        if (Start_Position < 0)
                        {
                            Start_Position = 0;
                        }
                        Console.WriteLine("Position: {0}", Start_Position);
                        break;
                }
                count++;
            }
            Console.ReadLine();
        }
    }
}