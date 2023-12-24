using System;
using Client;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dominio
{
    public abstract class Conexion
    {
        #region Properties
        private OleDbConnection connection;
        protected OleDbDataReader reader;
        #endregion

        public Conexion()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\MarketStudio.mdb");
        }

        #region Select Insert Update Delete
        /// <summary>
        /// Ej: SELECT * FROM Products;
        /// </summary>
        public virtual void Select(string sql)
        {
            Open();
            OleDbCommand c = new OleDbCommand(sql, connection);
            c.CommandType = CommandType.Text;
            try
            {
                reader = c.ExecuteReader();
            }
            catch (Exception e)
            {
                Info.Log("Error en comando[ " + sql + " ]: " + e.Message);
            }
        }

        /// <summary>
        /// Ej: INSERT INTO table1 (column1, column2, column3) VALUES (value1, value2, value3);
        /// Ej: INSERT INTO table2 (column1, column2, column3) SELECT column1, column2, column3 FROM table1
        /// </summary>
        public virtual bool Insert(string sql)
        {
            bool ok = false;

            Open();
            OleDbCommand c = new OleDbCommand(sql, connection);
            c.CommandText = sql;

            try
            {
                c.ExecuteNonQuery();
                ok = true;
            }
            catch (Exception e)
            {
                ok = false;
                Info.Log("Error en comando[ " + sql + " ]: " + e.Message);
            }

            Close();

            return ok;
        }

        /// <summary>
        /// Ej: UPDATE table_name SET column1 = value1, column2 = value2 WHERE condition;
        /// </summary>
        public virtual bool Update(string sql)
        {
            bool ok = false;

            Open();
            OleDbCommand c = new OleDbCommand(sql, connection);
            c.CommandText = sql;

            try
            {
                c.ExecuteNonQuery();
                ok = true;
            }
            catch (Exception e)
            {
                ok = false;
                Info.Log("Error en comando[ " + sql + " ]: " + e.Message);
            }
            finally
            {
                Close();
            }

            return ok;
        }

        /// <summary>
        /// Ej: DELETE FROM table_name WHERE condition;
        /// </summary>
        public virtual bool Delete(string sql)
        {
            bool ok = false;

            Open();
            OleDbCommand c = new OleDbCommand(sql, connection);
            c.CommandText = sql;

            try
            {
                c.ExecuteNonQuery();
                ok = true;
            }
            catch (Exception e)
            {
                ok = false;
                Info.Log("Error en comando[ " + sql + " ]: " + e.Message);
            }
            finally
            {
                Close();
            }

            return ok;
        }
        #endregion

        #region Count
        /// <summary>
        /// Ej: SELECT Count(ProductID) AS NumberOfProducts FROM Products;
        /// Ej: SELECT Max(Price) AS LargestPrice FROM Products;
        /// </summary>
        public virtual int Count(string sql)
        {
            int count = 0;

            Open();
            OleDbCommand c = new OleDbCommand(sql, connection);
            c.CommandType = CommandType.Text;
            try
            {
                reader = c.ExecuteReader();
            }
            catch (Exception e)
            {
                Info.Log("Error en comando[ " + sql + " ]: " + e.Message);
            }

            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    count = reader.GetInt32(0);
                }
            }

            Close();
            return count;
        }
        #endregion

        #region Conexion
        protected void Open()
        {
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Info.Log("Error al abrir la conexión: " + e.Message);
                Close();
            }
        }

        public virtual void Close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Info.Log("Error al cerrar la conexión: " + e.Message);
            }
        }
        #endregion
    }
}
