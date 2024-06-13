using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExemploForeach
    {
        public static void Main(string[] args) { 
        string [] carro = {"uno","apolo","kwid","206"};
            foreach (string contadora in carro)
            {
                Console.WriteLine(contadora);   
            }
        }
    }
}
