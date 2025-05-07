using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clac.SistemaCadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");
            Console.WriteLine("What is your name:");

            string name = Console.ReadLine();

            Console.WriteLine($"My name is {name}");
        }
    }
}
