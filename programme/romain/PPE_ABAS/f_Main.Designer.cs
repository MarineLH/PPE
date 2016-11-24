namespace PPE_ABAS
{
    partial class f_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerDeBatimentTSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterTSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resaListeTSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resaAjouterTSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientsListeTSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientAjouterTSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ListeResas = new System.Windows.Forms.Label();
            this.lbl_ListeHisto = new System.Windows.Forms.Label();
            this.lbl_addResa = new System.Windows.Forms.Label();
            this.lbl_olvOpen = new System.Windows.Forms.Label();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.reservationsToolStripMenuItem,
            this.clientsToolStripMenuItem});
            resources.ApplyResources(this.ms_main, "ms_main");
            this.ms_main.Name = "ms_main";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerDeBatimentTSItem,
            this.quitterTSItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            resources.ApplyResources(this.applicationToolStripMenuItem, "applicationToolStripMenuItem");
            // 
            // changerDeBatimentTSItem
            // 
            this.changerDeBatimentTSItem.Name = "changerDeBatimentTSItem";
            resources.ApplyResources(this.changerDeBatimentTSItem, "changerDeBatimentTSItem");
            this.changerDeBatimentTSItem.Click += new System.EventHandler(this.changerDeBatimentToolStripMenuItem_Click);
            // 
            // quitterTSItem
            // 
            this.quitterTSItem.Name = "quitterTSItem";
            resources.ApplyResources(this.quitterTSItem, "quitterTSItem");
            this.quitterTSItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resaListeTSItem,
            this.resaAjouterTSItem});
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            resources.ApplyResources(this.reservationsToolStripMenuItem, "reservationsToolStripMenuItem");
            // 
            // resaListeTSItem
            // 
            this.resaListeTSItem.Name = "resaListeTSItem";
            resources.ApplyResources(this.resaListeTSItem, "resaListeTSItem");
            this.resaListeTSItem.Click += new System.EventHandler(this.resaListeTSItem_Click);
            // 
            // resaAjouterTSItem
            // 
            this.resaAjouterTSItem.Name = "resaAjouterTSItem";
            resources.ApplyResources(this.resaAjouterTSItem, "resaAjouterTSItem");
            this.resaAjouterTSItem.Click += new System.EventHandler(this.resaAjouterTSItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientsListeTSItem,
            this.clientAjouterTSItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            resources.ApplyResources(this.clientsToolStripMenuItem, "clientsToolStripMenuItem");
            // 
            // ClientsListeTSItem
            // 
            this.ClientsListeTSItem.Name = "ClientsListeTSItem";
            resources.ApplyResources(this.ClientsListeTSItem, "ClientsListeTSItem");
            // 
            // clientAjouterTSItem
            // 
            this.clientAjouterTSItem.Name = "clientAjouterTSItem";
            resources.ApplyResources(this.clientAjouterTSItem, "clientAjouterTSItem");
            // 
            // lbl_ListeResas
            // 
            resources.ApplyResources(this.lbl_ListeResas, "lbl_ListeResas");
            this.lbl_ListeResas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lbl_ListeResas.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ListeResas.Name = "lbl_ListeResas";
            this.lbl_ListeResas.Click += new System.EventHandler(this.lbl_ListeResas_Click);
            // 
            // lbl_ListeHisto
            // 
            resources.ApplyResources(this.lbl_ListeHisto, "lbl_ListeHisto");
            this.lbl_ListeHisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lbl_ListeHisto.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ListeHisto.Name = "lbl_ListeHisto";
            this.lbl_ListeHisto.Click += new System.EventHandler(this.lbl_ListeHisto_Click);
            // 
            // lbl_addResa
            // 
            resources.ApplyResources(this.lbl_addResa, "lbl_addResa");
            this.lbl_addResa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lbl_addResa.ForeColor = System.Drawing.Color.Blue;
            this.lbl_addResa.Name = "lbl_addResa";
            this.lbl_addResa.Click += new System.EventHandler(this.lbl_addResa_Click);
            // 
            // lbl_olvOpen
            // 
            resources.ApplyResources(this.lbl_olvOpen, "lbl_olvOpen");
            this.lbl_olvOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lbl_olvOpen.ForeColor = System.Drawing.Color.Blue;
            this.lbl_olvOpen.Name = "lbl_olvOpen";
            this.lbl_olvOpen.Click += new System.EventHandler(this.lbl_olvOpen_Click);
            // 
            // f_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Controls.Add(this.lbl_olvOpen);
            this.Controls.Add(this.lbl_addResa);
            this.Controls.Add(this.lbl_ListeHisto);
            this.Controls.Add(this.lbl_ListeResas);
            this.Controls.Add(this.ms_main);
            this.IsMdiContainer = true;
            this.Name = "f_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_Main_FormClosed);
            this.Load += new System.EventHandler(this.f_Main_Load);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterTSItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resaListeTSItem;
        private System.Windows.Forms.ToolStripMenuItem resaAjouterTSItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientsListeTSItem;
        private System.Windows.Forms.ToolStripMenuItem clientAjouterTSItem;
        private System.Windows.Forms.ToolStripMenuItem changerDeBatimentTSItem;
        private System.Windows.Forms.Label lbl_ListeResas;
        private System.Windows.Forms.Label lbl_ListeHisto;
        private System.Windows.Forms.Label lbl_addResa;
        private System.Windows.Forms.Label lbl_olvOpen;
    }
}

