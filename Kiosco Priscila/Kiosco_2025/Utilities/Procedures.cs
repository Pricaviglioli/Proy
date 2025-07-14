using Kiosco_2025.Clases;
using Kiosco_2025.Sections.Admin;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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


        public void getTableLastID(DataGridView table, TextBox txtbox)
        {
            int lastID = (table.NewRowIndex) - 1;
            txtbox.Text = (int.Parse(table.Rows[lastID].Cells[0].Value.ToString()) + 1).ToString();
        }


        public decimal Cart(DataGridView CartTable, Productos productos, DataGridViewRow productSelected, char state, int cantidad, decimal subtotal ,decimal precioTotal, Label totalTxt)
        {
            bool exists = false;
            for (int i = 0; i < CartTable.Rows.Count; i++)
            {
                if (CartTable.Rows[i].Cells[0].Value != null && productos.id_prod == int.Parse(CartTable.Rows[i].Cells[0].Value.ToString()))
                {
                    exists = true;
                    break;
                }
                else if (CartTable.Rows[i].Cells[i].Value == null)
                {
                    break;
                }
            }
            if (state == 'A' && !exists)
            {
                subtotal = productos.precio_unitario * cantidad;
                CartTable.Rows.Add(productos.id_prod, productos.descripcion, productos.precio_unitario, cantidad, subtotal);
                precioTotal += subtotal;
                totalTxt.Text = "Total: $" + precioTotal.ToString();
            }
            else if (state == 'A' && exists)
            {
                MessageBox.Show("El producto ya se encuentra en el carrito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (CartTable.CurrentRow.Cells[2].Value != null && CartTable.CurrentRow.Cells[4].Value != null)
                {
                    decimal cantidadEliminar = Convert.ToDecimal(CartTable.CurrentRow.Cells[4].Value);
                    subtotal = cantidadEliminar;
                    precioTotal -= subtotal;
                    CartTable.Rows.Remove(productSelected);
                    if (precioTotal < 0)
                        precioTotal = 0;
                    totalTxt.Text = "Total: $" + precioTotal.ToString();
                }
                else
                {
                    totalTxt.Text = "Total:";
                }
            }
            return precioTotal;
        }


        public void BuscarDatosV2(string procedureName, DataGridView tableName, List<string> sqlParameters, List<object> parameters, List<String> TitleLists)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(sqlParameters[i], parameters[i]);
                }
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



        public void openMDIContainers(Form formSelected, Form formPadre)
        {
            formSelected.MdiParent = formPadre;
            formSelected.TopLevel = false;
            formSelected.FormBorderStyle = FormBorderStyle.None;
            formSelected.Dock = DockStyle.Fill;
            formSelected.WindowState = FormWindowState.Normal;
            formSelected.Show();
        }


        public bool sequenceSearch(DataGridView table, TextBox txtbox)
        {
            for (int i = 0; i < (table.RowCount - 1); i++)
            {
                if (table.Rows[i].Cells[1].Value.ToString() == txtbox.Text)
                {
                    return true;
                }
            }
            return false;
        }


        public string Logincomparision(DataGridView usersTable, (string, string) userInputs, List<(string, string, string)> users)
        {
            for (int i = 0; i < (usersTable.RowCount - 1); i++)
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



public void LimpiarCampos(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }
}
