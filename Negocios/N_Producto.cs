using Dominio;
using Entidades.Persona;
using Entidades.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_Producto
    {
        internal static List<E_Producto> productos = new List<E_Producto>();

        public static List<E_Producto> SelectProductos(string sql)
        {
            D_Producto dominio = new D_Producto();
            productos.Clear();
            dominio.Select(sql != "" ? sql : "SELECT * FROM Productos");
            while (dominio.Reader.Read())
            {
                E_Producto p = new E_Producto();

                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Producto = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.TipoUnidadMedida.Id = dominio.Reader.GetInt32(4);
                }

                productos.Add(p);
            }

            dominio.Close();
            return productos;
        }
        public static List<E_Producto> SelectProductos()
        {
            D_Producto dominio = new D_Producto();
            productos.Clear();
            dominio.Select("SELECT * FROM Productos");
            while (dominio.Reader.Read())
            {
                E_Producto p = new E_Producto();

                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Producto = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.TipoUnidadMedida.Id = dominio.Reader.GetInt32(4);
                }
                productos.Add(p);
            }
            dominio.Close();
            return productos;
        }

        public static List<E_Producto> SelectProductos(E_Proveedor proveedor, E_SubCategoria subCategoria)
        {
            D_Producto dominio = new D_Producto();
            productos.Clear();
            dominio.Select("SELECT * FROM Productos");
            while (dominio.Reader.Read())
            {
                E_Producto p = new E_Producto();

                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Producto = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.TipoUnidadMedida.Id = dominio.Reader.GetInt32(4);
                }
                productos.Add(p);
            }
            dominio.Close();
            return productos;
        }

        public static E_Producto SelectProducto(int idProducto)
        {
            D_Producto dominio = new D_Producto();
            dominio.Select("SELECT * FROM Productos WHERE id = " + idProducto);

            E_Producto p = new E_Producto();

            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Producto = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.TipoUnidadMedida.Id = dominio.Reader.GetInt32(4);
                }
            }
            return p;
        }
        public static E_Producto SelectProducto(string codigo)
        {
            D_Producto dominio = new D_Producto();
            dominio.Select("SELECT * FROM Productos WHERE codigo = " + codigo);

            E_Producto p = new E_Producto();

            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Producto = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.TipoUnidadMedida.Id = dominio.Reader.GetInt32(4);
                }
            }
            return p;
        }

        public static E_Producto GetProducto(int idProducto)
        {
            if (productos.Count <= 0)
                SelectProductos();

            E_Producto producto = productos.Find(x => x.Id == idProducto);
            return producto;
        }
        public static int GetProducto(string codigo)
        {
            if (productos.Count <= 0)
                SelectProductos();

            int idProducto = productos.Find(x => x.Codigo == codigo).Id;
            return idProducto;
        }
    }
}
