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
    public class EmpleadoBL
    {
        public List<EmpleadoEN> MostrarEmpleado()
        {
            return EmpleadoDAL.MostrarEmpleado();
        }
        public static int ModificarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            return EmpleadoDAL.ModificarEmpleado(pEmpleadoEN);
        }
        public static int EliminarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            return EmpleadoDAL.EliminarEmpleado(pEmpleadoEN);
        }
        public int GuardarEmpleado(EmpleadoEN pEmpleadoEN)
        {
            return EmpleadoDAL.GuardarEmpleado(pEmpleadoEN);
        }
    }
}
