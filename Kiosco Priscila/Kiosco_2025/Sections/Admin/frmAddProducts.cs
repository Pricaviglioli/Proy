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
    public partial class frmAddProducts : Form
    {
        Procedures procedure = new Procedures();
        Productos producto = new Productos();
        public frmAddProducts()
        {
            InitializeComponent();
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            procedure.MostrarDatos("spu_mostrar_prods", productsTable, new List<string> { "ID", "Producto", "Precio Unitario" });
            idProdInp.Text = productsTable.Rows.Count.ToString();
        }

        private void productsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            descprodInp.Text = productsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceInp.Text = productsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void addprodBtn_Click(object sender, EventArgs e)
        {
            producto = producto.setProductos(idProdInp.Text, descprodInp.Text, priceInp.Text);
            if (producto == null)
            {
                procedure.LimpiarCampos(new List<TextBox> { idProdInp, descprodInp, priceInp });
                return;
            }
            else
            {
                procedure.AgregarDatos("spu_agregar_prod", new List<string> { "@id_prod", "@descripcion", "@precio_unitario" }, new List<object> { producto.id_prod, producto.descripcion, producto.precio_unitario });
            }
        }
    }
}
