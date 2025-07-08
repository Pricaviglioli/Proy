namespace Kiosco_2025
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.divLogin = new System.Windows.Forms.TableLayoutPanel();
            this.userTxt = new System.Windows.Forms.Label();
            this.userInp = new System.Windows.Forms.TextBox();
            this.AppImg = new System.Windows.Forms.PictureBox();
            this.passwrdTxt = new System.Windows.Forms.Label();
            this.passwrdInp = new System.Windows.Forms.TextBox();
            this.userImg = new System.Windows.Forms.PictureBox();
            this.passwrdImg = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.divLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwrdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // divLogin
            // 
            this.divLogin.ColumnCount = 6;
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.02778F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.divLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.divLogin.Controls.Add(this.userTxt, 2, 1);
            this.divLogin.Controls.Add(this.userInp, 3, 1);
            this.divLogin.Controls.Add(this.passwrdTxt, 2, 2);
            this.divLogin.Controls.Add(this.passwrdInp, 3, 2);
            this.divLogin.Controls.Add(this.userImg, 1, 1);
            this.divLogin.Controls.Add(this.passwrdImg, 1, 2);
            this.divLogin.Controls.Add(this.loginBtn, 2, 3);
            this.divLogin.Controls.Add(this.AppImg, 0, 0);
            this.divLogin.Controls.Add(this.usersTable, 3, 0);
            this.divLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divLogin.Location = new System.Drawing.Point(0, 0);
            this.divLogin.Name = "divLogin";
            this.divLogin.RowCount = 5;
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.78641F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.21359F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.divLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.divLogin.Size = new System.Drawing.Size(381, 508);
            this.divLogin.TabIndex = 0;
            // 
            // userTxt
            // 
            this.userTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTxt.AutoSize = true;
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(117, 266);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(80, 22);
            this.userTxt.TabIndex = 0;
            this.userTxt.Text = "Usuario:";
            // 
            // userInp
            // 
            this.userInp.AcceptsTab = true;
            this.userInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.divLogin.SetColumnSpan(this.userInp, 2);
            this.userInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInp.Location = new System.Drawing.Point(214, 267);
            this.userInp.Name = "userInp";
            this.userInp.Size = new System.Drawing.Size(129, 21);
            this.userInp.TabIndex = 3;
            // 
            // AppImg
            // 
            this.AppImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divLogin.SetColumnSpan(this.AppImg, 3);
            this.AppImg.Image = ((System.Drawing.Image)(resources.GetObject("AppImg.Image")));
            this.AppImg.Location = new System.Drawing.Point(66, 82);
            this.AppImg.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.AppImg.Name = "AppImg";
            this.AppImg.Size = new System.Drawing.Size(105, 72);
            this.AppImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppImg.TabIndex = 5;
            this.AppImg.TabStop = false;
            // 
            // passwrdTxt
            // 
            this.passwrdTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdTxt.AutoSize = true;
            this.passwrdTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdTxt.Location = new System.Drawing.Point(113, 351);
            this.passwrdTxt.Name = "passwrdTxt";
            this.passwrdTxt.Size = new System.Drawing.Size(88, 17);
            this.passwrdTxt.TabIndex = 6;
            this.passwrdTxt.Text = "Contraseña:";
            // 
            // passwrdInp
            // 
            this.passwrdInp.AcceptsTab = true;
            this.passwrdInp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwrdInp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.divLogin.SetColumnSpan(this.passwrdInp, 2);
            this.passwrdInp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwrdInp.Location = new System.Drawing.Point(217, 349);
            this.passwrdInp.Name = "passwrdInp";
            this.passwrdInp.PasswordChar = '*';
            this.passwrdInp.Size = new System.Drawing.Size(124, 21);
            this.passwrdInp.TabIndex = 7;
            // 
            // userImg
            // 
            this.userImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userImg.Image = ((System.Drawing.Image)(resources.GetObject("userImg.Image")));
            this.userImg.Location = new System.Drawing.Point(28, 239);
            this.userImg.Name = "userImg";
            this.userImg.Size = new System.Drawing.Size(75, 77);
            this.userImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImg.TabIndex = 8;
            this.userImg.TabStop = false;
            // 
            // passwrdImg
            // 
            this.passwrdImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwrdImg.Image = ((System.Drawing.Image)(resources.GetObject("passwrdImg.Image")));
            this.passwrdImg.Location = new System.Drawing.Point(28, 322);
            this.passwrdImg.Name = "passwrdImg";
            this.passwrdImg.Size = new System.Drawing.Size(75, 76);
            this.passwrdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwrdImg.TabIndex = 9;
            this.passwrdImg.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divLogin.SetColumnSpan(this.loginBtn, 2);
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(136, 420);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(0, 0, 30, 30);
            this.loginBtn.Name = "loginBtn";
            this.divLogin.SetRowSpan(this.loginBtn, 2);
            this.loginBtn.Size = new System.Drawing.Size(123, 39);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Iniciar Sesión";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usersTable
            // 
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.divLogin.SetColumnSpan(this.usersTable, 3);
            this.usersTable.Location = new System.Drawing.Point(211, 3);
            this.usersTable.Name = "usersTable";
            this.usersTable.Size = new System.Drawing.Size(167, 230);
            this.usersTable.TabIndex = 11;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(381, 508);
            this.Controls.Add(this.divLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.divLogin.ResumeLayout(false);
            this.divLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwrdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel divLogin;
        private System.Windows.Forms.Label userTxt;
        private System.Windows.Forms.TextBox userInp;
        private System.Windows.Forms.PictureBox AppImg;
        private System.Windows.Forms.Label passwrdTxt;
        private System.Windows.Forms.TextBox passwrdInp;
        private System.Windows.Forms.PictureBox userImg;
        private System.Windows.Forms.PictureBox passwrdImg;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.DataGridView usersTable;
    }
}

