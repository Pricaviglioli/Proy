namespace Kiosco_2025.Sections.Admin
{
    partial class frmDeleteProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteProducts));
            this.divModProds = new System.Windows.Forms.TableLayoutPanel();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.idProdInp = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.Label();
            this.descprodInp = new System.Windows.Forms.TextBox();
            this.priceInp = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.Label();
            this.idprodTxt = new System.Windows.Forms.Label();
            this.delprodBtn = new System.Windows.Forms.Button();
            this.idprodImg = new System.Windows.Forms.PictureBox();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.priceImg = new System.Windows.Forms.PictureBox();
            this.divModProds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idprodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceImg)).BeginInit();
            this.SuspendLayout();
            // 
            // divModProds
            // 
            this.divModProds.ColumnCount = 8;
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36426F));
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.63574F));
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.divModProds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.divModProds.Controls.Add(this.productsTable, 1, 0);
            this.divModProds.Controls.Add(this.idProdInp, 4, 1);
            this.divModProds.Controls.Add(this.descTxt, 2, 2);
            this.divModProds.Controls.Add(this.descprodInp, 4, 2);
            this.divModProds.Controls.Add(this.priceInp, 4, 3);
            this.divModProds.Controls.Add(this.priceTxt, 2, 3);
            this.divModProds.Controls.Add(this.idprodTxt, 2, 1);
            this.divModProds.Controls.Add(this.delprodBtn, 2, 4);
            this.divModProds.Controls.Add(this.idprodImg, 1, 1);
            this.divModProds.Controls.Add(this.prodImg, 1, 2);
            this.divModProds.Controls.Add(this.priceImg, 1, 3);
            this.divModProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divModProds.Location = new System.Drawing.Point(0, 0);
            this.divModProds.Name = "divModProds";
            this.divModProds.RowCount = 5;
            this.divModProds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.75799F));
            this.divModProds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.24201F));
            this.divModProds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.divModProds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.divModProds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.divModProds.Size = new System.Drawing.Size(954, 561);
            this.divModProds.TabIndex = 3;
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
            this.divModProds.SetColumnSpan(this.productsTable, 6);
            this.productsTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productsTable.Location = new System.Drawing.Point(99, 3);
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.Size = new System.Drawing.Size(754, 333);
            this.productsTable.TabIndex = 4;
            this.productsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsTable_CellContentClick);
            // 
            // idProdInp
            // 
            this.idProdInp.AcceptsTab = true;
            this.idProdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divModProds.SetColumnSpan(this.idProdInp, 2);
            this.idProdInp.Location = new System.Drawing.Point(535, 354);
            this.idProdInp.Name = "idProdInp";
            this.idProdInp.ReadOnly = true;
            this.idProdInp.Size = new System.Drawing.Size(145, 20);
            this.idProdInp.TabIndex = 9;
            // 
            // descTxt
            // 
            this.descTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descTxt.AutoSize = true;
            this.divModProds.SetColumnSpan(this.descTxt, 2);
            this.descTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTxt.Location = new System.Drawing.Point(292, 408);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(210, 21);
            this.descTxt.TabIndex = 10;
            this.descTxt.Text = "Descripción del producto:";
            // 
            // descprodInp
            // 
            this.descprodInp.AcceptsTab = true;
            this.descprodInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divModProds.SetColumnSpan(this.descprodInp, 2);
            this.descprodInp.Location = new System.Drawing.Point(536, 409);
            this.descprodInp.Name = "descprodInp";
            this.descprodInp.Size = new System.Drawing.Size(143, 20);
            this.descprodInp.TabIndex = 11;
            // 
            // priceInp
            // 
            this.priceInp.AcceptsTab = true;
            this.priceInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divModProds.SetColumnSpan(this.priceInp, 2);
            this.priceInp.Location = new System.Drawing.Point(536, 465);
            this.priceInp.Name = "priceInp";
            this.priceInp.Size = new System.Drawing.Size(143, 20);
            this.priceInp.TabIndex = 12;
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceTxt.AutoSize = true;
            this.divModProds.SetColumnSpan(this.priceTxt, 2);
            this.priceTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.Location = new System.Drawing.Point(301, 460);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(191, 30);
            this.priceTxt.TabIndex = 13;
            this.priceTxt.Text = "Precio unitario:";
            // 
            // idprodTxt
            // 
            this.idprodTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idprodTxt.AutoSize = true;
            this.divModProds.SetColumnSpan(this.idprodTxt, 2);
            this.idprodTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idprodTxt.Location = new System.Drawing.Point(294, 349);
            this.idprodTxt.Name = "idprodTxt";
            this.idprodTxt.Size = new System.Drawing.Size(206, 30);
            this.idprodTxt.TabIndex = 8;
            this.idprodTxt.Text = "ID del producto:";
            // 
            // delprodBtn
            // 
            this.delprodBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divModProds.SetColumnSpan(this.delprodBtn, 4);
            this.delprodBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delprodBtn.Location = new System.Drawing.Point(429, 512);
            this.delprodBtn.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.delprodBtn.Name = "delprodBtn";
            this.delprodBtn.Size = new System.Drawing.Size(151, 38);
            this.delprodBtn.TabIndex = 14;
            this.delprodBtn.Text = "Eliminar producto";
            this.delprodBtn.UseVisualStyleBackColor = true;
            this.delprodBtn.Click += new System.EventHandler(this.delprodBtn_Click);
            // 
            // idprodImg
            // 
            this.idprodImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idprodImg.Image = ((System.Drawing.Image)(resources.GetObject("idprodImg.Image")));
            this.idprodImg.Location = new System.Drawing.Point(224, 342);
            this.idprodImg.Name = "idprodImg";
            this.idprodImg.Size = new System.Drawing.Size(52, 45);
            this.idprodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.idprodImg.TabIndex = 15;
            this.idprodImg.TabStop = false;
            // 
            // prodImg
            // 
            this.prodImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prodImg.Image = ((System.Drawing.Image)(resources.GetObject("prodImg.Image")));
            this.prodImg.Location = new System.Drawing.Point(224, 393);
            this.prodImg.Name = "prodImg";
            this.prodImg.Size = new System.Drawing.Size(52, 52);
            this.prodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prodImg.TabIndex = 16;
            this.prodImg.TabStop = false;
            // 
            // priceImg
            // 
            this.priceImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.priceImg.Image = ((System.Drawing.Image)(resources.GetObject("priceImg.Image")));
            this.priceImg.Location = new System.Drawing.Point(224, 451);
            this.priceImg.Name = "priceImg";
            this.priceImg.Size = new System.Drawing.Size(52, 48);
            this.priceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.priceImg.TabIndex = 17;
            this.priceImg.TabStop = false;
            // 
            // frmDeleteProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.divModProds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar producto - Administrador";
            this.Load += new System.EventHandler(this.frmDeleteProducts_Load);
            this.divModProds.ResumeLayout(false);
            this.divModProds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idprodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel divModProds;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.TextBox idProdInp;
        private System.Windows.Forms.Label descTxt;
        private System.Windows.Forms.TextBox descprodInp;
        private System.Windows.Forms.TextBox priceInp;
        private System.Windows.Forms.Label priceTxt;
        private System.Windows.Forms.Label idprodTxt;
        private System.Windows.Forms.Button delprodBtn;
        private System.Windows.Forms.PictureBox idprodImg;
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.PictureBox priceImg;
    }
}