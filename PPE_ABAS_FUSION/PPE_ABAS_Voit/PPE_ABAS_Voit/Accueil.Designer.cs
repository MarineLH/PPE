namespace PPE_ABAS_Voit
{
    partial class Accueil
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
            this.hotel_select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valider_hotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotel_select
            // 
            this.hotel_select.FormattingEnabled = true;
            this.hotel_select.Location = new System.Drawing.Point(192, 140);
            this.hotel_select.Name = "hotel_select";
            this.hotel_select.Size = new System.Drawing.Size(121, 24);
            this.hotel_select.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionnez un hotel";
            // 
            // valider_hotel
            // 
            this.valider_hotel.Location = new System.Drawing.Point(124, 231);
            this.valider_hotel.Name = "valider_hotel";
            this.valider_hotel.Size = new System.Drawing.Size(99, 45);
            this.valider_hotel.TabIndex = 2;
            this.valider_hotel.Text = "Validez";
            this.valider_hotel.UseVisualStyleBackColor = true;
            this.valider_hotel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 333);
            this.Controls.Add(this.valider_hotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotel_select);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hotel_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button valider_hotel;
    }
}

