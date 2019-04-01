using System;
namespace BandaMusical
{
    public class Violinista : Amigo
    {
        private Violin instrumento;
        private string tipo;
        public Violinista(string tipo)
        {
            instrumento = new Violin();
            this.tipo = tipo;
        }

        public override void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(this.getNombre() + ": Violinista " +tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Violinista " + tipo + " tocando");
        }
    }
}
