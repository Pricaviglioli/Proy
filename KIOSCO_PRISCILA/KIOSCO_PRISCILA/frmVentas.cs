using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSCO_PRISCILA
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kIOSCO_PriscilaDataSet);

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.DetallesVenta' Puede moverla o quitarla según sea necesario.
            this.detallesVentaTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.DetallesVenta);
            // TODO: esta línea de código carga datos en la tabla 'kIOSCO_PriscilaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.kIOSCO_PriscilaDataSet.Productos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iDVentaLabel1.Text = (Convert.ToInt32(iDVentaLabel1.Text) + 1).ToString();

            string query = "INSERT INTO DetallesVenta (IDVenta, IDProd, subtotal) VALUES (@idVenta, @idProd, @subtotal)";
            string conexionString = @"Data Source=eze\SQLEXPRESS;Initial Catalog=KIOSCO_Priscila;User ID=sa; Password=45505886; TrustServerCertificate=True";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                conexion.Open();  // Abrir conexión

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    cmd.Parameters.AddWithValue("@idProd", idProducto);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
