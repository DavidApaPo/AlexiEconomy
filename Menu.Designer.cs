namespace AlexiEconomy
{
    partial class Menu
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
            this.lbMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnEmployes = new System.Windows.Forms.Button();
            this.btnWare = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbMenu.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMenu.Location = new System.Drawing.Point(43, 9);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(62, 24);
            this.lbMenu.TabIndex = 0;
            this.lbMenu.Text = "Menu";
            this.lbMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 418);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1331, 55);
            this.panel2.TabIndex = 9;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::AlexiEconomy.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(410, 415);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(336, 268);
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // btnEmployes
            // 
            this.btnEmployes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmployes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployes.Image = global::AlexiEconomy.Properties.Resources.empleados_imag;
            this.btnEmployes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployes.Location = new System.Drawing.Point(713, 262);
            this.btnEmployes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Size = new System.Drawing.Size(192, 123);
            this.btnEmployes.TabIndex = 7;
            this.btnEmployes.Text = "Empleados";
            this.btnEmployes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployes.UseVisualStyleBackColor = false;
            // 
            // btnWare
            // 
            this.btnWare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWare.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWare.Image = global::AlexiEconomy.Properties.Resources.bodega_imag;
            this.btnWare.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWare.Location = new System.Drawing.Point(449, 262);
            this.btnWare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWare.Name = "btnWare";
            this.btnWare.Size = new System.Drawing.Size(192, 123);
            this.btnWare.TabIndex = 6;
            this.btnWare.Text = "Bodegas";
            this.btnWare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWare.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Image = global::AlexiEconomy.Properties.Resources.clientes_imag;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.Location = new System.Drawing.Point(209, 262);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(192, 123);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Clientes";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.Image = global::AlexiEconomy.Properties.Resources.probedores_imag;
            this.btnSuppliers.Location = new System.Drawing.Point(799, 100);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(192, 123);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Proveedores";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = global::AlexiEconomy.Properties.Resources.inventario_imag;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventory.Location = new System.Drawing.Point(584, 100);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(192, 132);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventario";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnSales
            // 
            this.btnSales.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::AlexiEconomy.Properties.Resources.ventas_imag;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.Location = new System.Drawing.Point(372, 100);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(192, 123);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Ventas";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = global::AlexiEconomy.Properties.Resources.producto_imag;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.Location = new System.Drawing.Point(151, 100);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(192, 123);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Productos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.txtProducts_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1327, 704);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnEmployes);
            this.Controls.Add(this.btnWare);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnWare;
        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button txtProducts;
        private System.Windows.Forms.Button txtSales;
        private System.Windows.Forms.Button txtInventory;
        private System.Windows.Forms.Button txtSuppliers;
        private System.Windows.Forms.Button txtCustomers;
        private System.Windows.Forms.Button txtWare;
        private System.Windows.Forms.Button txtEmployes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}