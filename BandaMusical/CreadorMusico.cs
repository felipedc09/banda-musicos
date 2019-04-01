using System;
namespace BandaMusical
{
    public class CreadorMusico : Creador
    {
        public static string GUITARRISTA = "guitarrista";
        public static string VIOLINISTA = "violinista";
        public static string FLAUTISTA = "flautista";
        public static string PERCUSIONISTA = "percusionista";
        public static string CANTANTE = "cantante";
        public static string TROMPETISTA = "trompetista";

        public override IMusico crear(string tipo, string identificador)
        {
            switch (tipo)
            {
                case "guitarrista":
                    return new Guitarrista(identificador);
                case "violinista":
                    return new Violinista(identificador);
                case "cantante":
                    return new Cantante(identificador);
                case "flautista":
                    return new Flautista(identificador);
                case "trompetista":
                    return new Trompetista(identificador);
                case "percusionista":
                    return new Percusionista(identificador);
                default:
                    return null;
            }
        }
    }
}
