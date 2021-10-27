using System;
namespace Heranca
{
    public class Animal
    {     
        private string urlImagem;
        public string UrlImagem { get; set; }

        private string comida;
        public string Comida { get; set; }

        private string habitat;
        public string Habitat { get; set; }

        private int fome;
        public int Fome { get; set; }

        public Animal(string urlImagem,
            string comida, string habitat, int fome)
        {
            this.urlImagem = urlImagem;
            this.comida = comida;
            this.habitat = habitat;
            this.fome = fome;
        }

        public Animal()
        {
        }

        public void comer()
        {
            Console.WriteLine("{0} comendo...", this.GetType().Name);
        }

        public void dormir()
        {
            Console.WriteLine("{0} dormindo...\nZzzzzzzzz.......", this.GetType().Name);
        }

        public override string ToString()
        {
            return String.Format("{0}[urlImagem='{1}', comida='{2}', habitat='{3}', fome={4}]",
               this.GetType().Name, urlImagem, comida, habitat, fome);
        }
    }
}
