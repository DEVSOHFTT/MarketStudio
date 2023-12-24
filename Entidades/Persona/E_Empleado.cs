using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class E_Empleado : E_Persona
    {
        int id;
        E_Usuario usuario;
        E_TipoCargo tipoCargo;
        int horasAsignadas;
        double sueldo;
        double incentivo;
        E_TipoPuesto tipoPuesto;

        public E_Empleado(int id, E_Usuario usuario, E_TipoCargo tipoCargo, int horasAsignadas, double sueldo, double incentivo, E_TipoPuesto tipoPuesto, string dni, string nombre, string apellido, string telefono, string telefonoAlternativo, string email, string domicilio) 
                        : base(dni, nombre, apellido, telefono, telefonoAlternativo, email, domicilio)
        {
            this.id = id;
            this.usuario = usuario;
            this.tipoCargo = tipoCargo;
            this.horasAsignadas = horasAsignadas;
            this.sueldo = sueldo;
            this.incentivo = incentivo;
            this.tipoPuesto = tipoPuesto;
        }

        public E_Empleado()
        {
            this.id = 0;
            this.usuario = new E_Usuario();
            this.tipoCargo = new E_TipoCargo();
            this.horasAsignadas = 0;
            this.sueldo = 0;
            this.incentivo = 0;
            this.tipoPuesto = new E_TipoPuesto();
        }

        public int Id { get => id; set => id = value; }
        public E_Usuario Usuario { get => usuario; set => usuario = value; }
        public E_TipoCargo TipoCargo { get => tipoCargo; set => tipoCargo = value; }
        public int HorasAsignadas { get => horasAsignadas; set => horasAsignadas = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public double Incentivo { get => incentivo; set => incentivo = value; }
        public E_TipoPuesto TipoPuesto { get => tipoPuesto; set => tipoPuesto = value; }

        public override string ToString()
        {
            return Apellido + " " + Nombre;
        }
    }
}
