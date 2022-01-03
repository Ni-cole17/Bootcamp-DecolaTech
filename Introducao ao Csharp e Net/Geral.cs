using System;
using Organizador1;
using Infos;
using Interfaces;
using Enum;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.Eduardo;

            Pessoa person1 = new Pessoa();
            Pessoa person2 = new Pessoa();


            person1.Nome = "Nicole";
            person1.Idade = 22;
            person1.Sobrenome = "Charron";
            person1.Cidade = "Fortaleza";

            person2.Nome = "Fifinha";
            person2.Idade = 15;
            person2.Sobrenome = "Charron";
            person2.Cidade = "Campo Mourão";

            Ani animal = new Ani();

            animal.Nome = "Baleia";
            animal.NomeDono = "Iolanda";
            animal.Especie = "Cachorro";

            var classe = new Classe1();
            Console.WriteLine("Hello");
        }
    }
}
