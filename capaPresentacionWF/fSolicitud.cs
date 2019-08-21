using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaEntidades;

namespace capaPresentacionWF
{
    public partial class fSolicitud : Form
    {
        logicaNegocioSolicitud logicaNS = new logicaNegocioSolicitud();
        logicaNegocioRecursos logicaRE = new logicaNegocioRecursos();
        logicaNegocioUsuarios logicaUS = new logicaNegocioUsuarios();

        public fSolicitud()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text=="Guardar")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = Convert.ToDateTime(dateTimePickerFechaSol.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechaUso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(dateTimePickerHoraInicio.Text);
                    objetoSolicitud.horafinal = Convert.ToDateTime(dateTimePickerHoraFinal.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;
                    objetoSolicitud.idrecursos = Convert.ToInt32(comboBoxIdRecursos.SelectedValue.ToString());
                    objetoSolicitud.idusuario = Convert.ToInt32(comboBoxIdUsuario.SelectedValue.ToString());

                    if (logicaNS.insertarSolicitud(objetoSolicitud) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechaSol.Text = "";
                        dateTimePickerFechaUso.Text = "";
                        dateTimePickerHoraInicio.Text = "";
                        dateTimePickerHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        comboBoxIdRecursos.Text = "";
                        comboBoxIdUsuario.Text = "";

                        tabSolicitud.SelectedTab = tabPage2;

                    }
                    else 
                    {
                        MessageBox.Show("Error al agregar solicitud");
                    }

                }

                if (buttonGuardar.Text=="Actualizar")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.idsolicitud = Convert.ToInt32(textBoxId.Text);
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = Convert.ToDateTime(dateTimePickerFechaSol.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechaUso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(dateTimePickerHoraInicio.Text);
                    objetoSolicitud.horafinal = Convert.ToDateTime(dateTimePickerHoraFinal.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;
                    objetoSolicitud.idrecursos = Convert.ToInt32(comboBoxIdRecursos.Text);
                    objetoSolicitud.idusuario = Convert.ToInt32(comboBoxIdUsuario.Text);

                    if (logicaNS.EditarSolicitud(objetoSolicitud)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechaSol.Text = "";
                        dateTimePickerFechaUso.Text = "";
                        dateTimePickerHoraInicio.Text = "";
                        dateTimePickerHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        comboBoxIdRecursos.Text = "";
                        comboBoxIdUsuario.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("ERROR AL ACTUALIZAR");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void fSolicitud_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            List<recursos> rcso = new List<recursos>();
            rcso = logicaRE.listarRecursos();
            List<Usuarios> usuar = new List<Usuarios>();
            usuar = logicaUS.listarUsuarios();
            comboBoxIdRecursos.ValueMember = "idrecursos";
            comboBoxIdRecursos.DisplayMember = "nombrer";
            comboBoxIdRecursos.DataSource = rcso;
            comboBoxIdUsuario.ValueMember = "idusuario";
            comboBoxIdUsuario.DisplayMember = "nombres";
            comboBoxIdUsuario.DataSource = usuar;
            dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;
            comboBoxIdRecursos.Visible = true;
            comboBoxIdRecursos.Enabled = false;
            labelidRec.Visible = true;
            comboBoxIdUsuario.Visible = true;
            comboBoxIdUsuario.Enabled = false;
            labelidUs.Visible = true;

            textBoxId.Text = dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString();
            textBoxAula.Text = dataGridViewSolicitud.CurrentRow.Cells["aula"].Value.ToString();
            textBoxNivel.Text = dataGridViewSolicitud.CurrentRow.Cells["nivel"].Value.ToString();
            dateTimePickerFechaSol.Text = dataGridViewSolicitud.CurrentRow.Cells["fechasolicitud"].Value.ToString();
            dateTimePickerFechaUso.Text = dataGridViewSolicitud.CurrentRow.Cells["fechauso"].Value.ToString();
            dateTimePickerHoraInicio.Text = dataGridViewSolicitud.CurrentRow.Cells["horainicio"].Value.ToString();
            dateTimePickerHoraFinal.Text = dataGridViewSolicitud.CurrentRow.Cells["horafinal"].Value.ToString();
            textBoxCarrera.Text = dataGridViewSolicitud.CurrentRow.Cells["carrera"].Value.ToString();
            textBoxAsignatura.Text = dataGridViewSolicitud.CurrentRow.Cells["asignatura"].Value.ToString();
            comboBoxIdRecursos.Text = dataGridViewSolicitud.CurrentRow.Cells["idrecursos"].Value.ToString();
            comboBoxIdUsuario.Text = dataGridViewSolicitud.CurrentRow.Cells["idusuario"].Value.ToString();

            tabSolicitud.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoSOL = Convert.ToInt32(dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString());
            try
            {
                if (logicaNS.eliminarSolicitud(codigoSOL)>0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                }
            }
            catch 
            {
                MessageBox.Show("Error al eliminar recurso");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Solicitud> listaSolicitud = logicaNS.BuscarSolicitud(textBoxBuscar.Text);
            dataGridViewSolicitud.DataSource = listaSolicitud;
        }
    }
}
