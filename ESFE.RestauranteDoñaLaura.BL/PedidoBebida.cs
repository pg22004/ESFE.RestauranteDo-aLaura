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
    public class PedidoBebida
    {
        public int GuardarPedidoBebida(PedidoBebidaEN pPedidoBebidaEN)
        {
            return PedidoBebidaDAL.GuardarPedidoBebida(pPedidoBebidaEN);
        }
        public static int EliminarPedidoBebida(PedidoBebidaEN pPedidoBebidaEN)
        {
            return PedidoBebidaDAL.EliminarPedidoBebida(pPedidoBebidaEN);
        }
        public static int ModificarPedidoBebida(PedidoBebidaEN pPedidoBebidaEN)
        {
            return PedidoBebidaDAL.ModificarPedidoBebida(pPedidoBebidaEN);
        }
        public List<PedidoBebidaEN> MostrarPedidoBebida()
        {
            return PedidoBebidaDAL.MostrarPedidoBebida();
        }
    }
}
