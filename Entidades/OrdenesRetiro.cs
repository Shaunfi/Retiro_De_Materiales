using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Entidades
{
    public class OrdenesRetiro
    {
        private int nroOrden;
        private DateTime fecha;
        private string responsable;
        private List<DetallesOrden> lDetalles;

        public OrdenesRetiro(int nroOrden, DateTime fecha, string responsable)
        {
            this.NroOrden = nroOrden;
            this.Fecha = fecha;
            this.Responsable = responsable;
            lDetalles = new List<DetallesOrden>();
        }

        public OrdenesRetiro()
        {
            nroOrden = 0;
            fecha = DateTime.Now;
            responsable = string.Empty;
            lDetalles = new List<DetallesOrden>();
        }

        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public List<DetallesOrden> LDetalles { get => lDetalles; set => lDetalles = value; }
    }
}
