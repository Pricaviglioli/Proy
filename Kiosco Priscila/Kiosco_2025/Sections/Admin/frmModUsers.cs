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
    public partial class frmModUsers : Form
    {
        Procedures procedure = new Procedures();
        Clases.User user = new Clases.User();
        public frmModUsers()
        {
            InitializeComponent();
        }

        private void frmModUsers_Load(object sender, EventArgs e)
        {
            procedure.MostrarDatos("spu_mostrar_usuarios", usersTable, new List<string> { "ID", "Nombre de usuario", "Contraseña", "Rol" });
        }

        private void usersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idUserInp.Text = usersTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            usernameInp.Text = usersTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            passwrdInp.Text = usersTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            roleInp.Text = usersTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void modUserBtn_Click(object sender, EventArgs e)
        {
            bool response = procedure.sequenceSearch(usersTable, usernameInp);
            if (response)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre de usuario", "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                procedure.LimpiarCampos(new List<TextBox> { idUserInp, usernameInp, passwrdInp });
                roleInp.SelectedItem = -1;
                return;
            }
            else
            {
                user = user.setUsuario(int.Parse(idUserInp.Text), usernameInp.Text, passwrdInp.Text, roleInp.Text);
                procedure.ActualizarDatos("spu_modificar_user", new List<string> { "@id_usuario", "@username", "@password", "@rol" }, new List<object> { user.id_usuario, user.username, user.password, user.rol });
                MessageBox.Show("Usuario modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
