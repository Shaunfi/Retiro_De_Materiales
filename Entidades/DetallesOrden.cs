using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Entidades
{
    public class DetallesOrden
    {
        private Materiales material;
        private int cantidad;

        public DetallesOrden(Materiales material, int cantidad)
        {
            this.material = material;
            this.cantidad = cantidad;
        }

        public DetallesOrden()
        {
            material = null;
            cantidad = 0;
        }

        public Materiales Material { get => material; set => material = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
