using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistencia
{
    public partial class Form1 : Form
    {
        private List<clsRegistroAsistencia> Registros = new List<clsRegistroAsistencia> ();
        public Form1()
        {
            InitializeComponent();
            // Agregar las columnas al DataGridView
            dgvReportes.Columns.Add("NombreEstudiante", "Nombre Estudiante");
            dgvReportes.Columns.Add("NumeroIdentificacion", "Numero Identificación");
            dgvReportes.Columns.Add("Fecha", "Fecha");
            dgvReportes.Columns.Add("Asistencia", "Asistencia");

            // Modificar las propiedades de las columnas
            dgvReportes.Columns[0].Width = 150;
            dgvReportes.Columns[1].Width = 150;
            dgvReportes.Columns[2].Width = 180;
            dgvReportes.Columns[3].Width = 100;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo registro de asistencia con los datos ingresados
            clsRegistroAsistencia nuevoRegistro = new clsRegistroAsistencia(
                dtpFecha.Value,
                txtNombre.Text,
                chkAsistencia.Checked,
                int.Parse(txtIdentificacion.Text)
            );

            // Agregar el nuevo registro a la lista de registros
            Registros.Add(nuevoRegistro);

            // Agregar el nuevo registro al DataGridView
            dgvReportes.Rows.Add(nuevoRegistro.NombreEstudiante, nuevoRegistro.NumeroIdentificacion, nuevoRegistro.Fecha, nuevoRegistro.EstadoAsistencia ? "Sí" : "No");

            // Limpiar las cajas de texto
            txtNombre.Text = "";
            txtIdentificacion.Text = "";
        }
    }
}
