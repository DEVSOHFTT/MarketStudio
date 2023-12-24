using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Producto
{
    public class E_SubCategoria
    {
        int id;
        string subCategoria;
        E_Categoria categoria;
        public E_SubCategoria(int id, string subCategoria, E_Categoria categoria)
        {
            this.id = id;
            this.subCategoria = subCategoria;
            this.categoria = categoria;
        }

        public E_SubCategoria()
        {
            this.id = 0;
            this.subCategoria = "";
            this.categoria = new E_Categoria();
        }

        public int Id { get => id; set => id = value; }
        public string SubCategoria { get => subCategoria; set => subCategoria = value; }
        public E_Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
