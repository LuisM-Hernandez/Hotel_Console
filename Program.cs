using System;

namespace Hotel_Console
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Welcome to the Carlington Hotel");
        Console.WriteLine("Which kind of room would you like?");
        Console.WriteLine("Press 1 for single, 2 for double and 3 for suite");
        var room = Int32.Parse(Console.ReadLine());

        switch (room)
        {
            case 1:
            Console.WriteLine("You selected single");
            Console.WriteLine("What floor do you wish to stay?");
            var floor = Int32.Parse(Console.ReadLine());

            if (floor <= 5)
            {
                Console.WriteLine("You have chosen floor number " + floor);
                Console.WriteLine("The cost per night is $45.00");
                Console.WriteLine("How long will you stay?");
                var roomCost = 45.00;
                var numNights = Int32.Parse(Console.ReadLine());
                var total1 = roomCost * numNights;
                Console.WriteLine("Your total is $"+ total1);
            }
                

            else if (floor == 6 || floor <=11)
            {
                Console.WriteLine("You have chosen floor number" + floor);
                    Console.WriteLine("The cost per night is $55.00");
                    Console.WriteLine("How long will you stay?");
                    var roomCost2 = 55.00;
                    var numNights2 = Int32.Parse(Console.ReadLine());
                    var total2 = roomCost2 * numNights2;
                    Console.WriteLine("Your total is $"+total2);
            }

            else if (floor == 12)
            {
                Console.WriteLine("That room is unavailable");
            }

            else if  (floor > 12)
            {
                Console.WriteLine("We do not have that many rooms. Try again");
            }

            break;

           
            

        }

        }
    }
}
