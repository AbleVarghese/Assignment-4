using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Airline_Reservation_System
    {
        public bool[] firstClassSeats = new bool[5];
        public bool[] economySeats = new bool[5];


        public void Menu()
        {
            int choice = 0;

            int counter = 0;

            for (int index = 0; index < 5; index++)
            {
                firstClassSeats[index] = false;
                economySeats[index] = false;
            }



            while (choice != 3)
            {
                counter += 1;
                Console.WriteLine("\n1. First Class\n2. Economy\n3. Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                // if (firstClassSeatNum >= 6)
                //     System.Environment.Exit(0);
                //else if (economySeatNum >= 6)
                //    System.Environment.Exit(0);

                switch (choice)
                {
                    case 1:
                        FirstClassSeatReservation();


                        break;
                    case 2: EconomySeatReservation();


                        break;

                    case 3: Console.WriteLine("\nExiting the system");
                        break;

                    default: Console.WriteLine("\nPlease make a selection..\n");
                        break;

                }
            }
        }

        public void EconomySeatReservation()
        {
            int indexSeatNo = 6;
            int index2 = 0;
            while (index2 < 5)
            {
                // Console.WriteLine("{0}a",indexSeatNo);
                if (economySeats[index2] == false)
                {
                    economySeats[index2] = true;
                    Console.Write("You have successfully reserved economy class ticket, your seat number is {0}", (indexSeatNo));
                    return;
                }
                index2 += 1;
                indexSeatNo += 1;

            }
            Console.WriteLine("Sorry, economy class has no more seats left.\n\n");

            int x = SeatsFullMethod();

            if (x == 5)
            {
                Console.WriteLine("Sorry, the seats are full, Next flight is in 3 hours");
                return;
            }
            else
            {

                Console.Write(" Would you like to reserve seat in first class? please type in yes/no: ");
                string changeClass = Console.ReadLine();
                if (changeClass == "yes" || changeClass == "YES")
                {
                    FirstClassSeatReservation();

                }
                if (changeClass == "no" || changeClass == "NO")
                {
                    return;

                }
            }


        }



        public void FirstClassSeatReservation()
        {
            int index = 1;
            int loopIndex = 0;
            while (loopIndex < 5)
            {
                if (firstClassSeats[loopIndex] == false)
                {
                    firstClassSeats[loopIndex] = true;
                    Console.WriteLine("You have successfully reserved first class ticket, your seat number is {0}", (index));
                    return;
                }
                loopIndex += 1;
                index += 1;


            }


            Console.WriteLine("sorry2, first class has no more seats left\n\n");

            int seatFullIndex = SeatsFullMethod();


            if (seatFullIndex == 5)
            {
                Console.WriteLine("Sorry, the seats are full, Next flight is in 3 hours");
                return;
            }

            Console.WriteLine("Would you like to reserve seat in economy class? ");

            string changeClass = Console.ReadLine();
            if (changeClass == "yes" || changeClass == "YES")
            {
                EconomySeatReservation();

            }
            if (changeClass == "no" || changeClass == "NO")
            {
                return;

            }


            return;

        }



        public int SeatsFullMethod()
        {


            int seatFullIndex = 0;
            while (seatFullIndex < 5)
            {

                if (firstClassSeats[seatFullIndex] == true && economySeats[seatFullIndex] == true)
                {
                    seatFullIndex += 1;



                }
                else
                {
                    return (seatFullIndex);

                }

            }

            return (seatFullIndex);

        }



    }
}
