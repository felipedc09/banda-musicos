using System;
namespace BandaMusical
{
    public class CreadorAmigo : Creador
    {
        private static CreadorAmigo instance;

        private CreadorAmigo() { }

        public static CreadorAmigo Instance
        {
            get
            {
                if (instance == null) {
                    instance = new CreadorAmigo();
                }
                return instance;
            }
        }

        public static string GUITARRISTA = "guitarrista";
        public static string VIOLINISTA = "violinista";
        public static string FLAUTISTA = "flautista";
        public static string PERCUSIONISTA = "percusionista";
        public static string CANTANTE = "cantante";
        public static string TROMPETISTA = "trompetista";

        public override Amigo crear(string tipo, string identificador)
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
