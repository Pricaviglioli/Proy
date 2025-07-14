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
    public partial class frmVentas : Form
    {
        Procedures procedures = new Procedures();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            procedures.MostrarDatos("spu_mostrar_vtas", tableVtas, new List<string> { "ID (Venta)", "Producto", "Cantidad", "Subtotal", "ID (Detalle)", "Fecha", "Pagó con", "Total" });
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            object pagoParam = null;
            if (tipoPagoSelect.SelectedIndex != -1)
                pagoParam = tipoPagoSelect.SelectedItem.ToString();

            var parametros = new List<object>
            {
                dateFilterOpc.Checked ? (object)datePickerInitial.Value.Date : null,
                dateFilterOpc.Checked ? (object)datePickerFinal.Value.Date   : null,
                string.IsNullOrWhiteSpace(searchProdInp.Text) ? null : (object)searchProdInp.Text,
                pagoParam,
            };

            procedures.BuscarDatosV2(
                "spu_buscar_ventas",
                tableVtas,
                new List<string> { "@fecha_inicio", "@fecha_fin", "@descripcion", "@tipo_pago" },
                parametros,
                new List<string> { "ID (Venta)", "Pagó con", "Total", "ID (Detalle venta)", "Fecha", "Producto", "Cantidad", "Subtotal" }
            );
        }

        //procedures.BuscarDatosV2("spu_buscar_ventas", tableVtas, new List<string> { "@fecha_inicio", "@fecha_fin", "@descripcion", "@tipo_pago" }, new List<string> { null, null, searchProdInp.Text, tipoPagoSelect.SelectedIndex.ToString() }, new List<String> { "ID (Venta)", "Pagó con", "Total", "ID (Detalle venta)", "Fecha", "Producto", "Cantidad", "Subtotal" });
    }
}
