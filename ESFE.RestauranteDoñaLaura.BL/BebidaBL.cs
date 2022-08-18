using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------
using ESFE.RestauranteDoñaLaura.EN;
using ESFE.RestauranteDoñaLaura.DAL;

namespace ESFE.RestauranteDoñaLaura.BL
{
    public class BebidaBL
    {
        public List<BebidaEN> MostrarBebida()
        {
            return BebidaDAL.MostrarBebida();
        }
        public static int ModificarBebida(BebidaEN pBebidaEN)
        {
            return BebidaDAL.ModificarBebida(pBebidaEN);
        }
        public static int EliminarBebida(BebidaEN pBebidaEN)
        {
            return BebidaDAL.EliminarBebida(pBebidaEN);
        }
        public int GuardarBebida(BebidaEN pBebidaEN)
        {
            return BebidaDAL.GuardarBebida(pBebidaEN);
        }
    }
}
