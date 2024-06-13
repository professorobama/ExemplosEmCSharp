using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExemploBreak
    {
        public static void Main(string[] args) {

            for (int i = 0; i < 10; i++)
            {
                if (i ==5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
    }
}
