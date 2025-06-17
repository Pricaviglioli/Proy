namespace KIOSCO_PRISCILA
{
    partial class frmDetallesVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idProdLabel;
            System.Windows.Forms.Label precioUnitarioLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label tipoPagoLabel;
            this.kIOSCO_PriscilaDataSet = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.TableAdapterManager();
            this.detallesVentaTableAdapter = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.DetallesVentaTableAdapter();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductos = new System.Windows.Forms.Label();
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inpCantidad = new System.Windows.Forms.TextBox();
            this.txtIDProd = new System.Windows.Forms.Label();
            this.txtPrecioUniProd = new System.Windows.Forms.Label();
            this.txtDesciProd = new System.Windows.Forms.Label();
            this.txtSubtotalProd = new System.Windows.Forms.Label();
            this.btnVerSubTotal = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.IDProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarVta = new System.Windows.Forms.Button();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.VentasTableAdapter();
            this.inpTipoPago = new System.Windows.Forms.ComboBox();
            this.txtCarrito = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idProdLabel = new System.Windows.Forms.Label();
            precioUnitarioLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            tipoPagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kIOSCO_PriscilaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(34, 285);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(51, 13);
            cantidadLabel.TabIndex = 2;
            cantidadLabel.Text = "cantidad:";
            // 
            // idProdLabel
            // 
            idProdLabel.AutoSize = true;
            idProdLabel.Location = new System.Drawing.Point(39, 256);
            idProdLabel.Name = "idProdLabel";
            idProdLabel.Size = new System.Drawing.Size(43, 13);
            idProdLabel.TabIndex = 4;
            idProdLabel.Text = "id Prod:";
            // 
            // precioUnitarioLabel
            // 
            precioUnitarioLabel.AutoSize = true;
            precioUnitarioLabel.Location = new System.Drawing.Point(25, 318);
            precioUnitarioLabel.Name = "precioUnitarioLabel";
            precioUnitarioLabel.Size = new System.Drawing.Size(79, 13);
            precioUnitarioLabel.TabIndex = 6;
            precioUnitarioLabel.Text = "Precio Unitario:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(35, 341);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(47, 13);
            subtotalLabel.TabIndex = 9;
            subtotalLabel.Text = "subtotal:";
            // 
            // tipoPagoLabel
            // 
            tipoPagoLabel.AutoSize = true;
            tipoPagoLabel.Location = new System.Drawing.Point(26, 381);
            tipoPagoLabel.Name = "tipoPagoLabel";
            tipoPagoLabel.Size = new System.Drawing.Size(59, 13);
            tipoPagoLabel.TabIndex = 15;
            tipoPagoLabel.Text = "Tipo Pago:";
            // 
            // kIOSCO_PriscilaDataSet
            // 
            this.kIOSCO_PriscilaDataSet.DataSetName = "KIOSCO_PriscilaDataSet";
            this.kIOSCO_PriscilaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.kIOSCO_PriscilaDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DetallesVentaTableAdapter = this.detallesVentaTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.UpdateOrder = KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // detallesVentaTableAdapter
            // 
            this.detallesVentaTableAdapter.ClearBeforeFill = true;
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.Location = new System.Drawing.Point(24, 79);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.Size = new System.Drawing.Size(344, 147);
            this.productosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProd";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descriProd";
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecioUnitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // txtProductos
            // 
            this.txtProductos.AutoSize = true;
            this.txtProductos.Location = new System.Drawing.Point(79, 60);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(75, 13);
            this.txtProductos.TabIndex = 2;
            this.txtProductos.Text = "PRODUCTOS";
            // 
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataMember = "DetallesVenta";
            this.detallesVentaBindingSource.DataSource = this.kIOSCO_PriscilaDataSet;
            // 
            // inpCantidad
            // 
            this.inpCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "cantidad", true));
            this.inpCantidad.Location = new System.Drawing.Point(91, 282);
            this.inpCantidad.Name = "inpCantidad";
            this.inpCantidad.Size = new System.Drawing.Size(100, 20);
            this.inpCantidad.TabIndex = 3;
            // 
            // txtIDProd
            // 
            this.txtIDProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "idProd", true));
            this.txtIDProd.Location = new System.Drawing.Point(88, 256);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(100, 23);
            this.txtIDProd.TabIndex = 5;
            this.txtIDProd.Text = "label1";
            // 
            // txtPrecioUniProd
            // 
            this.txtPrecioUniProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "PrecioUnitario", true));
            this.txtPrecioUniProd.Location = new System.Drawing.Point(110, 318);
            this.txtPrecioUniProd.Name = "txtPrecioUniProd";
            this.txtPrecioUniProd.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioUniProd.TabIndex = 7;
            this.txtPrecioUniProd.Text = "label1";
            // 
            // txtDesciProd
            // 
            this.txtDesciProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "descriProd", true));
            this.txtDesciProd.Location = new System.Drawing.Point(149, 256);
            this.txtDesciProd.Name = "txtDesciProd";
            this.txtDesciProd.Size = new System.Drawing.Size(100, 23);
            this.txtDesciProd.TabIndex = 9;
            this.txtDesciProd.Text = "label1";
            // 
            // txtSubtotalProd
            // 
            this.txtSubtotalProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "subtotal", true));
            this.txtSubtotalProd.Location = new System.Drawing.Point(88, 341);
            this.txtSubtotalProd.Name = "txtSubtotalProd";
            this.txtSubtotalProd.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotalProd.TabIndex = 10;
            this.txtSubtotalProd.Text = "label1";
            // 
            // btnVerSubTotal
            // 
            this.btnVerSubTotal.Location = new System.Drawing.Point(152, 336);
            this.btnVerSubTotal.Name = "btnVerSubTotal";
            this.btnVerSubTotal.Size = new System.Drawing.Size(75, 23);
            this.btnVerSubTotal.TabIndex = 11;
            this.btnVerSubTotal.Text = "Ver subtotal";
            this.btnVerSubTotal.UseVisualStyleBackColor = true;
            this.btnVerSubTotal.Click += new System.EventHandler(this.btnVerSubTotal_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(79, 421);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 20);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Venta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.AllowUserToAddRows = false;
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProd,
            this.Prod,
            this.cant,
            this.PrecioUni,
            this.subtotal});
            this.dataGridViewCarrito.Location = new System.Drawing.Point(441, 79);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.ReadOnly = true;
            this.dataGridViewCarrito.Size = new System.Drawing.Size(546, 147);
            this.dataGridViewCarrito.TabIndex = 13;
            // 
            // IDProd
            // 
            this.IDProd.HeaderText = "ID";
            this.IDProd.Name = "IDProd";
            // 
            // Prod
            // 
            this.Prod.HeaderText = "PRODUCTO";
            this.Prod.Name = "Prod";
            // 
            // cant
            // 
            this.cant.HeaderText = "CANTIDAD";
            this.cant.Name = "cant";
            // 
            // PrecioUni
            // 
            this.PrecioUni.HeaderText = "PRECIO UNITARIO";
            this.PrecioUni.Name = "PrecioUni";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SUBTOTAL";
            this.subtotal.Name = "subtotal";
            // 
            // btnGenerarVta
            // 
            this.btnGenerarVta.Location = new System.Drawing.Point(412, 376);
            this.btnGenerarVta.Name = "btnGenerarVta";
            this.btnGenerarVta.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarVta.TabIndex = 14;
            this.btnGenerarVta.Text = "Generar Venta";
            this.btnGenerarVta.UseVisualStyleBackColor = true;
            this.btnGenerarVta.Click += new System.EventHandler(this.btnGenerarVta_Click);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.kIOSCO_PriscilaDataSet;
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // inpTipoPago
            // 
            this.inpTipoPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "TipoPago", true));
            this.inpTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpTipoPago.FormattingEnabled = true;
            this.inpTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.inpTipoPago.Location = new System.Drawing.Point(91, 378);
            this.inpTipoPago.Name = "inpTipoPago";
            this.inpTipoPago.Size = new System.Drawing.Size(121, 21);
            this.inpTipoPago.TabIndex = 16;
            // 
            // txtCarrito
            // 
            this.txtCarrito.AutoSize = true;
            this.txtCarrito.Location = new System.Drawing.Point(567, 55);
            this.txtCarrito.Name = "txtCarrito";
            this.txtCarrito.Size = new System.Drawing.Size(55, 13);
            this.txtCarrito.TabIndex = 17;
            this.txtCarrito.Text = "CARRITO";
            // 
            // frmDetallesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 516);
            this.Controls.Add(this.txtCarrito);
            this.Controls.Add(tipoPagoLabel);
            this.Controls.Add(this.inpTipoPago);
            this.Controls.Add(this.btnGenerarVta);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerSubTotal);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.txtSubtotalProd);
            this.Controls.Add(this.txtDesciProd);
            this.Controls.Add(precioUnitarioLabel);
            this.Controls.Add(this.txtPrecioUniProd);
            this.Controls.Add(idProdLabel);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.inpCantidad);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.productosDataGridView);
            this.Name = "frmDetallesVenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kIOSCO_PriscilaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KIOSCO_PriscilaDataSet kIOSCO_PriscilaDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private KIOSCO_PriscilaDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private KIOSCO_PriscilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.Label txtProductos;
        private KIOSCO_PriscilaDataSetTableAdapters.DetallesVentaTableAdapter detallesVentaTableAdapter;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource;
        private System.Windows.Forms.TextBox inpCantidad;
        private System.Windows.Forms.Label txtIDProd;
        private System.Windows.Forms.Label txtPrecioUniProd;
        private System.Windows.Forms.Label txtDesciProd;
        private System.Windows.Forms.Label txtSubtotalProd;
        private System.Windows.Forms.Button btnVerSubTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Button btnGenerarVta;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private KIOSCO_PriscilaDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private System.Windows.Forms.ComboBox inpTipoPago;
        private System.Windows.Forms.Label txtCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}

