using System;
using System.Collections.Generic;

namespace BandaMusical
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Serenata!");

            Creador manejaorMusicos = CreadorAmigo.Instance;
            List<IMusico> todosMusicos = new List<IMusico>();

            Amigo pepe = manejaorMusicos.crear(CreadorAmigo.GUITARRISTA, "1");
            pepe.setNombre("Pepe");
            pepe.setEdad(30);
            todosMusicos.Add(pepe);

            Amigo alejo = manejaorMusicos.crear(CreadorAmigo.VIOLINISTA, "1");
            alejo.setNombre("Alejandro");
            alejo.setEdad(30);
            todosMusicos.Add(alejo);

            Amigo sara = manejaorMusicos.crear(CreadorAmigo.FLAUTISTA, "1");
            sara.setNombre("Sara");
            sara.setEdad(30);
            todosMusicos.Add(sara);

            Amigo felipe = manejaorMusicos.crear(CreadorAmigo.PERCUSIONISTA, "1");
            felipe.setNombre("Felipe");
            felipe.setEdad(30);
            todosMusicos.Add(felipe); 

            Amigo cris = manejaorMusicos.crear(CreadorAmigo.CANTANTE, "principal");
            cris.setNombre("Cristhian");
            cris.setEdad(30);
            todosMusicos.Add(cris); 

            Amigo juan = manejaorMusicos.crear(CreadorAmigo.TROMPETISTA, "1");
            juan.setNombre("Juan");
            juan.setEdad(30);
            todosMusicos.Add(juan); 

            Amigo sofia = manejaorMusicos.crear(CreadorAmigo.GUITARRISTA, "2");
            sofia.setNombre("Sofia");
            sofia.setEdad(30);
            todosMusicos.Add(sofia); 

            Amigo alex = manejaorMusicos.crear(CreadorAmigo.VIOLINISTA, "2");
            alex.setNombre("Alex");
            alex.setEdad(30);
            todosMusicos.Add(alex); 

            Amigo sergio = manejaorMusicos.crear(CreadorAmigo.FLAUTISTA, "2");
            sergio.setNombre("Sergio");
            sergio.setEdad(30);
            todosMusicos.Add(sergio); 

            Amigo sebas = manejaorMusicos.crear(CreadorAmigo.PERCUSIONISTA, "2");
            sebas.setNombre("Sebas");
            sebas.setEdad(30);
            todosMusicos.Add(sebas); 

            Amigo lorena = manejaorMusicos.crear(CreadorAmigo.CANTANTE, "secundaria");
            lorena.setNombre("Lorena");
            lorena.setEdad(30);
            todosMusicos.Add(lorena); 

            Amigo pilar = manejaorMusicos.crear(CreadorAmigo.TROMPETISTA, "2");
            pilar.setNombre("Pilar");
            pilar.setEdad(30);
            todosMusicos.Add(pilar); 

            Amigo lucho = manejaorMusicos.crear(CreadorAmigo.GUITARRISTA, "3");
            lucho.setNombre("Luis");
            lucho.setEdad(30);
            todosMusicos.Add(lucho); 

            Amigo juliancho = manejaorMusicos.crear(CreadorAmigo.VIOLINISTA, "3");
            juliancho.setNombre("Julian");
            juliancho.setEdad(30);
            todosMusicos.Add(juliancho); 

            Amigo pedro = manejaorMusicos.crear(CreadorAmigo.FLAUTISTA, "3");
            pedro.setNombre("Pedro");
            pedro.setEdad(30);
            todosMusicos.Add(pedro); 

            Amigo ivancho = manejaorMusicos.crear(CreadorAmigo.PERCUSIONISTA, "3");
            ivancho.setNombre("Ivan");
            ivancho.setEdad(30);
            todosMusicos.Add(ivancho); 

            Amigo daniel = manejaorMusicos.crear(CreadorAmigo.CANTANTE, "3");
            daniel.setNombre("Daniel");
            daniel.setEdad(30);
            todosMusicos.Add(daniel); 

            Amigo omar = manejaorMusicos.crear(CreadorAmigo.TROMPETISTA, "3");
            omar.setNombre("Omar");
            omar.setEdad(30);
            todosMusicos.Add(omar); 

            Amigo gabo = manejaorMusicos.crear(CreadorAmigo.GUITARRISTA, "4");
            gabo.setNombre("Gabriel");
            gabo.setEdad(30);
            todosMusicos.Add(gabo); 

            Amigo mono = manejaorMusicos.crear(CreadorAmigo.VIOLINISTA, "4");
            mono.setNombre("Fabian");
            mono.setEdad(30);
            todosMusicos.Add(mono); 

            Amigo pelon = manejaorMusicos.crear(CreadorAmigo.FLAUTISTA, "4");
            pelon.setNombre("Andres");
            pelon.setEdad(30);
            todosMusicos.Add(pelon); 

            Amigo carerata = manejaorMusicos.crear(CreadorAmigo.PERCUSIONISTA, "4");
            carerata.setNombre("Sarco");
            carerata.setEdad(30);
            todosMusicos.Add(carerata); 

            Amigo sabri = manejaorMusicos.crear(CreadorAmigo.CANTANTE, "apoyo");
            sabri.setNombre("Sabrina");
            sabri.setEdad(30);
            todosMusicos.Add(sabri); 

            Amigo cata = manejaorMusicos.crear(CreadorAmigo.TROMPETISTA, "4");
            cata.setNombre("Cata");
            cata.setEdad(30);
            todosMusicos.Add(cata);

            Presentacion presetnacion = new Presentacion();
            presetnacion.ElegirMusicos(todosMusicos);
            presetnacion.TocarBanda();
            Console.Read();
        }
    }
}
