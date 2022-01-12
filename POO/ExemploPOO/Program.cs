using System;
using System.Collections.Generic;
using System.Linq;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.Collections.Generic;

namespace ExemploPOO // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           var caminho = "C:\\Users\\nicol\\Documents\\DECOLATECH\\Trabalhandocomarquivos";
           var caminhocombine = Path.Combine(caminho, "Teste3");
           var caminhoArquivo = Path.Combine(caminho,"arquivo-teste-stream.txt");
           var listastring = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
           var listastringcontinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
           var novoCaminhoArquivo = Path.Combine(caminho,"Teste2","arquivo-teste-stream.txt");
           var copia = Path.Combine(caminho,"arquivo-teste-stream.txt");

           FileHelper helper = new FileHelper();
           helper.ListarDiretorios(caminho);
           helper.ListarArquivos(caminho);
           //helper.CriarDiretorio(caminhocombine);
           //helper.ExcluirDiretorio(caminhocombine,true);
           // helper.CriarArquivoTexto(caminhoArquivo,"Olá, esse é o primeiro arquivo!");
           //helper.CriarArquivoTextoStream(caminhoArquivo,listastring);
           //helper.AdicionarTextoStream(caminhoArquivo,listastringcontinuacao);
           //helper.LerArquivoStream(caminhoArquivo);
           //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
           //helper.CopiarArquivo(novoCaminhoArquivo,copia,false);
           helper.DeletarArquivo(copia);

           ICalculadora calc2 = new Calculadora();
           Console.WriteLine(calc2.Somar(10,30));

           Computador comp = new Computador();
           Console.WriteLine(comp.ToString());

           Corrente c = new Corrente();
           c.Creditar(100);
           c.ExibirSaldo();

           Calculadora calc = new Calculadora();
           Console.WriteLine($"Resultado da soma: {calc.Somar(10,4)}");
                                
           Aluno p2 = new Aluno();
           p2.Nome = "Luis";
           p2.Idade = 29;
           p2.Nota = 9;
           p2.Apresentar();

           Professor p3 = new Professor();
           p3.Salario = 3000;
           p3.Nome = "Francis";
           p3.Idade = 66;
           p3.Apresentar();
           
           
           Retangulo r = new Retangulo();
           r.DefinirMedidas(40,30);

           var area = r.ObterArea();
           Console.WriteLine($"Area:{area}");

           
            Pessoa p1 = new Pessoa();

            p1.Nome = "Nicole";
            p1.Idade = 22;

            p1.Apresentar();
        }
    }
}