namespace Kiosco_2025.Sections.Admin
{
    partial class frmDelUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelUsers));
            this.divDelUsers = new System.Windows.Forms.TableLayoutPanel();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.idUserInp = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.usernameInp = new System.Windows.Forms.TextBox();
            this.passwrdInp = new System.Windows.Forms.TextBox();
            this.passwrdTxt = new System.Windows.Forms.Label();
            this.idUserTxt = new System.Windows.Forms.Label();
            this.idprodImg = new System.Windows.Forms.PictureBox();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.priceImg = new System.Windows.Forms.PictureBox();
            this.delUserBtn = new System.Windows.Forms.Button();
            this.roleTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roleInp = new System.Windows.Forms.ComboBox();
            this.divDelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idprodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // divDelUsers
            // 
            this.divDelUsers.ColumnCount = 8;
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36426F));
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.63574F));
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.divDelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.divDelUsers.Controls.Add(this.usersTable, 1, 0);
            this.divDelUsers.Controls.Add(this.idUserInp, 4, 1);
            this.divDelUsers.Controls.Add(this.usernameTxt, 2, 2);
            this.divDelUsers.Controls.Add(this.usernameInp, 4, 2);
            this.divDelUsers.Controls.Add(this.passwrdInp, 4, 3);
            this.divDelUsers.Controls.Add(this.passwrdTxt, 2, 3);
            this.divDelUsers.Controls.Add(this.idUserTxt, 2, 1);
            this.divDelUsers.Controls.Add(this.idprodImg, 1, 1);
            this.divDelUsers.Controls.Add(this.prodImg, 1, 2);
            this.divDelUsers.Controls.Add(this.priceImg, 1, 3);
            this.divDelUsers.Controls.Add(this.delUserBtn, 2, 5);
            this.divDelUsers.Controls.Add(this.roleTxt, 2, 4);
            this.divDelUsers.Controls.Add(this.pictureBox1, 1, 4);
            this.divDelUsers.Controls.Add(this.roleInp, 4, 4);
            this.divDelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divDelUsers.Location = new System.Drawing.Point(0, 0);
            this.divDelUsers.Name = "divDelUsers";
            this.divDelUsers.RowCount = 6;
            this.divDelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.79532F));
            this.divDelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20468F));
            this.divDelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.divDelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.divDelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.divDelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.divDelUsers.Size = new System.Drawing.Size(968, 623);
            this.divDelUsers.TabIndex = 3;
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToDeleteRows = false;
            this.usersTable.AllowUserToResizeColumns = false;
            this.usersTable.AllowUserToResizeRows = false;
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.usersTable.BackgroundColor = System.Drawing.Color.LightCyan;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divDelUsers.SetColumnSpan(this.usersTable, 6);
            this.usersTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersTable.Location = new System.Drawing.Point(104, 3);
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersWidth = 62;
            this.usersTable.Size = new System.Drawing.Size(751, 295);
            this.usersTable.TabIndex = 4;
            this.usersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellContentClick);
            // 
            // idUserInp
            // 
            this.idUserInp.AcceptsTab = true;
            this.idUserInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divDelUsers.SetColumnSpan(this.idUserInp, 2);
            this.idUserInp.Location = new System.Drawing.Point(549, 332);
            this.idUserInp.Name = "idUserInp";
            this.idUserInp.ReadOnly = true;
            this.idUserInp.Size = new System.Drawing.Size(145, 20);
            this.idUserInp.TabIndex = 9;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTxt.AutoSize = true;
            this.divDelUsers.SetColumnSpan(this.usernameTxt, 2);
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(308, 370);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(206, 62);
            this.usernameTxt.TabIndex = 10;
            this.usernameTxt.Text = "Nombre de usuario:";
            // 
            // usernameInp
            // 
            this.usernameInp.AcceptsTab = true;
            this.usernameInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divDelUsers.SetColumnSpan(this.usernameInp, 2);
            this.usernameInp.Location = new System.Drawing.Point(550, 391);
            this.usernameInp.Name = "usernameInp";
            this.usernameInp.ReadOnly = true;
            this.usernameInp.Size = new System.Drawing.Size(143, 20);
            this.usernameInp.TabIndex = 11;
            // 
            // passwrdInp
            // 
            this.passwrdInp.AcceptsTab = true;
            this.passwrdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divDelUsers.SetColumnSpan(this.passwrdInp, 2);
            this.passwrdInp.Location = new System.Drawing.Point(550, 450);
            this.passwrdInp.Name = "passwrdInp";
            this.passwrdInp.PasswordChar = '*';
            this.passwrdInp.ReadOnly = true;
            this.passwrdInp.Size = new System.Drawing.Size(143, 20);
            this.passwrdInp.TabIndex = 12;
            // 
            // passwrdTxt
            // 
            this.passwrdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdTxt.AutoSize = true;
            this.divDelUsers.SetColumnSpan(this.passwrdTxt, 2);
            this.passwrdTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdTxt.Location = new System.Drawing.Point(315, 432);
            this.passwrdTxt.Name = "passwrdTxt";
            this.passwrdTxt.Size = new System.Drawing.Size(191, 56);
            this.passwrdTxt.TabIndex = 13;
            this.passwrdTxt.Text = "Contraseña del usuario:";
            // 
            // idUserTxt
            // 
            this.idUserTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idUserTxt.AutoSize = true;
            this.divDelUsers.SetColumnSpan(this.idUserTxt, 2);
            this.idUserTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUserTxt.Location = new System.Drawing.Point(334, 314);
            this.idUserTxt.Name = "idUserTxt";
            this.idUserTxt.Size = new System.Drawing.Size(153, 56);
            this.idUserTxt.TabIndex = 8;
            this.idUserTxt.Text = "ID del usuario:";
            // 
            // idprodImg
            // 
            this.idprodImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idprodImg.Image = ((System.Drawing.Image)(resources.GetObject("idprodImg.Image")));
            this.idprodImg.Location = new System.Drawing.Point(238, 318);
            this.idprodImg.Name = "idprodImg";
            this.idprodImg.Size = new System.Drawing.Size(52, 48);
            this.idprodImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.idprodImg.TabIndex = 15;
            this.idprodImg.TabStop = false;
            // 
            // prodImg
            // 
            this.prodImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prodImg.Image = ((System.Drawing.Image)(resources.GetObject("prodImg.Image")));
            this.prodImg.Location = new System.Drawing.Point(238, 375);
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
            this.priceImg.Location = new System.Drawing.Point(238, 436);
            this.priceImg.Name = "priceImg";
            this.priceImg.Size = new System.Drawing.Size(52, 48);
            this.priceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.priceImg.TabIndex = 17;
            this.priceImg.TabStop = false;
            // 
            // delUserBtn
            // 
            this.delUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divDelUsers.SetColumnSpan(this.delUserBtn, 4);
            this.delUserBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delUserBtn.Location = new System.Drawing.Point(443, 565);
            this.delUserBtn.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.delUserBtn.Name = "delUserBtn";
            this.delUserBtn.Size = new System.Drawing.Size(151, 38);
            this.delUserBtn.TabIndex = 14;
            this.delUserBtn.Text = "Eliminar Usuario";
            this.delUserBtn.UseVisualStyleBackColor = true;
            this.delUserBtn.Click += new System.EventHandler(this.delUserBtn_Click);
            // 
            // roleTxt
            // 
            this.roleTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleTxt.AutoSize = true;
            this.divDelUsers.SetColumnSpan(this.roleTxt, 2);
            this.roleTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleTxt.Location = new System.Drawing.Point(334, 488);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(153, 57);
            this.roleTxt.TabIndex = 18;
            this.roleTxt.Text = "Rol del usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 492);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // roleInp
            // 
            this.roleInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divDelUsers.SetColumnSpan(this.roleInp, 2);
            this.roleInp.FormattingEnabled = true;
            this.roleInp.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.roleInp.Location = new System.Drawing.Point(551, 506);
            this.roleInp.Name = "roleInp";
            this.roleInp.Size = new System.Drawing.Size(140, 21);
            this.roleInp.TabIndex = 23;
            // 
            // frmDelUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(968, 623);
            this.Controls.Add(this.divDelUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar usuarios - Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmDelUsers_Load);
            this.divDelUsers.ResumeLayout(false);
            this.divDelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idprodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel divDelUsers;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.TextBox idUserInp;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.TextBox usernameInp;
        private System.Windows.Forms.TextBox passwrdInp;
        private System.Windows.Forms.Label passwrdTxt;
        private System.Windows.Forms.Label idUserTxt;
        private System.Windows.Forms.PictureBox idprodImg;
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.PictureBox priceImg;
        private System.Windows.Forms.Button delUserBtn;
        private System.Windows.Forms.Label roleTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox roleInp;
    }
}