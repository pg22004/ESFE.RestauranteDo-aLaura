using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.RestauranteDoñaLaura.EN
{
    public class PedidoEN
    {
        public Int64 Id { get; set; }
        public Int64 IdCliente { get; set; }
        public Int64 IdEmpleado { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
