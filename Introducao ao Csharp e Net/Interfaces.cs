namespace Interfaces
{
    interface Animal
    {
        void Nome(string nome);
        void Dono(string nome_dono);
        void Especie(string especie);
    }
    class Ani : Animal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void Animal.Nome(string nome)
        {
            this.Nome = nome;

        }
        void Animal.Dono(string nomedono)
        {
            this.NomeDono = nomedono;

        }
        void Animal.Especie(string especie)
        {
            this.Especie = especie;

        }
    }
}