using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiroDeMateriales.Datos
{
    public class AccesoDatosDAO
    {
        private static AccesoDatosDAO instancia;

        private SqlConnection cnn;

        private SqlCommand cmd;

        private DataTable tabla;

        private SqlTransaction t;

        #region Funciones Internas
        private AccesoDatosDAO()
        {
            cnn = new SqlConnection(Properties.Resources.ConexionStr);
        }

        public static AccesoDatosDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AccesoDatosDAO();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }

        private void Conectar()
        {
            cnn.Open();

            cmd = new SqlCommand();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
        }

        private void Desconectar()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        #endregion

        #region Reader
        public DataTable ProcedureReader(string nombreSP)
        {
            tabla = new DataTable();
            Conectar();

            cmd.CommandText = nombreSP;

            tabla.Load(cmd.ExecuteReader());

            Desconectar();

            return tabla;
        }

        public DataTable ProcedureReader(string nombreSP, SqlParameter parameter)
        {
            tabla = new DataTable();
            Conectar();

            cmd.Parameters.Add(parameter);

            cmd.CommandText = nombreSP;

            tabla.Load(cmd.ExecuteReader());

            Desconectar();

            return tabla;
        }

        public DataTable ProcedureReader(string nombreSP, List<SqlParameter> listParam)
        {
            tabla = new DataTable();
            Conectar();

            listParam.ForEach((param) => { cmd.Parameters.Add(param); });

            cmd.CommandText = nombreSP;

            tabla.Load(cmd.ExecuteReader());

            Desconectar();

            return tabla;
        }
        #endregion

        #region NonExecuter
        public bool ProcedureNonExecuter(string nombreSP)
        {
            t = null;
            bool resultado = true;
            try
            {
                Conectar();

                t = cnn.BeginTransaction();

                cmd.CommandText = nombreSP;

                cmd.ExecuteNonQuery();

                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                Desconectar();
            }
            return resultado;
        }

        public bool ProcedureNonExecuter(string nombreSP, SqlParameter param)
        {
            t = null;
            bool resultado = true;
            try
            {
                Conectar();

                t = cnn.BeginTransaction();

                cmd.CommandText = nombreSP;

                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                Desconectar();
            }
            return resultado;
        }

        public bool ProcedureNonExecuter(string nombreSP, List<SqlParameter> listParam)
        {
            t = null;
            bool resultado = true;
            try
            {
                Conectar();

                t = cnn.BeginTransaction();

                cmd.CommandText = nombreSP;

                listParam.ForEach((param) => cmd.Parameters.Add(param));

                cmd.ExecuteNonQuery();

                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                    resultado = false;
                }
            }
            finally
            {
                Desconectar();
            }
            return resultado;
        }

        public void ProcedureNonExecuter(string nombreSP, List<SqlParameter> listParam, SqlTransaction t)
        {
            cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Transaction = t;
            cmd.CommandText = nombreSP;

            listParam.ForEach((param) => cmd.Parameters.Add(param));

            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
