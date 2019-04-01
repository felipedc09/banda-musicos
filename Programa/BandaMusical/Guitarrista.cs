using System;
namespace BandaMusical
{
    public class Guitarrista : Amigo
    {
        private Guitarra instrumento;
        private string tipo;
        public Guitarrista(string tipo)
        {
            this.instrumento = new Guitarra();
            this.tipo = tipo;
        }

        public override void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(this.getNombre() + ": Guitarrista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Guitarrista " + tipo + " tocando");
        }
    }
}
