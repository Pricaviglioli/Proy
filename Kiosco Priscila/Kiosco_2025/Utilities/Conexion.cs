using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco_2025.Utilities
{
    internal class Conexion
    {
        private SqlConnection connection = new SqlConnection("Data Source=EZE\\SQLEXPRESS;Initial Catalog=KIOSCO_2025;User ID=sa;Password=45505886");
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr;

        public SqlConnection Connect()
        {
            try
            {
                connection.Open();
                cmd.Connection = connection;
                MessageBox.Show("Conexión exitosa a la base de datos.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
