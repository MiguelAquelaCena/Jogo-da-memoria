namespace Jogo_da_memoria
{
    partial class FormDificuldade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDificuldade));
            this.Dif_Facil = new System.Windows.Forms.Button();
            this.Dif_media = new System.Windows.Forms.Button();
            this.Def_Dificil = new System.Windows.Forms.Button();
            this.Dif_Chosen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dif_Facil
            // 
            this.Dif_Facil.BackColor = System.Drawing.Color.Lime;
            this.Dif_Facil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dif_Facil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dif_Facil.Location = new System.Drawing.Point(40, 12);
            this.Dif_Facil.Name = "Dif_Facil";
            this.Dif_Facil.Size = new System.Drawing.Size(249, 26);
            this.Dif_Facil.TabIndex = 22;
            this.Dif_Facil.Tag = "o";
            this.Dif_Facil.Text = "Facil";
            this.Dif_Facil.UseVisualStyleBackColor = false;
            this.Dif_Facil.Click += new System.EventHandler(this.Dif_Facil_Click);
            // 
            // Dif_media
            // 
            this.Dif_media.BackColor = System.Drawing.Color.Gold;
            this.Dif_media.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dif_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dif_media.Location = new System.Drawing.Point(40, 44);
            this.Dif_media.Name = "Dif_media";
            this.Dif_media.Size = new System.Drawing.Size(249, 26);
            this.Dif_media.TabIndex = 23;
            this.Dif_media.Tag = "o";
            this.Dif_media.Text = "Media";
            this.Dif_media.UseVisualStyleBackColor = false;
            this.Dif_media.Click += new System.EventHandler(this.Dif_media_Click);
            // 
            // Def_Dificil
            // 
            this.Def_Dificil.BackColor = System.Drawing.Color.Red;
            this.Def_Dificil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Def_Dificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Def_Dificil.Location = new System.Drawing.Point(40, 76);
            this.Def_Dificil.Name = "Def_Dificil";
            this.Def_Dificil.Size = new System.Drawing.Size(249, 26);
            this.Def_Dificil.TabIndex = 24;
            this.Def_Dificil.Tag = "o";
            this.Def_Dificil.Text = "Dificil";
            this.Def_Dificil.UseVisualStyleBackColor = false;
            this.Def_Dificil.Click += new System.EventHandler(this.Def_Dificil_Click);
            // 
            // Dif_Chosen
            // 
            this.Dif_Chosen.BackColor = System.Drawing.Color.DarkRed;
            this.Dif_Chosen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dif_Chosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dif_Chosen.Location = new System.Drawing.Point(40, 108);
            this.Dif_Chosen.Name = "Dif_Chosen";
            this.Dif_Chosen.Size = new System.Drawing.Size(249, 26);
            this.Dif_Chosen.TabIndex = 25;
            this.Dif_Chosen.Tag = "o";
            this.Dif_Chosen.Text = "Chosen";
            this.Dif_Chosen.UseVisualStyleBackColor = false;
            this.Dif_Chosen.Click += new System.EventHandler(this.Dif_Chosen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_da_memoria.Properties.Resources.Brawlhalla_Logo_100M_Full;
            this.pictureBox1.Location = new System.Drawing.Point(335, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormDificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(488, 151);
            this.Controls.Add(this.Dif_Chosen);
            this.Controls.Add(this.Def_Dificil);
            this.Controls.Add(this.Dif_media);
            this.Controls.Add(this.Dif_Facil);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDificuldade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dificuldade";
            this.Load += new System.EventHandler(this.FormDificuldade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Dif_Facil;
        private System.Windows.Forms.Button Dif_media;
        private System.Windows.Forms.Button Def_Dificil;
        private System.Windows.Forms.Button Dif_Chosen;
    }
}