using RetiroDeMateriales.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Factory
{
    public class FabricaServicioImp : FabricaServicio
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
