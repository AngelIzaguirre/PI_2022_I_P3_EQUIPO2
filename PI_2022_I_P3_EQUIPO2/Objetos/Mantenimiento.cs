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
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Material { get; set; }
        public decimal Costo { get; set; }
        public string Empresa { get; set; }
        public int NumeroSerie { get; set; }
        public string Problema { get; set; }
        public string HoraIngreso { get; set; }
        public string HoraSalida { get; set; }


        public Mantenimiento() : this(0, string.Empty, string.Empty, 0.00M, string.Empty, 0, string.Empty, string.Empty,
            string.Empty)
        {
        }

        public Mantenimiento(int pId,string pNombre, string pMaterial, decimal pCosto, string pEmpresa, int pNumeroSerie,
            string pProblema, string pHoraIngreso, string pHoraSalida)
        {
            ID = pId;
            Nombre = pNombre;
            Material = pMaterial;
            Costo = pCosto;
            Empresa = pEmpresa;
            NumeroSerie = pNumeroSerie;
            Problema = pProblema;
            HoraIngreso = pHoraIngreso;
            HoraSalida = pHoraSalida;
        }
    }
}
