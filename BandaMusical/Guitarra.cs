using System;
namespace BandaMusical
{
    public class Guitarra : Instrumento
    {
        public override void afinar()
        {
            Console.WriteLine("Afinando la guitarra");
        }

        public override void tocar()
        {
            Console.WriteLine("Suena la guitarra");
        }
    }
}
