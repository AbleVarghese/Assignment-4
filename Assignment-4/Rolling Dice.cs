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
        public int[] repeatedSums = new int[11];
        public int[] possibleSums = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        
        

        //Properties

        public void RollingDice1()
        {


            Random dice1 = new Random();

            for (int index = 0; index < 36000; index++)
            {
                this.dice1Rolls[index] = dice1.Next(1, 7);
                if (this.dice1Rolls[index] >= 4)
                {
                    this.dice1Rolls[index] = dice1.Next(4, 7);
                }

            }
        }

      public void RollingDice2()
      {
        
          Random dice2 = new Random();

          for (int index = 0; index < 36000; index++)
          {
              this.dice2Rolls[index] = dice2.Next(1, 7);
              if (this.dice2Rolls[index] < 4)
              {
                  this.dice2Rolls[index] = dice2.Next(1, 4);
              }
            //  Console.Write("{0},  ", dice2Rolls[index]);

          }
          Console.Write("....\n\n\n");
      }






      public void Sums()
      {

           for (int index = 0; index <36000; index++)
           {
             
               this.sum[index] = this.dice1Rolls[index] + this.dice2Rolls[index];

              // Console.Write("{0},  ", sum[index]);

           }
          // Console.Write("....\n\n\n");
       }





       public void Compare()
       {


          //Clear(repeatedSums, 0, repeatedSums.Length);
          for (int index = 0; index < 11; index++)
           {
            
               for (int i = 0; i < 36000; i++)
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
                Console.WriteLine("1st Dice Roll\t2nd Dice Roll\tSums\n");
            for (int index = 0; index < 5; index++)
            {
                
                Console.WriteLine("    {0}         +        {1}       \t= {2}", this.dice1Rolls[index], this.dice2Rolls[index], sum[index]);
                Console.WriteLine("------------------------------------------");

            }
            Console.WriteLine("etc.. etc...  Above table continued upto 36000 times");
            Console.WriteLine("\n\n   Possible Sums\t  No. of Occurance\n");
            for (int i = 0; i < 11; i++)
            {
                    Console.WriteLine("\t{0}\t\t\t{1}", possibleSums[i], repeatedSums[i]);

            }
            Console.Write("\n\n");
        
        }
                   
              


    }
}
