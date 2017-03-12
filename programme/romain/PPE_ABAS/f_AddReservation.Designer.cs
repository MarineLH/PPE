﻿namespace PPE_ABAS
{
    partial class f_AddReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CliNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CliPrenom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rb_createClient = new System.Windows.Forms.RadioButton();
            this.cb_existingClients = new System.Windows.Forms.ComboBox();
            this.rb_searchClient = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CliTel = new System.Windows.Forms.MaskedTextBox();
            this.txt_CliAdl1 = new System.Windows.Forms.TextBox();
            this.txt_CliAdl2 = new System.Windows.Forms.TextBox();
            this.txt_CliAdcp = new System.Windows.Forms.TextBox();
            this.txt_CliAdville = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CliMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dt_resDate = new System.Windows.Forms.DateTimePicker();
            this.nup_resNbJours = new System.Windows.Forms.NumericUpDown();
            this.cb_typeChambre = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_dateSortie = new System.Windows.Forms.Label();
            this.txt_resDateSortie = new System.Windows.Forms.TextBox();
            this.lbl_chambresDispos = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_validate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_resNbJours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Inconsolata", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une réservation";
            // 
            // txt_CliNom
            // 
            this.txt_CliNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliNom, 2);
            this.txt_CliNom.Location = new System.Drawing.Point(113, 53);
            this.txt_CliNom.Name = "txt_CliNom";
            this.txt_CliNom.Size = new System.Drawing.Size(160, 22);
            this.txt_CliNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom * :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom :";
            // 
            // txt_CliPrenom
            // 
            this.txt_CliPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliPrenom, 2);
            this.txt_CliPrenom.Location = new System.Drawing.Point(113, 81);
            this.txt_CliPrenom.Name = "txt_CliPrenom";
            this.txt_CliPrenom.Size = new System.Drawing.Size(160, 22);
            this.txt_CliPrenom.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rb_createClient, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliNom, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliPrenom, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliTel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdcp, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdl2, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdl1, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliMail, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cb_existingClients, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.rb_searchClient, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_CliAdville, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.nup_resNbJours, 5, 10);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.dt_resDate, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cb_typeChambre, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dateSortie, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.txt_resDateSortie, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_chambresDispos, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.bt_cancel, 5, 15);
            this.tableLayoutPanel1.Controls.Add(this.bt_validate, 4, 15);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 444);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // rb_createClient
            // 
            this.rb_createClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_createClient.AutoSize = true;
            this.rb_createClient.Checked = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rb_createClient, 3);
            this.rb_createClient.Location = new System.Drawing.Point(31, 29);
            this.rb_createClient.Name = "rb_createClient";
            this.rb_createClient.Size = new System.Drawing.Size(130, 18);
            this.rb_createClient.TabIndex = 5;
            this.rb_createClient.TabStop = true;
            this.rb_createClient.Text = "Créer un client";
            this.rb_createClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_createClient.UseVisualStyleBackColor = true;
            this.rb_createClient.CheckedChanged += new System.EventHandler(this.rb_createClient_CheckedChanged);
            // 
            // cb_existingClients
            // 
            this.cb_existingClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.cb_existingClients, 2);
            this.cb_existingClients.Enabled = false;
            this.cb_existingClients.FormattingEnabled = true;
            this.cb_existingClients.Location = new System.Drawing.Point(293, 67);
            this.cb_existingClients.Name = "cb_existingClients";
            this.tableLayoutPanel1.SetRowSpan(this.cb_existingClients, 2);
            this.cb_existingClients.Size = new System.Drawing.Size(247, 21);
            this.cb_existingClients.TabIndex = 7;
            this.cb_existingClients.SelectedIndexChanged += new System.EventHandler(this.cb_existingClients_SelectedIndexChanged);
            // 
            // rb_searchClient
            // 
            this.rb_searchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rb_searchClient.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.rb_searchClient, 2);
            this.rb_searchClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_searchClient.Location = new System.Drawing.Point(309, 29);
            this.rb_searchClient.Name = "rb_searchClient";
            this.rb_searchClient.Size = new System.Drawing.Size(214, 18);
            this.rb_searchClient.TabIndex = 6;
            this.rb_searchClient.Text = "Chercher un client existant";
            this.rb_searchClient.UseVisualStyleBackColor = true;
            this.rb_searchClient.CheckedChanged += new System.EventHandler(this.rb_searchClient_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Téléphone : ";
            // 
            // txt_CliTel
            // 
            this.txt_CliTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliTel, 2);
            this.txt_CliTel.Location = new System.Drawing.Point(113, 109);
            this.txt_CliTel.Mask = "00 00 00 00 00";
            this.txt_CliTel.Name = "txt_CliTel";
            this.txt_CliTel.Size = new System.Drawing.Size(160, 22);
            this.txt_CliTel.TabIndex = 10;
            // 
            // txt_CliAdl1
            // 
            this.txt_CliAdl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliAdl1, 3);
            this.txt_CliAdl1.Location = new System.Drawing.Point(113, 165);
            this.txt_CliAdl1.Name = "txt_CliAdl1";
            this.txt_CliAdl1.Size = new System.Drawing.Size(299, 22);
            this.txt_CliAdl1.TabIndex = 11;
            // 
            // txt_CliAdl2
            // 
            this.txt_CliAdl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliAdl2, 3);
            this.txt_CliAdl2.Location = new System.Drawing.Point(113, 193);
            this.txt_CliAdl2.Name = "txt_CliAdl2";
            this.txt_CliAdl2.Size = new System.Drawing.Size(299, 22);
            this.txt_CliAdl2.TabIndex = 12;
            // 
            // txt_CliAdcp
            // 
            this.txt_CliAdcp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliAdcp, 2);
            this.txt_CliAdcp.Location = new System.Drawing.Point(113, 221);
            this.txt_CliAdcp.Name = "txt_CliAdcp";
            this.txt_CliAdcp.Size = new System.Drawing.Size(160, 22);
            this.txt_CliAdcp.TabIndex = 13;
            // 
            // txt_CliAdville
            // 
            this.txt_CliAdville.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CliAdville.Location = new System.Drawing.Point(418, 221);
            this.txt_CliAdville.Name = "txt_CliAdville";
            this.txt_CliAdville.Size = new System.Drawing.Size(136, 22);
            this.txt_CliAdville.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(3, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adresse : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(3, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "Complément : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
            this.label7.Location = new System.Drawing.Point(3, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Code Postal : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ville : ";
            // 
            // txt_CliMail
            // 
            this.txt_CliMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_CliMail, 3);
            this.txt_CliMail.Location = new System.Drawing.Point(113, 137);
            this.txt_CliMail.Name = "txt_CliMail";
            this.txt_CliMail.Size = new System.Drawing.Size(299, 22);
            this.txt_CliMail.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label9, 2);
            this.label9.Location = new System.Drawing.Point(3, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email : ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "Date : ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nombre de nuits : ";
            // 
            // dt_resDate
            // 
            this.dt_resDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.dt_resDate, 3);
            this.dt_resDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_resDate.Location = new System.Drawing.Point(58, 269);
            this.dt_resDate.Name = "dt_resDate";
            this.dt_resDate.Size = new System.Drawing.Size(215, 22);
            this.dt_resDate.TabIndex = 23;
            this.dt_resDate.ValueChanged += new System.EventHandler(this.dt_resDate_ValueChanged);
            // 
            // nup_resNbJours
            // 
            this.nup_resNbJours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nup_resNbJours.Location = new System.Drawing.Point(418, 269);
            this.nup_resNbJours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_resNbJours.Name = "nup_resNbJours";
            this.nup_resNbJours.Size = new System.Drawing.Size(136, 22);
            this.nup_resNbJours.TabIndex = 24;
            this.nup_resNbJours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_resNbJours.ValueChanged += new System.EventHandler(this.nup_resNbJours_ValueChanged);
            // 
            // cb_typeChambre
            // 
            this.cb_typeChambre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.cb_typeChambre, 2);
            this.cb_typeChambre.FormattingEnabled = true;
            this.cb_typeChambre.Location = new System.Drawing.Point(196, 325);
            this.cb_typeChambre.Name = "cb_typeChambre";
            this.cb_typeChambre.Size = new System.Drawing.Size(216, 21);
            this.cb_typeChambre.TabIndex = 25;
            this.cb_typeChambre.SelectedIndexChanged += new System.EventHandler(this.cb_typeChambre_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 3);
            this.label12.Location = new System.Drawing.Point(3, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 14);
            this.label12.TabIndex = 26;
            this.label12.Text = "Type de chambre : ";
            // 
            // lbl_dateSortie
            // 
            this.lbl_dateSortie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dateSortie.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_dateSortie, 2);
            this.lbl_dateSortie.Location = new System.Drawing.Point(3, 301);
            this.lbl_dateSortie.Name = "lbl_dateSortie";
            this.lbl_dateSortie.Size = new System.Drawing.Size(63, 14);
            this.lbl_dateSortie.TabIndex = 27;
            this.lbl_dateSortie.Text = "Sortie :";
            // 
            // txt_resDateSortie
            // 
            this.txt_resDateSortie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_resDateSortie, 3);
            this.txt_resDateSortie.Enabled = false;
            this.txt_resDateSortie.Location = new System.Drawing.Point(113, 297);
            this.txt_resDateSortie.Name = "txt_resDateSortie";
            this.txt_resDateSortie.Size = new System.Drawing.Size(299, 22);
            this.txt_resDateSortie.TabIndex = 28;
            // 
            // lbl_chambresDispos
            // 
            this.lbl_chambresDispos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_chambresDispos.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_chambresDispos, 6);
            this.lbl_chambresDispos.Location = new System.Drawing.Point(3, 352);
            this.lbl_chambresDispos.Name = "lbl_chambresDispos";
            this.lbl_chambresDispos.Size = new System.Drawing.Size(217, 14);
            this.lbl_chambresDispos.TabIndex = 29;
            this.lbl_chambresDispos.Text = "Nombre de chambres disponibles";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(418, 392);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(136, 23);
            this.bt_cancel.TabIndex = 30;
            this.bt_cancel.Text = "Annuler";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_validate
            // 
            this.bt_validate.Location = new System.Drawing.Point(279, 392);
            this.bt_validate.Name = "bt_validate";
            this.bt_validate.Size = new System.Drawing.Size(133, 23);
            this.bt_validate.TabIndex = 31;
            this.bt_validate.Text = "Enregistrer";
            this.bt_validate.UseVisualStyleBackColor = true;
            this.bt_validate.Click += new System.EventHandler(this.bt_validate_Click);
            // 
            // f_AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Inconsolata", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "f_AddReservation";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.f_AddReservation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_resNbJours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CliNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CliPrenom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rb_createClient;
        private System.Windows.Forms.RadioButton rb_searchClient;
        private System.Windows.Forms.ComboBox cb_existingClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_CliTel;
        private System.Windows.Forms.TextBox txt_CliAdl1;
        private System.Windows.Forms.TextBox txt_CliAdl2;
        private System.Windows.Forms.TextBox txt_CliAdcp;
        private System.Windows.Forms.TextBox txt_CliAdville;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CliMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_resDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nup_resNbJours;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_typeChambre;
        private System.Windows.Forms.Label lbl_dateSortie;
        private System.Windows.Forms.TextBox txt_resDateSortie;
        private System.Windows.Forms.Label lbl_chambresDispos;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_validate;
    }
}