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
    public class TipoCargoBL
    {
        public int GuardarTipoCargo(TipoCargoEN pTipoCargoEN)
        {
            return TipoCargoDAL.GuardarTipoCargo(pTipoCargoEN);
        }
        public static int EliminarTipoCargo(TipoCargoEN pTipoCargoEN)
        {
            return TipoCargoDAL.EliminarTipoCargo(pTipoCargoEN);
        }
        public static int ModificarTipoCargo(TipoCargoEN pTipoCargoEN)
        {
            return TipoCargoDAL.ModificarTipoCargo(pTipoCargoEN);
        }
        public List<TipoCargoEN> MostrarTipoCargo()
        {
            return TipoCargoDAL.MostrarTipoCargo();
        }
    }
}
