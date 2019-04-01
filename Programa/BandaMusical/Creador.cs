using System;
namespace BandaMusical
{
    public abstract class Creador
    {
        public abstract Amigo crear(string tipo, string identificador);
    }
}
