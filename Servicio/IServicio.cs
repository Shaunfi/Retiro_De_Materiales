using RetiroDeMateriales.Datos.Implementacion;
using RetiroDeMateriales.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Servicio
{
    public interface IServicio
    {
        OrdenesRetiroDAO Ordenes { get; }
        DetallesOrdenDAO Detalles { get; }
        MaterialesDAO Materiales { get; }


    }
}
