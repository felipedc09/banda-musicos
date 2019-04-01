using System;
namespace BandaMusical
{
    public class Percusionista : IMusico
    {
        private Tambor instrumento;
        private string tipo;
        public Percusionista(string tipo)
        {
            this.instrumento = new Tambor();
            this.tipo = tipo;
        }

        public void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Percusionista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Percusionista " + tipo + " tocando");
        }
    }
}
