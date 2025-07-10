namespace Kiosco_2025.Sections.User
{
    partial class frmMainU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainU));
            this.divVtas = new System.Windows.Forms.TableLayoutPanel();
            this.cartImg = new System.Windows.Forms.PictureBox();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.deleteItemCartBtn = new System.Windows.Forms.Button();
            this.searchProdInp = new System.Windows.Forms.TextBox();
            this.buscarProdTxt = new System.Windows.Forms.Label();
            this.prodTxt = new System.Windows.Forms.Label();
            this.cartTable = new System.Windows.Forms.DataGridView();
            this.addCartBtn = new System.Windows.Forms.Button();
            this.searchImg = new System.Windows.Forms.PictureBox();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.realizarVtaBtn = new System.Windows.Forms.Button();
            this.totalTxt = new System.Windows.Forms.Label();
            this.tipoPagoSelect = new System.Windows.Forms.ComboBox();
            this.tipoPagoTxt = new System.Windows.Forms.Label();
            this.cantidadTxt = new System.Windows.Forms.Label();
            this.cantInp = new System.Windows.Forms.TextBox();
            this.carritoTxt = new System.Windows.Forms.Label();
            this.divVtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // divVtas
            // 
            this.divVtas.ColumnCount = 10;
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.43361F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.56639F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.divVtas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.divVtas.Controls.Add(this.cartImg, 4, 0);
            this.divVtas.Controls.Add(this.prodImg, 0, 0);
            this.divVtas.Controls.Add(this.deleteItemCartBtn, 1, 3);
            this.divVtas.Controls.Add(this.searchProdInp, 1, 1);
            this.divVtas.Controls.Add(this.buscarProdTxt, 0, 1);
            this.divVtas.Controls.Add(this.prodTxt, 1, 0);
            this.divVtas.Controls.Add(this.cartTable, 4, 1);
            this.divVtas.Controls.Add(this.addCartBtn, 0, 3);
            this.divVtas.Controls.Add(this.searchImg, 3, 1);
            this.divVtas.Controls.Add(this.productsTable, 0, 2);
            this.divVtas.Controls.Add(this.realizarVtaBtn, 9, 3);
            this.divVtas.Controls.Add(this.totalTxt, 7, 3);
            this.divVtas.Controls.Add(this.tipoPagoSelect, 6, 3);
            this.divVtas.Controls.Add(this.tipoPagoTxt, 4, 3);
            this.divVtas.Controls.Add(this.cantidadTxt, 2, 3);
            this.divVtas.Controls.Add(this.cantInp, 3, 3);
            this.divVtas.Controls.Add(this.carritoTxt, 6, 0);
            this.divVtas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divVtas.Location = new System.Drawing.Point(0, 0);
            this.divVtas.Name = "divVtas";
            this.divVtas.RowCount = 4;
            this.divVtas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.90062F));
            this.divVtas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.09938F));
            this.divVtas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.divVtas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.divVtas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.divVtas.Size = new System.Drawing.Size(1243, 592);
            this.divVtas.TabIndex = 0;
            // 
            // cartImg
            // 
            this.cartImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divVtas.SetColumnSpan(this.cartImg, 2);
            this.cartImg.Image = ((System.Drawing.Image)(resources.GetObject("cartImg.Image")));
            this.cartImg.Location = new System.Drawing.Point(857, 4);
            this.cartImg.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.cartImg.Name = "cartImg";
            this.cartImg.Size = new System.Drawing.Size(76, 82);
            this.cartImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartImg.TabIndex = 18;
            this.cartImg.TabStop = false;
            // 
            // prodImg
            // 
            this.prodImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodImg.Image = ((System.Drawing.Image)(resources.GetObject("prodImg.Image")));
            this.prodImg.Location = new System.Drawing.Point(150, 6);
            this.prodImg.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(76, 77);
            this.prodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodImg.TabIndex = 17;
            this.prodImg.TabStop = false;
            // 
            // deleteItemCartBtn
            // 
            this.deleteItemCartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteItemCartBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemCartBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.deleteItemCartBtn.Location = new System.Drawing.Point(358, 526);
            this.deleteItemCartBtn.Name = "deleteItemCartBtn";
            this.deleteItemCartBtn.Size = new System.Drawing.Size(204, 42);
            this.deleteItemCartBtn.TabIndex = 12;
            this.deleteItemCartBtn.Text = "Eliminar del carrito";
            this.deleteItemCartBtn.UseVisualStyleBackColor = true;
            this.deleteItemCartBtn.Click += new System.EventHandler(this.deleteItemCartBtn_Click);
            // 
            // searchProdInp
            // 
            this.searchProdInp.AcceptsTab = true;
            this.searchProdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divVtas.SetColumnSpan(this.searchProdInp, 2);
            this.searchProdInp.Location = new System.Drawing.Point(446, 115);
            this.searchProdInp.Name = "searchProdInp";
            this.searchProdInp.Size = new System.Drawing.Size(170, 21);
            this.searchProdInp.TabIndex = 2;
            // 
            // buscarProdTxt
            // 
            this.buscarProdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscarProdTxt.AutoSize = true;
            this.buscarProdTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarProdTxt.Location = new System.Drawing.Point(66, 110);
            this.buscarProdTxt.Name = "buscarProdTxt";
            this.buscarProdTxt.Size = new System.Drawing.Size(215, 30);
            this.buscarProdTxt.TabIndex = 5;
            this.buscarProdTxt.Text = "Buscar producto:";
            // 
            // prodTxt
            // 
            this.prodTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prodTxt.AutoSize = true;
            this.divVtas.SetColumnSpan(this.prodTxt, 3);
            this.prodTxt.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTxt.Location = new System.Drawing.Point(447, 16);
            this.prodTxt.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.prodTxt.Name = "prodTxt";
            this.prodTxt.Size = new System.Drawing.Size(256, 58);
            this.prodTxt.TabIndex = 0;
            this.prodTxt.Text = "Productos";
            this.prodTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartTable
            // 
            this.cartTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.cartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divVtas.SetColumnSpan(this.cartTable, 6);
            this.cartTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cartTable.Location = new System.Drawing.Point(817, 93);
            this.cartTable.Name = "cartTable";
            this.cartTable.RowHeadersWidth = 62;
            this.divVtas.SetRowSpan(this.cartTable, 2);
            this.cartTable.Size = new System.Drawing.Size(423, 406);
            this.cartTable.TabIndex = 4;
            // 
            // addCartBtn
            // 
            this.addCartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addCartBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCartBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addCartBtn.Location = new System.Drawing.Point(74, 526);
            this.addCartBtn.Name = "addCartBtn";
            this.addCartBtn.Size = new System.Drawing.Size(199, 42);
            this.addCartBtn.TabIndex = 7;
            this.addCartBtn.Text = "Agregar al carrito";
            this.addCartBtn.UseVisualStyleBackColor = true;
            this.addCartBtn.Click += new System.EventHandler(this.addCartBtn_Click);
            // 
            // searchImg
            // 
            this.searchImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchImg.Image = ((System.Drawing.Image)(resources.GetObject("searchImg.Image")));
            this.searchImg.Location = new System.Drawing.Point(741, 103);
            this.searchImg.Name = "searchImg";
            this.searchImg.Size = new System.Drawing.Size(47, 45);
            this.searchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchImg.TabIndex = 6;
            this.searchImg.TabStop = false;
            this.searchImg.Click += new System.EventHandler(this.searchImg_Click);
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToDeleteRows = false;
            this.productsTable.AllowUserToResizeColumns = false;
            this.productsTable.AllowUserToResizeRows = false;
            this.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.productsTable.BackgroundColor = System.Drawing.Color.LightCyan;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divVtas.SetColumnSpan(this.productsTable, 4);
            this.productsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productsTable.Location = new System.Drawing.Point(3, 164);
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.RowHeadersWidth = 62;
            this.productsTable.Size = new System.Drawing.Size(808, 335);
            this.productsTable.TabIndex = 3;
            // 
            // realizarVtaBtn
            // 
            this.realizarVtaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.realizarVtaBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realizarVtaBtn.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.realizarVtaBtn.Location = new System.Drawing.Point(1134, 527);
            this.realizarVtaBtn.Name = "realizarVtaBtn";
            this.realizarVtaBtn.Size = new System.Drawing.Size(105, 40);
            this.realizarVtaBtn.TabIndex = 13;
            this.realizarVtaBtn.Text = "Facturar";
            this.realizarVtaBtn.UseVisualStyleBackColor = true;
            this.realizarVtaBtn.Click += new System.EventHandler(this.realizarVtaBtn_Click);
            // 
            // totalTxt
            // 
            this.totalTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalTxt.AutoSize = true;
            this.divVtas.SetColumnSpan(this.totalTxt, 2);
            this.totalTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.Location = new System.Drawing.Point(1052, 536);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(58, 22);
            this.totalTxt.TabIndex = 15;
            this.totalTxt.Text = "Total:";
            this.totalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoPagoSelect
            // 
            this.tipoPagoSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipoPagoSelect.FormattingEnabled = true;
            this.tipoPagoSelect.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia"});
            this.tipoPagoSelect.Location = new System.Drawing.Point(950, 536);
            this.tipoPagoSelect.Name = "tipoPagoSelect";
            this.tipoPagoSelect.Size = new System.Drawing.Size(77, 24);
            this.tipoPagoSelect.TabIndex = 14;
            // 
            // tipoPagoTxt
            // 
            this.tipoPagoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipoPagoTxt.AutoSize = true;
            this.divVtas.SetColumnSpan(this.tipoPagoTxt, 2);
            this.tipoPagoTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPagoTxt.Location = new System.Drawing.Point(829, 536);
            this.tipoPagoTxt.Name = "tipoPagoTxt";
            this.tipoPagoTxt.Size = new System.Drawing.Size(103, 21);
            this.tipoPagoTxt.TabIndex = 11;
            this.tipoPagoTxt.Text = "Abona con:";
            this.tipoPagoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cantidadTxt
            // 
            this.cantidadTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cantidadTxt.AutoSize = true;
            this.cantidadTxt.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTxt.Location = new System.Drawing.Point(604, 537);
            this.cantidadTxt.Name = "cantidadTxt";
            this.cantidadTxt.Size = new System.Drawing.Size(81, 19);
            this.cantidadTxt.TabIndex = 19;
            this.cantidadTxt.Text = "Cantidad:";
            // 
            // cantInp
            // 
            this.cantInp.AcceptsTab = true;
            this.cantInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cantInp.Location = new System.Drawing.Point(718, 536);
            this.cantInp.Name = "cantInp";
            this.cantInp.Size = new System.Drawing.Size(93, 21);
            this.cantInp.TabIndex = 20;
            // 
            // carritoTxt
            // 
            this.carritoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carritoTxt.AutoSize = true;
            this.divVtas.SetColumnSpan(this.carritoTxt, 4);
            this.carritoTxt.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carritoTxt.Location = new System.Drawing.Point(1006, 22);
            this.carritoTxt.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.carritoTxt.Name = "carritoTxt";
            this.carritoTxt.Size = new System.Drawing.Size(147, 45);
            this.carritoTxt.TabIndex = 10;
            this.carritoTxt.Text = "Carrito";
            this.carritoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMainU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1243, 592);
            this.Controls.Add(this.divVtas);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMainU_Load);
            this.divVtas.ResumeLayout(false);
            this.divVtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel divVtas;
        private System.Windows.Forms.Label prodTxt;
        private System.Windows.Forms.TextBox searchProdInp;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.DataGridView cartTable;
        private System.Windows.Forms.Label buscarProdTxt;
        private System.Windows.Forms.PictureBox searchImg;
        private System.Windows.Forms.Button addCartBtn;
        private System.Windows.Forms.Label carritoTxt;
        private System.Windows.Forms.Label tipoPagoTxt;
        private System.Windows.Forms.Button realizarVtaBtn;
        private System.Windows.Forms.ComboBox tipoPagoSelect;
        private System.Windows.Forms.Label totalTxt;
        private System.Windows.Forms.PictureBox cartImg;
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.Button deleteItemCartBtn;
        private System.Windows.Forms.Label cantidadTxt;
        private System.Windows.Forms.TextBox cantInp;
    }
}