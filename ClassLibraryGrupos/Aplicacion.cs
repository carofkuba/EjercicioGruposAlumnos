using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLibraryGrupos
{
    public class Aplicacion
    {
        private Dao dao = new Dao();


        public bool InsertGrupo(Grupo oGrupo)
        {
            return dao.InsertGrupo(oGrupo);
        }

        public void UpdateGrupo(Grupo grupo)
        {

            dao.UpdateGrupoDeAlumno(grupo);
        }

        public List<Grupo> GetGrupos()
        {
            return dao.GetGrupos();
        }

        public List<Grupo> GetGruposConAlumnos()
        {
            return dao.GetGruposConAlumnos();
        }

        public List<Alumno> GetAlumnos()
        {
            DataTable tabla = dao.GetTablaEnDataTable("Alumnos");
            return dao.GetAlumnosEnList(tabla);
        }

        public List<Alumno> GetAlumnosSinGrupo()
        {
            DataTable tabla = dao.GetAlumnosSinGrupo();
            return dao.GetAlumnosEnList(tabla);
        }

        public List<Alumno> GetAlumnosById(Grupo grupo)
        {
            DataTable tabla = dao.GetAlumnosById(grupo);
            return dao.GetAlumnosEnList(tabla);
        }

    }

   


    
}
