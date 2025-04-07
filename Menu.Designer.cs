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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmployes = new System.Windows.Forms.Button();
            this.txtProducts = new System.Windows.Forms.Button();
            this.txtWare = new System.Windows.Forms.Button();
            this.txtaSales = new System.Windows.Forms.Button();
            this.txtCustomers = new System.Windows.Forms.Button();
            this.txtInventory = new System.Windows.Forms.Button();
            this.txtSuppliers = new System.Windows.Forms.Button();
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
            // txtEmployes
            // 
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
            this.ClientSize = new System.Drawing.Size(1236, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}