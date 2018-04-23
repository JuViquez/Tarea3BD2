using System;
using System.Collections.Generic;
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
            }
        }
    }
}