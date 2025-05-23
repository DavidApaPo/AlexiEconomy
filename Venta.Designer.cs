﻿namespace AlexiEconomy
{
    partial class Venta
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
            this.lbUnits = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.PaneMenu = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.PaneUpper = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbPriceResult = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.gbSell = new System.Windows.Forms.GroupBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.lbReceive = new System.Windows.Forms.Label();
            this.dgSale = new System.Windows.Forms.DataGridView();
            this.PaneMenu.SuspendLayout();
            this.PaneUpper.SuspendLayout();
            this.gbSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 28);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 16);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Nombre";
            // 
            // lbUnits
            // 
            this.lbUnits.AutoSize = true;
            this.lbUnits.Location = new System.Drawing.Point(218, 26);
            this.lbUnits.Name = "lbUnits";
            this.lbUnits.Size = new System.Drawing.Size(61, 16);
            this.lbUnits.TabIndex = 10;
            this.lbUnits.Text = "Cantidad";
            this.lbUnits.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(431, 23);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 16);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Precio";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(299, 20);
            this.txtUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(100, 22);
            this.txtUnits.TabIndex = 1;
            this.txtUnits.TextChanged += new System.EventHandler(this.txtUnits_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(493, 20);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // PaneMenu
            // 
            this.PaneMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PaneMenu.Controls.Add(this.btnBack);
            this.PaneMenu.Location = new System.Drawing.Point(-8, 0);
            this.PaneMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaneMenu.Name = "PaneMenu";
            this.PaneMenu.Size = new System.Drawing.Size(1375, 34);
            this.PaneMenu.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::AlexiEconomy.Properties.Resources.flecha_regesar;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Location = new System.Drawing.Point(27, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 41);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "     Regresar ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PaneUpper
            // 
            this.PaneUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(231)))));
            this.PaneUpper.Controls.Add(this.txtName);
            this.PaneUpper.Controls.Add(this.txtPrice);
            this.PaneUpper.Controls.Add(this.lbName);
            this.PaneUpper.Controls.Add(this.lbPrice);
            this.PaneUpper.Controls.Add(this.lbUnits);
            this.PaneUpper.Controls.Add(this.txtUnits);
            this.PaneUpper.Location = new System.Drawing.Point(-3, 37);
            this.PaneUpper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaneUpper.Name = "PaneUpper";
            this.PaneUpper.Size = new System.Drawing.Size(1850, 76);
            this.PaneUpper.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1321, 541);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(1199, 489);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(51, 16);
            this.lbResult.TabIndex = 14;
            this.lbResult.Text = "TOTAL";
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            // 
            // lbPriceResult
            // 
            this.lbPriceResult.AutoSize = true;
            this.lbPriceResult.Location = new System.Drawing.Point(1351, 489);
            this.lbPriceResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPriceResult.Name = "lbPriceResult";
            this.lbPriceResult.Size = new System.Drawing.Size(35, 16);
            this.lbPriceResult.TabIndex = 15;
            this.lbPriceResult.Text = "8520";
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.Location = new System.Drawing.Point(1181, 541);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(100, 28);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "Cobrar";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            this.btnSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSell_KeyDown);
            // 
            // gbSell
            // 
            this.gbSell.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbSell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbSell.Controls.Add(this.txtChange);
            this.gbSell.Controls.Add(this.txtReceive);
            this.gbSell.Controls.Add(this.lbChange);
            this.gbSell.Controls.Add(this.lbReceive);
            this.gbSell.Location = new System.Drawing.Point(431, 343);
            this.gbSell.Margin = new System.Windows.Forms.Padding(4);
            this.gbSell.Name = "gbSell";
            this.gbSell.Padding = new System.Windows.Forms.Padding(4);
            this.gbSell.Size = new System.Drawing.Size(638, 239);
            this.gbSell.TabIndex = 14;
            this.gbSell.TabStop = false;
            this.gbSell.Visible = false;
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(147, 108);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(132, 22);
            this.txtChange.TabIndex = 5;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(147, 40);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(132, 22);
            this.txtReceive.TabIndex = 4;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            this.txtReceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReceive_KeyDown);
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Location = new System.Drawing.Point(69, 108);
            this.lbChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(54, 16);
            this.lbChange.TabIndex = 13;
            this.lbChange.Text = "Cambio";
            // 
            // lbReceive
            // 
            this.lbReceive.AutoSize = true;
            this.lbReceive.Location = new System.Drawing.Point(65, 43);
            this.lbReceive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReceive.Name = "lbReceive";
            this.lbReceive.Size = new System.Drawing.Size(62, 16);
            this.lbReceive.TabIndex = 12;
            this.lbReceive.Text = "Recibido";
            // 
            // dgSale
            // 
            this.dgSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale.Location = new System.Drawing.Point(-7, 116);
            this.dgSale.Margin = new System.Windows.Forms.Padding(4);
            this.dgSale.Name = "dgSale";
            this.dgSale.RowHeadersWidth = 51;
            this.dgSale.Size = new System.Drawing.Size(1854, 206);
            this.dgSale.TabIndex = 3;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 613);
            this.Controls.Add(this.dgSale);
            this.Controls.Add(this.gbSell);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.PaneMenu);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.PaneUpper);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbPriceResult);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PaneMenu.ResumeLayout(false);
            this.PaneUpper.ResumeLayout(false);
            this.PaneUpper.PerformLayout();
            this.gbSell.ResumeLayout(false);
            this.gbSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUnits;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel PaneMenu;
        private System.Windows.Forms.Panel PaneUpper;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbPriceResult;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.GroupBox gbSell;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label lbReceive;
        private System.Windows.Forms.DataGridView dgSale;
        private System.Windows.Forms.Button btnBack;
    }
}