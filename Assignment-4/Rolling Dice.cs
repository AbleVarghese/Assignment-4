using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class Rolling_Dice
    {
        //Instance Variables

        public int[] dice1 = new int[6];
        public int[] dice2 = new int[6];
        public int[] dice1Rolls = new int[36000];
        public int[] dice2Rolls = new int[36000];
        public int[] sum = new int[36000];
        public int[] repeatedSums = new int[12];
        public int[] possibleSums = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        
        

        //Properties

      public void RollingDice1()
        {


            Random dice1 = new Random();

           for (int index = 0; index < 12; index++)
           {
               this.dice1Rolls[index] = dice1.Next(1, 7);
               
           }
       }

      public void RollingDice2()
      {
        
          Random dice2 = new Random();

          for (int index = 0; index < 12; index++)
          {
              this.dice2Rolls[index] = dice2.Next(1, 7);
          }
      }






      public void Sums()
      {

           for (int index = 0; index < 12; index++)
           {
             
               this.sum[index] = this.dice1Rolls[index] + this.dice2Rolls[index];

           }
       }





       public void Compare()
       {


          // Array.ForEach(repeatedSums,Arra);//Clear(repeatedSums, 0, repeatedSums.Length);
          for (int index = 0; index < 11; index++)
           {


               for (int i = 0; i < 12; i++)
               {
                   if (this.sum[i] == this.possibleSums[index])
                   {
                       //Console.WriteLine("--jnjnjnj");
                       this.repeatedSums[index] += 1;

                   }
               }

           }
       }
 


        public void Display()
        {
            for (int i = 0; i < 11; i++)
            {


             // Console.WriteLine("{0}", repeatedSums[i]);
               Console.WriteLine("{0}  + {1} = {2}", this.dice1Rolls[i], this.dice2Rolls[i], sum[i]);
             //  Console.WriteLine("{0}",);
            }
        }
                   
              


    }
}
