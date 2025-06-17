namespace KIOSCO_PRISCILA
{
    partial class frmMain
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
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kIOSCO_PriscilaDataSet = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSet();
            this.productosTableAdapter = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.TableAdapterManager();
            this.detallesVentaTableAdapter = new KIOSCO_PRISCILA.KIOSCO_PriscilaDataSetTableAdapters.DetallesVentaTableAdapter();
            this.btnVtas = new System.Windows.Forms.Button();
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kIOSCO_PriscilaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.kIOSCO_PriscilaDataSet;
            // 
            // kIOSCO_PriscilaDataSet
            // 
            this.kIOSCO_PriscilaDataSet.DataSetName = "KIOSCO_PriscilaDataSet";
            this.kIOSCO_PriscilaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnVtas
            // 
            this.btnVtas.Location = new System.Drawing.Point(393, 403);
            this.btnVtas.Name = "btnVtas";
            this.btnVtas.Size = new System.Drawing.Size(216, 48);
            this.btnVtas.TabIndex = 0;
            this.btnVtas.Text = "Nueva Venta";
            this.btnVtas.UseVisualStyleBackColor = true;
            this.btnVtas.Click += new System.EventHandler(this.btnVtas_Click);
            // 
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataMember = "FK__DetallesV__IDPro__3C69FB99";
            this.detallesVentaBindingSource.DataSource = this.productosBindingSource;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 494);
            this.Controls.Add(this.btnVtas);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kIOSCO_PriscilaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KIOSCO_PriscilaDataSet kIOSCO_PriscilaDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private KIOSCO_PriscilaDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private KIOSCO_PriscilaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KIOSCO_PriscilaDataSetTableAdapters.DetallesVentaTableAdapter detallesVentaTableAdapter;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource;
        private System.Windows.Forms.Button btnVtas;
    }
}

