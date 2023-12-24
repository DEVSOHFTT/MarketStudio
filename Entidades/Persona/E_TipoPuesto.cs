using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Persona
{
    public class E_TipoPuesto
    {
        int id;
        string tipo;

        public E_TipoPuesto(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }

        public E_TipoPuesto()
        {
            this.id = 0;
            this.tipo = "";
        }

        public int Id { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
