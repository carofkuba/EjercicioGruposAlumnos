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
            await this.CargarDataGridView();
        }

        private async void btnCrearGrupo_Click(object sender, EventArgs e) 
        {
            string codigoGrupo = txtCodigoGrupo.Text;
            string nombreGrupo = txtNombreGrupo.Text;


            if (string.IsNullOrEmpty(codigoGrupo) || string.IsNullOrEmpty(nombreGrupo))
            {
                MessageBox.Show("Debe ingresar un código y un nombre", "Advertencia", MessageBoxButtons.OK);
            }
            else
            {
                if (await ValidarSiGrupoExiste(codigoGrupo))
                {

                    Grupo nuevoGrupo = new Grupo(codigoGrupo, nombreGrupo);

                    bool insertExitoso = await PostGrupoAsync(nuevoGrupo);

                    if (insertExitoso)
                    {
                        await this.CargarComboBox();
                        MessageBox.Show("Grupo creado");

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private async Task<bool> ValidarSiGrupoExiste(string codigoGrupo)
        {
            List<Grupo> listaGrupos = await DevolverGrupos();

            foreach(var grupo in listaGrupos)
            {
                if (grupo.Codigo.Equals(codigoGrupo))
                {
                    MessageBox.Show("El código ya existe");
                    return false;
                }
            }
            return true;
        }

        private async void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {

            if (chkSinGrupo.Checked)
            {
                await this.CargarListBoxConAlumnosSinGrupo();
            }
            else
            {
                if (cboGrupos.SelectedItem == null)
                {
                    await this.CargarListBoxConTodosLosAlumnos();
                }
                else
                {
                    await this.CargarListBoxConAlumnosPorGrupo();
                        
                }
                
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

       

        private async void btnListarGrupos_Click(object sender, EventArgs e)
        {

            List<Grupo> listaGrupos = await DevolverGrupos();

            dgvListarGrupos.DataSource = listaGrupos;

        }

        private async Task CargarComboBox()
        {
            List<Grupo> listaGrupos = await DevolverGrupos();

            cboGrupos.DataSource = listaGrupos;
            cboGrupos.DisplayMember = "nombre";
        }



        private async Task<bool> PostGrupoAsync(Grupo oGrupo)
        {

            string url = "https://localhost:7139/api/Grupos/insert";    

            string json = JsonConvert.SerializeObject(oGrupo);          

            var response = await Cliente.GetCliente().PostAsync(url, json); 
                                                                           
            return response.Equals("true"); 
        }
        private async Task<bool> PutGrupoAsync(Grupo grupo)
        {

            string url = "https://localhost:7139/api/Grupos/update";    

            string json = JsonConvert.SerializeObject(grupo);         

            var response = await Cliente.GetCliente().PutAsync(url, json); 

            return response.Equals("true"); 
        }

        private async Task<List<Grupo>> DevolverGrupos()
        {
            string url = "https://localhost:7139/api/Grupos/grupos";
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Grupo> listaGrupos = JsonConvert.DeserializeObject<List<Grupo>>(content);

            return listaGrupos; 
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

        //private async Task CargarListBoxConAlumnosPorGrupo(Grupo grupo)
        //{
        //    string groupId = grupo.Codigo;
        //    string url = "https://localhost:7139/api/Grupos/alumnosGrupoSeleccionado/";
        //    url = url + grupo.Codigo;
        //    var content = await Cliente.GetCliente().GetAsync(url);

        //    List<Alumno> listaAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(content);

        //    lstAlumnos.DataSource = listaAlumnos;
        //    lstAlumnos.DisplayMember = listaAlumnos.ToString();

        //



        private async Task CargarListBoxConAlumnosPorGrupo()
        {
            string url = "https://localhost:7139/api/Grupos/gruposAlumnos";
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Grupo> listaGruposYAlumnos = JsonConvert.DeserializeObject<List<Grupo>>(content);

            Grupo nuevoGrupo = (Grupo)cboGrupos.SelectedItem;
            string codigoGrupo = nuevoGrupo.Codigo;

            foreach(var grupo in listaGruposYAlumnos)
            {
                if (grupo.Codigo == codigoGrupo)
                {
                    List<Alumno> listaAlumnos = grupo.ListaAlumnos;
                    lstAlumnos.DataSource = listaAlumnos;
                    lstAlumnos.DisplayMember = listaAlumnos.ToString();
                }
            }
            
            

        }
        private async Task CargarDataGridView()
        {
            string url = "https://localhost:7139/api/Grupos/gruposAlumnos";
            var content = await Cliente.GetCliente().GetAsync(url);

            List<Grupo> listaGruposConAlumnos = JsonConvert.DeserializeObject<List<Grupo>>(content);

            foreach (var grupo in listaGruposConAlumnos)
            {

                dgvListarGrupos.Rows.Add(new object[] { grupo.Codigo, grupo.Nombre, grupo.ContarAlumnosEnLista() });

            }
        }

      




        private async void dgvListarGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            await CargarDataGridView();

           
        }

        
    }
}
