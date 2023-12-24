using Dominio;
using Entidades.Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public static class N_Empleado
    {
        /*
         "SELECT e.id, idUsuario, usuario, contraseña, habilitado, 
          idTipoCargo, tipoCargo, 
          horasAsignadas, sueldo, incentivo, 
          idTipoPuesto, puesto, 
          dni, nombre, apellido, telefono, telefonoAlternativo, email, domicilio 
          FROM Empleados AS e, Personas AS p, TiposCargo AS tc, TiposPuesto AS tp, Usuarios AS u 
          WHERE e.idUsuario = u.id AND e.idPersona = p.id AND e.idTipoCargo = tc.id AND e.idTipoPuesto = tp.id"
        */

        internal static List<E_Empleado> empleados = new List<E_Empleado>();
        public static List<E_Empleado> SelectEmpleados(string sql)
        {
            D_Empleado dominio = new D_Empleado();
            empleados.Clear();
            dominio.Select(sql != "" ? sql : "SELECT * FROM SelectAllEmpleados");
            while (dominio.Reader.Read())
            {
                E_Empleado empleado = new E_Empleado();

                if (!dominio.Reader.IsDBNull(0))
                {
                    empleado.Id = dominio.Reader.GetInt32(0);
                }
                //Usuario
                if (!dominio.Reader.IsDBNull(1))
                {
                    empleado.Usuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    empleado.Usuario.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    empleado.Usuario.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    empleado.Usuario.Habilitado = dominio.Reader.GetBoolean(4);
                }
                //TipoCargo
                if (!dominio.Reader.IsDBNull(5))
                {
                    empleado.TipoCargo.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    empleado.TipoCargo.Tipo = dominio.Reader.GetString(6);
                }
                //Empleado
                if (!dominio.Reader.IsDBNull(7))
                {
                    empleado.HorasAsignadas = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    empleado.Sueldo = Convert.ToDouble(dominio.Reader.GetDecimal(8));
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    empleado.Incentivo = Convert.ToDouble(dominio.Reader.GetDecimal(9));
                }
                //TipoPuesto
                if (!dominio.Reader.IsDBNull(10))
                {
                    empleado.TipoPuesto.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    empleado.TipoPuesto.Tipo = dominio.Reader.GetString(11);
                }
                //Persona
                if (!dominio.Reader.IsDBNull(12))
                {
                    empleado.Dni = dominio.Reader.GetString(12);
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    empleado.Nombre = dominio.Reader.GetString(13);
                }
                if (!dominio.Reader.IsDBNull(14))
                {
                    empleado.Apellido = dominio.Reader.GetString(14);
                }
                if (!dominio.Reader.IsDBNull(15))
                {
                    empleado.Telefono = dominio.Reader.GetString(15);
                }
                if (!dominio.Reader.IsDBNull(16))
                {
                    empleado.TelefonoAlternativo = dominio.Reader.GetString(16);
                }
                if (!dominio.Reader.IsDBNull(17))
                {
                    empleado.Email = dominio.Reader.GetString(17);
                }
                if (!dominio.Reader.IsDBNull(18))
                {
                    empleado.Domicilio = dominio.Reader.GetString(18);
                }

                empleados.Add(empleado);
            }
            dominio.Close();
            return empleados;
        }
        public static List<E_Empleado> SelectEmpleados()
        {
            D_Empleado dominio = new D_Empleado();
            empleados.Clear();
            dominio.Select("SELECT * FROM SelectAllEmpleados");

            while (dominio.Reader.Read())
            {
                E_Empleado empleado = new E_Empleado();

                if (!dominio.Reader.IsDBNull(0))
                {
                    empleado.Id = dominio.Reader.GetInt32(0);
                }
                //Usuario
                if (!dominio.Reader.IsDBNull(1))
                {
                    empleado.Usuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    empleado.Usuario.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    empleado.Usuario.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    empleado.Usuario.Habilitado = dominio.Reader.GetBoolean(4);
                }
                //TipoCargo
                if (!dominio.Reader.IsDBNull(5))
                {
                    empleado.TipoCargo.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    empleado.TipoCargo.Tipo = dominio.Reader.GetString(6);
                }
                //Empleado
                if (!dominio.Reader.IsDBNull(7))
                {
                    empleado.HorasAsignadas = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    empleado.Sueldo = Convert.ToDouble(dominio.Reader.GetDecimal(8));
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    empleado.Incentivo = Convert.ToDouble(dominio.Reader.GetDecimal(9));
                }
                //TipoPuesto
                if (!dominio.Reader.IsDBNull(10))
                {
                    empleado.TipoPuesto.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    empleado.TipoPuesto.Tipo = dominio.Reader.GetString(11);
                }
                //Persona
                if (!dominio.Reader.IsDBNull(12))
                {
                    empleado.Dni = dominio.Reader.GetString(12);
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    empleado.Nombre = dominio.Reader.GetString(13);
                }
                if (!dominio.Reader.IsDBNull(14))
                {
                    empleado.Apellido = dominio.Reader.GetString(14);
                }
                if (!dominio.Reader.IsDBNull(15))
                {
                    empleado.Telefono = dominio.Reader.GetString(15);
                }
                if (!dominio.Reader.IsDBNull(16))
                {
                    empleado.TelefonoAlternativo = dominio.Reader.GetString(16);
                }
                if (!dominio.Reader.IsDBNull(17))
                {
                    empleado.Email = dominio.Reader.GetString(17);
                }
                if (!dominio.Reader.IsDBNull(18))
                {
                    empleado.Domicilio = dominio.Reader.GetString(18);
                }

                empleados.Add(empleado);
            }
            dominio.Close();
            return empleados;
        }

        public static E_Empleado SelectEmpleado(string usuario)
        {
            D_Empleado dominio = new D_Empleado();
            E_Empleado empleado = new E_Empleado();

            dominio.Select("SELECT * FROM SelectAllEmpleados WHERE u.usuario = '" + usuario + "'");

            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    empleado.Id = dominio.Reader.GetInt32(0);
                }
                //Usuario
                if (!dominio.Reader.IsDBNull(1))
                {
                    empleado.Usuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    empleado.Usuario.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    empleado.Usuario.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    empleado.Usuario.Habilitado = dominio.Reader.GetBoolean(4);
                }
                //TipoCargo
                if (!dominio.Reader.IsDBNull(5))
                {
                    empleado.TipoCargo.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    empleado.TipoCargo.Tipo = dominio.Reader.GetString(6);
                }
                //Empleado
                if (!dominio.Reader.IsDBNull(7))
                {
                    empleado.HorasAsignadas = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    empleado.Sueldo = Convert.ToDouble(dominio.Reader.GetDecimal(8));
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    empleado.Incentivo = Convert.ToDouble(dominio.Reader.GetDecimal(9));
                }
                //TipoPuesto
                if (!dominio.Reader.IsDBNull(10))
                {
                    empleado.TipoPuesto.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    empleado.TipoPuesto.Tipo = dominio.Reader.GetString(11);
                }
                //Persona
                if (!dominio.Reader.IsDBNull(12))
                {
                    empleado.Dni = dominio.Reader.GetString(12);
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    empleado.Nombre = dominio.Reader.GetString(13);
                }
                if (!dominio.Reader.IsDBNull(14))
                {
                    empleado.Apellido = dominio.Reader.GetString(14);
                }
                if (!dominio.Reader.IsDBNull(15))
                {
                    empleado.Telefono = dominio.Reader.GetString(15);
                }
                if (!dominio.Reader.IsDBNull(16))
                {
                    empleado.TelefonoAlternativo = dominio.Reader.GetString(16);
                }
                if (!dominio.Reader.IsDBNull(17))
                {
                    empleado.Email = dominio.Reader.GetString(17);
                }
                if (!dominio.Reader.IsDBNull(18))
                {
                    empleado.Domicilio = dominio.Reader.GetString(18);
                }

                empleados.Add(empleado);
            }

            return empleado;
        }
        public static E_Empleado SelectEmpleado(int idEmpleado)
        {
            D_Empleado dominio = new D_Empleado();
            E_Empleado empleado = new E_Empleado();

            dominio.Select("SELECT * FROM SelectAllEmpleados WHERE e.id = " + idEmpleado);

            if (dominio.Reader.Read())
            {
                if (!dominio.Reader.IsDBNull(0))
                {
                    empleado.Id = dominio.Reader.GetInt32(0);
                }
                //Usuario
                if (!dominio.Reader.IsDBNull(1))
                {
                    empleado.Usuario.Id = dominio.Reader.GetInt32(1);
                }
                if (!dominio.Reader.IsDBNull(2))
                {
                    empleado.Usuario.Usuario = dominio.Reader.GetString(2);
                }
                if (!dominio.Reader.IsDBNull(3))
                {
                    empleado.Usuario.Contraseña = dominio.Reader.GetString(3);
                }
                if (!dominio.Reader.IsDBNull(4))
                {
                    empleado.Usuario.Habilitado = dominio.Reader.GetBoolean(4);
                }
                //TipoCargo
                if (!dominio.Reader.IsDBNull(5))
                {
                    empleado.TipoCargo.Id = dominio.Reader.GetInt32(5);
                }
                if (!dominio.Reader.IsDBNull(6))
                {
                    empleado.TipoCargo.Tipo = dominio.Reader.GetString(6);
                }
                //Empleado
                if (!dominio.Reader.IsDBNull(7))
                {
                    empleado.HorasAsignadas = dominio.Reader.GetInt32(7);
                }
                if (!dominio.Reader.IsDBNull(8))
                {
                    empleado.Sueldo = Convert.ToDouble(dominio.Reader.GetDecimal(8));
                }
                if (!dominio.Reader.IsDBNull(9))
                {
                    empleado.Incentivo = Convert.ToDouble(dominio.Reader.GetDecimal(9));
                }
                //TipoPuesto
                if (!dominio.Reader.IsDBNull(10))
                {
                    empleado.TipoPuesto.Id = dominio.Reader.GetInt32(10);
                }
                if (!dominio.Reader.IsDBNull(11))
                {
                    empleado.TipoPuesto.Tipo = dominio.Reader.GetString(11);
                }
                //Persona
                if (!dominio.Reader.IsDBNull(12))
                {
                    empleado.Dni = dominio.Reader.GetString(12);
                }
                if (!dominio.Reader.IsDBNull(13))
                {
                    empleado.Nombre = dominio.Reader.GetString(13);
                }
                if (!dominio.Reader.IsDBNull(14))
                {
                    empleado.Apellido = dominio.Reader.GetString(14);
                }
                if (!dominio.Reader.IsDBNull(15))
                {
                    empleado.Telefono = dominio.Reader.GetString(15);
                }
                if (!dominio.Reader.IsDBNull(16))
                {
                    empleado.TelefonoAlternativo = dominio.Reader.GetString(16);
                }
                if (!dominio.Reader.IsDBNull(17))
                {
                    empleado.Email = dominio.Reader.GetString(17);
                }
                if (!dominio.Reader.IsDBNull(18))
                {
                    empleado.Domicilio = dominio.Reader.GetString(18);
                }

                empleados.Add(empleado);
            }

            return empleado;
        }

        public static E_Empleado GetEmpleado(int idEmpleado)
        {
            if (empleados.Count <= 0)
                SelectEmpleados();

            E_Empleado empleado = empleados.Find(x => x.Id == idEmpleado);
            return empleado;
        }
        public static E_Empleado GetEmpleado(string usuario)
        {
            if (empleados.Count <= 0)
                SelectEmpleados();

            E_Empleado empleado = empleados.Find(x => x.Usuario.Usuario == usuario);
            return empleado;
        }
        public static int GetIDEmpleado(string usuario)
        {
            if (empleados.Count <= 0)
                SelectEmpleados();

            int idUsuario = N_Usuario.GetUsuario(usuario);

            int idEmpleado = empleados.Find(x => x.Usuario.Id == idUsuario).Id;
            return idEmpleado;
        }
    }
}
