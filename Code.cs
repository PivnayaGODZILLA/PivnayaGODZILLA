using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int trys = 1;

            Random r = new Random();
            bool cheat = false;

            Console.WriteLine("Enter minimal number");
            int min = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter max number");
            int max = Convert.ToInt32(Console.ReadLine());



            int num = r.Next(min, max);


            
            Console.WriteLine("Enter the range of a hint");
            
                int hint = Convert.ToInt32(Console.ReadLine());
            while (hint < min || hint > max)
            {
                Console.WriteLine("WRONG RANGE");
                hint = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter YOUR number");
            int o = Convert.ToInt32(Console.ReadLine());
            while (o != num)
            {
                switch (o)
                {
                    case 1111111111:
                        Console.WriteLine("ANSWER ----> " + num + " <---- ANSWER");
                        trys--;
                        cheat = true;                                           //CHEAT
                        Console.WriteLine("CHEAT ENABLED");
                        o = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:


                if (o < min)
                {
                    Console.WriteLine("too low");
                    o = Convert.ToInt32(Console.ReadLine());              //НИЖЕ МИНИМУМА
                }


                else if (num - hint <= o && num > o)
                {
                    Console.WriteLine("ALMOST, HIGHER");
                    o = Convert.ToInt32(Console.ReadLine());               //ПОДСКАЗКА ВЫШЕ
                        }


                 else if (num + hint >= o && num < o)
                {
                            Console.WriteLine("ALMOST, LOWER");
                            o = Convert.ToInt32(Console.ReadLine());        //ПОДСКАЗКА НИЖЕ
                        }


                else if (o > max)
                {
                    Console.WriteLine("too high");                                      
                    o = Convert.ToInt32(Console.ReadLine());                //БОЛШЬЕ МАКСИМУМА
                }


                else if (o > num)
                {
                    Console.WriteLine("LOWER ");
                    o = Convert.ToInt32(Console.ReadLine());                    //НИЖЕ
                }
                else if (o < num)


                {
                    Console.WriteLine("HIGHER");
                    o = Convert.ToInt32(Console.ReadLine());                    //ВЫШЕ

                }
                        break;
                }
                trys++;
            }
            Console.WriteLine("CONGRATS!!!");
            Console.WriteLine("It took you " + trys + " try(s)");


            if  ( cheat == true)
            {
                Console.WriteLine("\n----->!!!CHEATS WERE USED!!!<------");
            }
        }
              
  
        }

        
          
            }
        
        
    



                
        
    



