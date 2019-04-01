using System;
namespace BandaMusical
{
    public class Voz : Instrumento
    {
        public override void afinar()
        {
            Console.WriteLine("Afinando la voz");
        }

        public override void tocar()
        {
            Console.WriteLine("Suena la voz");
        }
    }
}
