using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public decimal Salario { get; set; }
        public string Genero { get; set; }
        public int Telefono { get; set; }
        public int NumeroContrato { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }


        public Empleado() : this(0,string.Empty, string.Empty, 0.00M, string.Empty, 0, 0, 0, 
            string.Empty)
        {
        }

        public Empleado(int pId, string pNombre, string pDireccion, decimal pSalario, string pGenero, int pTelefono, 
            int pNumeroContrato, int pEdad, string pCargo)
        {
            ID = pId;
            Nombre = pNombre;
            Direccion = pDireccion;
            Salario = pSalario;
            Genero = pGenero;
            Telefono = pTelefono;
            NumeroContrato = pNumeroContrato;
            Edad = pEdad;
            Cargo = pCargo;
        }
    }
}
