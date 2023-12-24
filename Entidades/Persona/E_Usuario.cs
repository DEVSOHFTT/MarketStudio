using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class E_Usuario
    {
        int id;
        E_TipoUsuario tipoUsuario;
        string usuario;
        string contraseña;
        bool habilitado;

        public E_Usuario(int id, E_TipoUsuario tipoUsuario, string usuario, string contraseña, bool habilitado)
        {
            this.id = id;
            this.tipoUsuario = tipoUsuario;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.habilitado = habilitado;
        }

        public E_Usuario()
        {
            this.id = 0;
            this.tipoUsuario = new E_TipoUsuario();
            this.usuario = "";
            this.contraseña = "";
            this.habilitado = false;
        }

        public int Id { get => id; set => id = value; }
        public E_TipoUsuario TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
