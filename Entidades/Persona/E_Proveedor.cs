using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class E_Proveedor: E_Persona
    {
        int id;
        string empresa;
        string cuit;
        public E_Proveedor(int id, string empresa, string cuit, string dni, string nombre, string apellido, string telefono, string telefonoAlternativo, string email, string domicilio): base( dni,  nombre,  apellido,  telefono,  telefonoAlternativo,  email,  domicilio)
        {
            this.id = id;
            this.empresa = empresa;
            this.cuit = cuit;
        }

        public E_Proveedor()
        {
            this.id = 0;
            this.empresa = "";
            this.cuit = "";
        }

        public int Id { get => id; set => id = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Cuit { get => cuit; set => cuit = value; }
    }
}
