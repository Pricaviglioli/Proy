using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosco_2025.Clases
{
    internal class Productos
    {
        public int id_prod;
        public string descripcion;
        public decimal precio_unitario;


        public Productos setProductos(string id, string nombre, string precio)
        {
            Productos producto = new Productos();
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
    }
}
