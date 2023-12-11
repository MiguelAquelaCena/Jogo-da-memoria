namespace Jogo_da_memoria
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.login_entrar = new System.Windows.Forms.Button();
            this.Login_Cancelar = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Passe = new System.Windows.Forms.TextBox();
            this.mostrar = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_entrar
            // 
            this.login_entrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.login_entrar.FlatAppearance.BorderSize = 2;
            this.login_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_entrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.login_entrar.Location = new System.Drawing.Point(33, 119);
            this.login_entrar.Name = "login_entrar";
            this.login_entrar.Size = new System.Drawing.Size(88, 29);
            this.login_entrar.TabIndex = 0;
            this.login_entrar.Text = "Entrar";
            this.login_entrar.UseVisualStyleBackColor = true;
            this.login_entrar.Click += new System.EventHandler(this.login_entrar_Click);
            // 
            // Login_Cancelar
            // 
            this.Login_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Login_Cancelar.FlatAppearance.BorderSize = 2;
            this.Login_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Login_Cancelar.Location = new System.Drawing.Point(143, 119);
            this.Login_Cancelar.Name = "Login_Cancelar";
            this.Login_Cancelar.Size = new System.Drawing.Size(88, 29);
            this.Login_Cancelar.TabIndex = 1;
            this.Login_Cancelar.Text = "Cancelar";
            this.Login_Cancelar.UseVisualStyleBackColor = true;
            this.Login_Cancelar.Click += new System.EventHandler(this.Login_Cancelar_Click);
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Gray;
            this.Username.Location = new System.Drawing.Point(33, 50);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(198, 19);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // Passe
            // 
            this.Passe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Passe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passe.ForeColor = System.Drawing.Color.Gray;
            this.Passe.Location = new System.Drawing.Point(33, 94);
            this.Passe.Name = "Passe";
            this.Passe.Size = new System.Drawing.Size(198, 19);
            this.Passe.TabIndex = 3;
            this.Passe.Text = "Password";
            this.Passe.UseSystemPasswordChar = true;
            // 
            // mostrar
            // 
            this.mostrar.AutoSize = true;
            this.mostrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.mostrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mostrar.Location = new System.Drawing.Point(237, 94);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(54, 16);
            this.mostrar.TabIndex = 4;
            this.mostrar.TabStop = true;
            this.mostrar.Text = "Mostrar";
            this.mostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mostrar_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_da_memoria.Properties.Resources.Brawlhalla_Logo_100M_Full;
            this.pictureBox1.Location = new System.Drawing.Point(297, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // register
            // 
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.register.FlatAppearance.BorderSize = 2;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.register.Location = new System.Drawing.Point(85, 154);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(88, 29);
            this.register.TabIndex = 6;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(422, 182);
            this.Controls.Add(this.register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mostrar);
            this.Controls.Add(this.Passe);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Login_Cancelar);
            this.Controls.Add(this.login_entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_entrar;
        private System.Windows.Forms.Button Login_Cancelar;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Passe;
        private System.Windows.Forms.LinkLabel mostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button register;
    }
}