using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        public static void Main()
        {
         

            Game Game = new Game();
            Testing Test = new Testing();

            Console.WriteLine("Thrice the dice are about to roll...");

            Console.WriteLine();

            Test.TestDie();
            Game.RollDice();

            Game.ContinueProgram();

            Console.ReadKey();

        }
    }
}
