namespace PPE_ABAS
{
    partial class FMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainMenu));
            this.lbl_selectedBat = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tp_resas_en_cours = new System.Windows.Forms.TabPage();
            this.olv_resas = new BrightIdeasSoftware.ObjectListView();
            this.olvc_resa_date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_resa_nbJours = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_resa_dateSortie = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_resa_clientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_resa_numChambre = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_resa_status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tp_historique = new System.Windows.Forms.TabPage();
            this.olv_histo = new BrightIdeasSoftware.ObjectListView();
            this.olvc_histo_date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_histo_nbJours = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_histo_dateSortie = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_histo_client = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_histo_chambre = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_histo_status = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tp_clientsHotel = new System.Windows.Forms.TabPage();
            this.olv_clients = new BrightIdeasSoftware.ObjectListView();
            this.olvc_client_clientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_client_adl1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_client_adcp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_client_adville = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_client_tel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_client_mail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_client_totalHotel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvc_client_totalChaine = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.bt_quit = new System.Windows.Forms.Button();
            this.cb_chooseBat = new System.Windows.Forms.ComboBox();
            this.abas_db_dataSet = new PPE_ABAS.abas_db_dataSet();
            this.batimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batimentTableAdapter = new PPE_ABAS.abas_db_dataSetTableAdapters.BatimentTableAdapter();
            this.bt_addRes = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.cm_olvi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cm_olvi_client = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierLesInformationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLesInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.tp_resas_en_cours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_resas)).BeginInit();
            this.tp_historique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_histo)).BeginInit();
            this.tp_clientsHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olv_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abas_db_dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batimentBindingSource)).BeginInit();
            this.cm_olvi.SuspendLayout();
            this.cm_olvi_client.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_selectedBat
            // 
            this.lbl_selectedBat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_selectedBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedBat.Location = new System.Drawing.Point(0, 0);
            this.lbl_selectedBat.Name = "lbl_selectedBat";
            this.lbl_selectedBat.Size = new System.Drawing.Size(1013, 26);
            this.lbl_selectedBat.TabIndex = 0;
            this.lbl_selectedBat.Text = "Globals.selectedBat.ToString()";
            this.lbl_selectedBat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tp_resas_en_cours);
            this.tabs.Controls.Add(this.tp_historique);
            this.tabs.Controls.Add(this.tp_clientsHotel);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ItemSize = new System.Drawing.Size(71, 30);
            this.tabs.Location = new System.Drawing.Point(12, 29);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(989, 653);
            this.tabs.TabIndex = 1;
            // 
            // tp_resas_en_cours
            // 
            this.tp_resas_en_cours.Controls.Add(this.olv_resas);
            this.tp_resas_en_cours.Location = new System.Drawing.Point(4, 34);
            this.tp_resas_en_cours.Name = "tp_resas_en_cours";
            this.tp_resas_en_cours.Padding = new System.Windows.Forms.Padding(3);
            this.tp_resas_en_cours.Size = new System.Drawing.Size(981, 615);
            this.tp_resas_en_cours.TabIndex = 0;
            this.tp_resas_en_cours.Text = "Resources.tp_resas_en_cours";
            this.tp_resas_en_cours.UseVisualStyleBackColor = true;
            // 
            // olv_resas
            // 
            this.olv_resas.AllColumns.Add(this.olvc_resa_date);
            this.olv_resas.AllColumns.Add(this.olvc_resa_nbJours);
            this.olv_resas.AllColumns.Add(this.olvc_resa_dateSortie);
            this.olv_resas.AllColumns.Add(this.olvc_resa_clientName);
            this.olv_resas.AllColumns.Add(this.olvc_resa_numChambre);
            this.olv_resas.AllColumns.Add(this.olvc_resa_status);
            this.olv_resas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olv_resas.CellEditUseWholeCell = false;
            this.olv_resas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_resa_date,
            this.olvc_resa_nbJours,
            this.olvc_resa_dateSortie,
            this.olvc_resa_clientName,
            this.olvc_resa_numChambre,
            this.olvc_resa_status});
            this.olv_resas.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_resas.FullRowSelect = true;
            this.olv_resas.Location = new System.Drawing.Point(3, 33);
            this.olv_resas.Name = "olv_resas";
            this.olv_resas.Size = new System.Drawing.Size(975, 579);
            this.olv_resas.TabIndex = 0;
            this.olv_resas.UseCompatibleStateImageBehavior = false;
            this.olv_resas.View = System.Windows.Forms.View.Details;
            this.olv_resas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.olv_resas_MouseClick);
            // 
            // olvc_resa_date
            // 
            this.olvc_resa_date.AspectName = "res_date";
            this.olvc_resa_date.Groupable = false;
            this.olvc_resa_date.Text = "Resources.olvc_date";
            this.olvc_resa_date.Width = 160;
            // 
            // olvc_resa_nbJours
            // 
            this.olvc_resa_nbJours.AspectName = "res_nbJours";
            this.olvc_resa_nbJours.Groupable = false;
            this.olvc_resa_nbJours.Text = "Resources.olvc_nbJours";
            this.olvc_resa_nbJours.Width = 120;
            // 
            // olvc_resa_dateSortie
            // 
            this.olvc_resa_dateSortie.AspectName = "res_dateSortie";
            this.olvc_resa_dateSortie.Groupable = false;
            this.olvc_resa_dateSortie.Text = "Resources.olvc_dateSortie";
            this.olvc_resa_dateSortie.Width = 160;
            // 
            // olvc_resa_clientName
            // 
            this.olvc_resa_clientName.AspectName = "Client_cli_id";
            this.olvc_resa_clientName.Text = "Resources.olvc_clientName";
            this.olvc_resa_clientName.Width = 200;
            // 
            // olvc_resa_numChambre
            // 
            this.olvc_resa_numChambre.AspectName = "numChambre";
            this.olvc_resa_numChambre.Text = "Resources.olvc_numChambre";
            this.olvc_resa_numChambre.Width = 75;
            // 
            // olvc_resa_status
            // 
            this.olvc_resa_status.AspectName = "ReservationStatus_rest_id";
            this.olvc_resa_status.Text = "Resources.olvc_status";
            this.olvc_resa_status.Width = 75;
            // 
            // tp_historique
            // 
            this.tp_historique.Controls.Add(this.olv_histo);
            this.tp_historique.Location = new System.Drawing.Point(4, 34);
            this.tp_historique.Name = "tp_historique";
            this.tp_historique.Padding = new System.Windows.Forms.Padding(3);
            this.tp_historique.Size = new System.Drawing.Size(981, 615);
            this.tp_historique.TabIndex = 1;
            this.tp_historique.Text = "Resources.tp_historique";
            this.tp_historique.UseVisualStyleBackColor = true;
            // 
            // olv_histo
            // 
            this.olv_histo.AllColumns.Add(this.olvc_histo_date);
            this.olv_histo.AllColumns.Add(this.olvc_histo_nbJours);
            this.olv_histo.AllColumns.Add(this.olvc_histo_dateSortie);
            this.olv_histo.AllColumns.Add(this.olvc_histo_client);
            this.olv_histo.AllColumns.Add(this.olvc_histo_chambre);
            this.olv_histo.AllColumns.Add(this.olvc_histo_status);
            this.olv_histo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olv_histo.CellEditUseWholeCell = false;
            this.olv_histo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_histo_date,
            this.olvc_histo_nbJours,
            this.olvc_histo_dateSortie,
            this.olvc_histo_client,
            this.olvc_histo_chambre,
            this.olvc_histo_status});
            this.olv_histo.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_histo.FullRowSelect = true;
            this.olv_histo.Location = new System.Drawing.Point(3, 33);
            this.olv_histo.Name = "olv_histo";
            this.olv_histo.Size = new System.Drawing.Size(975, 579);
            this.olv_histo.TabIndex = 1;
            this.olv_histo.UseCompatibleStateImageBehavior = false;
            this.olv_histo.View = System.Windows.Forms.View.Details;
            // 
            // olvc_histo_date
            // 
            this.olvc_histo_date.AspectName = "res_date";
            this.olvc_histo_date.Groupable = false;
            this.olvc_histo_date.Text = "Resources.olvc_date";
            this.olvc_histo_date.Width = 160;
            // 
            // olvc_histo_nbJours
            // 
            this.olvc_histo_nbJours.AspectName = "res_nbJours";
            this.olvc_histo_nbJours.Groupable = false;
            this.olvc_histo_nbJours.Text = "Resources.olvc_nbJours";
            this.olvc_histo_nbJours.Width = 120;
            // 
            // olvc_histo_dateSortie
            // 
            this.olvc_histo_dateSortie.AspectName = "res_dateSortie";
            this.olvc_histo_dateSortie.Groupable = false;
            this.olvc_histo_dateSortie.Text = "Resources.olvc_dateSortie";
            this.olvc_histo_dateSortie.Width = 160;
            // 
            // olvc_histo_client
            // 
            this.olvc_histo_client.AspectName = "Client_cli_id";
            this.olvc_histo_client.Text = "Resources.olvc_clientName";
            this.olvc_histo_client.Width = 200;
            // 
            // olvc_histo_chambre
            // 
            this.olvc_histo_chambre.AspectName = "numChambre";
            this.olvc_histo_chambre.Text = "Resources.olvc_numChambre";
            this.olvc_histo_chambre.Width = 75;
            // 
            // olvc_histo_status
            // 
            this.olvc_histo_status.AspectName = "ReservationStatus_rest_id";
            this.olvc_histo_status.Text = "Resources.olvc_status";
            this.olvc_histo_status.Width = 75;
            // 
            // tp_clientsHotel
            // 
            this.tp_clientsHotel.Controls.Add(this.olv_clients);
            this.tp_clientsHotel.Location = new System.Drawing.Point(4, 34);
            this.tp_clientsHotel.Name = "tp_clientsHotel";
            this.tp_clientsHotel.Size = new System.Drawing.Size(981, 615);
            this.tp_clientsHotel.TabIndex = 2;
            this.tp_clientsHotel.Text = "Resources.clientsHotel";
            this.tp_clientsHotel.UseVisualStyleBackColor = true;
            // 
            // olv_clients
            // 
            this.olv_clients.AllColumns.Add(this.olvc_client_clientName);
            this.olv_clients.AllColumns.Add(this.olvc_client_adl1);
            this.olv_clients.AllColumns.Add(this.olvc_client_adcp);
            this.olv_clients.AllColumns.Add(this.olvc_client_adville);
            this.olv_clients.AllColumns.Add(this.olvc_client_tel);
            this.olv_clients.AllColumns.Add(this.olvc_client_mail);
            this.olv_clients.AllColumns.Add(this.olvc_client_totalHotel);
            this.olv_clients.AllColumns.Add(this.olvc_client_totalChaine);
            this.olv_clients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olv_clients.CellEditUseWholeCell = false;
            this.olv_clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvc_client_clientName,
            this.olvc_client_adl1,
            this.olvc_client_adcp,
            this.olvc_client_adville,
            this.olvc_client_tel,
            this.olvc_client_mail,
            this.olvc_client_totalHotel,
            this.olvc_client_totalChaine});
            this.olv_clients.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_clients.FullRowSelect = true;
            this.olv_clients.Location = new System.Drawing.Point(3, 33);
            this.olv_clients.MultiSelect = false;
            this.olv_clients.Name = "olv_clients";
            this.olv_clients.ShowSortIndicators = false;
            this.olv_clients.Size = new System.Drawing.Size(975, 579);
            this.olv_clients.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olv_clients.TabIndex = 1;
            this.olv_clients.UseCompatibleStateImageBehavior = false;
            this.olv_clients.View = System.Windows.Forms.View.Details;
            this.olv_clients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.olv_clients_MouseClick);
            // 
            // olvc_client_clientName
            // 
            this.olvc_client_clientName.AspectName = "fullName";
            this.olvc_client_clientName.Groupable = false;
            this.olvc_client_clientName.Text = "Resources.olvc_clientName";
            this.olvc_client_clientName.Width = 120;
            // 
            // olvc_client_adl1
            // 
            this.olvc_client_adl1.AspectName = "cli_adl1";
            this.olvc_client_adl1.Groupable = false;
            this.olvc_client_adl1.Text = "Resources.olvc_adl1";
            this.olvc_client_adl1.Width = 150;
            // 
            // olvc_client_adcp
            // 
            this.olvc_client_adcp.AspectName = "cli_adcp";
            this.olvc_client_adcp.Groupable = false;
            this.olvc_client_adcp.Text = "Resources.olvc_adcp";
            this.olvc_client_adcp.Width = 80;
            // 
            // olvc_client_adville
            // 
            this.olvc_client_adville.AspectName = "cli_adville";
            this.olvc_client_adville.Text = "Resources.olvc_adville";
            this.olvc_client_adville.Width = 80;
            // 
            // olvc_client_tel
            // 
            this.olvc_client_tel.AspectName = "cli_tel";
            this.olvc_client_tel.Groupable = false;
            this.olvc_client_tel.Text = "Resources.olvc_tel";
            this.olvc_client_tel.Width = 110;
            // 
            // olvc_client_mail
            // 
            this.olvc_client_mail.AspectName = "cli_mail";
            this.olvc_client_mail.Groupable = false;
            this.olvc_client_mail.Text = "Resources.olvc_mail";
            this.olvc_client_mail.Width = 120;
            // 
            // olvc_client_totalHotel
            // 
            this.olvc_client_totalHotel.AspectName = "TotalDansHotel";
            this.olvc_client_totalHotel.Groupable = false;
            this.olvc_client_totalHotel.Text = "Resources.olvc_totalHotel";
            this.olvc_client_totalHotel.Width = 187;
            // 
            // olvc_client_totalChaine
            // 
            this.olvc_client_totalChaine.AspectName = "TotalChaineHotels";
            this.olvc_client_totalChaine.Groupable = false;
            this.olvc_client_totalChaine.Text = "Resources.olvc_totalChaine";
            this.olvc_client_totalChaine.Width = 50;
            // 
            // bt_quit
            // 
            this.bt_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quit.Location = new System.Drawing.Point(862, 684);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(139, 29);
            this.bt_quit.TabIndex = 1;
            this.bt_quit.Text = "Resources.f_main_exit";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // cb_chooseBat
            // 
            this.cb_chooseBat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_chooseBat.FormattingEnabled = true;
            this.cb_chooseBat.Location = new System.Drawing.Point(813, 0);
            this.cb_chooseBat.Name = "cb_chooseBat";
            this.cb_chooseBat.Size = new System.Drawing.Size(200, 21);
            this.cb_chooseBat.TabIndex = 2;
            this.cb_chooseBat.SelectedIndexChanged += new System.EventHandler(this.cb_chooseBat_SelectedIndexChanged);
            // 
            // abas_db_dataSet
            // 
            this.abas_db_dataSet.DataSetName = "abas_db_dataSet";
            this.abas_db_dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // batimentBindingSource
            // 
            this.batimentBindingSource.DataMember = "Batiment";
            this.batimentBindingSource.DataSource = this.abas_db_dataSet;
            // 
            // batimentTableAdapter
            // 
            this.batimentTableAdapter.ClearBeforeFill = true;
            // 
            // bt_addRes
            // 
            this.bt_addRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addRes.Location = new System.Drawing.Point(682, 684);
            this.bt_addRes.Name = "bt_addRes";
            this.bt_addRes.Size = new System.Drawing.Size(174, 29);
            this.bt_addRes.TabIndex = 3;
            this.bt_addRes.Text = "Resources.f_main_add";
            this.bt_addRes.UseVisualStyleBackColor = true;
            this.bt_addRes.Click += new System.EventHandler(this.bt_addRes_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(15, 3);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(235, 20);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "Globals.selectedUser.ToString()\r\n";
            // 
            // cm_olvi
            // 
            this.cm_olvi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.annulerToolStripMenuItem});
            this.cm_olvi.Name = "cm_olv";
            this.cm_olvi.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cm_olvi.Size = new System.Drawing.Size(131, 70);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Image = global::PPE_ABAS.Properties.Resources.sign_in;
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkInToolStripMenuItem.Text = "Check In";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Image = global::PPE_ABAS.Properties.Resources.sign_out_option;
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Image = global::PPE_ABAS.Properties.Resources.remove_symbol;
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // cm_olvi_client
            // 
            this.cm_olvi_client.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierLesInformationsToolStripMenuItem1});
            this.cm_olvi_client.Name = "cm_olvi_client";
            this.cm_olvi_client.Size = new System.Drawing.Size(208, 26);
            // 
            // modifierLesInformationsToolStripMenuItem1
            // 
            this.modifierLesInformationsToolStripMenuItem1.Name = "modifierLesInformationsToolStripMenuItem1";
            this.modifierLesInformationsToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.modifierLesInformationsToolStripMenuItem1.Text = "Modifier les informations";
            this.modifierLesInformationsToolStripMenuItem1.Click += new System.EventHandler(this.modifierLesInformationsToolStripMenuItem_Click);
            // 
            // modifierLesInformationsToolStripMenuItem
            // 
            this.modifierLesInformationsToolStripMenuItem.Name = "modifierLesInformationsToolStripMenuItem";
            this.modifierLesInformationsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.modifierLesInformationsToolStripMenuItem.Text = "Modifier les informations";
            this.modifierLesInformationsToolStripMenuItem.Click += new System.EventHandler(this.modifierLesInformationsToolStripMenuItem_Click);
            // 
            // FMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1013, 717);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.bt_addRes);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.cb_chooseBat);
            this.Controls.Add(this.lbl_selectedBat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(710, 470);
            this.Name = "FMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resources.f_main_menu_title";
            this.Load += new System.EventHandler(this.f_main_menu_Load);
            this.tabs.ResumeLayout(false);
            this.tp_resas_en_cours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olv_resas)).EndInit();
            this.tp_historique.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olv_histo)).EndInit();
            this.tp_clientsHotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olv_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abas_db_dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batimentBindingSource)).EndInit();
            this.cm_olvi.ResumeLayout(false);
            this.cm_olvi_client.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectedBat;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tp_resas_en_cours;
        private System.Windows.Forms.TabPage tp_historique;
        private System.Windows.Forms.TabPage tp_clientsHotel;
        private System.Windows.Forms.ComboBox cb_chooseBat;
        private abas_db_dataSet abas_db_dataSet;
        private System.Windows.Forms.BindingSource batimentBindingSource;
        private abas_db_dataSetTableAdapters.BatimentTableAdapter batimentTableAdapter;
        private System.Windows.Forms.Button bt_quit;
        private BrightIdeasSoftware.ObjectListView olv_resas;
        private BrightIdeasSoftware.OLVColumn olvc_resa_date;
        private BrightIdeasSoftware.OLVColumn olvc_resa_nbJours;
        private BrightIdeasSoftware.OLVColumn olvc_resa_dateSortie;
        private BrightIdeasSoftware.ObjectListView olv_clients;
        private BrightIdeasSoftware.OLVColumn olvc_resa_clientName;
        private BrightIdeasSoftware.OLVColumn olvc_resa_numChambre;
        private BrightIdeasSoftware.OLVColumn olvc_client_clientName;
        private BrightIdeasSoftware.OLVColumn olvc_client_adl1;
        private BrightIdeasSoftware.OLVColumn olvc_client_adcp;
        private BrightIdeasSoftware.OLVColumn olvc_client_adville;
        private BrightIdeasSoftware.OLVColumn olvc_client_tel;
        private BrightIdeasSoftware.OLVColumn olvc_client_mail;
        private BrightIdeasSoftware.OLVColumn olvc_client_totalHotel;
        private BrightIdeasSoftware.OLVColumn olvc_client_totalChaine;
        private BrightIdeasSoftware.ObjectListView olv_histo;
        private BrightIdeasSoftware.OLVColumn olvc_histo_date;
        private BrightIdeasSoftware.OLVColumn olvc_histo_nbJours;
        private BrightIdeasSoftware.OLVColumn olvc_histo_dateSortie;
        private BrightIdeasSoftware.OLVColumn olvc_histo_client;
        private BrightIdeasSoftware.OLVColumn olvc_histo_chambre;
        private System.Windows.Forms.Button bt_addRes;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.ContextMenuStrip cm_olvi;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn olvc_resa_status;
        private BrightIdeasSoftware.OLVColumn olvc_histo_status;
        private System.Windows.Forms.ContextMenuStrip cm_olvi_client;
        private System.Windows.Forms.ToolStripMenuItem modifierLesInformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierLesInformationsToolStripMenuItem1;
    }
}