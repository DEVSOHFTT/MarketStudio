using Entidades.Venta;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Entidades.Producto;

namespace Negocios
{
    public static class N_Venta
    {
        internal static List<E_Venta> ventas = new List<E_Venta>();

        public static List<E_Venta> SelectVentas(string sql)
        {
            D_Venta dominio = new D_Venta();
            ventas.Clear();
            dominio.Select(sql != "" ? sql : "SELECT v.id, fecha, v.idEmpleado FROM Ventas AS v, Empleados AS e WHERE v.idEmpleado = e.id");
            while (dominio.Reader.Read())
            {
                E_Venta v = new E_Venta();

                if (!dominio.Reader.IsDBNull(0))
                {
                   v.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                   v.Fecha = dominio.Reader.GetDateTime(1);
                }

                ventas.Add(v);
            }
            dominio.Close();
            return ventas;
        }
        public static List<E_Venta> SelectVentas()
        {
            D_Venta dominio = new D_Venta();
            ventas.Clear();
            dominio.Select("SELECT v.id, fecha, v.idEmpleado FROM Ventas AS v, Empleados AS e WHERE v.idEmpleado = e.id");
            while (dominio.Reader.Read())
            {
                E_Venta v = new E_Venta();

                if (!dominio.Reader.IsDBNull(0))
                {
                    v.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    v.Fecha = dominio.Reader.GetDateTime(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    v.Empleado.Id = dominio.Reader.GetInt32(2);
                }

                ventas.Add(v);
            }
            dominio.Close();
            return ventas;
        }

        public static E_Venta GetVenta(int idVenta)
        {
            if (ventas.Count <= 0)
                SelectVentas();

            E_Venta venta = ventas.Find(x => x.Id == idVenta);
            return venta;
        }

        public static bool InsertVenta(E_Venta venta)
        {
            D_Venta dominio = new D_Venta();
            bool ok = false;

            if (dominio.Insert("INSERT INTO Ventas(fecha, idEmpleado) VALUES('" + venta.Fecha.ToShortDateString() + "'," + venta.Empleado.Id + ")"))
            {
                ok = true;
            }

            return ok;
        }
        
        public static int CountVentas(string sql)
        {
            return new D_Venta().Count(sql);
        }

        public static int UltimaVenta()
        {
            D_Venta dominio = new D_Venta();
            int id = 0;
            id = dominio.Count("SELECT MAX(id) FROM Ventas");
            dominio.Close();
            return id;
        }
    }
}
