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
    public partial class frmDelUsers : Form
    {
        Procedures procedure = new Procedures();
        Clases.User user = new Clases.User();
        public frmDelUsers()
        {
            InitializeComponent();
        }

        private void frmDelUsers_Load(object sender, EventArgs e)
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

        private void delUserBtn_Click(object sender, EventArgs e)
        {
            user = user.setUsuario(int.Parse(idUserInp.Text), usernameInp.Text, passwrdInp.Text, roleInp.Text);
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                procedure.EliminarDatos("spu_eliminar_user", new List<string> { "@id_usuario" }, new List<object> { user.id_usuario });
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
