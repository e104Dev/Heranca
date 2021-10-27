using System;
namespace Heranca
{
    public class Aguia : Animal
    {
        public Aguia()
        {
        }

        public Aguia(string urlImagem, string comida,
            string habitat, int fome)
            : base(urlImagem, comida, habitat, fome)
        {
        }
    }
}
