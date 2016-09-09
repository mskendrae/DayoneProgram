using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayoneProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //String name = Console.ReadLine();
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello "+ name + "." );
            //Console.WriteLine(name);

            Console.WriteLine("Enter two numbers to be added together");
            int numberone = int.Parse(Console.ReadLine());
            int numbertwo = int.Parse(Console.ReadLine());
            int finalnumber = numbertwo + numberone;
            Console.WriteLine(finalnumber);
            
        }
    }
}
