using System;
namespace BandaMusical
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public string getNombre() {
            return nombre;
        }

        public void setNombre(string nombre) { 
            this.nombre = nombre;
        }

        public int getEdad()
        {
            return edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

    }
}
