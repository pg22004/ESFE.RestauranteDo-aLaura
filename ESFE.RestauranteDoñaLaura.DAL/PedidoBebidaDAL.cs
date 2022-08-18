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
    public class PedidoBebidaDAL
    {
        public static int GuardarPedidoBebida(PedidoBebidaEN pPedidoBebidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_GuardarPedidoBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@IdBebida", pPedidoBebidaEN.IdBebida));
                _comando.Parameters.Add(new SqlParameter("@IdPedido", pPedidoBebidaEN.IdPedido));
                _comando.Parameters.Add(new SqlParameter("@CantidadBebida", pPedidoBebidaEN.CantidadBebida));
                _comando.Parameters.Add(new SqlParameter("@TotalPagar", pPedidoBebidaEN.TotalPagar));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;

            }
        }
        public static int EliminarPedidoBebida(PedidoBebidaEN pPedidoBebidaEN)
        {

            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_EliminarPedidoBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pPedidoBebidaEN.Id));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static int ModificarPedidoBebida(PedidoBebidaEN pPedidoBebidaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando =
                new SqlCommand("SP_ModificarPedidoBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pPedidoBebidaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@IdBebida", pPedidoBebidaEN.IdBebida));
                _comando.Parameters.Add(new SqlParameter("@IdPedido", pPedidoBebidaEN.IdPedido));
                _comando.Parameters.Add(new SqlParameter("@CantidadBebida", pPedidoBebidaEN.CantidadBebida));
                _comando.Parameters.Add(new SqlParameter("@TotalPagar", pPedidoBebidaEN.TotalPagar));
                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }
        public static List<PedidoBebidaEN> MostrarPedidoBebida()
        {
            List<PedidoBebidaEN> _Lista = new List<PedidoBebidaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SQLServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("SP_MostrarPedidoBebida", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new PedidoBebidaEN
                    {
                        Id = _reader.GetByte(0),
                        IdBebida = _reader.GetByte(1),
                        IdPedido = _reader.GetByte(2),
                        CantidadBebida = _reader.GetByte(3),
                        TotalPagar = _reader.GetByte(4),


                    });
                }
                _conn.Close();
            }
            return _Lista;
        }


    }
}
