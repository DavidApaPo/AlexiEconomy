﻿namespace AlexiEconomy
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
            this.lbProducts = new System.Windows.Forms.Label();
            this.lbIVA = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPriceIVA = new System.Windows.Forms.Label();
            this.lbPriceBuy = new System.Windows.Forms.Label();
            this.cbMili = new System.Windows.Forms.ComboBox();
            this.cbIVA = new System.Windows.Forms.ComboBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPriceBuy = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSeach = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.TableProducts = new System.Windows.Forms.DataGridView();
            this.dataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPriceBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSerch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbMili = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.txtPriceIVA = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TableProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.Location = new System.Drawing.Point(616, 7);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(107, 26);
            this.lbProducts.TabIndex = 2;
            this.lbProducts.Text = "Productos";
            this.lbProducts.Click += new System.EventHandler(this.lbProducts_Click);
            // 
            // lbIVA
            // 
            this.lbIVA.AutoSize = true;
            this.lbIVA.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIVA.Location = new System.Drawing.Point(540, 58);
            this.lbIVA.Name = "lbIVA";
            this.lbIVA.Size = new System.Drawing.Size(84, 19);
            this.lbIVA.TabIndex = 3;
            this.lbIVA.Text = "Aplicar IVA";
            this.lbIVA.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnit.Location = new System.Drawing.Point(808, 58);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(137, 19);
            this.lbUnit.TabIndex = 4;
            this.lbUnit.Text = "Unidad c/u Medida";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(98, 130);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(52, 19);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Precio";
            // 
            // lbPriceIVA
            // 
            this.lbPriceIVA.AutoSize = true;
            this.lbPriceIVA.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceIVA.Location = new System.Drawing.Point(226, 130);
            this.lbPriceIVA.Name = "lbPriceIVA";
            this.lbPriceIVA.Size = new System.Drawing.Size(79, 19);
            this.lbPriceIVA.TabIndex = 6;
            this.lbPriceIVA.Text = "Precio IVA";
            // 
            // lbPriceBuy
            // 
            this.lbPriceBuy.AutoSize = true;
            this.lbPriceBuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceBuy.Location = new System.Drawing.Point(540, 178);
            this.lbPriceBuy.Name = "lbPriceBuy";
            this.lbPriceBuy.Size = new System.Drawing.Size(110, 19);
            this.lbPriceBuy.TabIndex = 7;
            this.lbPriceBuy.Text = "Precio Compra";
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
            this.cbIVA.SelectedIndexChanged += new System.EventHandler(this.cbIVA_SelectedIndexChanged);
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
            this.txtPrice.Location = new System.Drawing.Point(79, 159);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(84, 22);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
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
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(1232, 562);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSeach
            // 
            this.txtSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeach.Location = new System.Drawing.Point(1092, 9);
            this.txtSeach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.Size = new System.Drawing.Size(163, 28);
            this.txtSeach.TabIndex = 17;
            this.txtSeach.Text = "Buscar";
            this.txtSeach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1356, 562);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(736, 178);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(80, 19);
            this.lbStock.TabIndex = 22;
            this.lbStock.Text = "Existencias";
            this.lbStock.Click += new System.EventHandler(this.label9_Click);
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
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(876, 207);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 22);
            this.txtCategory.TabIndex = 26;
            this.txtCategory.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TableProducts
            // 
            this.TableProducts.AllowUserToAddRows = false;
            this.TableProducts.AllowUserToDeleteRows = false;
            this.TableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataName,
            this.dataMili,
            this.dataPriceBuy,
            this.dataBuy,
            this.dataStock,
            this.dataCategory});
            this.TableProducts.Location = new System.Drawing.Point(177, 263);
            this.TableProducts.Name = "TableProducts";
            this.TableProducts.ReadOnly = true;
            this.TableProducts.RowHeadersWidth = 51;
            this.TableProducts.RowTemplate.Height = 24;
            this.TableProducts.Size = new System.Drawing.Size(810, 580);
            this.TableProducts.TabIndex = 27;
            this.TableProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableProducts_CellContentClick_1);
            // 
            // dataName
            // 
            this.dataName.HeaderText = "Nombre";
            this.dataName.MinimumWidth = 6;
            this.dataName.Name = "dataName";
            this.dataName.ReadOnly = true;
            this.dataName.Width = 125;
            // 
            // dataMili
            // 
            this.dataMili.HeaderText = "Milimetros";
            this.dataMili.MinimumWidth = 6;
            this.dataMili.Name = "dataMili";
            this.dataMili.ReadOnly = true;
            this.dataMili.Width = 125;
            // 
            // dataPriceBuy
            // 
            this.dataPriceBuy.HeaderText = "Precio";
            this.dataPriceBuy.MinimumWidth = 6;
            this.dataPriceBuy.Name = "dataPriceBuy";
            this.dataPriceBuy.ReadOnly = true;
            this.dataPriceBuy.Width = 125;
            // 
            // dataBuy
            // 
            this.dataBuy.HeaderText = "Precio de Compra";
            this.dataBuy.MinimumWidth = 6;
            this.dataBuy.Name = "dataBuy";
            this.dataBuy.ReadOnly = true;
            this.dataBuy.Width = 125;
            // 
            // dataStock
            // 
            this.dataStock.HeaderText = "Existencias";
            this.dataStock.MinimumWidth = 6;
            this.dataStock.Name = "dataStock";
            this.dataStock.ReadOnly = true;
            this.dataStock.Width = 125;
            // 
            // dataCategory
            // 
            this.dataCategory.HeaderText = "Categoria";
            this.dataCategory.MinimumWidth = 6;
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.ReadOnly = true;
            this.dataCategory.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnSerch);
            this.panel1.Controls.Add(this.txtSeach);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lbProducts);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1521, 46);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSerch
            // 
            this.btnSerch.BackgroundImage = global::AlexiEconomy.Properties.Resources.Lupa;
            this.btnSerch.Location = new System.Drawing.Point(1251, 8);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(27, 29);
            this.btnSerch.TabIndex = 24;
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::AlexiEconomy.Properties.Resources.atra;
            this.btnBack.Location = new System.Drawing.Point(3, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 39);
            this.btnBack.TabIndex = 15;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(98, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(65, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nombre";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbMili
            // 
            this.lbMili.AutoSize = true;
            this.lbMili.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMili.Location = new System.Drawing.Point(271, 10);
            this.lbMili.Name = "lbMili";
            this.lbMili.Size = new System.Drawing.Size(81, 19);
            this.lbMili.TabIndex = 1;
            this.lbMili.Text = "Milimetros";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(883, 120);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(75, 19);
            this.lbCategory.TabIndex = 25;
            this.lbCategory.Text = "Categoria";
            this.lbCategory.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtPriceIVA
            // 
            this.txtPriceIVA.Location = new System.Drawing.Point(221, 159);
            this.txtPriceIVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPriceIVA.Name = "txtPriceIVA";
            this.txtPriceIVA.Size = new System.Drawing.Size(84, 22);
            this.txtPriceIVA.TabIndex = 13;
            this.txtPriceIVA.TextChanged += new System.EventHandler(this.txtPriceIVA_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.txtPriceIVA);
            this.panel2.Controls.Add(this.lbCategory);
            this.panel2.Controls.Add(this.lbMili);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.lbPriceIVA);
            this.panel2.Location = new System.Drawing.Point(4, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1466, 202);
            this.panel2.TabIndex = 28;
            // 
            // AltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 1055);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPriceBuy);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.cbIVA);
            this.Controls.Add(this.cbMili);
            this.Controls.Add(this.lbPriceBuy);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.lbIVA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AltaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AltaProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.Label lbIVA;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPriceIVA;
        private System.Windows.Forms.Label lbPriceBuy;
        private System.Windows.Forms.ComboBox cbMili;
        private System.Windows.Forms.ComboBox cbIVA;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPriceBuy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSeach;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DataGridView TableProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMili;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPriceBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbMili;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.TextBox txtPriceIVA;
        private System.Windows.Forms.Panel panel2;
    }
}