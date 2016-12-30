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
    }
}
