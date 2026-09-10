using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Empleado.Entity
{
    public class EmpleadoPorHora : Empleado
    {
        public int CantidadHoras { get; set; }
        public decimal PrecioHoras { get; set; }

        public EmpleadoPorHora(
            int EmpleadoId,
            string Nombre,
            string Apellido,
            string DUI,
            decimal SalarioBase,
            int cantidadHoras,
            decimal precioPorHoras
            )
        {
           
        }

        public override string ToString()
        {
            return string.Format($"{CantidadHoras}.{PrecioHoras}  ");
        }

    }
}
