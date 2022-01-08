using System;
using System.Collections.Generic;
using System.Linq;

namespace Revisao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno [] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = Obteropcaousuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        
                        var nota = decimal.Parse(Console.ReadLine()); //Conversão do valor da string para decimal

                        //if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                        //     aluno.Nota = nota;
                        //}   OUTRA FORMA DE CONVERTER O VALOR

                        aluno.Nota = nota;

                        alunos[indiceAluno] = aluno;
                        indiceAluno++; 
                        break;
                    case "2":
                        for(int i = 0; i < indiceAluno;i++){
                            Console.WriteLine($"Aluno: {alunos[i].Nome}");
                            Console.WriteLine($"Aluno : {alunos[i].Nota}");
                        }
                        // foreach(var a in alunos){
                        // Console.WriteLine($"Aluno: {a.Nome} - Nota{a.Nota}"$)
                        //}
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int j = 0; j < alunos.Length; j++)
                        {
                            if (!string.IsNullOrEmpty(alunos[j].Nome))
                            {
                                    notaTotal = notaTotal + alunos[j].Nota;
                                    nrAlunos++;
                            }   
                        }
                        var mediageral = notaTotal/nrAlunos;
                        ConceitoEnum conceitoGeral;
                        if(mediageral <= 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }
                        else if (mediageral <= 4)
                        {
                            conceitoGeral= ConceitoEnum.D;
                        }
                        else if (mediageral <= 6)
                        {
                            conceitoGeral= ConceitoEnum.C;
                        }
                        else if (mediageral <= 8)
                        {
                            conceitoGeral= ConceitoEnum.B;
                        }
                        else{
                            conceitoGeral= ConceitoEnum.A;
                        }
                        Console.WriteLine($"Média Geral: {mediageral} - Conceito Geral: {conceitoGeral}");
                        
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = Obteropcaousuario();
            }
        }

        private static string Obteropcaousuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo Aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}