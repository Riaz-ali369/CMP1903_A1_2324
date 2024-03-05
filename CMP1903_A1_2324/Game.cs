using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        
        List<int> RunningTotalList = new List<int>();


        //Methods
        public void RollDice()
        {
            int RunningSum = 0; // initlaises variables
            int Sum = 0;

            for (int i = 1; i <= 3; i++) // this loops to roll three times
            {
                Die Die = new Die();  // creates a new instance of a die
                int Roll = Die.DieRoll();
                Console.WriteLine($"Roll {i}: {Roll}");  // shows to the console and then adds to a list
                RunningTotalList.Add(Roll);
                Sum += Roll;
                System.Threading.Thread.Sleep(1);
            }

            foreach (int item in RunningTotalList) { RunningSum += item; }

            Console.WriteLine($"\nSum: {Sum}");
            Console.WriteLine($"Total Sum: {RunningSum}");


        }


        public void ContinueProgram()  // conditions for if the user wants to roll again 
        {

            Console.WriteLine("Would you like to roll again..? (Yes/No)");
            string UserAnswer = Console.ReadLine();

            if (UserAnswer == "Yes")
            {
                Console.WriteLine();
                Console.WriteLine("\n3 dice are about to be rolled...");
                Console.WriteLine();

                RollDice();
                ContinueProgram();
            }
            else if (UserAnswer == "No")
            {
                Console.WriteLine("\nThank you :)");
                Console.WriteLine("Click any button to end program...");

            }
            else
            {
                Console.WriteLine();
                ContinueProgram();

            }
        }
    }
}
