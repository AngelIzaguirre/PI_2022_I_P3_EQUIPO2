using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Equipaje
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Hora { get; set; }
        public decimal Peso { get; set; }
        public string ClaseBoleto { get; set; }
        public string Aerolinea { get; set; }
        public int NumeroBoleto { get; set; }
        public string Destino { get; set; }


        public Equipaje() : this(0,string.Empty,0, string.Empty, 0.00M, string.Empty, string.Empty,0, 
            string.Empty)
        {
        }

        public Equipaje(int pId,string pNombre, int pCantidad, string pHora, decimal pPeso, string pClaseBoleto, string pAerolinea,
            int pNumeroBoleto, string pDestino)
        {
            ID = pId;
            Nombre = pNombre;
            Cantidad = pCantidad;
            Hora = pHora;
            Peso = pPeso;
            ClaseBoleto = pClaseBoleto;
            Aerolinea = pAerolinea;
            NumeroBoleto = pNumeroBoleto;
            Destino = pDestino;
        }
    }
}
