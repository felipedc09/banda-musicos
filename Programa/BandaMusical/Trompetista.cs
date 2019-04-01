using System;
namespace BandaMusical
{
    public class Trompetista : Amigo
    {
        private Trompeta instrumento;
        private string tipo;
        public Trompetista(string tipo)
        {
            this.instrumento = new Trompeta();
            this.tipo = tipo;
        }

        public override void tocar()
        {
            Console.WriteLine("============================================");
            Console.WriteLine(this.getNombre() + ": Trompetista " + tipo + " preparandose para tocar");
            instrumento.usar();
            Console.WriteLine("Trompetista " + tipo + " tocando");
        }
    }
}
