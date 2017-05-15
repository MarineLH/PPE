namespace PPE_ABAS_Voit
{
    partial class page_principale
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.retour = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Select_modele = new System.Windows.Forms.ComboBox();
            this.Select_gamme = new System.Windows.Forms.ComboBox();
            this.Select_Client = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vehicule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Fin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(599, 421);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.retour);
            this.tabPage1.Controls.Add(this.Valider);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Select_modele);
            this.tabPage1.Controls.Add(this.Select_gamme);
            this.tabPage1.Controls.Add(this.Select_Client);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(591, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter une réservation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(353, 343);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 23);
            this.retour.TabIndex = 7;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(167, 344);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 6;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sélectionnez un véhicule :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sélectionnez la gamme de véhicule :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selectionnez une réservation :";
            // 
            // Select_modele
            // 
            this.Select_modele.Enabled = false;
            this.Select_modele.FormattingEnabled = true;
            this.Select_modele.Location = new System.Drawing.Point(310, 286);
            this.Select_modele.Name = "Select_modele";
            this.Select_modele.Size = new System.Drawing.Size(121, 24);
            this.Select_modele.TabIndex = 2;
            // 
            // Select_gamme
            // 
            this.Select_gamme.Enabled = false;
            this.Select_gamme.FormattingEnabled = true;
            this.Select_gamme.Items.AddRange(new object[] {
            "Standard",
            "Confort",
            "Luxe"});
            this.Select_gamme.Location = new System.Drawing.Point(310, 170);
            this.Select_gamme.Name = "Select_gamme";
            this.Select_gamme.Size = new System.Drawing.Size(121, 24);
            this.Select_gamme.TabIndex = 1;
            this.Select_gamme.SelectedIndexChanged += new System.EventHandler(this.Select_gamme_SelectedIndexChanged);
            // 
            // Select_Client
            // 
            this.Select_Client.FormattingEnabled = true;
            this.Select_Client.Location = new System.Drawing.Point(310, 64);
            this.Select_Client.Name = "Select_Client";
            this.Select_Client.Size = new System.Drawing.Size(121, 24);
            this.Select_Client.TabIndex = 0;
            this.Select_Client.SelectedIndexChanged += new System.EventHandler(this.Select_Client_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(591, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gérer les réservations";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Client,
            this.Vehicule,
            this.Date_Fin});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(34, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 275);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Client
            // 
            this.Client.Text = "Client";
            this.Client.Width = 132;
            // 
            // Vehicule
            // 
            this.Vehicule.Text = "Véhicule";
            this.Vehicule.Width = 92;
            // 
            // Date_Fin
            // 
            this.Date_Fin.Text = "Date de fin";
            this.Date_Fin.Width = 84;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(591, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gérer les véhicules";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gérer les véhicules";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter un véhicule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 30);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // page_principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 424);
            this.Controls.Add(this.tabControl1);
            this.Name = "page_principale";
            this.Text = "Page_Principale";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox Select_modele;
        private System.Windows.Forms.ComboBox Select_gamme;
        private System.Windows.Forms.ComboBox Select_Client;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ColumnHeader Vehicule;
        private System.Windows.Forms.ColumnHeader Date_Fin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}