using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Producto
{
    public class E_TipoUnidadMedia
    {
        int id;
        string unidadMedida;

        public E_TipoUnidadMedia(int id, string unidadMedida)
        {
            this.id = id;
            this.unidadMedida = unidadMedida;
        }

        public E_TipoUnidadMedia()
        {
            this.id = 0;
            this.unidadMedida = "";
        }

        public int Id { get => id; set => id = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }
    }
}
