using System;
namespace BandaMusical
{
    public interface ICreadorElemento
    {
        Instrumento crear(string tipo);
    }
}
