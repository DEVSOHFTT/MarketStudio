using Dominio;
using Entidades.Persona;
using Entidades.Producto;
using Entidades.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_TipoPago
    {
        internal static List<E_TipoPago> tiposPago = new List<E_TipoPago>();

        public static List<E_TipoPago> SelectTiposPago(string sql)
        {
            D_TipoPago dominio = new D_TipoPago();
            tiposPago.Clear();
            dominio.Select(sql != "" ? sql : "SELECT * FROM TiposPago");
            while (dominio.Reader.Read())
            {
                E_TipoPago t = new E_TipoPago();

                if (!dominio.Reader.IsDBNull(0))
                {
                    t.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    t.TipoPago = dominio.Reader.GetString(1);
                }

                tiposPago.Add(t);
            }
            dominio.Close();
            return tiposPago;
        }
        public static List<E_TipoPago> SelectTiposPago()
        {
            D_TipoPago dominio = new D_TipoPago();
            tiposPago.Clear();
            dominio.Select("SELECT * FROM TiposPago");
            while (dominio.Reader.Read())
            {
                E_TipoPago t = new E_TipoPago();

                if (!dominio.Reader.IsDBNull(0))
                {
                    t.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    t.TipoPago = dominio.Reader.GetString(1);
                }

                tiposPago.Add(t);
            }
            dominio.Close();
            return tiposPago;
        }

        public static E_TipoPago GetTipoPago(int idTipoPago)
        {
            if (tiposPago.Count <= 0)
                SelectTiposPago();

            E_TipoPago tipoPago = tiposPago.Find(x => x.Id == idTipoPago);
            return tipoPago;
        }
    }
}
