using System;
namespace BandaMusical
{
    public abstract class Instrumento
    {
        public abstract void afinar();
        public abstract void tocar();

        public void usar()
        {
            afinar();
            tocar();
        }
    }
}
