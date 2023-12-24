using Dominio;
using Entidades.Producto;
using Entidades.Venta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_TipoUnidadMedida
    {
       public static List<E_TipoUnidadMedia> tiposUnidadesMedia = new List<E_TipoUnidadMedia>();

        public static List<E_TipoUnidadMedia> SelectTiposUnidadesMedida(string sql)
        {
            D_TipoUnidadMedida dominio = new D_TipoUnidadMedida();
            tiposUnidadesMedia.Clear();
            dominio.Select(sql != "" ? sql : "SELECT * FROM TiposUnidadesMedida");
            while (dominio.Reader.Read())
            {
                E_TipoUnidadMedia t = new E_TipoUnidadMedia();

                if (!dominio.Reader.IsDBNull(0))
                {
                    t.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                   t.UnidadMedida = dominio.Reader.GetString(1);
                }

                tiposUnidadesMedia.Add(t);
            }
            dominio.Close();
            return tiposUnidadesMedia;
        }
        public static List<E_TipoUnidadMedia> SelectTiposUnidadesMedida()
        {
            D_TipoUnidadMedida dominio = new D_TipoUnidadMedida();
            tiposUnidadesMedia.Clear();
            dominio.Select("SELECT * FROM TiposUnidadesMedida");
            while (dominio.Reader.Read())
            {
                E_TipoUnidadMedia t = new E_TipoUnidadMedia();

                if (!dominio.Reader.IsDBNull(0))
                {
                    t.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    t.UnidadMedida = dominio.Reader.GetString(1);
                }

                tiposUnidadesMedia.Add(t);
            }
            dominio.Close();
            return tiposUnidadesMedia;
        }

        public static E_TipoUnidadMedia GetTipoPago(int idTipoUnidadMedida)
        {
            if (tiposUnidadesMedia.Count <= 0)
                SelectTiposUnidadesMedida();

            E_TipoUnidadMedia tipoUnidadMedia = tiposUnidadesMedia.Find(x => x.Id == idTipoUnidadMedida);
            return tipoUnidadMedia;
        }

        public static List<E_TipoUnidadMedia> GetTiposUnidadesMedida()
        {
            if (tiposUnidadesMedia.Count <= 0)
                SelectTiposUnidadesMedida();
            return tiposUnidadesMedia;
        }
    }
}
