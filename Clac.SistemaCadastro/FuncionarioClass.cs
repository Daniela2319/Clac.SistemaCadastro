using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clac.SistemaCadastro
{
    internal class FuncionarioClass : PessoaClass
    {
        //propriedades
        public int Matricula { get; set; }
        public string Profissao { get; set; }
        // construtor
        public FuncionarioClass(int id, string nome, int idade, string endereco, string cidade, int matricula, string profissao) : base(id, nome, idade, endereco, cidade)
        {
            this.Matricula = matricula;
            this.Profissao = profissao;
        }
       
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Address: {Address}, City: {City}, Matricula: {Matricula}, Profissão: {Profissao}";
        }

        //metodo para cadastrar funcionario via entrada de usuario
        public void CadastrarFuncionario(List<FuncionarioClass> listaFuncionarios)
        {
            Console.WriteLine("Digite o ID do funcionário:");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do funcionário:");
            Name = Console.ReadLine();
            Console.WriteLine("Digite a idade do funcionário:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o endereço do funcionário:");
            Address = Console.ReadLine();
            Console.WriteLine("Digite a cidade do funcionário:");
            City = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário:");
            Matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a profissão do funcionário:");
            Profissao = Console.ReadLine();

            FuncionarioClass funcionario = new FuncionarioClass(Id, Name, Age, Address, City, Matricula, Profissao);
            listaFuncionarios.Add(funcionario);

            Console.WriteLine($"Funcionário {Name} cadastrado com sucesso!");
        }
    }
    

    
}
