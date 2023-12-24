using Dominio;
using Entidades;
using Entidades.Persona;
using Entidades.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_Proveedor
    {
        /*
        SELECT pr.id, empresa, cuit, dni, nombre, apellido, telefono, telefonoAlternativo, email, domicilio 
        FROM Proveedores AS pr, Personas AS pe 
        WHERE pr.idPersona = pe.id;
        */

        internal static List<E_Proveedor> proveedores = new List<E_Proveedor>();
        public static List<E_Proveedor> SelectProveedores(string sql)
        {
            D_Proveedor dominio = new D_Proveedor();
            proveedores.Clear();

            dominio.Select(sql != "" ? sql : "SELECT * FROM SelectAllProveedores");
            while (dominio.Reader.Read())
            {
                E_Proveedor p = new E_Proveedor();

                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Empresa = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Cuit = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.Dni = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.Nombre = dominio.Reader.GetString(4);
                }
                if (!dominio.Reader.IsDBNull(5))
                {
                    p.Apellido = dominio.Reader.GetString(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    p.Telefono = dominio.Reader.GetString(6);
                }
                if (!dominio.Reader.IsDBNull(7))
                {
                    p.TelefonoAlternativo = dominio.Reader.GetString(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    p.Email = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    p.Domicilio = dominio.Reader.GetString(9);
                }

                proveedores.Add(p);
            }
            return proveedores;
        }
        public static List<E_Proveedor> SelectProveedores()
        {
            D_Proveedor dominio = new D_Proveedor();
            proveedores.Clear();

            dominio.Select("SELECT * FROM SelectAllProveedores");
            while (dominio.Reader.Read())
            {
                E_Proveedor p = new E_Proveedor();

                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Empresa = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Cuit = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.Dni = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.Nombre = dominio.Reader.GetString(4);
                }
                if (!dominio.Reader.IsDBNull(5))
                {
                    p.Apellido = dominio.Reader.GetString(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    p.Telefono = dominio.Reader.GetString(6);
                }
                if (!dominio.Reader.IsDBNull(7))
                {
                    p.TelefonoAlternativo = dominio.Reader.GetString(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    p.Email = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    p.Domicilio = dominio.Reader.GetString(9);
                }

                proveedores.Add(p);
            }
            dominio.Close();
            return proveedores;
        }

        public static E_Proveedor SelectProveedor(string empresa)
        {
            D_Proveedor dominio = new D_Proveedor();
            dominio.Select("SELECT * FROM SelectAllProveedores WHERE empresa = '" + empresa + "'");

            E_Proveedor p = new E_Proveedor();

            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Empresa = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Cuit = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.Dni = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.Nombre = dominio.Reader.GetString(4);
                }
                if (!dominio.Reader.IsDBNull(5))
                {
                    p.Apellido = dominio.Reader.GetString(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    p.Telefono = dominio.Reader.GetString(6);
                }
                if (!dominio.Reader.IsDBNull(7))
                {
                    p.TelefonoAlternativo = dominio.Reader.GetString(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    p.Email = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    p.Domicilio = dominio.Reader.GetString(9);
                }
            }
            dominio.Close();
            return p;
        }
        public static E_Proveedor SelectProveedor(int idProveedor)
        {
            D_Proveedor dominio = new D_Proveedor();
            dominio.Select("SELECT * FROM SelectAllProveedores WHERE pr.id = " + idProveedor);

            E_Proveedor p = new E_Proveedor();

            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Empresa = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Cuit = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.Dni = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.Nombre = dominio.Reader.GetString(4);
                }
                if (!dominio.Reader.IsDBNull(5))
                {
                    p.Apellido = dominio.Reader.GetString(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    p.Telefono = dominio.Reader.GetString(6);
                }
                if (!dominio.Reader.IsDBNull(7))
                {
                    p.TelefonoAlternativo = dominio.Reader.GetString(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    p.Email = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    p.Domicilio = dominio.Reader.GetString(9);
                }
            }
            dominio.Close();
            return p;
        }

        public static E_Proveedor GetProveedor(int idProveedor)
        {
            if (proveedores.Count <= 0)
                SelectProveedores();

            E_Proveedor proveedor = proveedores.Find(x => x.Id == idProveedor);
            return proveedor;
        }
        public static int GetProveedor(string empresa)
        {
            if (proveedores.Count <= 0)
                SelectProveedores();

            int idProveedor = proveedores.Find(x => x.Empresa == empresa).Id;
            return idProveedor;
        }

        public static List<E_Proveedor> GetProveedores()
        {
            if (proveedores.Count <= 0)
                SelectProveedores();

            return proveedores;
        }
    }
}
