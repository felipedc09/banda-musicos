using System;
namespace BandaMusical
{
    public class Guitarrista : IMusico
    {
        private Guitarra instrumento;
        private string tipo;
        public Guitarrista(string tipo)
        {
            this.instrumento = new Guitarra();
            this.tipo = tipo;
        }

        public void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Guitarrista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Guitarrista " + tipo + " tocando");
        }
    }
}
