namespace KIOSCO_PRISCILA
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDProdLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label iDLabel;
            this.kIOSCO_PriscilaDataSet = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.TableAdapterManager();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesVentaTableAdapter = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.DetallesVentaTableAdapter();
            this.iDProdComboBox = new System.Windows.Forms.ComboBox();
            this.subtotalLabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iDComboBox = new System.Windows.Forms.ComboBox();
            iDProdLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kIOSCO_PriscilaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // productosDataGridView
            // 
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.Size = new System.Drawing.Size(343, 225);
            this.productosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProd";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProd";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descriProd";
            this.dataGridViewTextBoxColumn2.HeaderText = "descriProd";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecioUnitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecioUnitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataMember = "DetallesVenta";
            this.detallesVentaBindingSource.DataSource = this.kIOSCO_PriscilaDataSet;
            // 
            // detallesVentaTableAdapter
            // 
            this.detallesVentaTableAdapter.ClearBeforeFill = true;
            // 
            // iDProdLabel
            // 
            iDProdLabel.AutoSize = true;
            iDProdLabel.Location = new System.Drawing.Point(12, 288);
            iDProdLabel.Name = "iDProdLabel";
            iDProdLabel.Size = new System.Drawing.Size(43, 13);
            iDProdLabel.TabIndex = 5;
            iDProdLabel.Text = "IDProd:";
            // 
            // iDProdComboBox
            // 
            this.iDProdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "IDProd", true));
            this.iDProdComboBox.FormattingEnabled = true;
            this.iDProdComboBox.Location = new System.Drawing.Point(61, 285);
            this.iDProdComboBox.Name = "iDProdComboBox";
            this.iDProdComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDProdComboBox.TabIndex = 6;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(16, 323);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(47, 13);
            subtotalLabel.TabIndex = 7;
            subtotalLabel.Text = "subtotal:";
            // 
            // subtotalLabel1
            // 
            this.subtotalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "subtotal", true));
            this.subtotalLabel1.Location = new System.Drawing.Point(69, 323);
            this.subtotalLabel1.Name = "subtotalLabel1";
            this.subtotalLabel1.Size = new System.Drawing.Size(100, 23);
            this.subtotalLabel1.TabIndex = 8;
            this.subtotalLabel1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(34, 261);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 9;
            iDLabel.Text = "ID:";
            // 
            // iDComboBox
            // 
            this.iDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "ID", true));
            this.iDComboBox.FormattingEnabled = true;
            this.iDComboBox.Location = new System.Drawing.Point(61, 258);
            this.iDComboBox.Name = "iDComboBox";
            this.iDComboBox.Size = new System.Drawing.Size(121, 21);
            this.iDComboBox.TabIndex = 10;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalLabel1);
            this.Controls.Add(iDProdLabel);
            this.Controls.Add(this.iDProdComboBox);
            this.Controls.Add(this.productosDataGridView);
            this.Name = "frmVentas";
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kIOSCO_PriscilaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KIOSCO_PriscilaDataSet kIOSCO_PriscilaDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private KIOSCO_PriscilaDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private KIOSCO_PriscilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private KIOSCO_PriscilaDataSetTableAdapters.DetallesVentaTableAdapter detallesVentaTableAdapter;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource;
        private System.Windows.Forms.ComboBox iDProdComboBox;
        private System.Windows.Forms.Label subtotalLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox iDComboBox;
    }
}