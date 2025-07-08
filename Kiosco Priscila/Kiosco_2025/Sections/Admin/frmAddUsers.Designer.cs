namespace Kiosco_2025.Sections.Admin
{
    partial class frmAddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUsers));
            this.divAddUsers = new System.Windows.Forms.TableLayoutPanel();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.idUserInp = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.usernameInp = new System.Windows.Forms.TextBox();
            this.passwrdInp = new System.Windows.Forms.TextBox();
            this.passwrdTxt = new System.Windows.Forms.Label();
            this.idUserTxt = new System.Windows.Forms.Label();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.idprodImg = new System.Windows.Forms.PictureBox();
            this.prodImg = new System.Windows.Forms.PictureBox();
            this.priceImg = new System.Windows.Forms.PictureBox();
            this.roleTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roleInp = new System.Windows.Forms.ComboBox();
            this.divAddUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idprodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // divAddUsers
            // 
            this.divAddUsers.ColumnCount = 8;
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36426F));
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.63574F));
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.divAddUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.divAddUsers.Controls.Add(this.usersTable, 1, 0);
            this.divAddUsers.Controls.Add(this.idUserInp, 4, 1);
            this.divAddUsers.Controls.Add(this.usernameTxt, 2, 2);
            this.divAddUsers.Controls.Add(this.usernameInp, 4, 2);
            this.divAddUsers.Controls.Add(this.passwrdInp, 4, 3);
            this.divAddUsers.Controls.Add(this.passwrdTxt, 2, 3);
            this.divAddUsers.Controls.Add(this.idUserTxt, 2, 1);
            this.divAddUsers.Controls.Add(this.idprodImg, 1, 1);
            this.divAddUsers.Controls.Add(this.prodImg, 1, 2);
            this.divAddUsers.Controls.Add(this.priceImg, 1, 3);
            this.divAddUsers.Controls.Add(this.addUserBtn, 2, 5);
            this.divAddUsers.Controls.Add(this.roleTxt, 2, 4);
            this.divAddUsers.Controls.Add(this.pictureBox1, 1, 4);
            this.divAddUsers.Controls.Add(this.roleInp, 4, 4);
            this.divAddUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divAddUsers.Location = new System.Drawing.Point(0, 0);
            this.divAddUsers.Name = "divAddUsers";
            this.divAddUsers.RowCount = 6;
            this.divAddUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.79532F));
            this.divAddUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20468F));
            this.divAddUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.divAddUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.divAddUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.divAddUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.divAddUsers.Size = new System.Drawing.Size(948, 608);
            this.divAddUsers.TabIndex = 2;
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
            this.divAddUsers.SetColumnSpan(this.usersTable, 6);
            this.usersTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usersTable.Location = new System.Drawing.Point(97, 3);
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.Size = new System.Drawing.Size(751, 295);
            this.usersTable.TabIndex = 4;
            this.usersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellContentClick);
            // 
            // idUserInp
            // 
            this.idUserInp.AcceptsTab = true;
            this.idUserInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divAddUsers.SetColumnSpan(this.idUserInp, 2);
            this.idUserInp.Location = new System.Drawing.Point(530, 318);
            this.idUserInp.Name = "idUserInp";
            this.idUserInp.ReadOnly = true;
            this.idUserInp.Size = new System.Drawing.Size(145, 20);
            this.idUserInp.TabIndex = 9;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTxt.AutoSize = true;
            this.divAddUsers.SetColumnSpan(this.usernameTxt, 2);
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(286, 374);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(211, 24);
            this.usernameTxt.TabIndex = 10;
            this.usernameTxt.Text = "Nombre de usuario:";
            // 
            // usernameInp
            // 
            this.usernameInp.AcceptsTab = true;
            this.usernameInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divAddUsers.SetColumnSpan(this.usernameInp, 2);
            this.usernameInp.Location = new System.Drawing.Point(531, 376);
            this.usernameInp.Name = "usernameInp";
            this.usernameInp.Size = new System.Drawing.Size(143, 20);
            this.usernameInp.TabIndex = 11;
            // 
            // passwrdInp
            // 
            this.passwrdInp.AcceptsTab = true;
            this.passwrdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divAddUsers.SetColumnSpan(this.passwrdInp, 2);
            this.passwrdInp.Location = new System.Drawing.Point(531, 435);
            this.passwrdInp.Name = "passwrdInp";
            this.passwrdInp.PasswordChar = '*';
            this.passwrdInp.Size = new System.Drawing.Size(143, 20);
            this.passwrdInp.TabIndex = 12;
            // 
            // passwrdTxt
            // 
            this.passwrdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdTxt.AutoSize = true;
            this.divAddUsers.SetColumnSpan(this.passwrdTxt, 2);
            this.passwrdTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdTxt.Location = new System.Drawing.Point(278, 434);
            this.passwrdTxt.Name = "passwrdTxt";
            this.passwrdTxt.Size = new System.Drawing.Size(227, 22);
            this.passwrdTxt.TabIndex = 13;
            this.passwrdTxt.Text = "Contraseña del usuario:";
            // 
            // idUserTxt
            // 
            this.idUserTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idUserTxt.AutoSize = true;
            this.divAddUsers.SetColumnSpan(this.idUserTxt, 2);
            this.idUserTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUserTxt.Location = new System.Drawing.Point(301, 313);
            this.idUserTxt.Name = "idUserTxt";
            this.idUserTxt.Size = new System.Drawing.Size(181, 30);
            this.idUserTxt.TabIndex = 8;
            this.idUserTxt.Text = "ID del usuario:";
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divAddUsers.SetColumnSpan(this.addUserBtn, 4);
            this.addUserBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.Location = new System.Drawing.Point(424, 550);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(151, 38);
            this.addUserBtn.TabIndex = 14;
            this.addUserBtn.Text = "Agregar usuario";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // idprodImg
            // 
            this.idprodImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.idprodImg.Image = ((System.Drawing.Image)(resources.GetObject("idprodImg.Image")));
            this.idprodImg.Location = new System.Drawing.Point(219, 304);
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
            this.prodImg.Location = new System.Drawing.Point(219, 360);
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
            this.priceImg.Location = new System.Drawing.Point(219, 421);
            this.priceImg.Name = "priceImg";
            this.priceImg.Size = new System.Drawing.Size(52, 48);
            this.priceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.priceImg.TabIndex = 17;
            this.priceImg.TabStop = false;
            // 
            // roleTxt
            // 
            this.roleTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleTxt.AutoSize = true;
            this.divAddUsers.SetColumnSpan(this.roleTxt, 2);
            this.roleTxt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleTxt.Location = new System.Drawing.Point(295, 486);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(194, 30);
            this.roleTxt.TabIndex = 18;
            this.roleTxt.Text = "Rol del usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // roleInp
            // 
            this.roleInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divAddUsers.SetColumnSpan(this.roleInp, 2);
            this.roleInp.FormattingEnabled = true;
            this.roleInp.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.roleInp.Location = new System.Drawing.Point(530, 491);
            this.roleInp.Name = "roleInp";
            this.roleInp.Size = new System.Drawing.Size(145, 21);
            this.roleInp.TabIndex = 21;
            // 
            // frmAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(948, 608);
            this.Controls.Add(this.divAddUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar usuarios - Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmAddUsers_Load);
            this.divAddUsers.ResumeLayout(false);
            this.divAddUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idprodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel divAddUsers;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.TextBox idUserInp;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.TextBox usernameInp;
        private System.Windows.Forms.TextBox passwrdInp;
        private System.Windows.Forms.Label passwrdTxt;
        private System.Windows.Forms.Label idUserTxt;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.PictureBox idprodImg;
        private System.Windows.Forms.PictureBox prodImg;
        private System.Windows.Forms.PictureBox priceImg;
        private System.Windows.Forms.Label roleTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox roleInp;
    }
}