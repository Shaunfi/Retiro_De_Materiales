using RetiroDeMateriales.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Datos.Interfaz
{
    public interface IOrdenesRetiroDAO
    {
        bool Agregar(OrdenesRetiro orden);
    }
}
