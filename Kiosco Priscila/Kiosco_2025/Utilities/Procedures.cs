using Kiosco_2025.Clases;
using Kiosco_2025.Sections.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco_2025.Utilities
{
    internal class Procedures
    {
        public void MostrarDatos(string procedureName, DataGridView tableName, List<String> TitleLists)
        {
            var da = new SqlDataAdapter(procedureName, new Conexion().Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            var dt = new DataTable();
            da.Fill(dt);
            tableName.DataSource = dt;
            foreach (DataGridViewColumn column in tableName.Columns)
            {
                tableName.Columns[column.Index].HeaderText = TitleLists[column.Index];
            }
        }


        public void BuscarDatos(string procedureName, DataGridView tableName, string sqlParameter, string parameter, List<String> TitleLists)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(sqlParameter, parameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableName.DataSource = dt;
                foreach (DataGridViewColumn column in tableName.Columns)
                {
                    tableName.Columns[column.Index].HeaderText = TitleLists[column.Index];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AgregarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
                }
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("ID ya existente. Por favor, verifique los datos ingresados.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 547:
                        MessageBox.Show("ID no encontrado, porfavor ingrese un ID existente", "Error de referencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Ocurrió un error al agregar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void EliminarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlParameters.Count; i++)
            {
                cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
            }
            cmd.ExecuteNonQuery();
        }

        public void ActualizarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
                }
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("ID ya existente. Por favor, verifique los datos ingresados.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 547:
                        MessageBox.Show("ID no encontrado, porfavor ingrese un ID existente", "Error de referencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Ocurrió un error al agregar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Cart(DataGridView CartTable, Productos productos, List<string> Atributos)
        {
            for (int i = 0; i < Atributos.Count; i++)
            {
                CartTable.Columns.Add(Atributos[i], Atributos[i]);
            }
            CartTable.Rows.Add(productos.id_prod, productos.descripcion, productos.precio_unitario);
        }


        public void openMDIContainers(Form formSelected, Form formPadre)
        {
            formSelected.MdiParent = formPadre;
            formSelected.TopLevel = false;
            formSelected.FormBorderStyle = FormBorderStyle.None;
            formSelected.Dock = DockStyle.Fill;
            formSelected.WindowState = FormWindowState.Normal;
            formSelected.Show();
        }


        public string Logincomparision(DataGridView usersTable, (string, string) userInputs, List<(string, string, string)> users)
        {
            for (int i = 0; i < usersTable.ColumnCount; i++)
            {
                users.Add((usersTable.Rows[i].Cells[1].Value.ToString(), usersTable.Rows[i].Cells[2].Value.ToString(), usersTable.Rows[i].Cells[3].Value.ToString()));
            }
            for (int i = 0; i < users.Count; i++)
            {
                if (userInputs.Item1 == users[i].Item1 && userInputs.Item2 == users[i].Item2)
                {
                    if (users[i].Item3 == "Administrador")
                    {
                        return "Administrador";
                    }
                    else if (users[i].Item3 == "Usuario")
                    {
                        return "Usuario";
                    }
                }
            }
            return null;
        }



        public Productos ParseDataProd(Productos producto, string id, string nombre, string precio)
        {
            if (!int.TryParse(id, out int idProd) || !decimal.TryParse(precio, out decimal precioUnitario))
            {
                MessageBox.Show("Error al parsear los datos del producto. Por favor, verifique los valores ingresados.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
            {
                producto.id_prod = idProd;
                producto.descripcion = nombre;
                producto.precio_unitario = precioUnitario;
                return producto;
            }
        }


        public void LimpiarCampos(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }
}
