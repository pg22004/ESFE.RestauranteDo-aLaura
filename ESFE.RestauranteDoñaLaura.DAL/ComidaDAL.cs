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
    public class ComidaDAL
    {
        public static List<ComidaEN> MostrarComida()
        {
            List<ComidaEN> _Lista = new List<ComidaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_MostrarComida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new ComidaEN
                    {
                        Id = _reader.GetByte(0),
                        Nombre = _reader.GetString(1),

                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        public static int ModificarComida(ComidaEN pComidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_ModificarComida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pComidaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@Nombre", pComidaEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Descripcion", pComidaEN.Descripcion));
                _comando.Parameters.Add(new SqlParameter("@Precio", pComidaEN.Precio));
                _comando.Parameters.Add(new SqlParameter("@IdCategoriaBebida", pComidaEN.IdCategoriaComida));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int EliminarComida(ComidaEN pComidaEN)
        {

            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_EliminarComida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pComidaEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int GuardarComida(ComidaEN pComidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_GuardarComida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Nombre", pComidaEN.Nombre));
                _comando.Parameters.Add(new SqlParameter("@Descripcion", pComidaEN.Descripcion));
                _comando.Parameters.Add(new SqlParameter("@Precio", pComidaEN.Precio));
                _comando.Parameters.Add(new SqlParameter("@IdCategoriaComida", pComidaEN.IdCategoriaComida));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;

            }
        }
    }
}
