using RetiroDeMateriales.Datos.Interfaz;
using RetiroDeMateriales.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Datos.Implementacion
{
    public class DetallesOrdenDAO : IDetallesOrdenDAO
    {
        public void Agregar(OrdenesRetiro orden, SqlTransaction t)
        {
            List<SqlParameter> listParam = new List<SqlParameter>();
            foreach (DetallesOrden df in orden.LDetalles)
            {
                listParam.Clear();

                listParam.Add(new SqlParameter("@nro_orden", orden.NroOrden));
                listParam.Add(new SqlParameter("@detalle", orden.LDetalles.IndexOf(df)));
                listParam.Add(new SqlParameter("@codigo", df.Material.Codigo));
                listParam.Add(new SqlParameter("@cantidad", df.Cantidad));

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_DETALLES", listParam, t);
            }
        }
    }
}
