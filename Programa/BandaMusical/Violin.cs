using System;
namespace BandaMusical
{
    public class Violin : Instrumento
    {
        public override void afinar()
        {
            Console.WriteLine("Afinando el violin");
        }

        public override void tocar()
        {
            Console.WriteLine("Suena el violin");
        }
    }
}
