using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Empleado.Entity
{
    public class EmpleadoTiempoCompleto : Empleado
    {
       

        public decimal TotalDescuentos { get; set; }
        public decimal TotalAFP { get; set; }
        public decimal TotalISSS { get; set; }


        public EmpleadoTiempoCompleto(int empleadoId, string nombre, string apellido, string DUI, decimal salariobase):
         base(empleadoId, nombre, apellido, DUI, salariobase)
        { 
           
        }

        public override string ToString()
        {
            return $"{Nombre} Descuentos :{TotalDescuentos: c2}, AFP: {TotalAFP: c2}, ISSS:  {TotalISSS: c2} ";
        }

    }
}
