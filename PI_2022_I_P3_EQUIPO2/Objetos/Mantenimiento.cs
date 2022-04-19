using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Mantenimiento
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public string Material { get; set; }
        public decimal Costo { get; set; }
        public string Empresa { get; set; }
        public int NumeroSerie { get; set; }
        public string Problema { get; set; }
        public string HoraIngreso { get; set; }
        public string HoraSalida { get; set; }


        public Mantenimiento() : this(string.Empty, 0, string.Empty, 0.00M, string.Empty, 0, string.Empty, string.Empty,
            string.Empty)
        {
        }

        public Mantenimiento(string nombre, int iD, string material, decimal costo, string empresa, int numeroSerie, string problema, string horaIngreso, string horaSalida)
        {
            Nombre = nombre;
            ID = iD;
            Material = material;
            Costo = costo;
            Empresa = empresa;
            NumeroSerie = numeroSerie;
            Problema = problema;
            HoraIngreso = horaIngreso;
            HoraSalida = horaSalida;
        }
    }
}
