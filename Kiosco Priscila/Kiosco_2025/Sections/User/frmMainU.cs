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
        }

        private void searchImg_Click(object sender, EventArgs e)
        {
            Procedures procedure = new Procedures();
            procedure.BuscarDatos("spu_buscarprod_nombre", productsTable, "@nombre_prod", searchProdInp.Text, new List<string> { "ID", "Producto", "Precio Unitario" });
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {
            List<string> Atributos = new List<string> { "ID", "Producto", "Precio unitario" };
            Productos productos = new Productos
            {
                id_prod = Convert.ToInt32(productsTable.CurrentRow.Cells[0].Value),
                descripcion = productsTable.CurrentRow.Cells[1].Value.ToString(),
                precio_unitario = Convert.ToDecimal(productsTable.CurrentRow.Cells[2].Value)
            };
            Procedures procedure = new Procedures();
            procedure.Cart(cartTable, productos, Atributos);
            totalAcumulated += productos.precio_unitario;
            totalTxt.Text = "Total: $" + totalAcumulated.ToString();
        }

        private void deleteItemCartBtn_Click(object sender, EventArgs e)
        {
            var productSelected = cartTable.CurrentRow;
            cartTable.Rows.Remove(productSelected);
            totalAcumulated -= Decimal.Parse(cartTable.CurrentRow.Cells[2].Value.ToString());
            totalTxt.Text = "Total: $" + totalAcumulated.ToString();
        }
    }
}
