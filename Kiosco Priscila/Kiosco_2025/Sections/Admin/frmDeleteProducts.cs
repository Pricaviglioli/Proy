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

namespace Kiosco_2025.Sections.Admin
{
    public partial class frmDeleteProducts : Form
    {
        Procedures procedure = new Procedures();
        Productos producto = new Productos();
        public frmDeleteProducts()
        {
            InitializeComponent();
        }

        private void frmDeleteProducts_Load(object sender, EventArgs e)
        {
            procedure.MostrarDatos("mostrar_prod_eliminables", productsTable, new List<string> { "ID", "Producto", "Precio Unitario" });
        }

        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProdInp.Text = productsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            descprodInp.Text = productsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceInp.Text = productsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void delprodBtn_Click(object sender, EventArgs e)
        {
            producto = producto.setProductos(idProdInp.Text, descprodInp.Text, priceInp.Text);
            if (producto == null)
            {
                procedure.LimpiarCampos(new List<TextBox> { idProdInp, descprodInp, priceInp });
                return;
            }
            else
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    procedure.EliminarDatos("spu_eliminar_prod", new List<string> { "@id_prod" }, new List<object> { producto.id_prod });
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
