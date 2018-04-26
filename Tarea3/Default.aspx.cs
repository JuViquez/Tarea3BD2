using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) //cuando carga la pagina
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext()) //usa el contexto de datos de Linq
            {
                spEstudiantesCarreraAno.DataSource = dbContext.estudiantesIngresadosCarreraAno(); //ejecuta sp de estudiantesIngresadosCarreraAño
                spEstudiantesCarreraAno.DataBind(); //binds to datagrid

                tbTotalEstudiantes.DataSource = dbContext.totalEstudiantes(); // ejecuta sp totalEstudiantes
                tbTotalEstudiantes.DataBind(); //binds to datagrid

                tbTotalEstudiantesCarrera.DataSource = dbContext.totalEstudiantesCarrera(); //ejecuta sp totalEstudiantesCarrera
                tbTotalEstudiantesCarrera.DataBind(); //binds to datagrid

                tbTotalEstudiantesAno.DataSource = dbContext.totalEstudiantesPorAno(); //ejecuta sp totalEstudiantes por Ano
                tbTotalEstudiantesAno.DataBind(); //binds to datagrid
            }
        }

        private byte[] getFileStream(FileUpload fu) //Convierte un archivo subido mediante un fileupload component a un arreglo de bytes
        {
            int filelength = fu.PostedFile.ContentLength;
            byte[] file = new byte[filelength];
            fu.PostedFile.InputStream.Read(file, 0, filelength);
            return file;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext()) //usa contexto de DB de linq
            {

                Estudiante estudiante = new Estudiante //crea un nuevo estudiante a con los datos obtenidos de la interfaz grafica
                {
                    cedula = Convert.ToDecimal(txtCedula.Text),
                    carnet = Convert.ToDecimal(txtCarnet.Text),
                    nombre = txtNombre.Text,
                    id_carrera = cbCarrera.SelectedValue,
                    fecha_ingreso = calendar.SelectedDate,
                    foto = getFileStream(img),
                    curriculum_vitae = getFileStream(curriculum)
                };

                dbContext.Estudiantes.InsertOnSubmit(estudiante); //prepara la insercion del estudiante
                dbContext.SubmitChanges(); //inserta los estudiantes
                tbEstudiantes.DataBind(); //binds to datagrid
            }
        }

        protected void btnSubmitCarrera_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext()) //usa contexto de la base de datos de linq
            {

                Carrera carrera = new Carrera //crea una carrera con los datos de la interfaz
                {
                    id_carrera = txtCodigoCarrera.Text,
                    nombre = txtNombreCarrera.Text,
                    encargado = txtEncargado.Text,
                    ubicacion = txtUbicacion.Text
                };

                dbContext.Carreras.InsertOnSubmit(carrera); //inserta una carrera en la base
                dbContext.SubmitChanges(); //commit insert
                tbCarrera.DataBind(); //binds to datagrid
                cbCarrera.DataBind(); //binds to dropdownlist
            }
        }

        protected void cbCarrera2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext()) //usa contexto de la base de datos de linq
            {
                spEstudiantesCarrera.DataSource = dbContext.estudiantesDeCarrera(cbCarrera2.SelectedValue); //ejecuta sp estudiantesCarrera
                spEstudiantesCarrera.DataBind(); //binds to datagrid
            }
        }

    }
}