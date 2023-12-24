using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Producto
{
    public class E_Categoria
    {
        int id;
        string categoria;

        public E_Categoria(int id, string categoria)
        {
            this.id = id;
            this.categoria = categoria;
        }

        public E_Categoria()
        {
            this.id = 0;
            this.categoria = "";
        }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
