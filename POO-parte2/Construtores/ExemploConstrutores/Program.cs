using System;
using ExemploConstrutores.Models;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            
            Matematica m = new Matematica(10,20);
            m.Somar();
            
            
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            // Operacao op = Calculadora.Somar; uma forma de chamar diferente sem o "new"
            op.Invoke(10,10);
            // também pode ser chamado assim: op(10,10);
            


            Data data = new Data();
            data.SetMes(-2);
            data.ApresentarMes();
           
            data.Mes = 12;
            Console.WriteLine(data.Mes);
           
            Aluno p2 = new Aluno("Nicole","Charron","Matemática");
            p2.Apresentar();
            
            
            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste Instância";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);

            Pessoa p1 = new Pessoa("Nicole", "Charron");
            p1.Apresentar();
        }
    }
}