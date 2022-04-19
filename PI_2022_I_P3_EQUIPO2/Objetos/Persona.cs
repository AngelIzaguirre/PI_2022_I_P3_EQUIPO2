using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public int RTN { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string NumeroIdentidad { get; set; }
        public string NumeroPasaporte { get; set; }
        public int Telefono { get; set; }
        public string Nacionalidad { get; set; }


        public Persona() : this(string.Empty, 0,0, string.Empty, 0, string.Empty, string.Empty, 0,
            string.Empty)
        {
        }

        public Persona(string nombre, int iD, int rTN, string genero, int edad, string numeroIdentidad, string numeroPasaporte, int telefono, string nacionalidad)
        {
            Nombre = nombre;
            ID = iD;
            RTN = rTN;
            Genero = genero;
            Edad = edad;
            NumeroIdentidad = numeroIdentidad;
            NumeroPasaporte = numeroPasaporte;
            Telefono = telefono;
            Nacionalidad = nacionalidad;
        }
    }
}
