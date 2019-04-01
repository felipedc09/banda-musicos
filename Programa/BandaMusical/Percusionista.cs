using System;
namespace BandaMusical
{
    public class Percusionista : Amigo
    {
        private Tambor instrumento;
        private string tipo;
        public Percusionista(string tipo)
        {
            this.instrumento = new Tambor();
            this.tipo = tipo;
        }

        public override void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(this.getNombre() + ": Percusionista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Percusionista " + tipo + " tocando");
        }
    }
}
