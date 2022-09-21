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
            //UC-2 Player Rolls a die to get number between 1 to 6

            int Start_Position = 0; 
            int ran = 0;
            Random random = new Random(); //Random function can generate random number
            ran = random.Next(1, 7);//Considering range from 1 to 6 i.e below 7
            Console.WriteLine("Rolled Dice");
            Console.WriteLine("Number got: "+ ran);
            Console.ReadLine();
        }
    }
}
