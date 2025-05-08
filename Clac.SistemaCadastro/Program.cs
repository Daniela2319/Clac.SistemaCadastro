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
           PessoaClass pessoa = new PessoaClass(1, "Daniela", 25, "Rua Paineiras", "Faz. Rio Grande");
            
            pessoa.Apresentar();
            //Console.WriteLine(pessoa.ToString());

           Console.WriteLine( pessoa.ToString());
        }
    }
}
