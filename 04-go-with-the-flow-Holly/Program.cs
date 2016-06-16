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
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("The End.");
            }

            else
            {
                while (answer.ToLower() == ("no"))
                Console.WriteLine("Get another cat!");
              
               
            }

            //static bool NoCat;
           // {
              //  string answer = Console.ReadLine();

               // while (!(answer.ToLower() == "no")) ;
               // {
               //     Console.WriteLine("Type yes or no");
               //     answer = Console.ReadLine();
                //}
               // if (answer.ToLower() == "no")
               // {
                //    return true;
              //  }


                Console.ReadKey();
        

         
        }
    }
}
