using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class E_Persona
    {
        string dni;
        string nombre;
        string apellido;
        string telefono;
        string telefonoAlternativo;
        string email;
        string domicilio;

        public E_Persona(string dni, string nombre, string apellido, string telefono, string telefonoAlternativo, string email, string domicilio)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.telefonoAlternativo = telefonoAlternativo;
            this.email = email;
            this.domicilio = domicilio;
        }

        public E_Persona()
        {
            this.dni = "";
            this.nombre = "";
            this.apellido = "";
            this.telefono = "";
            this.telefonoAlternativo = "";
            this.email = "";
            this.domicilio = "";
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string TelefonoAlternativo { get => telefonoAlternativo; set => telefonoAlternativo = value; }
        public string Email { get => email; set => email = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
    }
}
