using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tæller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antal = 1;
            do
            {
                Console.WriteLine(antal++);
            } while (antal < 11);
        }
    }
}
