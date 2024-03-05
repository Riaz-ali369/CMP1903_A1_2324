using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        //Property

        public int DieValue { get; set; }
        static Random rnd = new Random();

        //Method

        public int DieRoll()
        {
            DieValue = rnd.Next(1, 7); // this gives a value between 1 and 6 same as a die
            return DieValue;

        }
    }
}
