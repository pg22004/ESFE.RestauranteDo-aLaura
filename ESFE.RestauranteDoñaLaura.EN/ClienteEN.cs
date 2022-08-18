using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.RestauranteDoñaLaura.EN
{
    public class ClienteEN
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dui { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
}
