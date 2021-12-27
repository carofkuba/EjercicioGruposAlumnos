using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryGrupos
{
    public class Dao
    {
        SqlConnection cnn = null;
        string connectionString;
        public Dao()
        {
            connectionString = @"Data Source=LAPTOP-PHJ31ERV\SQLEXPRESS;Initial Catalog=Escuela;Integrated Security=True";
        }

        

        public bool InsertGrupo(Grupo oGrupo)
        {

            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertGrupo";

            cmd.Parameters.AddWithValue("@codigo", oGrupo.Codigo);
            cmd.Parameters.AddWithValue("@nombre", oGrupo.Nombre);

            cnn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();

            cnn.Close();

            if (rowsAffected > 0)
                return true;
            else
                return false;


        }

        public List<Grupo> GetGrupos()
        {
            DataTable tabla = GetTablaEnDataTable("Grupos");
            List<Grupo> listaGrupos = new List<Grupo>();

            foreach(DataRow row in tabla.Rows)
            {
                
                string codigo = row[0].ToString();
                string nombre = row[1].ToString();

                Grupo oGrupo = new Grupo(codigo, nombre);

                listaGrupos.Add(oGrupo);

            }

            return listaGrupos;

        }

        public List<Alumno> GetAlumnos()
        {
            DataTable tabla = GetTablaEnDataTable("Alumnos");
            List<Alumno> listaAlumnos = new List<Alumno>();

            foreach (DataRow row in tabla.Rows)
            {
                Alumno oAlumno = new Alumno();

                oAlumno.Legajo = Convert.ToInt32(row[0].ToString());
                oAlumno.Nombre = row[1].ToString();
                oAlumno.Apellido = row[2].ToString();

                listaAlumnos.Add(oAlumno);

            }

            return listaAlumnos;

        }

        public DataTable GetTablaEnDataTable(string nombreTabla)
        {

            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString;

            string query = "select * from " + nombreTabla;

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.Text;

            DataTable tabla = new DataTable();
            
            cnn.Open();
            
            tabla.Load(cmd.ExecuteReader());
            
            cnn.Close();

            return tabla;

        }

        public DataTable GetAlumnosSinGrupo()
        {

            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString;

            string query = "select * from Alumnos where grupo is null";

            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.Text;

            DataTable tabla = new DataTable();

            cnn.Open();

            tabla.Load(cmd.ExecuteReader());

            cnn.Close();

            return tabla;

        }

        public DataTable GetAlumnosById(Grupo grupo)
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();

            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_GetAlumnosById";

            cmd.Parameters.AddWithValue("@codigoGrupo", grupo.Codigo);

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            cnn.Close();

            return tabla;
        }

        public List<Alumno> GetAlumnosEnList(DataTable tabla)
        {
            
            List<Alumno> listaAlumnos = new List<Alumno>();

            foreach (DataRow row in tabla.Rows)
            {
                Alumno oAlumno = new Alumno();

                oAlumno.Legajo = Convert.ToInt32(row[0].ToString());
                oAlumno.Nombre = row[1].ToString();
                oAlumno.Apellido = row[2].ToString();

                listaAlumnos.Add(oAlumno);

            }

            return listaAlumnos;

        }



        public void UpdateGrupoDeAlumno(Grupo grupo)
        {

            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString;

            SqlCommand cmd = new SqlCommand();

            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateTablaAlumnos";

        
            foreach(Alumno alumno in grupo.ListaAlumnos)        //ACÁ ESTÁ EL LINK ENTRE LAS TABLAS!!!!!!!!
            {
                cmd.Parameters.AddWithValue("@codigoGrupo", grupo.Codigo);
                cmd.Parameters.AddWithValue("@legajoAlumno", alumno.Legajo);
                cmd.ExecuteNonQuery();
                
            }

            cnn.Close();

            
        }
    }
}
