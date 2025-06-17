using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSCO_PRISCILA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kIOSCO_PriscilaDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.DetallesVenta' Puede moverla o quitarla según sea necesario.
            this.detallesVentaTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.DetallesVenta);
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.Productos);
        }

        private void btnVtas_Click(object sender, EventArgs e)
        {
            Form vta = new frmVentas();
            vta.ShowDialog();
        }
    }
}

