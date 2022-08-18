﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.RestauranteDoñaLaura.EN
{
    public class BebidaEN
    {
        public Int64 Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public Int64 IdCategoriaBebida { get; set; }
    }
}
