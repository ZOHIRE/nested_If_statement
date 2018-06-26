using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {


//IF STATEMENT : اف الشرطية // NESTED IF STATEMENT : اف الشرطية المتداخلة 

            int myv1 = 10, myv2 = 15;

            if (myv1 == 10)
            {
                Console.WriteLine("\n\n\t equel 10");
                if (myv2 == 15)
                {
                    Console.WriteLine("\n\n\t my condition 2 is valable");
                }
                else

                {
                    Console.WriteLine("\n\n\t my v2 is not valable ");
                }

            }
            else
            {
                Console.WriteLine("\n\n\t my condition 1 is not valable");
            }



            int myv3 = 10, myv4 = 6, myv5 = 8 ;
            if (myv3 == 10)
            {
                Console.WriteLine("\n\n\n my statement 1 is true");
                if ((myv4 >= 11) && (myv5 <= 9))
                {
                    Console.WriteLine("\n\n\n statement 2 is true");
                }
                else
                {
                    Console.WriteLine("\n\n\n my statement 2 is false");
                }
            }
            else
            {
                Console.WriteLine("\n\n\n my statement 1 is FALSE");
            }


            int myv6 = 4, myv7 = 6;
            if ((myv6 <= 4) && (myv7 >= 5))
          
                {
                    Console.WriteLine("\n\n\n\n\t my conditin one is right");
                } 
                else if ((myv6 >= 9) && (myv7 <= 6))
                {
                            Console.WriteLine("\n\n\n\n\t my conditin tow is right");
                }
                else if (myv7 < 0)
                {
                            Console.WriteLine("\n\n\n\n\t my conditin tree is right");
                }
            if (myv7 == 6)
            {
                Console.WriteLine("yamaha");
            }                              
               else
               {
                   Console.WriteLine("\n\n\n\n\t no one conditin  is right");
               }
                




                    Console.ReadKey();
        }
    }
}