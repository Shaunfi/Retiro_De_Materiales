using RetiroDeMateriales.Datos.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Servicio
{
    public class Servicio : IServicio
    {
        public OrdenesRetiroDAO Ordenes { get; } = new OrdenesRetiroDAO();

        public DetallesOrdenDAO Detalles { get; } = new DetallesOrdenDAO();

        public MaterialesDAO Materiales { get; } = new MaterialesDAO();


    }
}
