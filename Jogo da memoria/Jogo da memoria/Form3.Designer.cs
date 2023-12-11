namespace Jogo_da_memoria
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Username = new System.Windows.Forms.TextBox();
            this.Passe = new System.Windows.Forms.TextBox();
            this.passe2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Criar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Gray;
            this.Username.Location = new System.Drawing.Point(52, 32);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(198, 19);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Passe
            // 
            this.Passe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Passe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passe.ForeColor = System.Drawing.Color.Gray;
            this.Passe.Location = new System.Drawing.Point(52, 57);
            this.Passe.Name = "Passe";
            this.Passe.Size = new System.Drawing.Size(198, 19);
            this.Passe.TabIndex = 4;
            this.Passe.Text = "Password";
            this.Passe.UseSystemPasswordChar = true;
            // 
            // passe2
            // 
            this.passe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passe2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passe2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passe2.ForeColor = System.Drawing.Color.Gray;
            this.passe2.Location = new System.Drawing.Point(52, 82);
            this.passe2.Name = "passe2";
            this.passe2.Size = new System.Drawing.Size(198, 19);
            this.passe2.TabIndex = 5;
            this.passe2.Text = "Password";
            this.passe2.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_da_memoria.Properties.Resources.Brawlhalla_Logo_100M_Full;
            this.pictureBox1.Location = new System.Drawing.Point(285, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Criar
            // 
            this.Criar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Criar.FlatAppearance.BorderSize = 2;
            this.Criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Criar.Location = new System.Drawing.Point(52, 107);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(88, 29);
            this.Criar.TabIndex = 7;
            this.Criar.Text = "Criar";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // cancelar
            // 
            this.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelar.FlatAppearance.BorderSize = 2;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelar.Location = new System.Drawing.Point(162, 107);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(88, 29);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(399, 146);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passe2);
            this.Controls.Add(this.Passe);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Passe;
        private System.Windows.Forms.TextBox passe2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button cancelar;
    }
}