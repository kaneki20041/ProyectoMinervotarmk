using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datCategoria
    {
        #region Singleton
        private static readonly datCategoria _instancia = new datCategoria();
        public static datCategoria Instancia
        {
            get
            {
                return datCategoria._instancia;
            }
        }
        #endregion Singleton

        #region metodos
        public List<entCategoria> ListaCategoria()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("splistarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria gato = new entCategoria();
                    gato.categoriaID = Convert.ToInt32(dr["CategoriaID"]);
                    gato.descripcion = dr["Categoria"].ToString();
                    gato.estado = Convert.ToBoolean(dr["estado"]);
                    lista.Add(gato);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        public void InsertaCat(entCategoria cat)
        {
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                SqlCommand cmd = new SqlCommand("spAgregarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descripcion", cat.descripcion);
                cmd.Parameters.AddWithValue("@estado", cat.estado);

                cn.Open();
                cmd.ExecuteNonQuery();
             }
                catch (Exception ex)
             {
                throw ex;
             }
        }

        public Boolean ModificarCat(entCategoria cat)
        {
            SqlCommand cmd = null;
            Boolean modifica = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", cat.categoriaID);
                cmd.Parameters.AddWithValue("@Estado", cat.estado);
                cmd.Parameters.AddWithValue("@Categoria", cat.descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modifica = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return modifica;
        }

        public Boolean InhabilitarCat(entCategoria cat)
        {
            SqlCommand cmd = null;
            Boolean inhabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInhabilitarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", cat.categoriaID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inhabilita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inhabilita;
        }
        #endregion metodos
    }
}