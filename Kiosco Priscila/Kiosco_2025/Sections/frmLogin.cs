using Kiosco_2025.Clases;
using Kiosco_2025.Sections.Admin;
using Kiosco_2025.Sections.User;
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
            var userInps = (userInp.Text, passwrdInp.Text);
            var users = new List<(string, string, string)>();
            Procedures procedures = new Procedures();
            string response = procedures.Logincomparision(usersTable, userInps, users);
            if (response == "Administrador")
            {
                frmMain main = new frmMain();
                main.ShowDialog();
            }
            else if (response == "Usuario")
            {
                frmMainU main = new frmMainU();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente nuevamente.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                procedures.LimpiarCampos(new List<TextBox> { userInp, passwrdInp });
            }
        }
    }
}
