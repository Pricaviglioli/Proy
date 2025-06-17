using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSCO_PRISCILA
{
    public partial class frmDetallesVenta : Form
    {
        private SqlConnection conn;
        public frmDetallesVenta()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["KIOSCO_PRISCILA.Properties.Settings.KIOSCO_PriscilaConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            conn.Open(); // Abrirla una vez
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kIOSCO_PriscilaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.DetallesVenta' Puede moverla o quitarla según sea necesario.
            this.detallesVentaTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.DetallesVenta);
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.DetallesVenta' Puede moverla o quitarla según sea necesario.
            this.detallesVentaTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.DetallesVenta);
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.Productos);

        }

        private void btnGenerarVta_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarrito.Rows.Count == 0 || dataGridViewCarrito.Rows[0].IsNewRow)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            int totalVenta = 0;

            foreach (DataGridViewRow fila in dataGridViewCarrito.Rows)
            {
                if (!fila.IsNewRow)
                    totalVenta += Convert.ToInt32(fila.Cells["Subtotal"].Value);
            }

            int idVentaGenerada = 0;

            // Insertar en VENTAS
            SqlCommand cmdVenta = new SqlCommand(@"
                INSERT INTO Ventas (fechaVta, totalVta, TipoPago)
                VALUES (@fecha, @total, @pago);
                SELECT SCOPE_IDENTITY();", conn);

            cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now.Date);
            cmdVenta.Parameters.AddWithValue("@total", totalVenta);
            cmdVenta.Parameters.AddWithValue("@pago", inpTipoPago.Text);

            idVentaGenerada = Convert.ToInt32(cmdVenta.ExecuteScalar());

            // Insertar en DETALLESVENTA
            foreach (DataGridViewRow fila in dataGridViewCarrito.Rows)
            {
                if (!fila.IsNewRow)
                {
                    int idProd = Convert.ToInt32(fila.Cells["IDProd"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["cant"].Value);
                    int subtotal = Convert.ToInt32(fila.Cells["subtotal"].Value);

                    SqlCommand cmdDetalle = new SqlCommand(@"
                        INSERT INTO DetallesVenta (IDVenta, IDProd, cantidad, subtotal)
                        VALUES (@idVenta, @idProd, @cantidad, @subtotal);", conn);

                    cmdDetalle.Parameters.AddWithValue("@idVenta", idVentaGenerada);
                    cmdDetalle.Parameters.AddWithValue("@idProd", idProd);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdDetalle.Parameters.AddWithValue("@subtotal", subtotal);

                    cmdDetalle.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Venta guardada con éxito. ID: " + idVentaGenerada);
            dataGridViewCarrito.Rows.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(txtIDProd.Text);
            string nombre = txtIDProd.Text;
            int cantidad = Convert.ToInt32(inpCantidad.Text);
            int precio = Convert.ToInt32(txtPrecioUniProd.Text);
            int subtotal = cantidad * precio;

            dataGridViewCarrito.Rows.Add(idProducto, nombre, cantidad, precio, subtotal);
        }

        private void btnVerSubTotal_Click(object sender, EventArgs e)
        {
            txtSubtotalProd.Text = Convert.ToString(Convert.ToInt32(txtPrecioUniProd.Text) * Convert.ToInt32(inpCantidad.Text)) + " $";
            int idprod = Convert.ToInt32(txtIDProd.Text);
            string PRODUCTO = Convert.ToString(txtDesciProd.Text);
            System.Diagnostics.Debug.WriteLine("ID Producto: " + idprod);
            System.Diagnostics.Debug.WriteLine("Producto: " + PRODUCTO);
            System.Diagnostics.Debug.WriteLine("Cantidad: " + inpCantidad.Text);
            System.Diagnostics.Debug.WriteLine("Precio Unitario: " + txtPrecioUniProd.Text);
            System.Diagnostics.Debug.WriteLine("Subtotal: " + txtSubtotalProd.Text);
            System.Diagnostics.Debug.WriteLine("Tipo de Pago: " + inpTipoPago.Text);
        }
    }
}
