namespace App_Delivery_HUGO
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRADORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrderAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrderUser = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUSTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.orders1 = new App_Delivery_HUGO.Orders(unUser);
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.orders1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.55106F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.44894F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 606);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BlueViolet;
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.aDMINISTRADORToolStripMenuItem, this.uSUARIOToolStripMenuItem, this.aJUSTESToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINISTRADORToolStripMenuItem
            // 
            this.aDMINISTRADORToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.aDMINISTRADORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.btnUsers, this.btnChart, this.btnBusiness, this.btnProduct, this.btnOrderAdmin});
            this.aDMINISTRADORToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aDMINISTRADORToolStripMenuItem.Name = "aDMINISTRADORToolStripMenuItem";
            this.aDMINISTRADORToolStripMenuItem.Size = new System.Drawing.Size(150, 35);
            this.aDMINISTRADORToolStripMenuItem.Text = "ADMINISTRADOR";
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Silver;
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(181, 26);
            this.btnUsers.Text = "USUARIOS";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.Silver;
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(181, 26);
            this.btnChart.Text = "GRAFICO";
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.BackColor = System.Drawing.Color.Silver;
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Size = new System.Drawing.Size(181, 26);
            this.btnBusiness.Text = "NEGOCIOS";
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Silver;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(181, 26);
            this.btnProduct.Text = "PRODUCTOS";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrderAdmin
            // 
            this.btnOrderAdmin.BackColor = System.Drawing.Color.Silver;
            this.btnOrderAdmin.Name = "btnOrderAdmin";
            this.btnOrderAdmin.Size = new System.Drawing.Size(181, 26);
            this.btnOrderAdmin.Text = "ORDENES";
            this.btnOrderAdmin.Click += new System.EventHandler(this.btnOrderAdmin_Click);
            // 
            // uSUARIOToolStripMenuItem
            // 
            this.uSUARIOToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.uSUARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.btnAddress, this.btnOrderUser});
            this.uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            this.uSUARIOToolStripMenuItem.Size = new System.Drawing.Size(89, 35);
            this.uSUARIOToolStripMenuItem.Text = "USUARIO";
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(181, 26);
            this.btnAddress.Text = "DIRECCION";
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnOrderUser
            // 
            this.btnOrderUser.BackColor = System.Drawing.Color.BlueViolet;
            this.btnOrderUser.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnOrderUser.Name = "btnOrderUser";
            this.btnOrderUser.Size = new System.Drawing.Size(181, 26);
            this.btnOrderUser.Text = "ORDENES";
            this.btnOrderUser.Click += new System.EventHandler(this.btnOrderUser_Click);
            // 
            // aJUSTESToolStripMenuItem
            // 
            this.aJUSTESToolStripMenuItem.BackColor = System.Drawing.Color.MediumOrchid;
            this.aJUSTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.btnChangePassword});
            this.aJUSTESToolStripMenuItem.Name = "aJUSTESToolStripMenuItem";
            this.aJUSTESToolStripMenuItem.Size = new System.Drawing.Size(81, 35);
            this.aJUSTESToolStripMenuItem.Text = "AJUSTES";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))),
                ((int) (((byte) (128)))), ((int) (((byte) (255)))));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(259, 26);
            this.btnChangePassword.Text = "CAMBIAR CONTRASEÑA";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // orders1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.orders1, 2);
            this.orders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orders1.Location = new System.Drawing.Point(3, 43);
            this.orders1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orders1.Name = "orders1";
            this.orders1.Size = new System.Drawing.Size(856, 559);
            this.orders1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(862, 606);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRADORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUSTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOrderAdmin;
        private System.Windows.Forms.ToolStripMenuItem btnUsers;
        private System.Windows.Forms.ToolStripMenuItem btnChart;
        private System.Windows.Forms.ToolStripMenuItem btnBusiness;
        private System.Windows.Forms.ToolStripMenuItem btnProduct;
        private System.Windows.Forms.ToolStripMenuItem btnAddress;
        private System.Windows.Forms.ToolStripMenuItem btnOrderUser;
        private System.Windows.Forms.ToolStripMenuItem btnChangePassword;
        private App_Delivery_HUGO.Orders orders1;
    }
}