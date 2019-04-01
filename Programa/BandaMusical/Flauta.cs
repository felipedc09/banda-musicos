using System;
namespace BandaMusical
{
    public class Flauta : Instrumento
    {
        public override void afinar()
        {
            Console.WriteLine("Afinando la flauta");
        }

        public override void tocar()
        {
            Console.WriteLine("Suena la flauta");
        }
    }
}
