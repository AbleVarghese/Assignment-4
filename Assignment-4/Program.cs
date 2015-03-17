using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Rolling_Dice Rolling = new Rolling_Dice();
            Rolling.RollingDice1();
            Rolling.RollingDice2();
            Rolling.Sums();          
            Rolling.Compare();
            Rolling.Display();
            Console.ReadKey();
        }
    }
}
