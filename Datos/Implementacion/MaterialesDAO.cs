using RetiroDeMateriales.Datos;
using RetiroDeMateriales.Datos.Interfaz;
using RetiroDeMateriales.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Datos.Implementacion
{
    public class MaterialesDAO : IMaterialesDAO
    {
        public List<Materiales> Listar()
        {
            List<Materiales> listMateriales = new List<Materiales>();

            DataTable tabla = AccesoDatosDAO.ObtenerInstancia().ProcedureReader("SP_CONSULTAR_MATERIALES");

            foreach (DataRow row in tabla.Rows) 
            {
                Materiales material = new Materiales();

                material.Codigo = Convert.ToInt32(row[0].ToString());
                material.Nombre = row[1].ToString();
                material.Stock = Convert.ToDouble(row[2].ToString());

                listMateriales.Add(material);
            }

            return listMateriales;
        }
    }
}
