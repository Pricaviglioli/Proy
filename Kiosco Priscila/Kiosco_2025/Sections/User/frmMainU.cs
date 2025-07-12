using Kiosco_2025.Clases;
using Kiosco_2025.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        Procedures procedure = new Procedures();
        public frmMainU()
        {
            InitializeComponent();
        }

        private void frmMainU_Load(object sender, EventArgs e)
        {
            procedure.MostrarDatos("spu_mostrar_prods", productsTable, new List<string> { "ID", "Producto", "Precio Unitario"});


            cartTable.Columns.Add("ID", "ID");
            cartTable.Columns.Add("Producto", "Producto");
            cartTable.Columns.Add("Precio Unitario", "Precio Unitario");
            cartTable.Columns.Add("Cantidad", "Cantidad");
            cartTable.Columns.Add("Subtotal", "Subtotal");
        }

        private void searchImg_Click(object sender, EventArgs e)
        {
            procedure.BuscarDatos("spu_buscarprod_nombre", productsTable, "@nombre_prod", searchProdInp.Text, new List<string> { "ID", "Producto", "Precio Unitario" });
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {
            if (productsTable.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un producto para agregar al carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!decimal.TryParse(cantInp.Text, out decimal subtotal) || subtotal <= 0)
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
                totalAcumulated = procedure.Cart(cartTable, productos, null, 'A', int.Parse(cantInp.Text), subtotal , totalAcumulated, totalTxt);
            }
            procedure.LimpiarCampos(new List<TextBox> { cantInp });
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
            totalAcumulated = procedure.Cart(cartTable, productos, productSelected, 'D', 0, 0, totalAcumulated, totalTxt);
            procedure.LimpiarCampos(new List<TextBox> { cantInp });
        }

        private void realizarVtaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está seguro de que desea realizar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == MessageBox.Show("Está seguro de que desea realizar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (tipoPagoSelect == null || tipoPagoSelect.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    List<string> sqlParametersVTA = new List<string> { "@tipo_pago", "@total" };
                    List<object> parametrosVTA = new List<object> { tipoPagoSelect.SelectedItem.ToString(), totalAcumulated };
                    procedure.AgregarDatos("spu_registrar_vta", sqlParametersVTA, parametrosVTA);


                    SqlCommand cmd = new SqlCommand("SELECT MAX(id_vta) FROM venta", new Conexion().Connect());
                    var result = cmd.ExecuteScalar();
                    int lastID = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                    for (int i = 0; i < (cartTable.Rows.Count - 1); i++)
                    {
                        DataGridViewRow Product = cartTable.Rows[i];
                        List<string> sqlParametersVTAItem = new List<string> { "@id_vta", "@id_prod", "@cantidad", "@fecha", "@subtotal" };
                        List<object> parametrosVTAItem = new List<object>
                        {
                            lastID,
                            Product.Cells[0].Value,
                            Convert.ToDecimal(Product.Cells[3].Value),
                            DateTime.Now,
                            Convert.ToDecimal(Product.Cells[2].Value)
                        };
                        procedure.AgregarDatos("spu_registrar_detallevta", sqlParametersVTAItem, parametrosVTAItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Venta cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cartTable.Rows.Clear();
            tipoPagoSelect.SelectedIndex = -1;
            totalAcumulated = 0;
        }
    }
}
