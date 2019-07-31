using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaEntidades;
using System.Data;


namespace capaDatos
{
    public class accesoDatosCuentas
    {
        SqlConnection cnx; //Conexión
        Cuentas ctas = new Cuentas();//Capaentidades
        Conexion cn = new Conexion();
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0;

        SqlDataReader dr = null;
        List<Cuentas> listaCuentas = null;

        public int insertarCuentas(Cuentas cu)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("pro_cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", cu.nombreuser);
                cm.Parameters.AddWithValue("@clave", cu.clave);
                cm.Parameters.AddWithValue("@rol", cu.rol);
                cm.Parameters.AddWithValue("@idusuario", cu.idusuario);
                

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

        public List<Cuentas> listarCuentas()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("pro_cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");
                cm.Parameters.AddWithValue("@idusuario", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuentas = new List<Cuentas>();
                while (dr.Read())
                {
                    Cuentas cue = new Cuentas();
                    cue.idcuenta = Convert.ToInt32(dr["idcuenta"].ToString());
                    cue.nombreuser = dr["nombre user"].ToString();
                    cue.clave = dr["clave"].ToString();
                    cue.rol = dr["rol"].ToString();
                    cue.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    listaCuentas.Add(cue);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuentas = null;
            }

            finally
            {
                cm.Connection.Close();
            }

            return listaCuentas;

        }

        public int eliminarCuentas(int idcuenta)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("pro_cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcomentario", idcuenta);
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");
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

        public int EditarCuentas(Cuentas cta)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("pro_cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcuenta", cta.idcuenta);
                cm.Parameters.AddWithValue("@nombreuser", cta.nombreuser);
                cm.Parameters.AddWithValue("@clave", cta.clave);
                cm.Parameters.AddWithValue("@rol", cta.rol);
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

        public List<Cuentas> BuscarCuentas(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("pro_cuentas", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", dato);
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");
                cm.Parameters.AddWithValue("@idusuario", "");
                
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuentas = new List<Cuentas>();
                while (dr.Read())
                {
                    Cuentas ct = new Cuentas();
                    ct.idcuenta = Convert.ToInt32(dr["idcuenta"].ToString());
                    ct.nombreuser = dr["nombre user"].ToString();
                    ct.clave = dr["clave"].ToString();
                    ct.rol = dr["rol"].ToString();
                    ct.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    listaCuentas.Add(ct);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuentas = null;
            }
            finally
            { cm.Connection.Close(); }

            return listaCuentas;
        }

    }
}

