using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clac.SistemaCadastro
{
    internal class PessoaClass
    {  //propriedades
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Address { get; set; }

        public string City { get; set; }


        // construtor
        public PessoaClass(int id, string nome, int idade, string endereco, string cidade)
        {
            this.Id = id;
            this.Name = nome;
            this.Age = idade;
            this.Address = endereco;
            this.City = cidade;
        }

        //metodo para apresenta apessoa
        public void Apresentar()  
        {
            Console.WriteLine($"Hello, my name is {Name}, have {Age}, live in {City} and {Address}");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Address: {Address}, City: {City}";
        }

    }
}
