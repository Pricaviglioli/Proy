namespace Kiosco_2025.Sections.Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.divVentas = new System.Windows.Forms.TableLayoutPanel();
            this.datePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.searchDateInitialTxt = new System.Windows.Forms.Label();
            this.tipoPagoSelect = new System.Windows.Forms.ComboBox();
            this.searchTipoPagoTxt = new System.Windows.Forms.Label();
            this.buscarProdTxt = new System.Windows.Forms.Label();
            this.searchProdInp = new System.Windows.Forms.TextBox();
            this.searchDateFinalTxt = new System.Windows.Forms.Label();
            this.datePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.tableVtas = new System.Windows.Forms.DataGridView();
            this.buscarbtn = new System.Windows.Forms.TableLayoutPanel();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.buscarTxt = new System.Windows.Forms.Label();
            this.dateFilterOpc = new System.Windows.Forms.CheckBox();
            this.divVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVtas)).BeginInit();
            this.buscarbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            this.SuspendLayout();
            // 
            // divVentas
            // 
            this.divVentas.ColumnCount = 9;
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.80882F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.19118F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.divVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.divVentas.Controls.Add(this.datePickerFinal, 7, 0);
            this.divVentas.Controls.Add(this.searchDateInitialTxt, 4, 0);
            this.divVentas.Controls.Add(this.tipoPagoSelect, 3, 0);
            this.divVentas.Controls.Add(this.searchTipoPagoTxt, 2, 0);
            this.divVentas.Controls.Add(this.buscarProdTxt, 0, 0);
            this.divVentas.Controls.Add(this.searchProdInp, 1, 0);
            this.divVentas.Controls.Add(this.searchDateFinalTxt, 6, 0);
            this.divVentas.Controls.Add(this.datePickerInitial, 5, 0);
            this.divVentas.Controls.Add(this.tableVtas, 0, 2);
            this.divVentas.Controls.Add(this.buscarbtn, 0, 1);
            this.divVentas.Controls.Add(this.dateFilterOpc, 8, 0);
            this.divVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divVentas.Location = new System.Drawing.Point(0, 0);
            this.divVentas.Name = "divVentas";
            this.divVentas.RowCount = 3;
            this.divVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.77419F));
            this.divVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.22581F));
            this.divVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 528F));
            this.divVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.divVentas.Size = new System.Drawing.Size(1104, 653);
            this.divVentas.TabIndex = 0;
            // 
            // datePickerFinal
            // 
            this.datePickerFinal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerFinal.Location = new System.Drawing.Point(917, 18);
            this.datePickerFinal.Name = "datePickerFinal";
            this.datePickerFinal.Size = new System.Drawing.Size(78, 21);
            this.datePickerFinal.TabIndex = 19;
            // 
            // searchDateInitialTxt
            // 
            this.searchDateInitialTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDateInitialTxt.AutoSize = true;
            this.searchDateInitialTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateInitialTxt.Location = new System.Drawing.Point(530, 8);
            this.searchDateInitialTxt.Name = "searchDateInitialTxt";
            this.searchDateInitialTxt.Size = new System.Drawing.Size(141, 42);
            this.searchDateInitialTxt.TabIndex = 16;
            this.searchDateInitialTxt.Text = "Buscar por fecha (inicio):";
            this.searchDateInitialTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoPagoSelect
            // 
            this.tipoPagoSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipoPagoSelect.FormattingEnabled = true;
            this.tipoPagoSelect.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.tipoPagoSelect.Location = new System.Drawing.Point(394, 18);
            this.tipoPagoSelect.Name = "tipoPagoSelect";
            this.tipoPagoSelect.Size = new System.Drawing.Size(126, 24);
            this.tipoPagoSelect.TabIndex = 15;
            // 
            // searchTipoPagoTxt
            // 
            this.searchTipoPagoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTipoPagoTxt.AutoSize = true;
            this.searchTipoPagoTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTipoPagoTxt.Location = new System.Drawing.Point(257, 8);
            this.searchTipoPagoTxt.Name = "searchTipoPagoTxt";
            this.searchTipoPagoTxt.Size = new System.Drawing.Size(126, 42);
            this.searchTipoPagoTxt.TabIndex = 10;
            this.searchTipoPagoTxt.Text = "Buscar por tipo de pago:";
            this.searchTipoPagoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buscarProdTxt
            // 
            this.buscarProdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscarProdTxt.AutoSize = true;
            this.buscarProdTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarProdTxt.Location = new System.Drawing.Point(37, 8);
            this.buscarProdTxt.Name = "buscarProdTxt";
            this.buscarProdTxt.Size = new System.Drawing.Size(91, 42);
            this.buscarProdTxt.TabIndex = 6;
            this.buscarProdTxt.Text = "Buscar por producto:";
            this.buscarProdTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchProdInp
            // 
            this.searchProdInp.AcceptsTab = true;
            this.searchProdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchProdInp.Location = new System.Drawing.Point(168, 18);
            this.searchProdInp.Name = "searchProdInp";
            this.searchProdInp.Size = new System.Drawing.Size(79, 21);
            this.searchProdInp.TabIndex = 3;
            // 
            // searchDateFinalTxt
            // 
            this.searchDateFinalTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchDateFinalTxt.AutoSize = true;
            this.searchDateFinalTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateFinalTxt.Location = new System.Drawing.Point(769, 8);
            this.searchDateFinalTxt.Name = "searchDateFinalTxt";
            this.searchDateFinalTxt.Size = new System.Drawing.Size(141, 42);
            this.searchDateFinalTxt.TabIndex = 17;
            this.searchDateFinalTxt.Text = "Buscar por fecha (final):";
            this.searchDateFinalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePickerInitial
            // 
            this.datePickerInitial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerInitial.Location = new System.Drawing.Point(682, 18);
            this.datePickerInitial.Name = "datePickerInitial";
            this.datePickerInitial.Size = new System.Drawing.Size(81, 21);
            this.datePickerInitial.TabIndex = 18;
            // 
            // tableVtas
            // 
            this.tableVtas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableVtas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tableVtas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divVentas.SetColumnSpan(this.tableVtas, 9);
            this.tableVtas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableVtas.Location = new System.Drawing.Point(3, 127);
            this.tableVtas.Name = "tableVtas";
            this.tableVtas.Size = new System.Drawing.Size(1098, 523);
            this.tableVtas.TabIndex = 20;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscarbtn.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.buscarbtn.ColumnCount = 2;
            this.divVentas.SetColumnSpan(this.buscarbtn, 9);
            this.buscarbtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.64486F));
            this.buscarbtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.35514F));
            this.buscarbtn.Controls.Add(this.searchImg, 1, 0);
            this.buscarbtn.Controls.Add(this.buscarTxt, 0, 0);
            this.buscarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarbtn.Location = new System.Drawing.Point(437, 73);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.RowCount = 1;
            this.buscarbtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buscarbtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.buscarbtn.Size = new System.Drawing.Size(230, 35);
            this.buscarbtn.TabIndex = 21;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // searchImg
            // 
            this.searchImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchImg.Image = ((System.Drawing.Image)(resources.GetObject("searchImg.Image")));
            this.searchImg.Location = new System.Drawing.Point(194, 4);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(32, 27);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchImg.TabIndex = 1;
            this.searchImg.TabStop = false;
            // 
            // buscarTxt
            // 
            this.buscarTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscarTxt.AutoSize = true;
            this.buscarTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarTxt.Location = new System.Drawing.Point(15, 5);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(161, 24);
            this.buscarTxt.TabIndex = 0;
            this.buscarTxt.Text = "Buscar venta/s";
            // 
            // dateFilterOpc
            // 
            this.dateFilterOpc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateFilterOpc.AutoSize = true;
            this.dateFilterOpc.Location = new System.Drawing.Point(1002, 19);
            this.dateFilterOpc.Name = "dateFilterOpc";
            this.dateFilterOpc.Size = new System.Drawing.Size(97, 20);
            this.dateFilterOpc.TabIndex = 22;
            this.dateFilterOpc.Text = "Filtrar x fecha";
            this.dateFilterOpc.UseVisualStyleBackColor = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 653);
            this.Controls.Add(this.divVentas);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas - Administrador";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.divVentas.ResumeLayout(false);
            this.divVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVtas)).EndInit();
            this.buscarbtn.ResumeLayout(false);
            this.buscarbtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel divVentas;
        private System.Windows.Forms.TextBox searchProdInp;
        private System.Windows.Forms.Label buscarProdTxt;
        private System.Windows.Forms.Label searchTipoPagoTxt;
        private System.Windows.Forms.Label searchDateInitialTxt;
        private System.Windows.Forms.ComboBox tipoPagoSelect;
        private System.Windows.Forms.Label searchDateFinalTxt;
        private System.Windows.Forms.DateTimePicker datePickerFinal;
        private System.Windows.Forms.DateTimePicker datePickerInitial;
        private System.Windows.Forms.DataGridView tableVtas;
        private System.Windows.Forms.TableLayoutPanel buscarbtn;
        private System.Windows.Forms.Label buscarTxt;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.CheckBox dateFilterOpc;
    }
}