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

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Aerolinea { get; set; }
        public decimal Costo { get; set; }
        public string FechaActual { get; set; }
        public int NumeroBoleto { get; set; }
        public string TipoBoleto { get; set; }
        public string CiudadActual { get; set; }
        public string CiudadSalida { get; set; }


        public Boleto() : this(0,string.Empty, string.Empty, 0.00M, string.Empty,0, string.Empty, string.Empty,
            string.Empty)
        {
        }

        public Boleto( int pId, string pNombre, string pAerolinea, decimal pCosto, string pFechaActual, int pNumeroBoleto, string pTipoBoleto, string pCiudadActual, string pCiudadSalida)
        {
            Id = pId;
            Nombre = pNombre;
            Aerolinea = pAerolinea;
            Costo = pCosto;
            FechaActual = pFechaActual;
            NumeroBoleto = pNumeroBoleto;
            TipoBoleto = pTipoBoleto;
            CiudadActual = pCiudadActual;
            CiudadSalida = pCiudadSalida;
        }

    }
}
