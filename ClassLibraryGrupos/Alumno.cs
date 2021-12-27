namespace ClassLibraryGrupos
{
    public class Alumno
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public bool SinGrupo { get; set; }


        public override string ToString()
        {
            return this.Legajo + " - " + this.Apellido + ", " + this.Nombre;
        }

      


    }
}