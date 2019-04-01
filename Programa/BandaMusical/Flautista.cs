using System;
namespace BandaMusical
{
    public class Flautista : Amigo
    {
        private Flauta instrumento;
        private string tipo;
        public Flautista(string tipo)
        {
            this.instrumento = new Flauta();
            this.tipo = tipo;
        }

        public override void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(this.getNombre() + ": Flautista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Flautista " + tipo + " tocando");
        }
    }
}
