using System;
namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        //private string nome;
        //private string sobrenome;

        private readonly string nome; //só posso alterar o valor na inicialização ou no construtor.
        private readonly string sobrenome;

        const double pi = 3.14; //Não posso fazer alteração em nenhum momento do código, visto que é uma constante


        public Pessoa() // É um construtor Ele tem o mesmo nome da classe e não possui um retorno
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}