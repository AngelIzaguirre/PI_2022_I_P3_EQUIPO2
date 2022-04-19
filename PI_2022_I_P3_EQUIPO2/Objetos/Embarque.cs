using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Embarque
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public decimal Costo { get; set; }
        public string FechaActual { get; set; }
        public int Telefono { get; set; }
        public string TipoBoleto { get; set; }
        public string Compañia { get; set; }
        public int Cantidad { get; set; }


        public Embarque() : this(0,string.Empty, string.Empty, 0.00M, string.Empty, 0, string.Empty, string.Empty,
            0)
        {
        }

        public Embarque(int pId, string pNombre, string pDireccion, decimal pCosto, string pFechaActual, int pTelefono, string pTipoBoleto,
            string pCompañia, int pCantidad)
        {
            ID = pId;
            Nombre = pNombre;
            Direccion = pDireccion;
            Costo = pCosto;
            FechaActual = pFechaActual;
            Telefono = pTelefono;
            TipoBoleto = pTipoBoleto;
            Compañia = pCompañia;
            Cantidad = pCantidad;
        }
    }
}
