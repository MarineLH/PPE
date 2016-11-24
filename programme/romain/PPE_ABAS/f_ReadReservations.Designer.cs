namespace PPE_ABAS
{
    partial class f_ReadReservations
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
            this.tab_ReservationsLists = new System.Windows.Forms.TabControl();
            this.tabPage_EnCours = new System.Windows.Forms.TabPage();
            this.lv_resa_EnCours = new System.Windows.Forms.ListView();
            this.tabPage_Historique = new System.Windows.Forms.TabPage();
            this.lv_resa_Histo = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_ReservationsLists.SuspendLayout();
            this.tabPage_EnCours.SuspendLayout();
            this.tabPage_Historique.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_ReservationsLists
            // 
            this.tab_ReservationsLists.Controls.Add(this.tabPage_EnCours);
            this.tab_ReservationsLists.Controls.Add(this.tabPage_Historique);
            this.tab_ReservationsLists.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab_ReservationsLists.Location = new System.Drawing.Point(0, 28);
            this.tab_ReservationsLists.Name = "tab_ReservationsLists";
            this.tab_ReservationsLists.SelectedIndex = 0;
            this.tab_ReservationsLists.Size = new System.Drawing.Size(667, 454);
            this.tab_ReservationsLists.TabIndex = 0;
            // 
            // tabPage_EnCours
            // 
            this.tabPage_EnCours.Controls.Add(this.lv_resa_EnCours);
            this.tabPage_EnCours.Location = new System.Drawing.Point(4, 23);
            this.tabPage_EnCours.Name = "tabPage_EnCours";
            this.tabPage_EnCours.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EnCours.Size = new System.Drawing.Size(659, 427);
            this.tabPage_EnCours.TabIndex = 0;
            this.tabPage_EnCours.Text = "En cours";
            this.tabPage_EnCours.UseVisualStyleBackColor = true;
            // 
            // lv_resa_EnCours
            // 
            this.lv_resa_EnCours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_resa_EnCours.GridLines = true;
            this.lv_resa_EnCours.Location = new System.Drawing.Point(3, 3);
            this.lv_resa_EnCours.Name = "lv_resa_EnCours";
            this.lv_resa_EnCours.Size = new System.Drawing.Size(653, 421);
            this.lv_resa_EnCours.TabIndex = 0;
            this.lv_resa_EnCours.UseCompatibleStateImageBehavior = false;
            this.lv_resa_EnCours.View = System.Windows.Forms.View.Details;
            // 
            // tabPage_Historique
            // 
            this.tabPage_Historique.Controls.Add(this.lv_resa_Histo);
            this.tabPage_Historique.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Historique.Name = "tabPage_Historique";
            this.tabPage_Historique.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Historique.Size = new System.Drawing.Size(659, 427);
            this.tabPage_Historique.TabIndex = 1;
            this.tabPage_Historique.Text = "Historique";
            this.tabPage_Historique.UseVisualStyleBackColor = true;
            // 
            // lv_resa_Histo
            // 
            this.lv_resa_Histo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_resa_Histo.Location = new System.Drawing.Point(3, 3);
            this.lv_resa_Histo.Name = "lv_resa_Histo";
            this.lv_resa_Histo.Size = new System.Drawing.Size(653, 421);
            this.lv_resa_Histo.TabIndex = 1;
            this.lv_resa_Histo.UseCompatibleStateImageBehavior = false;
            this.lv_resa_Histo.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inconsolata", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Réservations";
            // 
            // f_ReadReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab_ReservationsLists);
            this.Font = new System.Drawing.Font("Inconsolata", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "f_ReadReservations";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.f_ReadReservations_Load);
            this.tab_ReservationsLists.ResumeLayout(false);
            this.tabPage_EnCours.ResumeLayout(false);
            this.tabPage_Historique.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ReservationsLists;
        private System.Windows.Forms.TabPage tabPage_EnCours;
        private System.Windows.Forms.TabPage tabPage_Historique;
        private System.Windows.Forms.ListView lv_resa_EnCours;
        private System.Windows.Forms.ListView lv_resa_Histo;
        private System.Windows.Forms.Label label1;
    }
}