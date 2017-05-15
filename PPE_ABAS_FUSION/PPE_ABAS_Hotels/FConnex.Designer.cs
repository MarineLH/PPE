namespace PPE_ABAS_Hotels
{
    partial class FConnex
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
            this.cb_chooseBat = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_chooseUser = new System.Windows.Forms.ComboBox();
            this.lbl_chooseUser = new System.Windows.Forms.Label();
            this.lbl_chooseBat = new System.Windows.Forms.Label();
            this.bt_connex = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_chooseBat
            // 
            this.cb_chooseBat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_chooseBat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_chooseBat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_chooseBat.FormattingEnabled = true;
            this.cb_chooseBat.Location = new System.Drawing.Point(6, 38);
            this.cb_chooseBat.Name = "cb_chooseBat";
            this.cb_chooseBat.Size = new System.Drawing.Size(236, 21);
            this.cb_chooseBat.TabIndex = 0;
            this.cb_chooseBat.SelectedIndexChanged += new System.EventHandler(this.cb_chooseBat_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_chooseUser);
            this.groupBox1.Controls.Add(this.lbl_chooseUser);
            this.groupBox1.Controls.Add(this.lbl_chooseBat);
            this.groupBox1.Controls.Add(this.bt_connex);
            this.groupBox1.Controls.Add(this.cb_chooseBat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources.f_connex_title";
            // 
            // cb_chooseUser
            // 
            this.cb_chooseUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_chooseUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_chooseUser.FormattingEnabled = true;
            this.cb_chooseUser.Location = new System.Drawing.Point(6, 87);
            this.cb_chooseUser.Name = "cb_chooseUser";
            this.cb_chooseUser.Size = new System.Drawing.Size(236, 21);
            this.cb_chooseUser.TabIndex = 1;
            // 
            // lbl_chooseUser
            // 
            this.lbl_chooseUser.AutoSize = true;
            this.lbl_chooseUser.Location = new System.Drawing.Point(7, 71);
            this.lbl_chooseUser.Name = "lbl_chooseUser";
            this.lbl_chooseUser.Size = new System.Drawing.Size(165, 13);
            this.lbl_chooseUser.TabIndex = 3;
            this.lbl_chooseUser.Text = "Resources.f_connex_select_user";
            // 
            // lbl_chooseBat
            // 
            this.lbl_chooseBat.AutoSize = true;
            this.lbl_chooseBat.Location = new System.Drawing.Point(7, 20);
            this.lbl_chooseBat.Name = "lbl_chooseBat";
            this.lbl_chooseBat.Size = new System.Drawing.Size(160, 13);
            this.lbl_chooseBat.TabIndex = 2;
            this.lbl_chooseBat.Text = "Resources.f_connex_select_bat";
            // 
            // bt_connex
            // 
            this.bt_connex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_connex.Location = new System.Drawing.Point(6, 128);
            this.bt_connex.Name = "bt_connex";
            this.bt_connex.Size = new System.Drawing.Size(236, 23);
            this.bt_connex.TabIndex = 2;
            this.bt_connex.Text = "Resources.f_connex_bt_connex";
            this.bt_connex.UseVisualStyleBackColor = true;
            this.bt_connex.Click += new System.EventHandler(this.bt_connex_Click);
            // 
            // FConnex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 181);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FConnex";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resources.f_connex_title";
            this.Load += new System.EventHandler(this.f_connex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_chooseBat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_connex;
        private System.Windows.Forms.Label lbl_chooseBat;
        private System.Windows.Forms.Label lbl_chooseUser;
        private System.Windows.Forms.ComboBox cb_chooseUser;
    }
}

