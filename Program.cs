using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = 0, pointc = 0 ;

            int pc;
            string start;
            Random comp = new Random();
            
            int comp1 = comp.Next(1, 4);

            Console.WriteLine("==================================");
            Console.WriteLine("^v_<^<_ROCK PAPERS SISSORS_>^>_>v^");
            Console.WriteLine("==================================");

            Console.WriteLine("\n\t    PRESS ENTER");

            Console.ReadLine();


            Console.WriteLine("enter TO START, x TO CANCEL");
            start = Console.ReadLine();
            while (start != "x")
            {
                Console.WriteLine("1 - rock" +
                    " \n2 - paper" +
                    " \n3 - sisors\n");

                pc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (comp1 == 1)
                {
                    Console.WriteLine("Comp chose rock\n");
                }
                else if (comp1 == 2)
                {                                               //comp
                    Console.WriteLine("Comp chose paper\n");
                }
                else if (comp1 == 3)
                {
                    Console.WriteLine("Comp chose sissors\n");
                }
                switch (pc)
                {
                    case 1:
                        Console.WriteLine("You chose rock\n");
                        break;
                    case 2:
                        Console.WriteLine("You chose paper\n");
                        break;
                    case 3:
                        Console.WriteLine("You chose sissors\n");
                        break;
                        
                }
                if (pc == 1 && comp1 == 3)
                {
                    Console.WriteLine("\nYOU WIN");
                    point++;
                }
                else if (pc == 1 && comp1 == 2)
                {
                    Console.WriteLine("\nYOU LOSE");
                    pointc++;

                }
                else if (pc == 1 && comp1 == 1)
                {
                    Console.WriteLine("\nDRAW");

                }
                else if (pc == 2  && comp1 == 1)
                    {
                        Console.WriteLine("\nYOU WIN");
                    point++;
                    }
                else if (pc == 2 && comp1 == 3)
                {
                        Console.WriteLine("\nYOU LOSE");
                        pointc++;

                    }
                else if (pc == 2 && comp1 == 2)
                    {
                        Console.WriteLine("\nDRAW");

                    }
                else if (pc == 3 && comp1 == 2)
                {
                    Console.WriteLine("\nYOU WIN");
                    point++;
                }
                else if (pc == 3 && comp1 == 1)
                {
                    Console.WriteLine("\nYOU LOSE");
                    pointc++;

                }
                else if (pc == 3 && comp1 == 3)
                {
                    Console.WriteLine("\nDRAW");

                }

                Console.WriteLine("\nYOU :" + point);
                Console.WriteLine("COMP :" + pointc);

                Console.WriteLine("\nenter TO PLAY AGAIN, x TO CANCEL\n");
                start = Console.ReadLine();
                comp = new Random();
                comp1 = comp.Next(1, 4);

            }

        }
    }
}
