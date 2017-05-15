namespace PPE_ABAS_Hotels
{
    partial class FQuickSwitch
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
            this.bt_val = new System.Windows.Forms.Button();
            this.cb_chooseUser = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bt_val);
            this.groupBox1.Controls.Add(this.cb_chooseUser);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources.f_quick_sw_select_user";
            // 
            // bt_val
            // 
            this.bt_val.Location = new System.Drawing.Point(7, 66);
            this.bt_val.Name = "bt_val";
            this.bt_val.Size = new System.Drawing.Size(198, 23);
            this.bt_val.TabIndex = 1;
            this.bt_val.Text = "Resources.val";
            this.bt_val.UseVisualStyleBackColor = true;
            this.bt_val.Click += new System.EventHandler(this.bt_val_Click);
            // 
            // cb_chooseUser
            // 
            this.cb_chooseUser.FormattingEnabled = true;
            this.cb_chooseUser.Location = new System.Drawing.Point(7, 20);
            this.cb_chooseUser.Name = "cb_chooseUser";
            this.cb_chooseUser.Size = new System.Drawing.Size(198, 21);
            this.cb_chooseUser.TabIndex = 0;
            // 
            // FQuickSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 120);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FQuickSwitch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resources.f_quick_sw_title";
            this.Load += new System.EventHandler(this.FQuickSwitch_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_chooseUser;
        private System.Windows.Forms.Button bt_val;
    }
}