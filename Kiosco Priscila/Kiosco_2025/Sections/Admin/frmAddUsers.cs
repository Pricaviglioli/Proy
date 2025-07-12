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
    public partial class frmAddUsers : Form
    {
        Procedures procedure = new Procedures();
        Clases.User user = new Clases.User();
        public frmAddUsers()
        {
            InitializeComponent();
        }

        private void frmAddUsers_Load(object sender, EventArgs e)
        {
            procedure.MostrarDatos("spu_mostrar_usuarios", usersTable, new List<string> { "ID", "Nombre de usuario", "Contraseña", "Rol" });
            idUserInp.Text = usersTable.Rows.Count.ToString();
        }

        private void usersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usernameInp.Text = usersTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            passwrdInp.Text = usersTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            roleInp.Text = usersTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            user = user.setUsuario(int.Parse(idUserInp.Text), usernameInp.Text, passwrdInp.Text, roleInp.Text);
            procedure.AgregarDatos("spu_agregar_user", new List<string> { "@id_usuario", "@username", "@password", "@rol" }, new List<object> { user.id_usuario, user.username, user.password, user.rol});
        }
    }
}
