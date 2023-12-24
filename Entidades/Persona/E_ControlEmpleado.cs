using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class E_ControlEmpleado
    {
        int id;
        DateTime fecha;
        E_Empleado empleado;
        DateTime horaIngreso;
        DateTime horaSalida;

        public E_ControlEmpleado(int id, DateTime fecha, E_Empleado empleado, DateTime horaIngreso, DateTime horaSalida)
        {
            this.id = id;
            this.fecha = fecha;
            this.empleado = empleado;
            this.horaIngreso = horaIngreso;
            this.horaSalida = horaSalida;
        }
        public E_ControlEmpleado()
        {
            this.id = 0;
            this.fecha = new DateTime();
            this.empleado = new E_Empleado();
            this.horaIngreso = new DateTime();
            this.horaSalida = new DateTime();
        }

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public E_Empleado Empleado { get => empleado; set => empleado = value; }
        public DateTime HoraIngreso { get => horaIngreso; set => horaIngreso = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
    }
}
