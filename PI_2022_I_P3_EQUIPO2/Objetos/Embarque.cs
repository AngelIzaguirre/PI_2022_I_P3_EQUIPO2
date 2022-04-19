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
        public string Nombre { get; set; }
        public int ID { get; set; }
        public string Direccion { get; set; }
        public decimal Costo { get; set; }
        public string FechaActual { get; set; }
        public int Telefono { get; set; }
        public string TipoBoleto { get; set; }
        public string Compañia { get; set; }
        public int Cantidad { get; set; }


        public Embarque() : this(string.Empty, 0, string.Empty, 0.00M, string.Empty, 0, string.Empty, string.Empty,
            0)
        {
        }

        public Embarque(string nombre, int iD, string direccion, decimal costo, string fechaActual, int telefono, string tipoBoleto, string compañia, int cantidad)
        {
            Nombre = nombre;
            ID = iD;
            Direccion = direccion;
            Costo = costo;
            FechaActual = fechaActual;
            Telefono = telefono;
            TipoBoleto = tipoBoleto;
            Compañia = compañia;
            Cantidad = cantidad;
        }
    }
}
