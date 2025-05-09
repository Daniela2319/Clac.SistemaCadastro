using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clac.SistemaCadastro
{
    internal class GerenciadorFuncionarioClass
    {
        private List<FuncionarioClass> funcionarios;

        public GerenciadorFuncionarioClass()
        {
            funcionarios = new List<FuncionarioClass>();
        }

        public void AdicionarFuncionario(FuncionarioClass funcionario)
        {
            funcionarios.Add(funcionario);
            
        }

        public void ExibirFuncionarios()
        {
            Console.WriteLine("Lista de Funcionários:");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.ToString());
            }
        }

        public void ExibirTotalFuncionarios()
        {
            Console.WriteLine($"Total de Funcionários: {funcionarios.Count}");
        }

        public List<FuncionarioClass> ObterFuncionarios()
        {
            return funcionarios;
        }
    }
}
