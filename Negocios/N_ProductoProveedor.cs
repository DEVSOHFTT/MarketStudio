 using Dominio;
using Entidades.Persona;
using Entidades.Producto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_ProductoProveedor
    {
        internal static List<E_ProductoProveedor> productosProveedores = new List<E_ProductoProveedor>();
        public static List<E_ProductoProveedor> SelectProductosProveedores(string where)
        {
            D_ProductoProveedor dominio = new D_ProductoProveedor();
            productosProveedores.Clear();
            dominio.Select("SELECT * FROM SelectAllProductosProveedores " + where);
            while (dominio.Reader.Read())
            {
                E_ProductoProveedor pp = new E_ProductoProveedor();

                //Datos del Producto
                if (!dominio.Reader.IsDBNull(0))
                {
                    pp.Producto.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    pp.Producto.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    pp.Producto.Producto = dominio.Reader.GetString(2);
                }
                //Datos de la categoria
                if (!dominio.Reader.IsDBNull(3))
                {
                    pp.Producto.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    pp.Producto.SubCategoria.SubCategoria = dominio.Reader.GetString(4);
                }
                //Datos de la unidad de medida
                if (!dominio.Reader.IsDBNull(5))
                {
                    pp.Producto.TipoUnidadMedida.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    pp.Producto.TipoUnidadMedida.UnidadMedida = dominio.Reader.GetString(6);
                }
                //Datos del proveedor
                if (!dominio.Reader.IsDBNull(7))
                {
                    pp.Proveedor.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    pp.Proveedor.Empresa = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    pp.Proveedor.Cuit = dominio.Reader.GetString(9);
                }
                //Datos de ProductoProveedor
                if (!dominio.Reader.IsDBNull(10))
                {
                    pp.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    pp.Stock = Convert.ToDouble(dominio.Reader.GetDecimal(11));
                }
                if (!dominio.Reader.IsDBNull(12))
                {
                    pp.PrecioCompra = Convert.ToDouble(dominio.Reader.GetDecimal(12));
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    pp.PrecioVenta = Convert.ToDouble(dominio.Reader.GetDecimal(13));
                }

                productosProveedores.Add(pp);
            }
            dominio.Close();
            return productosProveedores;
        }

        public static List<E_ProductoProveedor> SelectProductosProveedores(E_Proveedor proveedor, E_SubCategoria subCategoria)
        {
            D_ProductoProveedor dominio = new D_ProductoProveedor();
            productosProveedores.Clear();
            dominio.Select("SELECT * FROM SelectAllProductosProveedores WHERE prs.id = " + proveedor.Id + " AND sc.id = " + subCategoria.Id);
            while (dominio.Reader.Read())
            {
                E_ProductoProveedor pp = new E_ProductoProveedor();

                //Datos del Producto
                if (!dominio.Reader.IsDBNull(0))
                {
                    pp.Producto.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    pp.Producto.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    pp.Producto.Producto = dominio.Reader.GetString(2);
                }
                //Datos de la categoria
                if (!dominio.Reader.IsDBNull(3))
                {
                    pp.Producto.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    pp.Producto.SubCategoria.SubCategoria = dominio.Reader.GetString(4);
                }
                //Datos de la unidad de medida
                if (!dominio.Reader.IsDBNull(5))
                {
                    pp.Producto.TipoUnidadMedida.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    pp.Producto.TipoUnidadMedida.UnidadMedida = dominio.Reader.GetString(6);
                }
                //Datos del proveedor
                if (!dominio.Reader.IsDBNull(7))
                {
                    pp.Proveedor.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    pp.Proveedor.Empresa = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    pp.Proveedor.Cuit = dominio.Reader.GetString(9);
                }
                //Datos de ProductoProveedor
                if (!dominio.Reader.IsDBNull(10))
                {
                    pp.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    pp.Stock = Convert.ToDouble(dominio.Reader.GetDecimal(11));
                }
                if (!dominio.Reader.IsDBNull(12))
                {
                    pp.PrecioCompra = Convert.ToDouble(dominio.Reader.GetDecimal(12));
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    pp.PrecioVenta = Convert.ToDouble(dominio.Reader.GetDecimal(13));
                }

                productosProveedores.Add(pp);
            }
            dominio.Close();
            return productosProveedores;
        }
        public static List<E_ProductoProveedor> SelectProductosProveedores(E_Proveedor proveedor)
        {
            D_ProductoProveedor dominio = new D_ProductoProveedor();
            productosProveedores.Clear();
            dominio.Select("SELECT * FROM SelectAllProductosProveedores WHERE prs.id = " + proveedor.Id);
            while (dominio.Reader.Read())
            {
                E_ProductoProveedor pp = new E_ProductoProveedor();

                //Datos del Producto
                if (!dominio.Reader.IsDBNull(0))
                {
                    pp.Producto.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    pp.Producto.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    pp.Producto.Producto = dominio.Reader.GetString(2);
                }
                //Datos de la categoria
                if (!dominio.Reader.IsDBNull(3))
                {
                    pp.Producto.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    pp.Producto.SubCategoria.SubCategoria = dominio.Reader.GetString(4);
                }
                //Datos de la unidad de medida
                if (!dominio.Reader.IsDBNull(5))
                {
                    pp.Producto.TipoUnidadMedida.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    pp.Producto.TipoUnidadMedida.UnidadMedida = dominio.Reader.GetString(6);
                }
                //Datos del proveedor
                if (!dominio.Reader.IsDBNull(7))
                {
                    pp.Proveedor.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    pp.Proveedor.Empresa = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    pp.Proveedor.Cuit = dominio.Reader.GetString(9);
                }
                //Datos de ProductoProveedor
                if (!dominio.Reader.IsDBNull(10))
                {
                    pp.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    pp.Stock = Convert.ToDouble(dominio.Reader.GetDecimal(11));
                }
                if (!dominio.Reader.IsDBNull(12))
                {
                    pp.PrecioCompra = Convert.ToDouble(dominio.Reader.GetDecimal(12));
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    pp.PrecioVenta = Convert.ToDouble(dominio.Reader.GetDecimal(13));
                }

                productosProveedores.Add(pp);
            }
            dominio.Close();
            return productosProveedores;
        }
        public static List<E_ProductoProveedor> SelectProductosProveedores(E_SubCategoria subCategoria)
        {
            D_ProductoProveedor dominio = new D_ProductoProveedor();
            productosProveedores.Clear();
            dominio.Select("SELECT * FROM SelectAllProductosProveedores WHERE sc.id = " + subCategoria.Id);
            while (dominio.Reader.Read())
            {
                E_ProductoProveedor pp = new E_ProductoProveedor();

                //Datos del Producto
                if (!dominio.Reader.IsDBNull(0))
                {
                    pp.Producto.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    pp.Producto.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    pp.Producto.Producto = dominio.Reader.GetString(2);
                }
                //Datos de la categoria
                if (!dominio.Reader.IsDBNull(3))
                {
                    pp.Producto.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    pp.Producto.SubCategoria.SubCategoria = dominio.Reader.GetString(4);
                }
                //Datos de la unidad de medida
                if (!dominio.Reader.IsDBNull(5))
                {
                    pp.Producto.TipoUnidadMedida.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    pp.Producto.TipoUnidadMedida.UnidadMedida = dominio.Reader.GetString(6);
                }
                //Datos del proveedor
                if (!dominio.Reader.IsDBNull(7))
                {
                    pp.Proveedor.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    pp.Proveedor.Empresa = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    pp.Proveedor.Cuit = dominio.Reader.GetString(9);
                }
                //Datos de ProductoProveedor
                if (!dominio.Reader.IsDBNull(10))
                {
                    pp.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    pp.Stock = Convert.ToDouble(dominio.Reader.GetDecimal(11));
                }
                if (!dominio.Reader.IsDBNull(12))
                {
                    pp.PrecioCompra = Convert.ToDouble(dominio.Reader.GetDecimal(12));
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    pp.PrecioVenta = Convert.ToDouble(dominio.Reader.GetDecimal(13));
                }

                productosProveedores.Add(pp);
            }
            dominio.Close();
            return productosProveedores;
        }

        public static List<E_ProductoProveedor> SelectProductosProveedores(int idProveedor)
        {
            D_ProductoProveedor dominio = new D_ProductoProveedor();
            productosProveedores.Clear();
            dominio.Select("SELECT * FROM SelectAllProductosProveedores WHERE prs.id = " + idProveedor);
            while (dominio.Reader.Read())
            {
                E_ProductoProveedor pp = new E_ProductoProveedor();

                //Datos del Producto
                if (!dominio.Reader.IsDBNull(0))
                {
                    pp.Producto.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    pp.Producto.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    pp.Producto.Producto = dominio.Reader.GetString(2);
                }
                //Datos de la categoria
                if (!dominio.Reader.IsDBNull(3))
                {
                    pp.Producto.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    pp.Producto.SubCategoria.SubCategoria = dominio.Reader.GetString(4);
                }
                //Datos de la unidad de medida
                if (!dominio.Reader.IsDBNull(5))
                {
                    pp.Producto.TipoUnidadMedida.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    pp.Producto.TipoUnidadMedida.UnidadMedida = dominio.Reader.GetString(6);
                }
                //Datos del proveedor
                if (!dominio.Reader.IsDBNull(7))
                {
                    pp.Proveedor.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    pp.Proveedor.Empresa = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    pp.Proveedor.Cuit = dominio.Reader.GetString(9);
                }
                //Datos de ProductoProveedor
                if (!dominio.Reader.IsDBNull(10))
                {
                    pp.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    pp.Stock = Convert.ToDouble(dominio.Reader.GetDecimal(11));
                }
                if (!dominio.Reader.IsDBNull(12))
                {
                    pp.PrecioCompra = Convert.ToDouble(dominio.Reader.GetDecimal(12));
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    pp.PrecioVenta = Convert.ToDouble(dominio.Reader.GetDecimal(13));
                }

                productosProveedores.Add(pp);
            }
            dominio.Close();
            return productosProveedores;
        }
        public static List<E_ProductoProveedor> SelectProductosProveedores()
        {
            D_ProductoProveedor dominio = new D_ProductoProveedor();
            productosProveedores.Clear();
            dominio.Select("SELECT * FROM SelectAllProductosProveedores");
            while (dominio.Reader.Read())
            {
                E_ProductoProveedor pp = new E_ProductoProveedor();

                //Datos del Producto
                if (!dominio.Reader.IsDBNull(0))
                {
                    pp.Producto.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    pp.Producto.Codigo = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    pp.Producto.Producto = dominio.Reader.GetString(2);
                }
                //Datos de la categoria
                if (!dominio.Reader.IsDBNull(3))
                {
                    pp.Producto.SubCategoria.Id = dominio.Reader.GetInt32(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    pp.Producto.SubCategoria.SubCategoria = dominio.Reader.GetString(4);
                }
                //Datos de la unidad de medida
                if (!dominio.Reader.IsDBNull(5))
                {
                    pp.Producto.TipoUnidadMedida.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    pp.Producto.TipoUnidadMedida.UnidadMedida = dominio.Reader.GetString(6);
                }
                //Datos del proveedor
                if (!dominio.Reader.IsDBNull(7))
                {
                    pp.Proveedor.Id = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    pp.Proveedor.Empresa = dominio.Reader.GetString(8);
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    pp.Proveedor.Cuit = dominio.Reader.GetString(9);
                }
                //Datos de ProductoProveedor
                if (!dominio.Reader.IsDBNull(10))
                {
                    pp.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    pp.Stock = Convert.ToDouble(dominio.Reader.GetDecimal(11));
                }
                if (!dominio.Reader.IsDBNull(12))
                {
                    pp.PrecioCompra = Convert.ToDouble(dominio.Reader.GetDecimal(12));
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    pp.PrecioVenta = Convert.ToDouble(dominio.Reader.GetDecimal(13));
                }

                productosProveedores.Add(pp);
            }
            dominio.Close();
            return productosProveedores;
        }

        public static E_ProductoProveedor SelectProductoProveedor(int idProducto, int idProveedor)
        {
            D_ProductoProveedor dominio = new D_ProductoProveedor();
            dominio.Select("SELECT pp.id, pp.idProducto, pp.idProveedor, pp.precioCompra, pp.precioVenta " +
                           "FROM ProductosProveedores AS pp, Proveedores AS pres, Productos AS pros " +
                           "WHERE pros.id = " + idProducto + " AND pres.id = " + idProveedor);
            E_ProductoProveedor p = new E_ProductoProveedor();

            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    p.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    p.Producto.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    p.Proveedor.Id = dominio.Reader.GetInt32(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    p.PrecioCompra = Convert.ToDouble(dominio.Reader.GetDecimal(3));
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    p.PrecioVenta = Convert.ToDouble(dominio.Reader.GetDecimal(4));
                }
            }
            return p;
        }
        public static E_ProductoProveedor GetProductoProveedor(int idProducto, int idProveedor)
        {
            if (productosProveedores.Count <= 0)
                SelectProductosProveedores();

            E_ProductoProveedor pp = productosProveedores.Find(x => x.Producto.Id == idProducto && x.Proveedor.Id == idProveedor);
            return pp;
        }
        public static E_ProductoProveedor GetProductoProveedor(string codigo, string proveedor)
        {
            if (productosProveedores.Count <= 0)
                SelectProductosProveedores();

            E_ProductoProveedor pp = productosProveedores.Find(x => x.Producto.Codigo == codigo && x.Proveedor.Empresa == proveedor);
            return pp;
        }

        public static List<E_ProductoProveedor> GetProductosProveedores(string empresa)
        {
            List<E_ProductoProveedor> pp = new List<E_ProductoProveedor>();
            foreach (E_ProductoProveedor p in SelectProductosProveedores())
            {
                if (p.Proveedor.Empresa == empresa)
                    pp.Add(p);
            }
            return pp;
        }

        public static List<E_ProductoProveedor> GetProductosProveedores()
        {
            if (productosProveedores.Count <= 0)
                SelectProductosProveedores();
            return productosProveedores;
        }
        public static int GetIDProductoProveedor(string codigo, string proveedor)
        {
            if (productosProveedores.Count <= 0)
                SelectProductosProveedores();

            int idProducto = N_Producto.GetProducto(codigo);
            int idProveedor = N_Proveedor.GetProveedor(proveedor);

            int pp = GetProductoProveedor(idProducto, idProveedor).Id;
            return pp;
        }

        public static bool EliminarProductoProveedor(E_ProductoProveedor producto)
        {
            bool ok = false;
            if (producto != null)
            {
                D_ProductoProveedor dominio = new D_ProductoProveedor();
                ok = dominio.Delete("DELETE * FROM Productos WHERE id = " + producto.Producto.Id);
                dominio.Close();
            }
            return ok;
        }
        public static bool InsertarProductoProveedor(E_ProductoProveedor producto)
        {
            bool ok = false;
            if (producto != null)
            {
                D_ProductoProveedor dominio = new D_ProductoProveedor();
                ok = dominio.Delete("INSERT INTO Productos(codigo, producto, idSubCategoria, idTipoUnidadMedida) VALUES('" + 
                                    producto.Producto.Codigo + "', '" + producto.Producto.Producto + "', " + producto.Producto.SubCategoria.Id + ", " +
                                    producto.Producto.TipoUnidadMedida.Id + ")");
                dominio.Close();

                Thread.Sleep(100);

                if (ok)
                {
                    dominio = new D_ProductoProveedor();
                    int idProducto = dominio.Count("SELECT MAX(id) FROM Productos");
                    dominio.Close();

                    Thread.Sleep(100);
                    dominio = new D_ProductoProveedor();
                    ok = dominio.Delete("INSERT INTO ProductosProveedores(idProducto, idProveedor, stock, precioCompra, precioVenta) VALUES(" +
                                    idProducto + ", " + producto.Proveedor.Id + ", " + producto.Stock.ToString().Replace(',', '.') + ", " +
                                    producto.PrecioCompra.ToString().Replace(',','.') + ", " + producto.PrecioVenta.ToString().Replace(',', '.') + ")");
                }

                dominio.Close();
            }
            return ok;
        }

        public static bool ActualizarProductoProveedor(E_ProductoProveedor producto)
        {
            bool ok = false;
            if (producto != null)
            {
                D_ProductoProveedor dominio = new D_ProductoProveedor();
                ok = dominio.Delete("UPDATE Productos SET codigo = '" + producto.Producto.Codigo + "', producto = '" + producto.Producto.Producto +
                                    "', idSubCategoria = " + producto.Producto.SubCategoria.Id + ", idTipoUnidadMedida = " + producto.Producto.TipoUnidadMedida.Id +
                                    " WHERE id = " + producto.Producto.Id);
                dominio.Close();

                Thread.Sleep(200);

                if (ok)
                {
                    dominio = new D_ProductoProveedor();
                    ok = dominio.Delete("UPDATE ProductosProveedores SET idProducto = " + producto.Producto.Id + ", idProveedor = " + producto.Proveedor.Id +
                                        ", stock = " + producto.Stock.ToString().Replace(',', '.') + ", precioCompra = " + producto.PrecioCompra.ToString().Replace(',', '.') +
                                        ", precioVenta = " + producto.PrecioVenta.ToString().Replace(',', '.') + " WHERE id = " + producto.Id);
                }

                dominio.Close();
            }
            return ok;
        }
    }
}
