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
            this.lbName = new System.Windows.Forms.Label();
            this.lbMili = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.lbIVA = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPriceIVA = new System.Windows.Forms.Label();
            this.lbBuy = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbMili = new System.Windows.Forms.ComboBox();
            this.cbIVA = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPriceIVA = new System.Windows.Forms.TextBox();
            this.txtPriceBuy = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSerch = new System.Windows.Forms.Button();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(79, 47);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nombre";
            // 
            // lbMili
            // 
            this.lbMili.AutoSize = true;
            this.lbMili.Location = new System.Drawing.Point(210, 47);
            this.lbMili.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMili.Name = "lbMili";
            this.lbMili.Size = new System.Drawing.Size(53, 13);
            this.lbMili.TabIndex = 1;
            this.lbMili.Text = "Milimetros";
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Location = new System.Drawing.Point(405, 7);
            this.lbProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(55, 13);
            this.lbProducts.TabIndex = 2;
            this.lbProducts.Text = "Productos";
            // 
            // lbIVA
            // 
            this.lbIVA.AutoSize = true;
            this.lbIVA.Location = new System.Drawing.Point(405, 47);
            this.lbIVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIVA.Name = "lbIVA";
            this.lbIVA.Size = new System.Drawing.Size(59, 13);
            this.lbIVA.TabIndex = 3;
            this.lbIVA.Text = "Aplicar IVA";
            this.lbIVA.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(606, 47);
            this.lbUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(99, 13);
            this.lbUnit.TabIndex = 4;
            this.lbUnit.Text = "Unidad c/u Medida";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(69, 145);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(37, 13);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Precio";
            // 
            // lbPriceIVA
            // 
            this.lbPriceIVA.AutoSize = true;
            this.lbPriceIVA.Location = new System.Drawing.Point(208, 153);
            this.lbPriceIVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPriceIVA.Name = "lbPriceIVA";
            this.lbPriceIVA.Size = new System.Drawing.Size(57, 13);
            this.lbPriceIVA.TabIndex = 6;
            this.lbPriceIVA.Text = "Precio IVA";
            // 
            // lbBuy
            // 
            this.lbBuy.AutoSize = true;
            this.lbBuy.Location = new System.Drawing.Point(405, 145);
            this.lbBuy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuy.Name = "lbBuy";
            this.lbBuy.Size = new System.Drawing.Size(76, 13);
            this.lbBuy.TabIndex = 7;
            this.lbBuy.Text = "Precio Compra";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
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
            this.cbMili.Location = new System.Drawing.Point(198, 75);
            this.cbMili.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMili.Name = "cbMili";
            this.cbMili.Size = new System.Drawing.Size(92, 21);
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
            this.cbIVA.Location = new System.Drawing.Point(396, 75);
            this.cbIVA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIVA.Name = "cbIVA";
            this.cbIVA.Size = new System.Drawing.Size(92, 21);
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
            this.cbUnit.Location = new System.Drawing.Point(608, 75);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(92, 21);
            this.cbUnit.TabIndex = 11;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(62, 176);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtPriceIVA
            // 
            this.txtPriceIVA.Location = new System.Drawing.Point(198, 176);
            this.txtPriceIVA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPriceIVA.Name = "txtPriceIVA";
            this.txtPriceIVA.Size = new System.Drawing.Size(76, 20);
            this.txtPriceIVA.TabIndex = 13;
            this.txtPriceIVA.TextChanged += new System.EventHandler(this.txtPriceIVA_TextChanged);
            // 
            // txtPriceBuy
            // 
            this.txtPriceBuy.Location = new System.Drawing.Point(403, 168);
            this.txtPriceBuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPriceBuy.Name = "txtPriceBuy";
            this.txtPriceBuy.Size = new System.Drawing.Size(76, 20);
            this.txtPriceBuy.TabIndex = 14;
            this.txtPriceBuy.TextChanged += new System.EventHandler(this.txtPriceBuy_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(924, 467);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 19);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtSeach
            // 
            this.txtSeach.Location = new System.Drawing.Point(838, 21);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(76, 20);
            this.txtSeach.TabIndex = 17;
            this.txtSeach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(783, 24);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(40, 13);
            this.lbSearch.TabIndex = 18;
            this.lbSearch.Text = "Buscar";
            this.lbSearch.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::AlexiEconomy.Properties.Resources.atra;
            this.btnBack.Location = new System.Drawing.Point(9, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 44);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1017, 467);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 19);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(552, 145);
            this.lbStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(60, 13);
            this.lbStock.TabIndex = 22;
            this.lbStock.Text = "Existencias";
            this.lbStock.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(541, 168);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(76, 20);
            this.txtStock.TabIndex = 23;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // btnSerch
            // 
            this.btnSerch.BackgroundImage = global::AlexiEconomy.Properties.Resources.Lupa;
            this.btnSerch.Location = new System.Drawing.Point(924, 20);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(21, 25);
            this.btnSerch.TabIndex = 24;
            this.btnSerch.UseVisualStyleBackColor = true;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(668, 136);
            this.lbCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(52, 13);
            this.lbCategory.TabIndex = 25;
            this.lbCategory.Text = "Categoria";
            this.lbCategory.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(657, 168);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(76, 20);
            this.txtCategory.TabIndex = 26;
            this.txtCategory.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 492);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbSearch);
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
            this.Controls.Add(this.lbBuy);
            this.Controls.Add(this.lbPriceIVA);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbIVA);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lbMili);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaProductos";
            this.Text = "AltaProductos";
            this.Load += new System.EventHandler(this.AltaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMili;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.Label lbIVA;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPriceIVA;
        private System.Windows.Forms.Label lbBuy;
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
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtCategory;
    }
}