using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.RestauranteDoñaLaura.EN
{
    public class PedidoBebidaEN
    {
        public Int64 Id { get; set; }
        public Int64 IdBebida { get; set; }
        public Int64 IdPedido { get; set; }
        public Int32 CantidadBebida { get; set; }
        public decimal TotalPagar { get; set; }
    }
}
