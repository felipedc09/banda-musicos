using System;
using System.Collections.Generic;

namespace BandaMusical
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Serenata!");

            Creador manejaorMusicos = new CreadorMusico();

            List<IMusico> todosMusicos = new List<IMusico>
            {
                manejaorMusicos.crear(CreadorMusico.GUITARRISTA, "1"),
                manejaorMusicos.crear(CreadorMusico.VIOLINISTA, "1"),
                manejaorMusicos.crear(CreadorMusico.FLAUTISTA, "1"),
                manejaorMusicos.crear(CreadorMusico.PERCUSIONISTA, "1"),
                manejaorMusicos.crear(CreadorMusico.CANTANTE, "principal"),
                manejaorMusicos.crear(CreadorMusico.TROMPETISTA, "1"),
                manejaorMusicos.crear(CreadorMusico.GUITARRISTA, "2"),
                manejaorMusicos.crear(CreadorMusico.VIOLINISTA, "2"),
                manejaorMusicos.crear(CreadorMusico.FLAUTISTA, "2"),
                manejaorMusicos.crear(CreadorMusico.PERCUSIONISTA, "2"),
                manejaorMusicos.crear(CreadorMusico.CANTANTE, "secundaria"),
                manejaorMusicos.crear(CreadorMusico.TROMPETISTA, "2"),
                manejaorMusicos.crear(CreadorMusico.GUITARRISTA, "3"),
                manejaorMusicos.crear(CreadorMusico.VIOLINISTA, "3"),
                manejaorMusicos.crear(CreadorMusico.FLAUTISTA, "3"),
                manejaorMusicos.crear(CreadorMusico.PERCUSIONISTA, "3"),
                manejaorMusicos.crear(CreadorMusico.CANTANTE, "3"),
                manejaorMusicos.crear(CreadorMusico.TROMPETISTA, "3"),
                manejaorMusicos.crear(CreadorMusico.GUITARRISTA, "4"),
                manejaorMusicos.crear(CreadorMusico.VIOLINISTA, "4"),
                manejaorMusicos.crear(CreadorMusico.FLAUTISTA, "4"),
                manejaorMusicos.crear(CreadorMusico.PERCUSIONISTA, "4"),
                manejaorMusicos.crear(CreadorMusico.CANTANTE, "apoyo"),
                manejaorMusicos.crear(CreadorMusico.TROMPETISTA, "4")
            };

            Presentacion presetnacion = new Presentacion();
            presetnacion.ElegirMusicos(todosMusicos);
            presetnacion.TocarBanda();
            Console.Read();
        }
    }
}
