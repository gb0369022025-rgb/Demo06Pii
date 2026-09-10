using System;
using System.Collections.Generic;
using System.Text;

namespace Empleado.Entity
{
    public abstract class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string DUI  { get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado()
        {
            
        }

        public Empleado(int empleadoId, string nombre, string apellido, string dUI, decimal salario)
        {
            EmpleadoId = empleadoId;
            Nombre = nombre;
            Apellido = apellido;
            DUI = dUI;
            SalarioBase = salario;
        }

        public abstract decimal CalcularSalario()
    }

   
}
