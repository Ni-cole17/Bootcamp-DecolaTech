using System;
namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo; // somente a própria classe e classes filhas conseguem acessar

        public abstract void Creditar(double valor);
        
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: " + saldo);
        }


    }
}