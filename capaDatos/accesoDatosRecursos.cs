using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosRecursos
    {
        SqlConnection cnx; //Conexión
        recursos ctas = new recursos();//Capaentidades
        Conexion cn = new Conexion();
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0;

        SqlDataReader dr = null;
        List<recursos> listaRecursos = null;

        public int insertarRecursos(recursos rec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("recursos_proc", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", rec.nombrer);
                cm.Parameters.AddWithValue("@codigo", rec.codigo);
                cm.Parameters.AddWithValue("@descripcion", rec.descripcion);


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        public List<recursos> listarRecursos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recursos_proc", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRecursos = new List<recursos>();
                while (dr.Read())
                {
                    recursos r = new recursos();
                    r.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    r.nombrer = dr["nombrer"].ToString();
                    r.codigo = dr["codigo"].ToString();
                    r.descripcion = dr["descripcion"].ToString();
                    listaRecursos.Add(r);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecursos = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaRecursos;

        }

        public int eliminarRecursos(int idrecursos)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recursos_proc", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idrecursos", idrecursos);
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;

        }

        public int EditarRecursos(recursos re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recursos_proc", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idrecursos", re.idrecursos);
                cm.Parameters.AddWithValue("@nombrer", re.nombrer);
                cm.Parameters.AddWithValue("@codigo", re.codigo);
                cm.Parameters.AddWithValue("@descripcion", re.descripcion);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }

            return indicador;
        }

        public List<recursos> BuscarRecursos(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recursos_proc", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idrecursos","");
                cm.Parameters.AddWithValue("@nombrer", dato);
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRecursos = new List<recursos>();
                while (dr.Read())
                {
                    recursos rc = new recursos();
                    rc.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    rc.nombrer = dr["nombrer"].ToString();
                    rc.codigo = dr["codigo"].ToString();
                    rc.descripcion = dr["descripcion"].ToString();
                    listaRecursos.Add(rc);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecursos = null;
            }
            finally
            { cm.Connection.Close(); }

            return listaRecursos;
        }
    }
}
