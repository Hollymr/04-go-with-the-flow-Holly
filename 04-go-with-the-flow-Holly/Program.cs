using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_go_with_the_flow_Holly
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Are you happy?");
            Console.WriteLine("Type yes or no.");
            string answer = Console.ReadLine();

            if (answer.ToLower() == ("yes"))
            {

                Console.WriteLine("The End.");
            }

            else
            {
                
                    while (!(answer.ToLower() == ("yes")))
                    Console.WriteLine("Get another cat!");

            }

            Console.ReadKey();

        }



 //       static bool GetYesorNo()
//        {
//            string answer = Console.ReadLine();
//
//            while (!(answer.ToLower() == "yes" || answer.ToLower() == "no"))
//            {
//                answer = Console.ReadLine();
//                Console.WriteLine("Please state yes or no.");
//
//                if (answer.ToLower() == "yes")
//                {
//                    return true;
//                }
//
//                else (answer.ToLower() == "no")               
//                {
//                    return false; 
//                                      
//                        
 //               }
//            }
 //       }


    }

}
