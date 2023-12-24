using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Producto
{
    public class E_Producto
    {
        int id;
        string codigo;
        string producto;
        E_SubCategoria subCategoria;
        E_TipoUnidadMedia tipoUnidadMedida;

        public E_Producto(int id, string codigo, string producto, E_SubCategoria subCategoria, E_TipoUnidadMedia tipoUnidadMedida)
        {
            this.id = id;
            this.codigo = codigo;
            this.producto = producto;
            this.subCategoria = subCategoria;
            this.tipoUnidadMedida = tipoUnidadMedida;
        }

        public E_Producto()
        {
            this.id = 0;
            this.codigo = "";
            this.producto = "";
            this.subCategoria = new E_SubCategoria();
            this.tipoUnidadMedida = new E_TipoUnidadMedia();
        }

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public E_SubCategoria SubCategoria { get => subCategoria; set => subCategoria = value; }
        public E_TipoUnidadMedia TipoUnidadMedida { get => tipoUnidadMedida; set => tipoUnidadMedida = value; }
    }
}
