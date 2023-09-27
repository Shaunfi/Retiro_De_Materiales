using RetiroDeMateriales.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Factory
{
    public abstract class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
