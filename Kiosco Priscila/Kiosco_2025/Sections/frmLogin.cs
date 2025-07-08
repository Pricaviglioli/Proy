using Kiosco_2025.Clases;
using Kiosco_2025.Utilities;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

namespace Kiosco_2025
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.Connect();
            Procedures procedure = new Procedures();
            procedure.MostrarDatos("spu_mostrar_usuarios", usersTable, new List<string> { "ID", "Nombre de usuario", "Contraseña", "Rol" });
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < usersTable.Columns.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(usersTable.Rows[0].Cells[i].Value);
            }
        }
    }
}
