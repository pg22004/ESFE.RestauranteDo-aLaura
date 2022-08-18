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
    public class PedidoBL
    {
        public int GuardarPedido(PedidoEN pPedidoEN)
        {
            return PedidoDAL.GuardarPedido(pPedidoEN);
        }
        public static int EliminarPedido(PedidoEN pPedidoEN)
        {
            return PedidoDAL.EliminarPedido(pPedidoEN);
        }
        public static int ModificarPedido(PedidoEN pPedidoEN)
        {
            return PedidoDAL.ModificarPedido(pPedidoEN);
        }
        public List<PedidoEN> MostrarPedido()
        {
            return PedidoDAL.MostrarPedido();
        }
    }
}
