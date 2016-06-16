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
                Console.WriteLine("Get another cat!");
                
            }
            Console.ReadKey();
        }
    }
}
