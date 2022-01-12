using System.IO;
using System;
using System.Collections.Generic;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }

        }

        public void ListarArquivos(string caminho)
        {
            var retornoArquivo = Directory.GetFiles(caminho,"*.txt",SearchOption.AllDirectories);
            foreach (var retorno in retornoArquivo)
            {
                Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            Console.WriteLine(retorno.FullName);
        }
        public void ExcluirDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho,apagarArquivos);

        }
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho)){
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.AppendText(caminho)){
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            
            foreach(var linha in conteudo){
                Console.WriteLine(linha);
            }
        }
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminho, string novoCaminho)
        {
            File.Move(caminho,novoCaminho);
        }
        public void CopiarArquivo(string caminho, string destino, bool sobrescrever)
        {
            File.Copy(caminho, destino,sobrescrever);
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}