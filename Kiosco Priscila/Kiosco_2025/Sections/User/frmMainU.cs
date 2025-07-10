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
        Decimal totalAcumulated;
        public frmMainU()
        {
            InitializeComponent();
        }

        private void frmMainU_Load(object sender, EventArgs e)
        {
            Procedures procedure = new Procedures();
            procedure.MostrarDatos("spu_mostrar_prods", productsTable, new List<string> { "ID", "Producto", "Precio Unitario"});


            cartTable.Columns.Add("ID", "ID");
            cartTable.Columns.Add("Producto", "Producto");
            cartTable.Columns.Add("Precio Unitario", "Precio Unitario");
            cartTable.Columns.Add("Cantidad", "Cantidad");
        }

        private void searchImg_Click(object sender, EventArgs e)
        {
            Procedures procedure = new Procedures();
            procedure.BuscarDatos("spu_buscarprod_nombre", productsTable, "@nombre_prod", searchProdInp.Text, new List<string> { "ID", "Producto", "Precio Unitario" });
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {
            if (productsTable.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar al carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Procedures procedures = new Procedures();
            if (!decimal.TryParse(cantInp.Text, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Productos productos = new Productos
                {
                    id_prod = Convert.ToInt32(productsTable.CurrentRow.Cells[0].Value),
                    descripcion = productsTable.CurrentRow.Cells[1].Value.ToString(),
                    precio_unitario = Convert.ToDecimal(productsTable.CurrentRow.Cells[2].Value)
                };
                totalAcumulated = procedures.Cart(cartTable, productos, null, 'A', cantidad, totalAcumulated, totalTxt);
            }
            procedures.LimpiarCampos(new List<TextBox> { cantInp });
        }

        private void deleteItemCartBtn_Click(object sender, EventArgs e)
        {
            if (cartTable.CurrentRow == null)
            {
                MessageBox.Show("No hay productos en el carrito para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var productSelected = cartTable.CurrentRow;
            Productos productos = new Productos
            {
                id_prod = Convert.ToInt32(cartTable.CurrentRow.Cells[0].Value),
                descripcion = cartTable.CurrentRow.Cells[1].Value.ToString(),
                precio_unitario = Convert.ToDecimal(cartTable.CurrentRow.Cells[2].Value)
            };
            Procedures procedure = new Procedures();
            totalAcumulated = procedure.Cart(cartTable, productos, productSelected, 'D', 0, totalAcumulated, totalTxt);
            procedure.LimpiarCampos(new List<TextBox> { cantInp });
        }
    }
}
