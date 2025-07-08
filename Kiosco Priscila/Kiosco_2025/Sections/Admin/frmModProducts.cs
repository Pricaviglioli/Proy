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
    public partial class frmModProducts : Form
    {
        public frmModProducts()
        {
            InitializeComponent();
        }

        private void frmModProducts_Load(object sender, EventArgs e)
        {
            Procedures procedure = new Procedures();
            procedure.MostrarDatos("spu_mostrar_prods", productsTable, new List<string> { "ID", "Producto", "Precio Unitario" });
        }

        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProdInp.Text = productsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            descprodInp.Text = productsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceInp.Text = productsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void modprodBtn_Click(object sender, EventArgs e)
        {
            Procedures procedures = new Procedures();
            Productos producto = new Productos();
            producto = procedures.ParseDataProd(producto, idProdInp.Text, descprodInp.Text, priceInp.Text);
            if (producto == null)
            {
                procedures.LimpiarCampos(new List<TextBox> { idProdInp, descprodInp, priceInp });
                return;
            }
            else
            {
                procedures.ActualizarDatos("spu_modificar_prod", new List<string> { "@id_prod", "@descripcion", "@precio_unitario" }, new List<object> { producto.id_prod, producto.descripcion, producto.precio_unitario });
            }
        }
    }
}
