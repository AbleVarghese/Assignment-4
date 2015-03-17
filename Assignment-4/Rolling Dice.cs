using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Rolling_Dice
    {
        //Instance Variables

        int[] dice1 = new int[6];
        int[] dice2 = new int[6];


        //Properties

       void RollingDice1()
        {
           Random dice1 = new Random();

           for (int index = 0; index < 10; index++)
           {
               dice1.Next(1, 6);
           }
           


        }




    }
}
