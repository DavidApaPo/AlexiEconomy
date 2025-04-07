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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnWare = new System.Windows.Forms.Button();
            this.btnEmployes = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            this.btnSales.Location = new System.Drawing.Point(416, 65);
            this.btnSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(75, 23);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Ventas";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnaSales_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(613, 65);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(819, 65);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(75, 23);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Proveedores";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(996, 64);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Clientes";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnWare
            // 
            this.btnWare.Location = new System.Drawing.Point(416, 176);
            this.btnWare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWare.Name = "btnWare";
            this.btnWare.Size = new System.Drawing.Size(75, 23);
            this.btnWare.TabIndex = 6;
            this.btnWare.Text = "Bodegas";
            this.btnWare.UseVisualStyleBackColor = true;
            // 
            // btnEmployes
            // 
            this.btnEmployes.Location = new System.Drawing.Point(885, 149);
            this.btnEmployes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Size = new System.Drawing.Size(75, 23);
            this.btnEmployes.TabIndex = 7;
            this.btnEmployes.Text = "Empleados";
            this.btnEmployes.UseVisualStyleBackColor = true;
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.txtEmployes);
            this.panel1.Controls.Add(this.txtProducts);
            this.panel1.Controls.Add(this.txtWare);
            this.panel1.Controls.Add(this.txtaSales);
            this.panel1.Controls.Add(this.txtCustomers);
            this.panel1.Controls.Add(this.txtInventory);
            this.panel1.Controls.Add(this.txtSuppliers);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 418);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(239, 64);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.txtProducts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AlexiEconomy.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(528, 273);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 244);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.txtEmployes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmployes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmployes.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployes.Image = global::AlexiEconomy.Properties.Resources.empleados_imag;
            this.txtEmployes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtEmployes.Location = new System.Drawing.Point(713, 262);
            this.txtEmployes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployes.Name = "txtEmployes";
            this.txtEmployes.Size = new System.Drawing.Size(192, 123);
            this.txtEmployes.TabIndex = 7;
            this.txtEmployes.Text = "Empleados";
            this.txtEmployes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtEmployes.UseVisualStyleBackColor = false;
            // 
            // txtProducts
            // 
            this.txtProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtProducts.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducts.Image = global::AlexiEconomy.Properties.Resources.producto_imag;
            this.txtProducts.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtProducts.Location = new System.Drawing.Point(151, 100);
            this.txtProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(192, 123);
            this.txtProducts.TabIndex = 1;
            this.txtProducts.Text = "Productos";
            this.txtProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtProducts.UseVisualStyleBackColor = false;
            this.txtProducts.Click += new System.EventHandler(this.txtProducts_Click);
            // 
            // txtWare
            // 
            this.txtWare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtWare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtWare.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWare.Image = global::AlexiEconomy.Properties.Resources.bodega_imag;
            this.txtWare.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtWare.Location = new System.Drawing.Point(449, 262);
            this.txtWare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWare.Name = "txtWare";
            this.txtWare.Size = new System.Drawing.Size(192, 123);
            this.txtWare.TabIndex = 6;
            this.txtWare.Text = "Bodegas";
            this.txtWare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtWare.UseVisualStyleBackColor = false;
            // 
            // txtaSales
            // 
            this.txtaSales.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtaSales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtaSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtaSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtaSales.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaSales.Image = global::AlexiEconomy.Properties.Resources.ventas_imag;
            this.txtaSales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtaSales.Location = new System.Drawing.Point(372, 100);
            this.txtaSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaSales.Name = "txtaSales";
            this.txtaSales.Size = new System.Drawing.Size(192, 123);
            this.txtaSales.TabIndex = 2;
            this.txtaSales.Text = "Ventas";
            this.txtaSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtaSales.UseVisualStyleBackColor = false;
            // 
            // txtCustomers
            // 
            this.txtCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCustomers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomers.Image = global::AlexiEconomy.Properties.Resources.clientes_imag;
            this.txtCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtCustomers.Location = new System.Drawing.Point(209, 262);
            this.txtCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(192, 123);
            this.txtCustomers.TabIndex = 5;
            this.txtCustomers.Text = "Clientes";
            this.txtCustomers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtCustomers.UseVisualStyleBackColor = false;
            // 
            // txtInventory
            // 
            this.txtInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtInventory.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Image = global::AlexiEconomy.Properties.Resources.inventario_imag;
            this.txtInventory.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtInventory.Location = new System.Drawing.Point(584, 100);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(192, 132);
            this.txtInventory.TabIndex = 3;
            this.txtInventory.Text = "Inventario";
            this.txtInventory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtInventory.UseVisualStyleBackColor = false;
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSuppliers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppliers.Image = global::AlexiEconomy.Properties.Resources.probedores_imag;
            this.txtSuppliers.Location = new System.Drawing.Point(799, 100);
            this.txtSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(192, 123);
            this.txtSuppliers.TabIndex = 4;
            this.txtSuppliers.Text = "Proveedores";
            this.txtSuppliers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtSuppliers.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEmployes);
            this.Controls.Add(this.btnWare);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnWare;
        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txtProducts;
        private System.Windows.Forms.Button txtaSales;
        private System.Windows.Forms.Button txtInventory;
        private System.Windows.Forms.Button txtSuppliers;
        private System.Windows.Forms.Button txtCustomers;
        private System.Windows.Forms.Button txtWare;
        private System.Windows.Forms.Button txtEmployes;
        private System.Windows.Forms.Panel panel1;

    }
}