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
            this.txtProducts = new System.Windows.Forms.Button();
            this.txtaSales = new System.Windows.Forms.Button();
            this.txtInventory = new System.Windows.Forms.Button();
            this.txtSuppliers = new System.Windows.Forms.Button();
            this.txtCustomers = new System.Windows.Forms.Button();
            this.txtWare = new System.Windows.Forms.Button();
            this.txtEmployes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProducts
            // 
            this.txtProducts.Location = new System.Drawing.Point(165, 65);
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(75, 23);
            this.txtProducts.TabIndex = 1;
            this.txtProducts.Text = "Productos";
            this.txtProducts.UseVisualStyleBackColor = true;
            // 
            // txtaSales
            // 
            this.txtaSales.Location = new System.Drawing.Point(279, 65);
            this.txtaSales.Name = "txtaSales";
            this.txtaSales.Size = new System.Drawing.Size(75, 23);
            this.txtaSales.TabIndex = 2;
            this.txtaSales.Text = "Ventas";
            this.txtaSales.UseVisualStyleBackColor = true;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(381, 64);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(75, 23);
            this.txtInventory.TabIndex = 3;
            this.txtInventory.Text = "Inventario";
            this.txtInventory.UseVisualStyleBackColor = true;
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.Location = new System.Drawing.Point(478, 64);
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(75, 23);
            this.txtSuppliers.TabIndex = 4;
            this.txtSuppliers.Text = "Proveedores";
            this.txtSuppliers.UseVisualStyleBackColor = true;
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(595, 64);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(75, 23);
            this.txtCustomers.TabIndex = 5;
            this.txtCustomers.Text = "Clientes";
            this.txtCustomers.UseVisualStyleBackColor = true;
            // 
            // txtWare
            // 
            this.txtWare.Location = new System.Drawing.Point(165, 137);
            this.txtWare.Name = "txtWare";
            this.txtWare.Size = new System.Drawing.Size(75, 23);
            this.txtWare.TabIndex = 6;
            this.txtWare.Text = "Bodegas";
            this.txtWare.UseVisualStyleBackColor = true;
            // 
            // txtEmployes
            // 
            this.txtEmployes.Location = new System.Drawing.Point(304, 136);
            this.txtEmployes.Name = "txtEmployes";
            this.txtEmployes.Size = new System.Drawing.Size(75, 23);
            this.txtEmployes.TabIndex = 7;
            this.txtEmployes.Text = "Empleados";
            this.txtEmployes.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmployes);
            this.Controls.Add(this.txtWare);
            this.Controls.Add(this.txtCustomers);
            this.Controls.Add(this.txtSuppliers);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtaSales);
            this.Controls.Add(this.txtProducts);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtProducts;
        private System.Windows.Forms.Button txtaSales;
        private System.Windows.Forms.Button txtInventory;
        private System.Windows.Forms.Button txtSuppliers;
        private System.Windows.Forms.Button txtCustomers;
        private System.Windows.Forms.Button txtWare;
        private System.Windows.Forms.Button txtEmployes;
    }
}