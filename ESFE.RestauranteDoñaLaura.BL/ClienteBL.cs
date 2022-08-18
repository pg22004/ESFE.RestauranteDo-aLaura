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
    public class ClienteBL
    {
        public List<ClienteEN> MostrarCliente()
        {
            return ClienteDAL.MostrarCliente();
        }
        public static int ModificarCliente(ClienteEN pClienteEN)
        {
            return ClienteDAL.ModificarCliente(pClienteEN);
        }
        public static int EliminarCliente(ClienteEN pClienteEN)
        {
            return ClienteDAL.EliminarCliente(pClienteEN);
        }
        public int GuardarCliente(ClienteEN pClienteEN)
        {
            return ClienteDAL.GuardarCliente(pClienteEN);
        }
    }
}
