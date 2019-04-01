using System;
namespace BandaMusical
{
    public class Tambor : Instrumento
    {
        public override void afinar()
        {
            Console.WriteLine("Afinando el tambor");
        }

        public override void tocar()
        {
            Console.WriteLine("Suena el tambor");
        }

    }
}
