using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Equipaje
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public int Cantidad { get; set; }
        public string Hora { get; set; }
        public decimal Peso { get; set; }
        public string ClaseBoleto { get; set; }
        public string Aerolinea { get; set; }
        public int NumeroBoleto { get; set; }
        public string Destino { get; set; }


        public Equipaje() : this(string.Empty, 0,0, string.Empty, 0.00M, string.Empty, string.Empty,0, 
            string.Empty)
        {
        }

        public Equipaje(string nombre, int iD, int cantidad, string hora, decimal peso, string claseBoleto, string aerolinea, int numeroBoleto, string destino)
        {
            Nombre = nombre;
            ID = iD;
            Cantidad = cantidad;
            Hora = hora;
            Peso = peso;
            ClaseBoleto = claseBoleto;
            Aerolinea = aerolinea;
            NumeroBoleto = numeroBoleto;
            Destino = destino;
        }
    }
}
