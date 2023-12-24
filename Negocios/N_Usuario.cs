using Dominio;
using Entidades.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_Usuario
    {
        internal static List<E_Usuario> usuarios = new List<E_Usuario>();
        public static List<E_Usuario> SelectUsuarios(string sql)
        {
            D_Usuario dominio = new D_Usuario();
            usuarios.Clear();
            dominio.Select(sql != "" ? sql : "SELECT * FROM Usuarios");
            while (dominio.Reader.Read())
            {
                E_Usuario u = new E_Usuario();

                if (!dominio.Reader.IsDBNull(0))
                {
                    u.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    u.TipoUsuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    u.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    u.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    u.Habilitado = dominio.Reader.GetBoolean(4);
                }

                usuarios.Add(u);
            }
            dominio.Close();
            return usuarios;
        }
        public static List<E_Usuario> SelectUsuarios()
        {
            D_Usuario dominio = new D_Usuario();
            usuarios.Clear();
            dominio.Select("SELECT * FROM Usuarios");
            while (dominio.Reader.Read())
            {
                E_Usuario u = new E_Usuario();

                if (!dominio.Reader.IsDBNull(0))
                {
                    u.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    u.TipoUsuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    u.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    u.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    u.Habilitado = dominio.Reader.GetBoolean(4);
                }

                usuarios.Add(u);
            }
            dominio.Close();
            return usuarios;
        }

        public static E_Usuario SelectUsuario(int idUsuario)
        {
            D_Usuario dominio = new D_Usuario();
            E_Usuario usuario = new E_Usuario();
            dominio.Select("SELECT * FROM Usuarios WHERE id = " + idUsuario);
            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    usuario.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    usuario.TipoUsuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    usuario.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    usuario.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    usuario.Habilitado = dominio.Reader.GetBoolean(4);
                }
            }

            return usuario;
        }
        public static E_Usuario SelectUsuario(string usuario)
        {
            D_Usuario dominio = new D_Usuario();
            E_Usuario user = new E_Usuario();
            dominio.Select("SELECT * FROM Usuarios WHERE usuario = '" + usuario + "'");
            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    user.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    user.TipoUsuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    user.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    user.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    user.Habilitado = dominio.Reader.GetBoolean(4);
                }
            }

            return user;
        }

        public static E_Usuario GetUsuario(int idUsuario)
        {
            if (usuarios.Count <= 0)
                SelectUsuarios();

            E_Usuario usuario = usuarios.Find(x => x.Id == idUsuario);
            return usuario;
        }
        public static int GetUsuario(string usuario)
        {
            if (usuarios.Count <= 0)
                SelectUsuarios();

            int idUsuario = usuarios.Find(x => x.Usuario == usuario).Id;
            return idUsuario;
        }

        public static bool InsertUsuario(int idTipoUsuario, string usuario, string contraseña)
        {
            string sql = "INSERT INTO Usuarios(idTipoUsuario, usuario, contraseña, habilitado) " +
                         "VALUES(" + idTipoUsuario + ",'" + usuario + "','" + contraseña + "'," + true + ")";
            D_Usuario dominio = new D_Usuario();
            return dominio.Insert(sql);
        }
    }
}
