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
    public class ComidaBL
    {
        public List<ComidaEN> MostrarComida()
        {
            return ComidaDAL.MostrarComida();
        }
        public static int ModificarComida(ComidaEN pComidaEN)
        {
            return ComidaDAL.ModificarComida(pComidaEN);
        }
        public static int EliminarComida(ComidaEN pComidaEN)
        {
            return ComidaDAL.EliminarComida(pComidaEN);
        }
        public int GuardarComida(ComidaEN pComidaEN)
        {
            return ComidaDAL.GuardarComida(pComidaEN);
        }
    }
}
