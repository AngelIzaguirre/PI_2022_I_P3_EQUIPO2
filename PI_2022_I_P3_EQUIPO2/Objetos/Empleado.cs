using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_P3_EQUIPO2.Properties
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public string Direccion { get; set; }
        public decimal Salario { get; set; }
        public string Genero { get; set; }
        public int Telefono { get; set; }
        public int NumeroContrato { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }


        public Empleado() : this(string.Empty, 0, string.Empty, 0.00M, string.Empty, 0, 0, 0, 
            string.Empty)
        {
        }

        public Empleado(string nombre, int iD, string direccion, decimal salario, string genero, int telefono, int numeroContrato, int edad, string cargo)
        {
            Nombre = nombre;
            ID = iD;
            Direccion = direccion;
            Salario = salario;
            Genero = genero;
            Telefono = telefono;
            NumeroContrato = numeroContrato;
            Edad = edad;
            Cargo = cargo;
        }
    }
}
