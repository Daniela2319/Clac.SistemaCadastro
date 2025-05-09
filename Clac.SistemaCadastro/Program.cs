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
            List<FuncionarioClass> listaFuncionarios = new List<FuncionarioClass>();
            GerenciadorFuncionarioClass gerenciador = new GerenciadorFuncionarioClass();
            string resposta;

            do
            {
                FuncionarioClass funcionario1 = new FuncionarioClass(0, "", 0, "", "", 0, "");
                funcionario1.CadastrarFuncionario(listaFuncionarios);
                gerenciador.AdicionarFuncionario(funcionario1);

                Console.WriteLine("Deseja cadastrar outro funcionário? (s/n)");
                resposta = Console.ReadLine();
            } while (resposta == "s");
            


            gerenciador.ExibirFuncionarios();
            gerenciador.ExibirTotalFuncionarios();
            Console.ReadKey();
            //Console.WriteLine("Pressione qualquer tecla para sair...");




        }
    }
}
