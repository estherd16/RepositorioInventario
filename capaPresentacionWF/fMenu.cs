using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacionWF
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void pictureBoxRecursos_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRecursos Recursosmenu = new fRecursos();
            Recursosmenu.Show();
        }

        private void pictureBoxUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            fUsuarios Usuariosmenu = new fUsuarios();
            Usuariosmenu.Show();
        }

        private void pictureBoxSolicitud_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSolicitud Solicitudmenu = new fSolicitud();
            Solicitudmenu.Show();
        }
    }
}
