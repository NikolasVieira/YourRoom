using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourRoom.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void hospedesF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospede frm = new frmHospede();
            frm.ShowDialog();
        }

        private void quartosF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuarto frm = new frmQuarto();
            frm.ShowDialog();
        }

        private void usuariosF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva frm = new frmReserva();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
