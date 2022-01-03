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
        string connectionString = @"Data Source=LAPTOP-PHJ31ERV\SQLEXPRESS;Initial Catalog=Escuela;Integrated Security=True";
        

        private SqlConnection GetSqlConnectionSingleton()
        {
            if(cnn == null)
            {
                cnn = new SqlConnection(connectionString);
            }
            return cnn;
        }

        

        public bool InsertGrupo(Grupo oGrupo)
        {

            cnn = GetSqlConnectionSingleton();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertGrupo";

            cmd.Parameters.AddWithValue("@codigo", oGrupo.Codigo);
            cmd.Parameters.AddWithValue("@nombre", oGrupo.Nombre);

            
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

            foreach (DataRow row in tabla.Rows)
            {
                Grupo nuevoGrupo = new Grupo(row[0].ToString(), row[1].ToString());
                listaGrupos.Add(nuevoGrupo);
            }

            return listaGrupos;



        }


        public List<Grupo> GetGruposConAlumnos()
        {
            List<Grupo> listaGrupos = new List<Grupo>();
            listaGrupos = GetGrupos();

            foreach(var grupo in listaGrupos)
            {
                string codigoGrupo = grupo.Codigo;

                DataTable tabla = GetSPConParamEntrada("sp_AlumnosPorGrupo", "@codigoGrupo", codigoGrupo);

                foreach(DataRow row in tabla.Rows)
                {

                    if (!row[0].Equals(DBNull.Value)) {

                        Alumno nuevoAlumno = new Alumno();
                        nuevoAlumno.Legajo = Convert.ToInt32(row[0].ToString());
                        nuevoAlumno.Nombre = row[1].ToString();
                        nuevoAlumno.Apellido = row[2].ToString();

                        grupo.AgregarAlumno(nuevoAlumno);

                    } 
                }
            }
            return listaGrupos;
        }

        public DataTable GetSPConParamEntrada(string SP, string param, string valorParamEnt)
        {
            cnn = GetSqlConnectionSingleton();

            SqlCommand cmd = new SqlCommand();

            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;

            cmd.Parameters.AddWithValue(param, valorParamEnt);

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            cnn.Close();

            return tabla;
        }

        public DataTable GetSP(string SP)
        {
            cnn = GetSqlConnectionSingleton();

            SqlCommand cmd = new SqlCommand();

            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP;

           

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


        public DataTable GetTablaEnDataTable(string nombreTabla)
        {

            cnn = GetSqlConnectionSingleton();

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

            cnn = GetSqlConnectionSingleton();

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
            cnn = GetSqlConnectionSingleton();

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

        public void UpdateGrupoDeAlumno(Grupo grupo)
        {

            cnn = GetSqlConnectionSingleton();

            SqlCommand cmd = new SqlCommand();

            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updateTablaAlumnos";

        
            foreach(Alumno alumno in grupo.ListaAlumnos)        
            {
                cmd.Parameters.AddWithValue("@codigoGrupo", grupo.Codigo);
                cmd.Parameters.AddWithValue("@legajoAlumno", alumno.Legajo);
                cmd.ExecuteNonQuery();
                
            }

            cnn.Close();

            
        }
    }
}
