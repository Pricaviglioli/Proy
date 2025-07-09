namespace Kiosco_2025.Sections.Admin
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.AppImg = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAdmin.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuAdmin.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppImg,
            this.sToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.ventasToolStripMenuItem1});
            this.menuAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(1177, 51);
            this.menuAdmin.TabIndex = 0;
            this.menuAdmin.Text = "menuStrip1";
            // 
            // AppImg
            // 
            this.AppImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AppImg.Image = ((System.Drawing.Image)(resources.GetObject("AppImg.Image")));
            this.AppImg.Name = "AppImg";
            this.AppImg.Size = new System.Drawing.Size(40, 47);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductosToolStripMenuItem,
            this.eliminarProductosToolStripMenuItem,
            this.modificarProductosToolStripMenuItem,
            this.agregarUsuariosToolStripMenuItem,
            this.eliminarUsuariosToolStripMenuItem,
            this.modificarUsuariosToolStripMenuItem});
            this.sToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(148, 47);
            this.sToolStripMenuItem.Text = "Kiosco";
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarProductosToolStripMenuItem.Image")));
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.agregarProductosToolStripMenuItem_Click);
            // 
            // eliminarProductosToolStripMenuItem
            // 
            this.eliminarProductosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarProductosToolStripMenuItem.Image")));
            this.eliminarProductosToolStripMenuItem.Name = "eliminarProductosToolStripMenuItem";
            this.eliminarProductosToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.eliminarProductosToolStripMenuItem.Text = "Eliminar Productos";
            this.eliminarProductosToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductosToolStripMenuItem_Click);
            // 
            // modificarProductosToolStripMenuItem
            // 
            this.modificarProductosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarProductosToolStripMenuItem.Image")));
            this.modificarProductosToolStripMenuItem.Name = "modificarProductosToolStripMenuItem";
            this.modificarProductosToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.modificarProductosToolStripMenuItem.Text = "Modificar Productos";
            this.modificarProductosToolStripMenuItem.Click += new System.EventHandler(this.modificarProductosToolStripMenuItem_Click);
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            this.agregarUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarUsuariosToolStripMenuItem.Image")));
            this.agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            this.agregarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.agregarUsuariosToolStripMenuItem.Text = "Agregar usuarios";
            this.agregarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuariosToolStripMenuItem_Click);
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            this.eliminarUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarUsuariosToolStripMenuItem.Image")));
            this.eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            this.eliminarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.eliminarUsuariosToolStripMenuItem.Text = "Eliminar usuarios";
            this.eliminarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuariosToolStripMenuItem_Click);
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            this.modificarUsuariosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarUsuariosToolStripMenuItem.Image")));
            this.modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            this.modificarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.modificarUsuariosToolStripMenuItem.Text = "Modificar usuarios";
            this.modificarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuariosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ventasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem.Image")));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(40, 47);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(156, 47);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1177, 691);
            this.Controls.Add(this.menuAdmin);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuAdmin;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal - Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem AppImg;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuariosToolStripMenuItem;
    }
}