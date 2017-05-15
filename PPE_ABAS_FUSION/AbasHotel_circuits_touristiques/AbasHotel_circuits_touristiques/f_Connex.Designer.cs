namespace PPE_ABAS_Circuits
{
    partial class f_Connex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Connex));
            this.connexion = new System.Windows.Forms.Label();
            this.cb_chooseBat = new System.Windows.Forms.ComboBox();
            this.choix_hotel = new System.Windows.Forms.Label();
            this.bt_val_choix_hotel = new System.Windows.Forms.Button();
            this.lb_no_selected_hotel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connexion
            // 
            this.connexion.AutoSize = true;
            this.connexion.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexion.Location = new System.Drawing.Point(158, 232);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(203, 18);
            this.connexion.TabIndex = 0;
            this.connexion.Text = "connexion à la base de données..";
            // 
            // cb_chooseBat
            // 
            this.cb_chooseBat.FormattingEnabled = true;
            this.cb_chooseBat.Location = new System.Drawing.Point(43, 73);
            this.cb_chooseBat.Name = "cb_chooseBat";
            this.cb_chooseBat.Size = new System.Drawing.Size(213, 21);
            this.cb_chooseBat.TabIndex = 1;
            // 
            // choix_hotel
            // 
            this.choix_hotel.AutoSize = true;
            this.choix_hotel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choix_hotel.Location = new System.Drawing.Point(39, 22);
            this.choix_hotel.Name = "choix_hotel";
            this.choix_hotel.Size = new System.Drawing.Size(125, 20);
            this.choix_hotel.TabIndex = 2;
            this.choix_hotel.Text = "Nom de l\'Hôtel :";
            // 
            // bt_val_choix_hotel
            // 
            this.bt_val_choix_hotel.Location = new System.Drawing.Point(181, 132);
            this.bt_val_choix_hotel.Name = "bt_val_choix_hotel";
            this.bt_val_choix_hotel.Size = new System.Drawing.Size(75, 23);
            this.bt_val_choix_hotel.TabIndex = 3;
            this.bt_val_choix_hotel.Text = "valider";
            this.bt_val_choix_hotel.UseVisualStyleBackColor = true;
            this.bt_val_choix_hotel.Click += new System.EventHandler(this.bt_val_choix_hotel_Click);
            // 
            // lb_no_selected_hotel
            // 
            this.lb_no_selected_hotel.AutoSize = true;
            this.lb_no_selected_hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no_selected_hotel.ForeColor = System.Drawing.Color.Red;
            this.lb_no_selected_hotel.Location = new System.Drawing.Point(40, 142);
            this.lb_no_selected_hotel.Name = "lb_no_selected_hotel";
            this.lb_no_selected_hotel.Size = new System.Drawing.Size(115, 13);
            this.lb_no_selected_hotel.TabIndex = 4;
            this.lb_no_selected_hotel.Text = "Veuillez chosir un hôtel";
            // 
            // f_Connex
            // 
            this.ClientSize = new System.Drawing.Size(373, 259);
            this.Controls.Add(this.lb_no_selected_hotel);
            this.Controls.Add(this.bt_val_choix_hotel);
            this.Controls.Add(this.choix_hotel);
            this.Controls.Add(this.cb_chooseBat);
            this.Controls.Add(this.connexion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_Connex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abas Hôtel - Connexion";
            this.Load += new System.EventHandler(this.f_connex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label connexion;
        private System.Windows.Forms.ComboBox cb_chooseBat;
        private System.Windows.Forms.Label choix_hotel;
        private System.Windows.Forms.Button bt_val_choix_hotel;
        private System.Windows.Forms.Label lb_no_selected_hotel;
    }
}

