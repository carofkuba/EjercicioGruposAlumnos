namespace ClassLibraryGrupos
{
    public class Grupo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public List<Alumno> ListaAlumnos { get; set; }

        public Grupo(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
            ListaAlumnos = new List<Alumno>();
        }

        public void AgregarAlumno(Alumno oAlumno)
        {
            ListaAlumnos.Add(oAlumno);

        }

        public void QuitarAlumno(Alumno oAlumno)
        {
            ListaAlumnos.Remove(oAlumno);
        }

        public int ContarAlumnos()
        {
            return ListaAlumnos.Count();
        }

        public List<Alumno> MostrarAlumnos()
        {
            return ListaAlumnos;
        }

        
    }
     
}