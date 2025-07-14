using Kiosco_2025.Clases;
using Kiosco_2025.Utilities;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
        Procedures procedure = new Procedures();
        Productos producto = new Productos();
        public frmModProducts()
        {
            InitializeComponent();
        }

        private void frmModProducts_Load(object sender, EventArgs e)
        {
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
            bool response = procedure.sequenceSearch(productsTable, descprodInp);
            producto = producto.setProductos(idProdInp.Text, descprodInp.Text, priceInp.Text);
            if (producto == null || response)
            {
                MessageBox.Show("Ya existe un producto con ese nombre", "Producto existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                procedure.LimpiarCampos(new List<TextBox> { idProdInp, descprodInp, priceInp });
                return;
            }
            else
            {
                procedure.ActualizarDatos("spu_modificar_prod", new List<string> { "@id_prod", "@descripcion", "@precio_unitario" }, new List<object> { producto.id_prod, producto.descripcion, producto.precio_unitario });
                MessageBox.Show("Producto modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
