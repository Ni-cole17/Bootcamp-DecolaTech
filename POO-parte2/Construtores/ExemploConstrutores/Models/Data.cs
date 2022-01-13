namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }
        public void SetMes(int mes)
        {
            if(mes > 0 && mes <=12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public int Mes // mais simples fazer com uma propriedade, visto que evita fazer 2 métodos get e set.
            {
             get
             {
                return this.mes;
             }
             set
             {
                if(value > 0 && value <=12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
             } 
            }

        public void ApresentarMes()
        {
           if(mesValido)
           {
                Console.WriteLine(mes);
           }
           else
           {
                Console.WriteLine("Mês Inválido");
           } 
        }

    }
}