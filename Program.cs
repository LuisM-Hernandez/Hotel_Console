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
                var stay = Int32.Parse(Console.ReadLine());
                
                
                if (stay <= 3)
                {
                    Console.WriteLine("You've chosen "+ stay + " nights");
                    var cost = 45.00;
                    var total = stay * cost;
                    Console.WriteLine("Your total is $"+total); 
                    
                   
                }
            }
            break;

            case 2:

            Console.WriteLine("You selected double");
            Console.WriteLine("What floor do you wish to stay?");
            var floornum2 = Int32.Parse(Console.ReadLine());

            if (floornum2 <= 5)
            {
                Console.WriteLine("You have chosen floor number " + floornum2);
                Console.WriteLine("How long will you stay?");
                var stay = Int32.Parse(Console.ReadLine());
                
                if (stay <= 3)
                {
                    Console.WriteLine("You've chosen "+ stay + " nights");
                }
            }
            break;

            case 3:

            Console.WriteLine("You selected suite");
            Console.WriteLine("What floor do you wish to stay?");
            var floornum3 = Int32.Parse(Console.ReadLine());

            if (floornum3 <= 5)
            {
                Console.WriteLine("You have chosen floor number " + floornum3);
                Console.WriteLine("How long will you stay?");
                var stay = Int32.Parse(Console.ReadLine());
                
                if (stay <= 3)
                {
                    Console.WriteLine("You've chosen "+ stay + " nights");
                }
            }
            break;

            

        }




        }
    }
}
