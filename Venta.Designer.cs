namespace AlexiEconomy
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
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbPriceResult = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.gbSell = new System.Windows.Forms.GroupBox();
            this.lbReceive = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.gbSell.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(10, 23);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nombre";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(10, 55);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 1;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(170, 50);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(37, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Precio";
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(64, 104);
            this.txtUnits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(76, 20);
            this.txtUnits.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 23);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(211, 43);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 28);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbCantidad);
            this.panel2.Location = new System.Drawing.Point(-6, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 132);
            this.panel2.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(938, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(776, 407);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(42, 13);
            this.lbResult.TabIndex = 11;
            this.lbResult.Text = "TOTAL";
            // 
            // lbPriceResult
            // 
            this.lbPriceResult.AutoSize = true;
            this.lbPriceResult.Location = new System.Drawing.Point(944, 407);
            this.lbPriceResult.Name = "lbPriceResult";
            this.lbPriceResult.Size = new System.Drawing.Size(31, 13);
            this.lbPriceResult.TabIndex = 12;
            this.lbPriceResult.Text = "8520";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(779, 478);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 13;
            this.btnSell.Text = "Cobrar";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // gbSell
            // 
            this.gbSell.Controls.Add(this.txtChange);
            this.gbSell.Controls.Add(this.txtReceive);
            this.gbSell.Controls.Add(this.lbChange);
            this.gbSell.Controls.Add(this.lbReceive);
            this.gbSell.Location = new System.Drawing.Point(381, 214);
            this.gbSell.Name = "gbSell";
            this.gbSell.Size = new System.Drawing.Size(315, 186);
            this.gbSell.TabIndex = 14;
            this.gbSell.TabStop = false;
            this.gbSell.Visible = false;
            // 
            // lbReceive
            // 
            this.lbReceive.AutoSize = true;
            this.lbReceive.Location = new System.Drawing.Point(49, 35);
            this.lbReceive.Name = "lbReceive";
            this.lbReceive.Size = new System.Drawing.Size(49, 13);
            this.lbReceive.TabIndex = 0;
            this.lbReceive.Text = "Recibido";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Location = new System.Drawing.Point(52, 88);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(42, 13);
            this.lbChange.TabIndex = 1;
            this.lbChange.Text = "Cambio";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(194, 35);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(100, 20);
            this.txtReceive.TabIndex = 2;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(194, 81);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(100, 20);
            this.txtChange.TabIndex = 3;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 513);
            this.Controls.Add(this.gbSell);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lbPriceResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbSell.ResumeLayout(false);
            this.gbSell.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbPriceResult;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.GroupBox gbSell;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label lbReceive;
    }
}