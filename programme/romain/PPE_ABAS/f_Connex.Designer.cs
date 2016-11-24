namespace PPE_ABAS
{
    partial class f_Connex
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_selectBat = new System.Windows.Forms.Button();
            this.lbl_chooseBat = new System.Windows.Forms.Label();
            this.cb_chooseBat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bt_selectBat);
            this.groupBox1.Controls.Add(this.lbl_chooseBat);
            this.groupBox1.Controls.Add(this.cb_chooseBat);
            this.groupBox1.Font = new System.Drawing.Font("Inconsolata", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(290, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion";
            // 
            // bt_selectBat
            // 
            this.bt_selectBat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_selectBat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_selectBat.Location = new System.Drawing.Point(32, 144);
            this.bt_selectBat.Margin = new System.Windows.Forms.Padding(2);
            this.bt_selectBat.Name = "bt_selectBat";
            this.bt_selectBat.Size = new System.Drawing.Size(220, 28);
            this.bt_selectBat.TabIndex = 2;
            this.bt_selectBat.Text = "Continuer";
            this.bt_selectBat.UseVisualStyleBackColor = true;
            this.bt_selectBat.Click += new System.EventHandler(this.bt_selectBat_Click);
            // 
            // lbl_chooseBat
            // 
            this.lbl_chooseBat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_chooseBat.AutoSize = true;
            this.lbl_chooseBat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_chooseBat.Location = new System.Drawing.Point(38, 47);
            this.lbl_chooseBat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_chooseBat.Name = "lbl_chooseBat";
            this.lbl_chooseBat.Size = new System.Drawing.Size(208, 16);
            this.lbl_chooseBat.TabIndex = 1;
            this.lbl_chooseBat.Text = "Choisissez votre bâtiment";
            // 
            // cb_chooseBat
            // 
            this.cb_chooseBat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_chooseBat.Font = new System.Drawing.Font("Inconsolata", 11F);
            this.cb_chooseBat.FormattingEnabled = true;
            this.cb_chooseBat.Location = new System.Drawing.Point(32, 78);
            this.cb_chooseBat.Margin = new System.Windows.Forms.Padding(2);
            this.cb_chooseBat.Name = "cb_chooseBat";
            this.cb_chooseBat.Size = new System.Drawing.Size(220, 23);
            this.cb_chooseBat.TabIndex = 0;
            // 
            // f_Connex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 225);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Inconsolata", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(333, 264);
            this.Name = "f_Connex";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.f_Connex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_selectBat;
        private System.Windows.Forms.Label lbl_chooseBat;
        private System.Windows.Forms.ComboBox cb_chooseBat;
    }
}