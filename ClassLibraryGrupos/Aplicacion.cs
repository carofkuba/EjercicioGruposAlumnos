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

        

        public List<Alumno> GetAlumnos()
        {


            return dao.GetAlumnosEnList(dao.GetTablaEnDataTable("Alumnos"));
        }

        public List<Alumno> GetAlumnosSinGrupo()
        {
            return dao.GetAlumnosEnList(dao.GetAlumnosSinGrupo());
        }

        public List<Alumno> GetAlumnosById(Grupo grupo)
        {
            return dao.GetAlumnosEnList(dao.GetAlumnosById(grupo));
        }

    }

   


    
}
