using Entidades.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Venta
{
    public class E_Venta
    {
        int id;
        DateTime fecha;
        E_Empleado empleado;

        public E_Venta(int id, DateTime fecha, E_Empleado empleado)
        {
            this.id = id;
            this.fecha = fecha;
            this.empleado = empleado;
        }


        public E_Venta()
        {
            this.id = 0;
            this.fecha = new DateTime();
            this.empleado = new E_Empleado();
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public E_Empleado Empleado { get => empleado; set => empleado = value; }
    }
}
