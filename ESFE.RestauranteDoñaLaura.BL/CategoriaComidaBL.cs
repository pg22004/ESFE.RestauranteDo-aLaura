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
   public class CategoriaComidaBL
    {
        public int GuardarCategoriaComida(CategoriaComidaEN pCategoriaComidaEN)
        {
            return CategoriaComidaDAL.GuardarCategoriaComida(pCategoriaComidaEN);
        }
        public static int EliminarCategoriaComida(CategoriaComidaEN pCategoriaComidaEN)
        {
            return CategoriaComidaDAL.EliminarCategoriaComida(pCategoriaComidaEN);
        }
        public static int ModificarCategoriaComida(CategoriaComidaEN pCategoriaComidaEN)
        {
            return CategoriaComidaDAL.ModificarCategoriaComida(pCategoriaComidaEN);
        }
        public List<CategoriaComidaEN> MostrarCategoriaComida()
        {
            return CategoriaComidaDAL.MostrarCategoriaComida();
        }
    }
}
