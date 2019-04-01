using System;
namespace BandaMusical
{
    public abstract class Creador
    {
        public abstract IMusico crear(string tipo, string identificador);
    }
}
