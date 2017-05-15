namespace PPE_ABAS_RES
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addReservationTab = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timeGB = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateLB = new System.Windows.Forms.Label();
            this.hourLB = new System.Windows.Forms.Label();
            this.hourUD = new System.Windows.Forms.NumericUpDown();
            this.hLB = new System.Windows.Forms.Label();
            this.minUD = new System.Windows.Forms.NumericUpDown();
            this.tableGB = new System.Windows.Forms.GroupBox();
            this.labelNbTables = new System.Windows.Forms.Label();
            this.tablesUD = new System.Windows.Forms.NumericUpDown();
            this.clientInfoGB = new System.Windows.Forms.GroupBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLB = new System.Windows.Forms.Label();
            this.telLB = new System.Windows.Forms.Label();
            this.telTB = new System.Windows.Forms.TextBox();
            this.loadingLB = new System.Windows.Forms.Label();
            this.validateBT = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.validerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.addReservationTab.SuspendLayout();
            this.timeGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUD)).BeginInit();
            this.tableGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesUD)).BeginInit();
            this.clientInfoGB.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restauration";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1090, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quitter";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(4, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choix bâtiment";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.addReservationTab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Inconsolata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.listView3);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Font = new System.Drawing.Font("Inconsolata", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1233, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(6, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Réservations à venir en attente :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView3
            // 
            this.listView3.AllowColumnReorder = true;
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView3.Location = new System.Drawing.Point(0, 338);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(913, 220);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1008, 41);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(133, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseMnemonic = false;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Réservations à venir en attente :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(913, 220);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // addReservationTab
            // 
            this.addReservationTab.Controls.Add(this.progressBar1);
            this.addReservationTab.Controls.Add(this.timeGB);
            this.addReservationTab.Controls.Add(this.tableGB);
            this.addReservationTab.Controls.Add(this.clientInfoGB);
            this.addReservationTab.Controls.Add(this.loadingLB);
            this.addReservationTab.Controls.Add(this.validateBT);
            this.addReservationTab.Location = new System.Drawing.Point(4, 40);
            this.addReservationTab.Name = "addReservationTab";
            this.addReservationTab.Padding = new System.Windows.Forms.Padding(3);
            this.addReservationTab.Size = new System.Drawing.Size(1233, 595);
            this.addReservationTab.TabIndex = 1;
            this.addReservationTab.Text = "Ajouter réversation";
            this.addReservationTab.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-4, 589);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1241, 10);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Visible = false;
            // 
            // timeGB
            // 
            this.timeGB.Controls.Add(this.dateTimePicker1);
            this.timeGB.Controls.Add(this.dateLB);
            this.timeGB.Controls.Add(this.hourLB);
            this.timeGB.Controls.Add(this.hourUD);
            this.timeGB.Controls.Add(this.hLB);
            this.timeGB.Controls.Add(this.minUD);
            this.timeGB.Location = new System.Drawing.Point(488, 8);
            this.timeGB.Name = "timeGB";
            this.timeGB.Size = new System.Drawing.Size(400, 122);
            this.timeGB.TabIndex = 19;
            this.timeGB.TabStop = false;
            this.timeGB.Text = "Horaires";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 25);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateLB
            // 
            this.dateLB.AutoSize = true;
            this.dateLB.Location = new System.Drawing.Point(6, 31);
            this.dateLB.Name = "dateLB";
            this.dateLB.Size = new System.Drawing.Size(56, 16);
            this.dateLB.TabIndex = 6;
            this.dateLB.Text = "Date :";
            // 
            // hourLB
            // 
            this.hourLB.AutoSize = true;
            this.hourLB.Location = new System.Drawing.Point(6, 75);
            this.hourLB.Name = "hourLB";
            this.hourLB.Size = new System.Drawing.Size(64, 16);
            this.hourLB.TabIndex = 8;
            this.hourLB.Text = "Heure :";
            // 
            // hourUD
            // 
            this.hourUD.Location = new System.Drawing.Point(91, 73);
            this.hourUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.hourUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.hourUD.Name = "hourUD";
            this.hourUD.Size = new System.Drawing.Size(50, 25);
            this.hourUD.TabIndex = 11;
            this.hourUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hourUD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // hLB
            // 
            this.hLB.AutoSize = true;
            this.hLB.Location = new System.Drawing.Point(168, 75);
            this.hLB.Name = "hLB";
            this.hLB.Size = new System.Drawing.Size(16, 16);
            this.hLB.TabIndex = 12;
            this.hLB.Text = "H";
            // 
            // minUD
            // 
            this.minUD.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.minUD.Location = new System.Drawing.Point(218, 73);
            this.minUD.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minUD.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.minUD.Name = "minUD";
            this.minUD.Size = new System.Drawing.Size(56, 25);
            this.minUD.TabIndex = 13;
            this.minUD.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // tableGB
            // 
            this.tableGB.Controls.Add(this.labelNbTables);
            this.tableGB.Controls.Add(this.tablesUD);
            this.tableGB.Location = new System.Drawing.Point(6, 150);
            this.tableGB.Name = "tableGB";
            this.tableGB.Size = new System.Drawing.Size(359, 109);
            this.tableGB.TabIndex = 18;
            this.tableGB.TabStop = false;
            this.tableGB.Text = "Tables";
            // 
            // labelNbTables
            // 
            this.labelNbTables.AutoSize = true;
            this.labelNbTables.Location = new System.Drawing.Point(11, 21);
            this.labelNbTables.Name = "labelNbTables";
            this.labelNbTables.Size = new System.Drawing.Size(248, 16);
            this.labelNbTables.TabIndex = 4;
            this.labelNbTables.Text = "Nombre de tables disponibles :";
            // 
            // tablesUD
            // 
            this.tablesUD.Font = new System.Drawing.Font("Inconsolata", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesUD.Location = new System.Drawing.Point(14, 60);
            this.tablesUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.tablesUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tablesUD.Name = "tablesUD";
            this.tablesUD.Size = new System.Drawing.Size(72, 31);
            this.tablesUD.TabIndex = 14;
            this.tablesUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // clientInfoGB
            // 
            this.clientInfoGB.Controls.Add(this.nameTB);
            this.clientInfoGB.Controls.Add(this.nameLB);
            this.clientInfoGB.Controls.Add(this.telLB);
            this.clientInfoGB.Controls.Add(this.telTB);
            this.clientInfoGB.Location = new System.Drawing.Point(6, 6);
            this.clientInfoGB.Name = "clientInfoGB";
            this.clientInfoGB.Size = new System.Drawing.Size(359, 124);
            this.clientInfoGB.TabIndex = 17;
            this.clientInfoGB.TabStop = false;
            this.clientInfoGB.Text = "Coordonées";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(84, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(227, 25);
            this.nameTB.TabIndex = 1;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Location = new System.Drawing.Point(11, 33);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(48, 16);
            this.nameLB.TabIndex = 0;
            this.nameLB.Text = "Nom :";
            // 
            // telLB
            // 
            this.telLB.AutoSize = true;
            this.telLB.Location = new System.Drawing.Point(11, 80);
            this.telLB.Name = "telLB";
            this.telLB.Size = new System.Drawing.Size(96, 16);
            this.telLB.TabIndex = 2;
            this.telLB.Text = "Téléphone :";
            // 
            // telTB
            // 
            this.telTB.Location = new System.Drawing.Point(132, 77);
            this.telTB.Name = "telTB";
            this.telTB.Size = new System.Drawing.Size(179, 25);
            this.telTB.TabIndex = 3;
            this.telTB.TextChanged += new System.EventHandler(this.telTB_TextChanged);
            // 
            // loadingLB
            // 
            this.loadingLB.AutoSize = true;
            this.loadingLB.Font = new System.Drawing.Font("Inconsolata", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLB.Location = new System.Drawing.Point(404, 212);
            this.loadingLB.Name = "loadingLB";
            this.loadingLB.Size = new System.Drawing.Size(0, 97);
            this.loadingLB.TabIndex = 16;
            this.loadingLB.Visible = false;
            // 
            // validateBT
            // 
            this.validateBT.Image = ((System.Drawing.Image)(resources.GetObject("validateBT.Image")));
            this.validateBT.Location = new System.Drawing.Point(488, 407);
            this.validateBT.Name = "validateBT";
            this.validateBT.Size = new System.Drawing.Size(196, 66);
            this.validateBT.TabIndex = 15;
            this.validateBT.Text = "Valider";
            this.validateBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.validateBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.validateBT.UseVisualStyleBackColor = true;
            this.validateBT.Visible = false;
            this.validateBT.Click += new System.EventHandler(this.validateBT_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.listView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1233, 595);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historique des réservations";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Réservations passées :";
            // 
            // listView2
            // 
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(0, 41);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(970, 450);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1233, 595);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Informations pratiques";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1233, 595);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Statistiques";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pieChart1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Réservations";
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(24, 24);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(292, 290);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(1101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validerToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.annulerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 70);
            // 
            // validerToolStripMenuItem
            // 
            this.validerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("validerToolStripMenuItem.Image")));
            this.validerToolStripMenuItem.Name = "validerToolStripMenuItem";
            this.validerToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.validerToolStripMenuItem.Text = "Valider";
            this.validerToolStripMenuItem.Click += new System.EventHandler(this.validerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierToolStripMenuItem.Image")));
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("annulerToolStripMenuItem.Image")));
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.annulerToolStripMenuItem.Text = "Annuler";
            this.annulerToolStripMenuItem.Click += new System.EventHandler(this.annulerToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 757);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Inconsolata", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.addReservationTab.ResumeLayout(false);
            this.addReservationTab.PerformLayout();
            this.timeGB.ResumeLayout(false);
            this.timeGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUD)).EndInit();
            this.tableGB.ResumeLayout(false);
            this.tableGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesUD)).EndInit();
            this.clientInfoGB.ResumeLayout(false);
            this.clientInfoGB.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage addReservationTab;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telTB;
        private System.Windows.Forms.Label telLB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLB;
        private System.Windows.Forms.Label labelNbTables;
        private System.Windows.Forms.Label hourLB;
        private System.Windows.Forms.Label dateLB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown minUD;
        private System.Windows.Forms.Label hLB;
        private System.Windows.Forms.NumericUpDown hourUD;
        private System.Windows.Forms.NumericUpDown tablesUD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button validateBT;
        private System.Windows.Forms.Label loadingLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox clientInfoGB;
        private System.Windows.Forms.GroupBox tableGB;
        private System.Windows.Forms.GroupBox timeGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem validerToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}