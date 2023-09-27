using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Entidades
{
    public class Materiales
    {
        private int codigo;
        private string nombre;
        private double stock;

        public Materiales(int codigo, string nombre, double stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.stock = stock;
        }

        public Materiales() 
        {
            codigo = 0;
            nombre = String.Empty;
            stock = 0;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Stock { get => stock; set => stock = value; }
    }
}
