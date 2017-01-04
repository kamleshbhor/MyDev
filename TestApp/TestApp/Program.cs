using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
            PrintCity();
            PrintState();
            PrintCountry();
            Console.Read();
        }

        public static void PrintName()
        {
            Console.WriteLine("Kamlesh");
        }


        public static void PrintCity()
        {
            Console.WriteLine("Pune");
        }



        public static void PrintState()
        {
            Console.WriteLine("Maharashtra");
        }

        public static void PrintCountry()
        {
            Console.WriteLine("India");
        }
    }
}
