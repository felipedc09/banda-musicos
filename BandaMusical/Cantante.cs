using System;
namespace BandaMusical
{
    public class Cantante : IMusico
    {
        private Voz instrumento;
        private string tipo;
        public Cantante(string tipo)
        {
            this.instrumento = new Voz();
            this.tipo = tipo;
        }

        public void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Cantante " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Cantante " + tipo + " tocando");
        }
    }
}
