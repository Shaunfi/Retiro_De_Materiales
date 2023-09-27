using RetiroDeMateriales.Datos.Implementacion;
using RetiroDeMateriales.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Servicios
{
    public class Servicio : IServicio
    {
        public OrdenesRetiroDAO Ordenes { get; }
        public DetallesOrdenDAO Detalles { get; }
        public MaterialesDAO Materiales { get; }

        public Servicio()
        {
            Ordenes = new OrdenesRetiroDAO();
            Detalles = new DetallesOrdenDAO();
            Materiales = new MaterialesDAO();
        }
    }
    //public class Servicio : IServicio
    //{
        //private OrdenesRetiroDAO ordenes;
        //private DetallesOrdenDAO detalles;
        //private MaterialesDAO materiales;

        //public OrdenesRetiroDAO Ordenes { get => ordenes; }

        //public DetallesOrdenDAO Detalles { get => detalles; }

        //public MaterialesDAO Materiales { get => materiales; }

        //public Servicio() 
        //{
        //    ordenes = new OrdenesRetiroDAO();
        //    detalles = new DetallesOrdenDAO();
        //    materiales = new MaterialesDAO();
        //}

   // }
}
