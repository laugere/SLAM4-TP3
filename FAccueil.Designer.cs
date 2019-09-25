namespace MusicAtoutV1
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_villes = new System.Windows.Forms.Button();
            this.btn_salles = new System.Windows.Forms.Button();
            this.btn_oeuvres = new System.Windows.Forms.Button();
            this.btn_batiments = new System.Windows.Forms.Button();
            this.ImageCenter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_villes
            // 
            this.btn_villes.Location = new System.Drawing.Point(12, 12);
            this.btn_villes.Name = "btn_villes";
            this.btn_villes.Size = new System.Drawing.Size(158, 23);
            this.btn_villes.TabIndex = 1;
            this.btn_villes.Text = "Gestion des villes";
            this.btn_villes.UseVisualStyleBackColor = true;
            this.btn_villes.Click += new System.EventHandler(this.Btn_villes_Click);
            // 
            // btn_salles
            // 
            this.btn_salles.Location = new System.Drawing.Point(12, 415);
            this.btn_salles.Name = "btn_salles";
            this.btn_salles.Size = new System.Drawing.Size(158, 23);
            this.btn_salles.TabIndex = 2;
            this.btn_salles.Text = "Gestion des salles";
            this.btn_salles.UseVisualStyleBackColor = true;
            this.btn_salles.Click += new System.EventHandler(this.Btn_salles_Click);
            // 
            // btn_oeuvres
            // 
            this.btn_oeuvres.Location = new System.Drawing.Point(609, 415);
            this.btn_oeuvres.Name = "btn_oeuvres";
            this.btn_oeuvres.Size = new System.Drawing.Size(179, 23);
            this.btn_oeuvres.TabIndex = 3;
            this.btn_oeuvres.Text = "Gestion des oeuvres";
            this.btn_oeuvres.UseVisualStyleBackColor = true;
            this.btn_oeuvres.Click += new System.EventHandler(this.Btn_oeuvres_Click);
            // 
            // btn_batiments
            // 
            this.btn_batiments.Location = new System.Drawing.Point(609, 12);
            this.btn_batiments.Name = "btn_batiments";
            this.btn_batiments.Size = new System.Drawing.Size(179, 23);
            this.btn_batiments.TabIndex = 4;
            this.btn_batiments.Text = "Gestion des bâtiments";
            this.btn_batiments.UseVisualStyleBackColor = true;
            this.btn_batiments.Click += new System.EventHandler(this.Btn_batiments_Click);
            // 
            // ImageCenter
            // 
            this.ImageCenter.BackgroundImage = global::MusicAtoutV1.Properties.Resources.ES_Spotify_logo_with_text_svg__1024x308_1;
            this.ImageCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageCenter.Location = new System.Drawing.Point(229, 139);
            this.ImageCenter.Name = "ImageCenter";
            this.ImageCenter.Size = new System.Drawing.Size(323, 163);
            this.ImageCenter.TabIndex = 0;
            this.ImageCenter.TabStop = false;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_batiments);
            this.Controls.Add(this.btn_oeuvres);
            this.Controls.Add(this.btn_salles);
            this.Controls.Add(this.btn_villes);
            this.Controls.Add(this.ImageCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FrmAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageCenter;
        private System.Windows.Forms.Button btn_villes;
        private System.Windows.Forms.Button btn_salles;
        private System.Windows.Forms.Button btn_oeuvres;
        private System.Windows.Forms.Button btn_batiments;
    }
}

