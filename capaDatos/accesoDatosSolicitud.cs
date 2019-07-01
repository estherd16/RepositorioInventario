using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;

namespace capaDatos
{
    public class accesoDatosSolicitud
    {
        SqlConnection cnx; //Conexión
        Solicitud so = new Solicitud();//Capaentidades
        Conexion cn = new Conexion();
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0;

        SqlDataReader dr = null;
        List<Solicitud> listaSolicitud = null;

        public int insertarSolicitud(Solicitud sol)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("insertar", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", sol.aula);
                cm.Parameters.AddWithValue("@nivel", sol.nivel);
                cm.Parameters.AddWithValue("@fechasolicitud", sol.fechasolicitud);
                cm.Parameters.AddWithValue("@fechauso", sol.fechauso);
                cm.Parameters.AddWithValue("@horainicio", sol.horainicio);
                cm.Parameters.AddWithValue("@horafinal", sol.horafinal);
                cm.Parameters.AddWithValue("@carrera", sol.carrera);
                cm.Parameters.AddWithValue("@asignatura", sol.asignatura);
                cm.Parameters.AddWithValue("@idrecursos", sol.idrecursos);
                cm.Parameters.AddWithValue("@idusuario", sol.idusuario);


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
        public List<Solicitud> listarSolicitud()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("listar", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaSolicitud = new List<Solicitud>();
                while (dr.Read())
                {
                    Solicitud s = new Solicitud();
                    s.idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    s.aula = dr["aula"].ToString();
                    s.nivel = dr["nivel"].ToString();
                    s.fechasolicitud = Convert.ToDateTime(dr["fechasolicitud"].ToString());
                    s.fechauso = Convert.ToDateTime(dr["fechauso"].ToString());
                    s.horainicio = Convert.ToDateTime(dr["horainicio"].ToString());
                    s.horafinal = Convert.ToDateTime(dr["horafinal"].ToString());
                    s.carrera = dr["carrera"].ToString();
                    s.asignatura = dr["asignatura"].ToString();
                    s.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    s.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    listaSolicitud.Add(s);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSolicitud = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaSolicitud;

        }

        public int eliminarSolicitud(int idsolicitud)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("eliminar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idsolicitud", idsolicitud);
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");

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

        public int EditarSolicitud(Solicitud sl)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("editar", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idsolicitud", sl.idsolicitud);
                cm.Parameters.AddWithValue("@aula", sl.aula);
                cm.Parameters.AddWithValue("@nivel", sl.nivel);
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", sl.carrera);
                cm.Parameters.AddWithValue("@asignatura", sl.asignatura);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", "");

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

        public List<Solicitud> BuscarSolicitud(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("buscar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idsolicitud", dato);
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@idusuario", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaSolicitud = new List<Solicitud>();
                while (dr.Read())
                {
                    Solicitud sd = new Solicitud();
                    sd.idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    sd.aula = dr["aula"].ToString();
                    sd.nivel = dr["nivel"].ToString();
                    sd.fechasolicitud = Convert.ToDateTime(dr["fechasolicitud"].ToString());
                    sd.fechauso = Convert.ToDateTime(dr["fechauso"].ToString());
                    sd.horainicio = Convert.ToDateTime(dr["horainicio"].ToString());
                    sd.horafinal = Convert.ToDateTime(dr["horafinal"].ToString());
                    sd.carrera = dr["carrera"].ToString();
                    sd.asignatura = dr["asignatura"].ToString();
                    sd.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    sd.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    listaSolicitud.Add(sd);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaSolicitud = null;
            }
            finally
            { cm.Connection.Close(); }

            return listaSolicitud;
        }
    }
}
