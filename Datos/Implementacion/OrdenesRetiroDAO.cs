using RetiroDeMateriales.Datos.Interfaz;
using RetiroDeMateriales.Entidades;
using RetiroDeMateriales.Servicios;
using RetiroDeMateriales.Factory;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace RetiroDeMateriales.Datos.Implementacion
{
    public class OrdenesRetiroDAO : IOrdenesRetiroDAO  
    {
        public bool Agregar(OrdenesRetiro orden)
        {
            bool resultado = true;
            SqlConnection cnn = AccesoDatosDAO.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            Servicio servicio = new Servicio();
            try
            {
                cnn.Open();

                t = cnn.BeginTransaction();

                List<SqlParameter> listParam = new List<SqlParameter>();

                listParam.Add(new SqlParameter("@responsable", orden.Responsable));
                SqlParameter outParam = new SqlParameter("@nro", SqlDbType.Int);
                outParam.Direction = ParameterDirection.Output;
                listParam.Add(outParam);

                AccesoDatosDAO.ObtenerInstancia().ProcedureNonExecuter("SP_INSERTAR_ORDEN", listParam, t);

                orden.NroOrden = Convert.ToInt32(outParam.Value);

                servicio.Detalles.Agregar(orden, t);

                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    resultado = false;
                    t.Rollback();
                }
            }
            finally
            {
                cnn.Close();
            }

            return resultado;
        }
    }
}
