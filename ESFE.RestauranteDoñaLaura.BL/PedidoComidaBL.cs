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
    public class PedidoComidaBL
    {
        public int GuardarPedidoComida(PedidoComidaEN pPedidoComidaEN)
        {
            return PedidoComidaDAL.GuardarPedidoComida(pPedidoComidaEN);
        }
        public static int EliminarPedidoComida(PedidoComidaEN pPedidoComidaEN)
        {
            return PedidoComidaDAL.EliminarPedidoComida(pPedidoComidaEN);
        }
        public static int ModificarPedidoComida(PedidoComidaEN pPedidoComidaEN)
        {
            return PedidoComidaDAL.ModificarPedidoComida(pPedidoComidaEN);
        }
        public List<PedidoComidaEN> MostrarPedidoComida()
        {
            return PedidoComidaDAL.MostrarPedidoComida();
        }
    }
}
