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
    public partial class frmVentas : Form
    {
        Procedures procedures = new Procedures();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            procedures.MostrarDatos("spu_mostrar_vtas", tableVtas, new List<string> { "ID (Venta)", "Producto", "Cantidad", "Subtotal", "ID (Detalle)", "Fecha", "Pagó con", "Total" });
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
        }
    }
}
