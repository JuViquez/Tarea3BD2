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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private byte[] getFileStream(FileUpload fu)
        {
            int filelength = fu.PostedFile.ContentLength;
            byte[] file = new byte[filelength];
            fu.PostedFile.InputStream.Read(file, 0, filelength);
            return file;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {

                Estudiante estudiante = new Estudiante
                {
                    cedula = Convert.ToDecimal(txtCedula.Text),
                    carnet = Convert.ToDecimal(txtCarnet.Text),
                    nombre = txtNombre.Text,
                    id_carrera = null,
                    fecha_ingreso = calendar.SelectedDate,
                    foto = getFileStream(img),
                    curriculum_vitae = getFileStream(curriculum)
                };

                dbContext.Estudiantes.InsertOnSubmit(estudiante);
                dbContext.SubmitChanges();
                tbEstudiantes.DataBind();
            }
        }

        protected void tbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {

                Estudiante estudiante = (from est in dbContext.Estudiantes
                                         where est.cedula == Convert.ToDecimal(tbEstudiantes.SelectedRow.Cells[0].Text)
                                         select est).First();
                txtCedula.Text = estudiante.cedula.ToString();
                txtCarnet.Text = estudiante.carnet.ToString();
                txtNombre.Text = estudiante.nombre;
                cbCarrera.SelectedValue = estudiante.id_carrera;
                calendar.SelectedDate = estudiante.fecha_ingreso;
                foto.ImageUrl = GetImage(estudiante.foto.ToArray());
                
            }
        }
        public string GetImage(object img)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String((byte[])img);
        }

        public void onImg_upload(object sender, EventArgs e )
        {
            byte[] file = getFileStream(img);
            foto.ImageUrl = GetImage(file);
        }

        protected void LinqDataSource3_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {

        }

        protected void tbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}