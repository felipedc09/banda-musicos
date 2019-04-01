using System;
namespace BandaMusical
{
    public class Trompeta : Instrumento
    {
        public override void afinar()
        {
            Console.WriteLine("Afinando la trompeta");
        }


        public override void tocar()
        {
            Console.WriteLine("Suena la trompeta");
        }
    }
}
