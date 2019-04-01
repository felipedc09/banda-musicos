using System;
namespace BandaMusical
{
    public class Cantante : Amigo
    {
        private Voz instrumento;
        private string tipo;
        public Cantante(string tipo)
        {
            this.instrumento = new Voz();
            this.tipo = tipo;
        }

        public override void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(this.getNombre() + ": Cantante " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Cantante " + tipo + " tocando");
        }
    }
}
