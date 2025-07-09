using Kiosco_2025.Clases;
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

namespace Kiosco_2025.Sections.User
{
    public partial class frmMainU : Form
    {
        public frmMainU()
        {
            InitializeComponent();
        }

        private void frmMainU_Load(object sender, EventArgs e)
        {
            Procedures procedure = new Procedures();
            procedure.MostrarDatos("spu_mostrar_prods", productsTable, new List<string> { "ID", "Producto", "Precio Unitario"});
        }

        private void searchImg_Click(object sender, EventArgs e)
        {
            Procedures procedure = new Procedures();
            procedure.BuscarDatos("spu_buscarprod_nombre", productsTable, "@nombre_prod", searchProdInp.Text, new List<string> { "ID", "Producto", "Precio Unitario" });
        }

        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<object> selectedProduct = new List<object>();
            Productos productos = new Productos();
            for (int i = 0; i < productsTable.Columns.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(productsTable.Rows[e.RowIndex].Cells[i].Value);
            }
        }
    }
}
