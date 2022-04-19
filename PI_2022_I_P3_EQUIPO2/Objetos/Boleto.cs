using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Boleto
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public string Aerolinea { get; set; }
        public decimal Costo { get; set; }
        public string FechaActual { get; set; }
        public int NumeroBoleto { get; set; }
        public string TipoBoleto { get; set; }
        public string CiudadActual { get; set; }
        public string CiudadSalida { get; set; }


        public Boleto() : this(string.Empty, 0, string.Empty, 0.00M, string.Empty,0, string.Empty, string.Empty,
            string.Empty)
        {
        }

        public Boleto(string nombre, int iD, string aerolinea, decimal costo, string fechaActual, int numeroBoleto, string tipoBoleto, string ciudadActual, string ciudadSalida)
        {
            Nombre = nombre;
            ID = iD;
            Aerolinea = aerolinea;
            Costo = costo;
            FechaActual = fechaActual;
            NumeroBoleto = numeroBoleto;
            TipoBoleto = tipoBoleto;
            CiudadActual = ciudadActual;
            CiudadSalida = ciudadSalida;
        }
    }
}
