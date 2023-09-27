using RetiroDeMateriales.Entidades;
using RetiroDeMateriales.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Datos.Interfaz
{
    public interface IMaterialesDAO
    {
        List<Materiales> Listar();
    }
}
