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

 Console.WriteLine("Please make your choice between Applications. \n\n1. Rolling Dice App. \n2. Airline Reservation System\n");
 int select=Convert.ToInt32(Console.ReadLine());
 
            if(select==1)
            {

            Rolling_Dice Rolling = new Rolling_Dice();
            Rolling.RollingDice1();
            Rolling.RollingDice2();
            Rolling.Sums();          
            Rolling.Compare();
            Rolling.Display();
            Console.ReadKey();
            }

            else if (select == 2)
            {
                Airline_Reservation_System Flight = new Airline_Reservation_System();
                Flight.Menu();
            }

            else
            { Console.WriteLine("\nPlease enter choice No. 1 or choice No. 2"); }



        }
    }
}
