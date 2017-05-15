namespace PPE_ABAS_Hotels
{
    partial class FAddResa
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
            this.lbl_currentHotel = new System.Windows.Forms.Label();
            this.bt_quit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_pnom = new System.Windows.Forms.Label();
            this.rb_createClient = new System.Windows.Forms.RadioButton();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.txt_CliNom = new System.Windows.Forms.TextBox();
            this.txt_CliPrenom = new System.Windows.Forms.TextBox();
            this.txt_CliTel = new System.Windows.Forms.MaskedTextBox();
            this.txt_CliAdcp = new System.Windows.Forms.TextBox();
            this.txt_CliAdl2 = new System.Windows.Forms.TextBox();
            this.lbl_cp = new System.Windows.Forms.Label();
            this.lbl_ad2 = new System.Windows.Forms.Label();
            this.lbl_ad1 = new System.Windows.Forms.Label();
            this.rb_searchClient = new System.Windows.Forms.RadioButton();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.nup_resNbJours = new System.Windows.Forms.NumericUpDown();
            this.lbl_nbNuit = new System.Windows.Forms.Label();
            this.dt_resDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.cb_typeChambre = new System.Windows.Forms.ComboBox();
            this.lbl_typeC = new System.Windows.Forms.Label();
            this.lbl_dateSortie = new System.Windows.Forms.Label();
            this.txt_resDateSortie = new System.Windows.Forms.TextBox();
            this.lbl_chambresDispos = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_validate = new System.Windows.Forms.Button();
            this.txt_CliMail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_CliAdl1 = new System.Windows.Forms.TextBox();
            this.txt_CliAdville = new System.Windows.Forms.TextBox();
            this.cb_existingClients = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_resNbJours)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_currentHotel
            // 
            this.lbl_currentHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_currentHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentHotel.Location = new System.Drawing.Point(0, 0);
            this.lbl_currentHotel.Name = "lbl_currentHotel";
            this.lbl_currentHotel.Size = new System.Drawing.Size(500, 24);
            this.lbl_currentHotel.TabIndex = 0;
            this.lbl_currentHotel.Text = "Resources.f_add_resa_selected + Globals.selectedBat";
            this.lbl_currentHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_quit
            // 
            this.bt_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quit.Location = new System.Drawing.Point(405, 377);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(83, 26);
            this.bt_quit.TabIndex = 1;
            this.bt_quit.Text = "Resources.close";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.28807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.46502F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_nom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pnom, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rb_createClient, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliNom, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliPrenom, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliTel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdcp, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdl2, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_cp, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ad2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ad1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.rb_searchClient, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ville, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.nup_resNbJours, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_nbNuit, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.dt_resDate, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_date, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cb_typeChambre, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.lbl_typeC, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dateSortie, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txt_resDateSortie, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_chambresDispos, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.bt_cancel, 5, 15);
            this.tableLayoutPanel1.Controls.Add(this.bt_validate, 4, 15);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliMail, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_mail, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdl1, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdville, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.cb_existingClients, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 391);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lbl_nom
            // 
            this.lbl_nom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nom.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_nom, 2);
            this.lbl_nom.Location = new System.Drawing.Point(3, 56);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(42, 13);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nom * :";
            // 
            // lbl_pnom
            // 
            this.lbl_pnom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_pnom.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_pnom, 2);
            this.lbl_pnom.Location = new System.Drawing.Point(3, 82);
            this.lbl_pnom.Name = "lbl_pnom";
            this.lbl_pnom.Size = new System.Drawing.Size(49, 13);
            this.lbl_pnom.TabIndex = 4;
            this.lbl_pnom.Text = "Prénom :";
            // 
            // rb_createClient
            // 
            this.rb_createClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_createClient.AutoSize = true;
            this.rb_createClient.Checked = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rb_createClient, 3);
            this.rb_createClient.Location = new System.Drawing.Point(40, 29);
            this.rb_createClient.Name = "rb_createClient";
            this.rb_createClient.Size = new System.Drawing.Size(93, 17);
            this.rb_createClient.TabIndex = 5;
            this.rb_createClient.TabStop = true;
            this.rb_createClient.Text = "Créer un client";
            this.rb_createClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_createClient.UseVisualStyleBackColor = true;
            this.rb_createClient.CheckedChanged += new System.EventHandler(this.rb_createClient_CheckedChanged);
            // 
            // lbl_tel
            // 
            this.lbl_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_tel, 2);
            this.lbl_tel.Location = new System.Drawing.Point(3, 108);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(67, 13);
            this.lbl_tel.TabIndex = 9;
            this.lbl_tel.Text = "Téléphone : ";
            // 
            // txt_CliNom
            // 
            this.txt_CliNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliNom, 2);
            this.txt_CliNom.Location = new System.Drawing.Point(104, 52);
            this.txt_CliNom.Name = "txt_CliNom";
            this.txt_CliNom.Size = new System.Drawing.Size(138, 20);
            this.txt_CliNom.TabIndex = 1;
            // 
            // txt_CliPrenom
            // 
            this.txt_CliPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliPrenom, 2);
            this.txt_CliPrenom.Location = new System.Drawing.Point(104, 79);
            this.txt_CliPrenom.Name = "txt_CliPrenom";
            this.txt_CliPrenom.Size = new System.Drawing.Size(138, 20);
            this.txt_CliPrenom.TabIndex = 3;
            // 
            // txt_CliTel
            // 
            this.txt_CliTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliTel, 2);
            this.txt_CliTel.Location = new System.Drawing.Point(104, 105);
            this.txt_CliTel.Mask = "00 00 00 00 00";
            this.txt_CliTel.Name = "txt_CliTel";
            this.txt_CliTel.Size = new System.Drawing.Size(138, 20);
            this.txt_CliTel.TabIndex = 10;
            // 
            // txt_CliAdcp
            // 
            this.txt_CliAdcp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliAdcp, 2);
            this.txt_CliAdcp.Location = new System.Drawing.Point(104, 209);
            this.txt_CliAdcp.Name = "txt_CliAdcp";
            this.txt_CliAdcp.Size = new System.Drawing.Size(138, 20);
            this.txt_CliAdcp.TabIndex = 13;
            // 
            // txt_CliAdl2
            // 
            this.txt_CliAdl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliAdl2, 4);
            this.txt_CliAdl2.Location = new System.Drawing.Point(107, 183);
            this.txt_CliAdl2.Name = "txt_CliAdl2";
            this.txt_CliAdl2.Size = new System.Drawing.Size(383, 20);
            this.txt_CliAdl2.TabIndex = 12;
            // 
            // lbl_cp
            // 
            this.lbl_cp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cp.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_cp, 2);
            this.lbl_cp.Location = new System.Drawing.Point(3, 212);
            this.lbl_cp.Name = "lbl_cp";
            this.lbl_cp.Size = new System.Drawing.Size(73, 13);
            this.lbl_cp.TabIndex = 17;
            this.lbl_cp.Text = "Code Postal : ";
            // 
            // lbl_ad2
            // 
            this.lbl_ad2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ad2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_ad2, 2);
            this.lbl_ad2.Location = new System.Drawing.Point(3, 186);
            this.lbl_ad2.Name = "lbl_ad2";
            this.lbl_ad2.Size = new System.Drawing.Size(74, 13);
            this.lbl_ad2.TabIndex = 16;
            this.lbl_ad2.Text = "Complément : ";
            // 
            // lbl_ad1
            // 
            this.lbl_ad1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ad1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_ad1, 2);
            this.lbl_ad1.Location = new System.Drawing.Point(3, 160);
            this.lbl_ad1.Name = "lbl_ad1";
            this.lbl_ad1.Size = new System.Drawing.Size(54, 13);
            this.lbl_ad1.TabIndex = 15;
            this.lbl_ad1.Text = "Adresse : ";
            // 
            // rb_searchClient
            // 
            this.rb_searchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_searchClient.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rb_searchClient, 2);
            this.rb_searchClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_searchClient.Location = new System.Drawing.Point(299, 29);
            this.rb_searchClient.Name = "rb_searchClient";
            this.rb_searchClient.Size = new System.Drawing.Size(150, 17);
            this.rb_searchClient.TabIndex = 6;
            this.rb_searchClient.Text = "Chercher un client existant";
            this.rb_searchClient.UseVisualStyleBackColor = true;
            this.rb_searchClient.CheckedChanged += new System.EventHandler(this.rb_searchClient_CheckedChanged);
            // 
            // lbl_ville
            // 
            this.lbl_ville.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(251, 212);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(35, 13);
            this.lbl_ville.TabIndex = 18;
            this.lbl_ville.Text = "Ville : ";
            // 
            // nup_resNbJours
            // 
            this.nup_resNbJours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nup_resNbJours.Location = new System.Drawing.Point(378, 265);
            this.nup_resNbJours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_resNbJours.Name = "nup_resNbJours";
            this.nup_resNbJours.Size = new System.Drawing.Size(117, 20);
            this.nup_resNbJours.TabIndex = 24;
            this.nup_resNbJours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_resNbJours.ValueChanged += new System.EventHandler(this.nup_resNbJours_ValueChanged);
            // 
            // lbl_nbNuit
            // 
            this.lbl_nbNuit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nbNuit.AutoSize = true;
            this.lbl_nbNuit.Location = new System.Drawing.Point(251, 268);
            this.lbl_nbNuit.Name = "lbl_nbNuit";
            this.lbl_nbNuit.Size = new System.Drawing.Size(93, 13);
            this.lbl_nbNuit.TabIndex = 22;
            this.lbl_nbNuit.Text = "Nombre de nuits : ";
            // 
            // dt_resDate
            // 
            this.dt_resDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.dt_resDate, 3);
            this.dt_resDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_resDate.Location = new System.Drawing.Point(56, 265);
            this.dt_resDate.Name = "dt_resDate";
            this.dt_resDate.Size = new System.Drawing.Size(186, 20);
            this.dt_resDate.TabIndex = 23;
            this.dt_resDate.ValueChanged += new System.EventHandler(this.dt_resDate_ValueChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(3, 268);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(39, 13);
            this.lbl_date.TabIndex = 21;
            this.lbl_date.Text = "Date : ";
            // 
            // cb_typeChambre
            // 
            this.cb_typeChambre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.cb_typeChambre, 2);
            this.cb_typeChambre.FormattingEnabled = true;
            this.cb_typeChambre.Location = new System.Drawing.Point(179, 317);
            this.cb_typeChambre.Name = "cb_typeChambre";
            this.cb_typeChambre.Size = new System.Drawing.Size(187, 21);
            this.cb_typeChambre.TabIndex = 25;
            this.cb_typeChambre.SelectedIndexChanged += new System.EventHandler(this.cb_typeChambre_SelectedIndexChanged);
            // 
            // lbl_typeC
            // 
            this.lbl_typeC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_typeC.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_typeC, 3);
            this.lbl_typeC.Location = new System.Drawing.Point(3, 321);
            this.lbl_typeC.Name = "lbl_typeC";
            this.lbl_typeC.Size = new System.Drawing.Size(99, 13);
            this.lbl_typeC.TabIndex = 26;
            this.lbl_typeC.Text = "Type de chambre : ";
            // 
            // lbl_dateSortie
            // 
            this.lbl_dateSortie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dateSortie.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_dateSortie, 2);
            this.lbl_dateSortie.Location = new System.Drawing.Point(3, 294);
            this.lbl_dateSortie.Name = "lbl_dateSortie";
            this.lbl_dateSortie.Size = new System.Drawing.Size(40, 13);
            this.lbl_dateSortie.TabIndex = 27;
            this.lbl_dateSortie.Text = "Sortie :";
            // 
            // txt_resDateSortie
            // 
            this.txt_resDateSortie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_resDateSortie, 3);
            this.txt_resDateSortie.Enabled = false;
            this.txt_resDateSortie.Location = new System.Drawing.Point(106, 291);
            this.txt_resDateSortie.Name = "txt_resDateSortie";
            this.txt_resDateSortie.Size = new System.Drawing.Size(259, 20);
            this.txt_resDateSortie.TabIndex = 28;
            // 
            // lbl_chambresDispos
            // 
            this.lbl_chambresDispos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_chambresDispos.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_chambresDispos, 6);
            this.lbl_chambresDispos.Location = new System.Drawing.Point(3, 344);
            this.lbl_chambresDispos.Name = "lbl_chambresDispos";
            this.lbl_chambresDispos.Size = new System.Drawing.Size(163, 13);
            this.lbl_chambresDispos.TabIndex = 29;
            this.lbl_chambresDispos.Text = "Nombre de chambres disponibles";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(376, 364);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(117, 23);
            this.bt_cancel.TabIndex = 30;
            this.bt_cancel.Text = "Annuler";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_validate
            // 
            this.bt_validate.Location = new System.Drawing.Point(251, 364);
            this.bt_validate.Name = "bt_validate";
            this.bt_validate.Size = new System.Drawing.Size(115, 23);
            this.bt_validate.TabIndex = 31;
            this.bt_validate.Text = "Enregistrer";
            this.bt_validate.UseVisualStyleBackColor = true;
            this.bt_validate.Click += new System.EventHandler(this.bt_validate_Click);
            // 
            // txt_CliMail
            // 
            this.txt_CliMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliMail, 4);
            this.txt_CliMail.Location = new System.Drawing.Point(107, 131);
            this.txt_CliMail.Name = "txt_CliMail";
            this.txt_CliMail.Size = new System.Drawing.Size(383, 20);
            this.txt_CliMail.TabIndex = 19;
            // 
            // lbl_mail
            // 
            this.lbl_mail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_mail.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_mail, 2);
            this.lbl_mail.Location = new System.Drawing.Point(3, 134);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(41, 13);
            this.lbl_mail.TabIndex = 20;
            this.lbl_mail.Text = "Email : ";
            // 
            // txt_CliAdl1
            // 
            this.txt_CliAdl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliAdl1, 4);
            this.txt_CliAdl1.Location = new System.Drawing.Point(107, 157);
            this.txt_CliAdl1.Name = "txt_CliAdl1";
            this.txt_CliAdl1.Size = new System.Drawing.Size(383, 20);
            this.txt_CliAdl1.TabIndex = 11;
            // 
            // txt_CliAdville
            // 
            this.txt_CliAdville.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CliAdville.Location = new System.Drawing.Point(378, 209);
            this.txt_CliAdville.Name = "txt_CliAdville";
            this.txt_CliAdville.Size = new System.Drawing.Size(117, 20);
            this.txt_CliAdville.TabIndex = 14;
            // 
            // cb_existingClients
            // 
            this.cb_existingClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.cb_existingClients, 2);
            this.cb_existingClients.Enabled = false;
            this.cb_existingClients.FormattingEnabled = true;
            this.cb_existingClients.Location = new System.Drawing.Point(255, 52);
            this.cb_existingClients.Name = "cb_existingClients";
            this.cb_existingClients.Size = new System.Drawing.Size(238, 21);
            this.cb_existingClients.TabIndex = 7;
            this.cb_existingClients.SelectedIndexChanged += new System.EventHandler(this.cb_existingClients_SelectedIndexChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_title, 4);
            this.lbl_title.Font = new System.Drawing.Font("Inconsolata", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(3, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(192, 16);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Ajouter une réservation";
            // 
            // FAddResa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 415);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.lbl_currentHotel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FAddResa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FAddResa";
            this.Load += new System.EventHandler(this.f_add_resa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_resNbJours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_currentHotel;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_pnom;
        private System.Windows.Forms.RadioButton rb_createClient;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.TextBox txt_CliNom;
        private System.Windows.Forms.TextBox txt_CliPrenom;
        private System.Windows.Forms.MaskedTextBox txt_CliTel;
        private System.Windows.Forms.TextBox txt_CliAdcp;
        private System.Windows.Forms.TextBox txt_CliAdl2;
        private System.Windows.Forms.Label lbl_cp;
        private System.Windows.Forms.Label lbl_ad2;
        private System.Windows.Forms.Label lbl_ad1;
        private System.Windows.Forms.RadioButton rb_searchClient;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.NumericUpDown nup_resNbJours;
        private System.Windows.Forms.Label lbl_nbNuit;
        private System.Windows.Forms.DateTimePicker dt_resDate;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.ComboBox cb_typeChambre;
        private System.Windows.Forms.Label lbl_typeC;
        private System.Windows.Forms.Label lbl_dateSortie;
        private System.Windows.Forms.TextBox txt_resDateSortie;
        private System.Windows.Forms.Label lbl_chambresDispos;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_validate;
        private System.Windows.Forms.TextBox txt_CliMail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_CliAdl1;
        private System.Windows.Forms.TextBox txt_CliAdville;
        private System.Windows.Forms.ComboBox cb_existingClients;
    }
}