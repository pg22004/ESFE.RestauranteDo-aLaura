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
    public class CategoriaBebidaBL
    {
        public int GuardarCategoriaBebida(CategoriaBebidaEN pCategoriaBebidaEN)
        {
            return CategoriaBebidaDAL.GuardarCategoriaBebida(pCategoriaBebidaEN);
        }
        public static int EliminarCategoriaBebida(CategoriaBebidaEN pCategoriaBebidaEN)
        {
            return CategoriaBebidaDAL.EliminarCategoriaBebida(pCategoriaBebidaEN);
        }
        public static int ModificarCartegoriaBebida(CategoriaBebidaEN pCategoriaBebidaEN)
        {
            return CategoriaBebidaDAL.ModificarCartegoriaBebida(pCategoriaBebidaEN);
        }
        public List<CategoriaBebidaEN> MostrarCategoriaBebida()
        {
            return CategoriaBebidaDAL.MostrarCategoriaBebida();
        }
    }
}
