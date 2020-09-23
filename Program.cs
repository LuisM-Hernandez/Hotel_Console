using System;

namespace Hotel_Console
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("Welcome to the Carlington Hotel");
        Console.WriteLine("");
        Console.WriteLine("What kind of room would you like?");
        Console.WriteLine("");
        Console.WriteLine("Press 1 for single, 2 for double and 3 for suite");
        var room = Int32.Parse(Console.ReadLine());

        switch (room)
        {
            case 1:  
            Console.WriteLine("You selected single");
            Console.WriteLine("");
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
                var discount = (total1) - (total1 / 100) * 10;
                

                if (numNights <= 3)
                {
                    Console.WriteLine("Your total is $"+ total1);
                }

                else if (numNights >= 4)
                {
                    Console.WriteLine("Your total is $"+ discount);
                }
                
            }
                
            else if (floor == 6 || floor <=11)
            {
                    Console.WriteLine("You have chosen floor number" + floor);
                    Console.WriteLine("The cost per night is $55.00");
                    Console.WriteLine("How long will you stay?");
                    var roomCost2 = 55.00;
                    var numNights2 = Int32.Parse(Console.ReadLine());
                    var total2 = roomCost2 * numNights2;
                    var discount2 = (total2) - (total2 / 100) * 10;

                    if (numNights2 <= 3)
                    {
                        Console.WriteLine("Your total is $"+ total2);
                    }

                    else if (numNights2 >=4)
                    {
                        Console.WriteLine("Your total is $"+ discount2);
                    }
                    
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

            case 2:
            Console.WriteLine("You selected double");
            Console.WriteLine("");
            Console.WriteLine("What floor do you wish to stay?");
            var floor2 = Int32.Parse(Console.ReadLine());

            if (floor2 <= 5)
            {
                Console.WriteLine("You have chosen floor number " + floor2);
                Console.WriteLine("The cost per night is $60.00");
                Console.WriteLine("How long will you stay?");
                var roomCost = 60.00;
                var numNights = Int32.Parse(Console.ReadLine());
                var total1 = roomCost * numNights;
                var discount = (total1) - (total1 / 100) * 10;
                

                if (numNights <= 3)
                {
                    Console.WriteLine("Your total is $"+ total1);
                }

                else if (numNights >= 4)
                {
                    Console.WriteLine("Your total is $"+ discount);
                }
                
            }
                
            else if (floor2 == 6 || floor2 <=11)
            {
                    Console.WriteLine("You have chosen floor number" + floor2);
                    Console.WriteLine("The cost per night is $72.00");
                    Console.WriteLine("How long will you stay?");
                    var roomCost2 = 72.00;
                    var numNights2 = Int32.Parse(Console.ReadLine());
                    var total2 = roomCost2 * numNights2;
                    var discount2 = (total2) - (total2 / 100) * 10;

                    if (numNights2 <= 3)
                    {
                        Console.WriteLine("Your total is $"+ total2);
                    }

                    else if (numNights2 >=4)
                    {
                        Console.WriteLine("Your total is $"+ discount2);
                    }
                    
            }

            else if (floor2 == 12)
            {
                    Console.WriteLine("You have chosen floor number " + floor2);
                    Console.WriteLine("The cost per night is $120.00");
                    Console.WriteLine("How long will you stay?");
                    var roomCost2 = 120.00;
                    var numNights2 = Int32.Parse(Console.ReadLine());
                    var total2 = roomCost2 * numNights2;
                    var discount2 = (total2) - (total2 / 100) * 10;

                    if (numNights2 <= 3)
                    {
                        Console.WriteLine("Your total is $"+ total2);
                    }

                    else if (numNights2 >=4)
                    {
                        Console.WriteLine("Your total is $"+ discount2);
                    }
            }

            else if  (floor2 > 12)
            {
                Console.WriteLine("We do not have that many rooms. Try again");
            }

            break;

            case 3:
            Console.WriteLine("You selected suite");
            Console.WriteLine("");
            Console.WriteLine("What floor do you wish to stay?");
            var floor3 = Int32.Parse(Console.ReadLine());

            if (floor3 <= 5)
            {
                Console.WriteLine("You have chosen floor number " + floor3);
                Console.WriteLine("The cost per night is $130.00");
                Console.WriteLine("How long will you stay?");
                var roomCost = 130.00;
                var numNights = Int32.Parse(Console.ReadLine());
                var total1 = roomCost * numNights;
                var discount = (total1) - (total1 / 100) * 10;
                

                if (numNights <= 3)
                {
                    Console.WriteLine("Your total is $"+ total1);
                }

                else if (numNights >= 4)
                {
                    Console.WriteLine("Your total is $"+ discount);
                }
                
            }
                
            else if (floor3 == 6 || floor3 <=11)
            {
                    Console.WriteLine("You have chosen floor number" + floor3);
                    Console.WriteLine("The cost per night is $215.00");
                    Console.WriteLine("How long will you stay?");
                    var roomCost2 = 215.00;
                    var numNights2 = Int32.Parse(Console.ReadLine());
                    var total2 = roomCost2 * numNights2;
                    var discount2 = (total2) - (total2 / 100) * 10;

                    if (numNights2 <= 3)
                    {
                        Console.WriteLine("Your total is $"+ total2);
                    }

                    else if (numNights2 >=4)
                    {
                        Console.WriteLine("Your total is $"+ discount2);
                    }
                    
            }

            else if (floor3 == 12)
            {
                    Console.WriteLine("You have chosen floor number " + floor3);
                    Console.WriteLine("The cost per night is $350.00");
                    Console.WriteLine("How long will you stay?");
                    var roomCost2 = 350.00;
                    var numNights2 = Int32.Parse(Console.ReadLine());
                    var total2 = roomCost2 * numNights2;
                    var discount2 = (total2) - (total2 / 100) * 10;

                    if (numNights2 <= 3)
                    {
                        Console.WriteLine("Your total is $"+ total2);
                    }

                    else if (numNights2 >=4)
                    {
                        Console.WriteLine("Your total is $"+ discount2);
                    }
            }

            else if  (floor3 > 12)
            {
                Console.WriteLine("We do not have that many rooms. Try again");
            }

            break;
        }

        }
    }
}
