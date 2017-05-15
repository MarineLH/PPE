namespace PPE_Accueil_Commun
{
    partial class FChooseAppli
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_hotel = new System.Windows.Forms.Button();
            this.bt_resto = new System.Windows.Forms.Button();
            this.bt_voitures = new System.Windows.Forms.Button();
            this.bt_circuits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_quit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bt_hotel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_resto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_voitures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_circuits, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_hotel
            // 
            this.bt_hotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_hotel.Location = new System.Drawing.Point(3, 3);
            this.bt_hotel.Name = "bt_hotel";
            this.bt_hotel.Size = new System.Drawing.Size(134, 82);
            this.bt_hotel.TabIndex = 0;
            this.bt_hotel.Text = "Gestion des hotels et réservations";
            this.bt_hotel.UseVisualStyleBackColor = true;
            this.bt_hotel.Click += new System.EventHandler(this.bt_hotel_Click);
            // 
            // bt_resto
            // 
            this.bt_resto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_resto.Location = new System.Drawing.Point(143, 3);
            this.bt_resto.Name = "bt_resto";
            this.bt_resto.Size = new System.Drawing.Size(135, 82);
            this.bt_resto.TabIndex = 1;
            this.bt_resto.Text = "Gestion des réservations de restaurants";
            this.bt_resto.UseVisualStyleBackColor = true;
            this.bt_resto.Click += new System.EventHandler(this.bt_resto_Click);
            // 
            // bt_voitures
            // 
            this.bt_voitures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_voitures.Location = new System.Drawing.Point(3, 91);
            this.bt_voitures.Name = "bt_voitures";
            this.bt_voitures.Size = new System.Drawing.Size(134, 82);
            this.bt_voitures.TabIndex = 2;
            this.bt_voitures.Text = "Gestion des véhicules de location";
            this.bt_voitures.UseVisualStyleBackColor = true;
            this.bt_voitures.Click += new System.EventHandler(this.bt_voitures_Click);
            // 
            // bt_circuits
            // 
            this.bt_circuits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_circuits.Location = new System.Drawing.Point(143, 91);
            this.bt_circuits.Name = "bt_circuits";
            this.bt_circuits.Size = new System.Drawing.Size(135, 82);
            this.bt_circuits.TabIndex = 3;
            this.bt_circuits.Text = "Gestion des circuits touristiques";
            this.bt_circuits.UseVisualStyleBackColor = true;
            this.bt_circuits.Click += new System.EventHandler(this.bt_circuits_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue sur le logiciel de gestion des hôtels ABAS.\r\nChoisissez une application" +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(218, 234);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(75, 23);
            this.bt_quit.TabIndex = 2;
            this.bt_quit.Text = "Fermer";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // FChooseAppli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 269);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FChooseAppli";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Button bt_hotel;
        private System.Windows.Forms.Button bt_resto;
        private System.Windows.Forms.Button bt_voitures;
        private System.Windows.Forms.Button bt_circuits;
    }
}

