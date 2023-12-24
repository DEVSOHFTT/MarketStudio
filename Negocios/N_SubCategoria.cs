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
    public static class N_SubCategoria
    {
        static List<E_SubCategoria> subCategorias = new List<E_SubCategoria>();
        public static List<E_SubCategoria> SelectSubCategorias(string sql)
        {
            D_SubCategoria dominio = new D_SubCategoria();
            subCategorias.Clear();
            dominio.Select(sql != "" ? sql : "SELECT * FROM SelectAllCategorias");
            while (dominio.Reader.Read())
            {
                E_SubCategoria c = new E_SubCategoria();

                if (!dominio.Reader.IsDBNull(0))
                {
                    c.Categoria.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    c.Categoria.Categoria = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    c.Id = dominio.Reader.GetInt32(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    c.SubCategoria = dominio.Reader.GetString(3);
                }

                subCategorias.Add(c);
            }
            dominio.Close();
            return subCategorias;
        }
        public static List<E_SubCategoria> SelectSubCategorias()
        {
            D_SubCategoria dominio = new D_SubCategoria();
            subCategorias.Clear();
            dominio.Select("SELECT * FROM SelectAllCategorias");
            while (dominio.Reader.Read())
            {
                E_SubCategoria c = new E_SubCategoria();

                if (!dominio.Reader.IsDBNull(0))
                {
                    c.Categoria.Id = dominio.Reader.GetInt32(0);
                }
                if (!dominio.Reader.IsDBNull(1))
                {
                    c.Categoria.Categoria = dominio.Reader.GetString(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    c.Id = dominio.Reader.GetInt32(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    c.SubCategoria = dominio.Reader.GetString(3);
                }

                subCategorias.Add(c);
            }
            dominio.Close();
            return subCategorias;
        }

        public static E_SubCategoria GetSubCategoria(int idSubCategoria)
        {
            if (subCategorias.Count <= 0)
                SelectSubCategorias();

            E_SubCategoria subCategoria = subCategorias.Find(x => x.Id == idSubCategoria);
            return subCategoria;
        }
        public static List<E_SubCategoria> GetSubCategorias()
        {
            if (subCategorias.Count <= 0)
                SelectSubCategorias();
            return subCategorias;
        }
    }
}
