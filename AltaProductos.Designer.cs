namespace AlexiEconomy
{
    partial class AltaProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbMili = new System.Windows.Forms.ComboBox();
            this.cbIVA = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPriceIVA = new System.Windows.Forms.TextBox();
            this.txtPriceBuy = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Milimetros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aplicar IVA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidad c/u Medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // txtIVA
            // 
            this.txtIVA.AutoSize = true;
            this.txtIVA.Location = new System.Drawing.Point(277, 188);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(70, 16);
            this.txtIVA.TabIndex = 6;
            this.txtIVA.Text = "Precio IVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Precio Compra";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbMili
            // 
            this.cbMili.FormattingEnabled = true;
            this.cbMili.Items.AddRange(new object[] {
            "25",
            "30",
            "35",
            "40",
            "45"});
            this.cbMili.Location = new System.Drawing.Point(264, 92);
            this.cbMili.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMili.Name = "cbMili";
            this.cbMili.Size = new System.Drawing.Size(121, 24);
            this.cbMili.TabIndex = 9;
            this.cbMili.SelectedIndexChanged += new System.EventHandler(this.cbMili_SelectedIndexChanged);
            // 
            // cbIVA
            // 
            this.cbIVA.FormattingEnabled = true;
            this.cbIVA.Items.AddRange(new object[] {
            "Si",
            "No",
            "Exento"});
            this.cbIVA.Location = new System.Drawing.Point(528, 92);
            this.cbIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIVA.Name = "cbIVA";
            this.cbIVA.Size = new System.Drawing.Size(121, 24);
            this.cbIVA.TabIndex = 10;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "Kilogramos",
            "Pieza",
            "Litros",
            ""});
            this.cbUnit.Location = new System.Drawing.Point(811, 92);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(121, 24);
            this.cbUnit.TabIndex = 11;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(83, 217);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtPriceIVA
            // 
            this.txtPriceIVA.Location = new System.Drawing.Point(264, 217);
            this.txtPriceIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceIVA.Name = "txtPriceIVA";
            this.txtPriceIVA.Size = new System.Drawing.Size(100, 22);
            this.txtPriceIVA.TabIndex = 13;
            this.txtPriceIVA.TextChanged += new System.EventHandler(this.txtPriceIVA_TextChanged);
            // 
            // txtPriceBuy
            // 
            this.txtPriceBuy.Location = new System.Drawing.Point(537, 207);
            this.txtPriceBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceBuy.Name = "txtPriceBuy";
            this.txtPriceBuy.Size = new System.Drawing.Size(100, 22);
            this.txtPriceBuy.TabIndex = 14;
            this.txtPriceBuy.TextChanged += new System.EventHandler(this.txtPriceBuy_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1232, 575);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(1117, 26);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(100, 22);
            this.txtSeach.TabIndex = 17;
            this.txtSeach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1044, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Buscar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 65);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1356, 575);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(736, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Existencias";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(721, 207);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 23;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // btnSerch
            // 
            this.btnSerch.BackgroundImage = global::AlexiEconomy.Properties.Resources.Lupa;
            this.btnSerch.Location = new System.Drawing.Point(1232, 24);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(28, 31);
            this.btnSerch.TabIndex = 24;
            this.btnSerch.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(890, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Categoria";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(876, 207);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 22);
            this.txtCategory.TabIndex = 26;
            this.txtCategory.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 606);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPriceBuy);
            this.Controls.Add(this.txtPriceIVA);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.cbIVA);
            this.Controls.Add(this.cbMili);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AltaProductos";
            this.Text = "AltaProductos";
            this.Load += new System.EventHandler(this.AltaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtIVA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbMili;
        private System.Windows.Forms.ComboBox cbIVA;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPriceIVA;
        private System.Windows.Forms.TextBox txtPriceBuy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCategory;
    }
}