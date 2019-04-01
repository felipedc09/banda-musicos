using System;
namespace BandaMusical
{
    public class Violinista : IMusico
    {
        private Violin instrumento;
        private string tipo;
        public Violinista(string tipo)
        {
            instrumento = new Violin();
            this.tipo = tipo;
        }

        public void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Violinista " +tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Violinista " + tipo + " tocando");
        }
    }
}
