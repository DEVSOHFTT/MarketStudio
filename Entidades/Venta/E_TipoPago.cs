using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Venta
{
    public class E_TipoPago
    {
        int id;
        string tipoPago;

        public E_TipoPago(int id, string tipoPago)
        {
            this.id = id;
            this.tipoPago = tipoPago;
        }

        public E_TipoPago()
        {
            this.id = 0;
            this.tipoPago = "";
        }

        public int Id { get => id; set => id = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
    }
}
