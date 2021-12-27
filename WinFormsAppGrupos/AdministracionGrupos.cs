using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ClassLibraryGrupos;


namespace WinFormsAppGrupos
{
    public partial class FrmAdminGrupos : Form
    {
        public FrmAdminGrupos()
        {
            InitializeComponent();
        }

        private async void FrmAdminGrupos_Load(object sender, EventArgs e)
        {

            await this.CargarComboBox();

            
            
        }

        private void btnCrearGrupos_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            string codigoGrupo = txtCodigoGrupo.Text;
            string nombreGrupo = txtNombreGrupo.Text;

            Grupo nuevoGrupo = new Grupo(codigoGrupo, nombreGrupo);

            bool insertExitoso = await PostGrupoAsync(nuevoGrupo);

            if (insertExitoso)
            {
                MessageBox.Show("Grupo creado");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private async Task<bool> PostGrupoAsync(Grupo oGrupo)
        {

            string url = "https://localhost:7139/api/Grupos/insert";    //controller

            string json = JsonConvert.SerializeObject(oGrupo);          //convierte el objeto en un json

            var response = await Cliente.GetCliente().PostAsync(url, json); //ese json lo manda por http
                                                                            //este método devuelve un string!

            return response.Equals("true"); // si la response es igual a "true", devuelve "true".
        }

      

        private async void btnAdministrarGrupos_Click(object sender, EventArgs e)
        {
            

            
        }

        private async Task CargarComboBox()
        {
            string url = "https://localhost:7139/api/Grupos/grupos";
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Grupo> listaGrupos = JsonConvert.DeserializeObject<List<Grupo>>(content);


            cboGrupos.DataSource = listaGrupos;
            cboGrupos.DisplayMember = "nombre";
            
        }

        private async Task CargarListBoxConTodosLosAlumnos()
        {
            string url = "https://localhost:7139/api/Grupos/alumnos";
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Alumno> listaAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(content);

            lstAlumnos.DataSource = listaAlumnos;
            lstAlumnos.DisplayMember = listaAlumnos.ToString();

        }

        private async Task CargarListBoxConAlumnosSinGrupo()
        {
            string url = "https://localhost:7139/api/Grupos/alumnosSinGrupo";
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Alumno> listaAlumnosSinGrupo = JsonConvert.DeserializeObject<List<Alumno>>(content);

            lstAlumnos.DataSource = listaAlumnosSinGrupo;
            lstAlumnos.DisplayMember = listaAlumnosSinGrupo.ToString();

        }

       

        private async Task CargarListBoxConAlumnosPorGrupo(Grupo grupo)
        {
            string groupId = grupo.Codigo;
            string url = "https://localhost:7139/api/Grupos/alumnosGrupoSeleccionado/ ";
            url = url + grupo.Codigo;
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Alumno> listaAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(content);

            lstAlumnos.DataSource = listaAlumnos;
            lstAlumnos.DisplayMember = listaAlumnos.ToString();

        }

        private async void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {

            if (chkSinGrupo.Checked)
            {
                await this.CargarListBoxConAlumnosSinGrupo();
            }

            if (chkSinGrupo.Checked == false && cboGrupos.SelectedItem != null)
            {
                Grupo nuevoGrupo = (Grupo)cboGrupos.SelectedItem;

                await this.CargarListBoxConAlumnosPorGrupo(nuevoGrupo);
            }

            else
            {

                await this.CargarListBoxConTodosLosAlumnos();
            }



        }

        private async void btnAgregarAlGrupo_Click(object sender, EventArgs e)
        {
            Grupo grupoSeleccionado = (Grupo)cboGrupos.SelectedItem;

            Alumno alumnoSeleccionado = (Alumno)lstAlumnos.SelectedItem;

            grupoSeleccionado.AgregarAlumno((Alumno)lstAlumnos.SelectedItem);

            
            await PutGrupoAsync(grupoSeleccionado);

            MessageBox.Show("Agregado con éxito"); 
       
        }



        private async Task<bool> PutGrupoAsync(Grupo grupo)
        {

            string url = "https://localhost:7139/api/Grupos/update";    

            string json = JsonConvert.SerializeObject(grupo);          //convierte el objeto en un json

            var response = await Cliente.GetCliente().PutAsync(url, json); //ese json lo manda por http
                                                                            //este método devuelve un string!

            return response.Equals("true"); // si la response es igual a "true", devuelve "true".
        }


        
      
     


        private async void btnListarGrupos_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:7139/api/Grupos/grupos";
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Grupo> listaGrupos = JsonConvert.DeserializeObject<List<Grupo>>(content);

            dgvListarGrupos.DataSource = listaGrupos;
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
