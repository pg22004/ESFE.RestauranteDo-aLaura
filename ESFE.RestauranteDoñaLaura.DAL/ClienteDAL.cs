using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
//Referencias
using ESFE.RestauranteDoñaLaura.EN;
using System.Data;
using System.Data.SqlClient;
//--------------------------------------------------

namespace ESFE.RestauranteDoñaLaura.DAL
{
    public class ClienteDAL
    {
        public static List<ClienteEN> MostrarCliente()
        {
            List<ClienteEN> _Lista = new List<ClienteEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_MostrarCliente", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new ClienteEN
                    {
                        Id = _reader.GetByte(0),
                        Nombre = _reader.GetString(1),
                        Apellido = _reader.GetString(2),
                        Dui = _reader.GetString(3),
                        Telefono = _reader.GetString(4),
                        Correo = _reader.GetString(5),

                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        public static int ModificarCliente(ClienteEN pClienteEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_ModificarCliente", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pClienteEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pClienteEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pClienteEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@Dui", pClienteEN.Dui));
                _comando.Parameters.Add(new SqlParameter("@Telefono", pClienteEN.Telefono));
                _comando.Parameters.Add(new SqlParameter("@Correo", pClienteEN.Correo));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int EliminarCliente(ClienteEN pClienteEN)
        {

            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_EliminarCliente", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pClienteEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int GuardarCliente(ClienteEN pClienteEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_GuardarCliente", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pClienteEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Apellido", pClienteEN.Apellido));
                _comando.Parameters.Add(new SqlParameter("@Dui", pClienteEN.Dui));
                _comando.Parameters.Add(new SqlParameter("@Telefono", pClienteEN.Telefono));
                _comando.Parameters.Add(new SqlParameter("@Correo", pClienteEN.Correo));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;

            }
        }
    }
}
