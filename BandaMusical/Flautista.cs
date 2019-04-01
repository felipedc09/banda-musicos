using System;
namespace BandaMusical
{
    public class Flautista : IMusico
    {
        private Flauta instrumento;
        private string tipo;
        public Flautista(string tipo)
        {
            this.instrumento = new Flauta();
            this.tipo = tipo;
        }

        public void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Flautista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Flautista " + tipo + " tocando");
        }
    }
}
