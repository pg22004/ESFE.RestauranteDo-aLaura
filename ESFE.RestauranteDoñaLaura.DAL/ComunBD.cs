using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------
using System.Data;
using System.Data.SqlClient;
//-----------------------------

namespace ESFE.RestauranteDoñaLaura.DAL
{
    public class ComunBD
    {
        public enum TipoBD
        {
            SQLServer, Oracle, BD2
        }
        public const string sqlconn = @"Data Source=DESKTOP-SIJQEDF\SERVIDORSQL;Initial Catalog=RestauranteBD;Integrated Security=True";

        public static IDbConnection ObtenerConexion(TipoBD pTipoBD)
        {
            IDbConnection _conn;
            if (pTipoBD == TipoBD.SQLServer)
            {
                _conn = new SqlConnection(sqlconn);
                return _conn;
            }
            return null;
        }
    }
}
