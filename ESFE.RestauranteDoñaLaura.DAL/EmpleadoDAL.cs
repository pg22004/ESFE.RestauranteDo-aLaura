using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
using ESFE.RestauranteDoñaLaura.EN;
using System.Data;
using System.Data.SqlClient;
//--------------------------------------------------

namespace ESFE.RestauranteDoñaLaura.DAL
{
    public class EmpleadoDAL
    {
        public static List<EmpleadoEN> MostrarEmpleado()
        {
            List<EmpleadoEN> _Lista = new List<EmpleadoEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_MostrarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new EmpleadoEN
                    {
                        Id = _reader.GetByte(0),
                        Nombre = _reader.GetString(1),
                        Apellido = _reader.GetString(2),
                        Correo = _reader.GetString(3),
                        Contraseña = _reader.GetString(4),
                        Telefono = _reader.GetByte(5),
                        IdTipoCargo = _reader.GetByte(6),

                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        public static int ModificarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_ModificarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pEmpleadoEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pEmpleadoEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pEmpleadoEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@Correo", pEmpleadoEN.Correo));
                _comando.Parameters.Add(new SqlParameter("@Contraseña", pEmpleadoEN.Contraseña));
                _comando.Parameters.Add(new SqlParameter("@Telefono", pEmpleadoEN.Telefono));
                _comando.Parameters.Add(new SqlParameter("@IdTipoCargo", pEmpleadoEN.IdTipoCargo));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int EliminarEmpleado(EmpleadoEN pEmpleadoEN)
        {

            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_EliminarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pEmpleadoEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int GuardarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_GuardarEmpleado", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pEmpleadoEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pEmpleadoEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@Correo", pEmpleadoEN.Correo));
                _comando.Parameters.Add(new SqlParameter("@Contraseña", pEmpleadoEN.Contraseña));
                _comando.Parameters.Add(new SqlParameter("@Telefono", pEmpleadoEN.Telefono));
                _comando.Parameters.Add(new SqlParameter("@IdTipoCargo", pEmpleadoEN.IdTipoCargo));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;

            }
        }
    }
}
