using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
      
        //Method

        public void TestDie()
        {
            Die Die = new Die();
            int TestRollSum = 0;

            for (int i = 1; i < 1000; i++) // loops the amount of rolls
            {
                int TestRollValue = Die.DieRoll();
                TestRollSum += TestRollValue;
                Debug.Assert(TestRollValue >= 1 && TestRollValue <= 6, "Die rolls are out of range");
                Debug.Assert(TestRollSum >= i && TestRollSum <= (6 * i), $"Die roll sum is out of range, roll; {TestRollValue} sum: {TestRollSum}");

            }
        }
    }
}
