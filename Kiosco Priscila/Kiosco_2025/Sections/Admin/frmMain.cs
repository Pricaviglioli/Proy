using Kiosco_2025.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco_2025.Sections.Admin
{
    public partial class frmMain : Form
    {
        Procedures procedures = new Procedures();
        public frmMain()
        {
            InitializeComponent();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures.openMDIContainers(new frmAddProducts(), this);
        }

        private void eliminarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures.openMDIContainers(new frmDeleteProducts(), this);
        }

        private void modificarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures.openMDIContainers(new frmModProducts(), this);
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures.openMDIContainers(new frmAddUsers(), this);
        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures.openMDIContainers(new frmDelUsers(), this);
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures.openMDIContainers(new frmModUsers(), this);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            procedures.openMDIContainers(new frmVentas(), this);
        }
    }
}
