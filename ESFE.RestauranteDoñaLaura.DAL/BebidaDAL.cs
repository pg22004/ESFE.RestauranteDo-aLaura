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
    public class BebidaDAL
    {
        public static List<BebidaEN> MostrarBebida()
        {
            List<BebidaEN> _Lista = new List<BebidaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_MostrarBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new BebidaEN
                    {
                        Id = _reader.GetByte(0),
                        Nombre = _reader.GetString(1),


                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        public static int ModificarBebida(BebidaEN pBebidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_ModificarBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pBebidaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pBebidaEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Descripcion", pBebidaEN.Descripcion));
                _comando.Parameters.Add(new SqlParameter("@Precio", pBebidaEN.Precio));
                _comando.Parameters.Add(new SqlParameter("@IdCategoriaBebida", pBebidaEN.IdCategoriaBebida));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int EliminarBebida(BebidaEN pBebidaEN)
        {

            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_EliminarBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pBebidaEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int GuardarBebida(BebidaEN pBebidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_GuardarBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pBebidaEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Descripcion", pBebidaEN.Descripcion));
                _comando.Parameters.Add(new SqlParameter("@Precio", pBebidaEN.Precio));
                _comando.Parameters.Add(new SqlParameter("@IdCategoriaBebida", pBebidaEN.IdCategoriaBebida));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;

            }
        }
    }
}
