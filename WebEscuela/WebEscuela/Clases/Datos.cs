using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebEscuela.Clases
{
    public class Datos
    {
        private string cadena = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Escuela.mdf;Integrated Security=True";
        public SqlConnection cn;
        public SqlDataAdapter da;
        public DataSet ds = new DataSet();
        public SqlCommand comando;

        private void Conectar()
        {
            cn = new SqlConnection(cadena);
        }

        public Datos()
        {
            Conectar();
        }


        public DataTable consultaLoginA()
        {
            string tabla = "alumno";
            string sql = "SELECT * FROM" + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];

            return dt;

        }

        public DataTable consultaLoginA(string ID)
        {
            string tabla = "SELECT * FROM alumno WHERE id_rut=" + ID;

            string sql = tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];

            return dt;
        }

        public DataTable consultaTabla(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];

            return dt;
        }

        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool modificar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();

            if (i > 0)
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool eliminar(string sql)
        {
            cn.Open();
            comando = new SqlCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();

            if (i > 0)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}