using System;
namespace BandaMusical
{
    public class Trompetista : IMusico
    {
        private Trompeta instrumento;
        private string tipo;
        public Trompetista(string tipo)
        {
            this.instrumento = new Trompeta();
            this.tipo = tipo;
        }

        public void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Trompetista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Trompetista " + tipo + " tocando");
        }
    }
}
