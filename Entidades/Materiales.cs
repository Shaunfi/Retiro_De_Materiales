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
        private int stock;

        public Materiales(int codigo, string nombre, int stock)
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
        public int Stock { get => stock; set => stock = value; }
    }
}
