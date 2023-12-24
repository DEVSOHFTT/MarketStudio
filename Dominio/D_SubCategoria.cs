using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class D_SubCategoria : Conexion
    {
        public OleDbDataReader Reader { get => reader; }

        #region ABM
        public override void Select(string sql)
        {
            base.Select(sql);
        }

        public override bool Insert(string sql)
        {
            return base.Insert(sql);
        }

        public override bool Update(string sql)
        {
            return base.Update(sql);
        }

        public override bool Delete(string sql)
        {
            return base.Delete(sql);
        }
        #endregion

        #region Other Queries
        public override int Count(string sql)
        {
            return base.Count(sql);
        }
        public override void Close()
        {
            base.Close();
        }
        #endregion
    }
}
