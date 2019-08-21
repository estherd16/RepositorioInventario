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
    public partial class fUsuarios : Form
    {
        logicaNegocioUsuarios logicaNUS = new logicaNegocioUsuarios();
        public fUsuarios()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text=="Guardar")
                {
                    Usuarios objetoUsuarios = new Usuarios();
                    objetoUsuarios.cedula = textBoxcedulauser.Text;
                    objetoUsuarios.nombres = textBoxNombreUser.Text;
                    objetoUsuarios.apellidos = textBoxApellidosUser.Text;
                    objetoUsuarios.email = textBoxCorreoUser.Text;
                    objetoUsuarios.telefono = textBoxTelefonoUser.Text;

                    if (logicaNUS.insertarUsuarios(objetoUsuarios)>0)
	                {
		                MessageBox.Show("Agregado con éxito");
                        dataGridViewUsuarios.DataSource = logicaNUS.listarUsuarios();
                        textBoxcedulauser.Text = "";
                        textBoxNombreUser.Text= "";
                        textBoxApellidosUser.Text= "";
                        textBoxCorreoUser.Text= "";
                        textBoxTelefonoUser.Text= "";

	                }
                    else
                    {
                        MessageBox.Show("Error al agregar Usuario");
                    }
                     
                      
                }

                if (buttonGuardar.Text == "Actualizar")
                {
                    Usuarios objetoUsuarios = new Usuarios();
                    objetoUsuarios.idusuario = Convert.ToInt32(textBoxId.Text);
                    objetoUsuarios.cedula = textBoxcedulauser.Text;
                    objetoUsuarios.nombres = textBoxNombreUser.Text;
                    objetoUsuarios.apellidos = textBoxApellidosUser.Text;
                    objetoUsuarios.email=textBoxCorreoUser.Text;
                    objetoUsuarios.telefono=textBoxTelefonoUser.Text;


                    if (logicaNUS.EditarUsuarios(objetoUsuarios)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewUsuarios.DataSource = logicaNUS.listarUsuarios();
                        textBoxcedulauser.Text = "";
                        textBoxNombreUser.Text= "";
                        textBoxApellidosUser.Text= "";
                        textBoxCorreoUser.Text= "";
                        textBoxTelefonoUser.Text= "";
                        tabUsuarios.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void fUsuarios_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewUsuarios.DataSource = logicaNUS.listarUsuarios();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;
            textBoxId.Text = dataGridViewUsuarios.CurrentRow.Cells["idusuario"].Value.ToString();
            textBoxcedulauser.Text = dataGridViewUsuarios.CurrentRow.Cells["cedula"].Value.ToString();
            textBoxNombreUser.Text = dataGridViewUsuarios.CurrentRow.Cells["nombres"].Value.ToString();
            textBoxApellidosUser.Text = dataGridViewUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
            textBoxCorreoUser.Text= dataGridViewUsuarios.CurrentRow.Cells["email"].Value.ToString();
            textBoxTelefonoUser.Text = dataGridViewUsuarios.CurrentRow.Cells["telefono"].Value.ToString();
            tabUsuarios.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoUS = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells["idusuario"].Value.ToString());
            try
            {
                if (logicaNUS.eliminarUsuarios(codigoUS)>0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewUsuarios.DataSource = logicaNUS.listarUsuarios();
                }
            }
            catch 
            {
                MessageBox.Show("ERROR al eliminar usuario");
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Usuarios> listaUsuarios = logicaNUS.BuscarUsuarios(textBoxBuscar.Text);
            dataGridViewUsuarios.DataSource = listaUsuarios;
        }
        }
    }

