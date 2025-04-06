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
            this.btnaSales = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnWare = new System.Windows.Forms.Button();
            this.btnEmployes = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnaSales
            // 
            this.btnaSales.Location = new System.Drawing.Point(312, 53);
            this.btnaSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnaSales.Name = "btnaSales";
            this.btnaSales.Size = new System.Drawing.Size(56, 19);
            this.btnaSales.TabIndex = 2;
            this.btnaSales.Text = "Ventas";
            this.btnaSales.UseVisualStyleBackColor = true;
            this.btnaSales.Click += new System.EventHandler(this.btnaSales_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(460, 53);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(56, 19);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Location = new System.Drawing.Point(614, 53);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(56, 19);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Proveedores";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(747, 52);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(56, 19);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Clientes";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnWare
            // 
            this.btnWare.Location = new System.Drawing.Point(312, 143);
            this.btnWare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWare.Name = "btnWare";
            this.btnWare.Size = new System.Drawing.Size(56, 19);
            this.btnWare.TabIndex = 6;
            this.btnWare.Text = "Bodegas";
            this.btnWare.UseVisualStyleBackColor = true;
            // 
            // btnEmployes
            // 
            this.btnEmployes.Location = new System.Drawing.Point(664, 121);
            this.btnEmployes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmployes.Name = "btnEmployes";
            this.btnEmployes.Size = new System.Drawing.Size(56, 19);
            this.btnEmployes.TabIndex = 7;
            this.btnEmployes.Text = "Empleados";
            this.btnEmployes.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(179, 52);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(56, 19);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.txtProducts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AlexiEconomy.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(396, 222);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 231);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEmployes);
            this.Controls.Add(this.btnWare);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnaSales);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaSales;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnWare;
        private System.Windows.Forms.Button btnEmployes;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}