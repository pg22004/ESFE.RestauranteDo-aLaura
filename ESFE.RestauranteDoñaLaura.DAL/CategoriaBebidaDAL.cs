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
    public class CategoriaBebidaDAL
    {
        public static int GuardarCategoriaBebida(CategoriaBebidaEN pCategoriaBebidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_GuardarCategoriaBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pCategoriaBebidaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;

            }
        }
        public static int EliminarCategoriaBebida(CategoriaBebidaEN pCategoriaBebidaEN)
        {

            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_EliminarCategoriaBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCategoriaBebidaEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int ModificarCartegoriaBebida(CategoriaBebidaEN pCategoriaBebidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_ModificarCategoriaBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCategoriaBebidaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pCategoriaBebidaEN.Nombre));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static List<CategoriaBebidaEN> MostrarCategoriaBebida()
        {
            List<CategoriaBebidaEN> _Lista = new List<CategoriaBebidaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_MostrarCategoriaBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new CategoriaBebidaEN
                    {
                        Id = _reader.GetByte(0),
                        Nombre = _reader.GetString(1),


                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
    }
}
