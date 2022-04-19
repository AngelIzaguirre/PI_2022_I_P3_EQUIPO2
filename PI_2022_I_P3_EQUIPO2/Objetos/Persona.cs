using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int RTN { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string NumeroIdentidad { get; set; }
        public string NumeroPasaporte { get; set; }
        public int Telefono { get; set; }
        public string Nacionalidad { get; set; }


        public Persona() : this(0,string.Empty,0, string.Empty, 0, string.Empty, string.Empty, 0,
            string.Empty)
        {
        }

        public Persona(int pId,string pNombre, int pRTN, string pGenero, int pEdad, string pNumeroIdentidad, string pNumeroPasaporte,
            int pTelefono, string pNacionalidad)
        {
            ID = pId;
            Nombre = pNombre;
            RTN = pRTN;
            Genero = pGenero;
            Edad = pEdad;
            NumeroIdentidad = pNumeroIdentidad;
            NumeroPasaporte = pNumeroPasaporte;
            Telefono = pTelefono;
            Nacionalidad = pNacionalidad;
        }
    }
}
