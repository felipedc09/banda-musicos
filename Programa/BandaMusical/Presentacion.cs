using System;
using System.Collections.Generic;

namespace BandaMusical
{
    public class Presentacion
    {
        List<IMusico> musicosDisponibles;

        public void ElegirMusicos(List<IMusico> todosMusicos) {
            musicosDisponibles = ObtenerMusicosDisponibles(todosMusicos);
            Console.WriteLine("----------");
            Console.WriteLine(musicosDisponibles.Count + " musicos estan listos para la presentación");
            Console.WriteLine("----------");
        }

        public void TocarBanda() {
            foreach (IMusico musico in musicosDisponibles)
            {
                musico.tocar();
            }
            Console.WriteLine("");
            Console.WriteLine("*******************************************");
            Console.WriteLine(musicosDisponibles.Count + " musicos tocando en la presentación");
            Console.WriteLine("*******************************************");
        }

        private List<IMusico> ObtenerMusicosDisponibles(List<IMusico> todosMusicos)
        {
            Random r = new Random();
            List<IMusico> musicos = new List<IMusico>();
            foreach (IMusico musico in todosMusicos)
            {
                if (NextBool(r))
                {
                    musicos.Add(musico);
                }
            }
            return musicos;
        }

        private bool NextBool(Random r, int truePercentage = 50)
        {
            return r.NextDouble() < truePercentage / 100.0;
        }
    }
}
