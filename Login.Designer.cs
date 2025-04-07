namespace AlexiEconomy
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneBackground = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.paneBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneBackground
            // 
            this.paneBackground.BackColor = System.Drawing.Color.Transparent;
            this.paneBackground.BackgroundImage = global::AlexiEconomy.Properties.Resources.fondo;
            this.paneBackground.Controls.Add(this.gbLogin);
            this.paneBackground.Location = new System.Drawing.Point(416, 12);
            this.paneBackground.Margin = new System.Windows.Forms.Padding(2);
            this.paneBackground.Name = "paneBackground";
            this.paneBackground.Size = new System.Drawing.Size(414, 491);
            this.paneBackground.TabIndex = 5;
            this.paneBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.paneBackground_Paint);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(155, 186);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(72, 19);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Usuario";
            this.lbUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(142, 253);
            this.lbContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(102, 19);
            this.lbContraseña.TabIndex = 2;
            this.lbContraseña.Text = "Contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Aqua;
            this.btnLogin.Location = new System.Drawing.Point(124, 341);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureProfile
            // 
            this.pictureProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureProfile.BackgroundImage = global::AlexiEconomy.Properties.Resources.login;
            this.pictureProfile.Location = new System.Drawing.Point(102, 19);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(151, 144);
            this.pictureProfile.TabIndex = 5;
            this.pictureProfile.TabStop = false;
            this.pictureProfile.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtPass
            // 
            this.txtPass.AcceptsTab = true;
            this.txtPass.Location = new System.Drawing.Point(144, 284);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.AcceptsTab = true;
            this.txtUser.Location = new System.Drawing.Point(144, 220);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(95, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.txtPass);
            this.gbLogin.Controls.Add(this.txtUser);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.pictureProfile);
            this.gbLogin.Controls.Add(this.lbContraseña);
            this.gbLogin.Controls.Add(this.lbUser);
            this.gbLogin.Location = new System.Drawing.Point(37, 64);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(358, 390);
            this.gbLogin.TabIndex = 6;
            this.gbLogin.TabStop = false;
            this.gbLogin.Enter += new System.EventHandler(this.txtUse_TextChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1027, 616);
            this.Controls.Add(this.paneBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Form1";
            this.paneBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel paneBackground;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.GroupBox gbLogin;
    }
}

