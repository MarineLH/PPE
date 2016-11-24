namespace PPE_ABAS
{
    partial class f_Resas_OLV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Resas_OLV));
            this.olv_ResClients = new BrightIdeasSoftware.ObjectListView();
            this.olv_date = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_client = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_duree = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_dateSortie = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_NoChambre = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olv_delete = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.olv_ResClients)).BeginInit();
            this.SuspendLayout();
            // 
            // olv_ResClients
            // 
            this.olv_ResClients.AllColumns.Add(this.olv_date);
            this.olv_ResClients.AllColumns.Add(this.olv_client);
            this.olv_ResClients.AllColumns.Add(this.olv_duree);
            this.olv_ResClients.AllColumns.Add(this.olv_dateSortie);
            this.olv_ResClients.AllColumns.Add(this.olv_NoChambre);
            this.olv_ResClients.AllColumns.Add(this.olv_delete);
            this.olv_ResClients.CellEditUseWholeCell = false;
            this.olv_ResClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olv_date,
            this.olv_client,
            this.olv_duree,
            this.olv_dateSortie,
            this.olv_NoChambre,
            this.olv_delete});
            this.olv_ResClients.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_ResClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olv_ResClients.GridLines = true;
            this.olv_ResClients.Location = new System.Drawing.Point(0, 0);
            this.olv_ResClients.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.olv_ResClients.Name = "olv_ResClients";
            this.olv_ResClients.Size = new System.Drawing.Size(894, 426);
            this.olv_ResClients.TabIndex = 0;
            this.olv_ResClients.UseCompatibleStateImageBehavior = false;
            this.olv_ResClients.View = System.Windows.Forms.View.Details;
            // 
            // olv_date
            // 
            this.olv_date.AspectName = "res_date";
            this.olv_date.IsEditable = false;
            this.olv_date.Text = "Date";
            this.olv_date.Width = 160;
            // 
            // olv_client
            // 
            this.olv_client.AspectName = "cliFullName";
            this.olv_client.IsEditable = false;
            this.olv_client.Text = "Client";
            this.olv_client.Width = 160;
            // 
            // olv_duree
            // 
            this.olv_duree.AspectName = "res_nbJours";
            this.olv_duree.Text = "Nb. nuits";
            this.olv_duree.Width = 100;
            // 
            // olv_dateSortie
            // 
            this.olv_dateSortie.AspectName = "res_dateSortie";
            this.olv_dateSortie.IsEditable = false;
            this.olv_dateSortie.Text = "Date sortie";
            this.olv_dateSortie.Width = 160;
            // 
            // olv_NoChambre
            // 
            this.olv_NoChambre.AspectName = "numChambre";
            this.olv_NoChambre.IsEditable = false;
            this.olv_NoChambre.Text = "N° Chambre";
            this.olv_NoChambre.Width = 100;
            // 
            // olv_delete
            // 
            this.olv_delete.Text = "";
            this.olv_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.olv_delete.Width = 100;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "edit.png");
            // 
            // f_Resas_OLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 426);
            this.Controls.Add(this.olv_ResClients);
            this.Font = new System.Drawing.Font("Inconsolata", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "f_Resas_OLV";
            this.ShowIcon = false;
            this.Text = "f_Resas_OLV";
            this.Load += new System.EventHandler(this.f_Resas_OLV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.olv_ResClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olv_ResClients;
        private BrightIdeasSoftware.OLVColumn olv_date;
        private BrightIdeasSoftware.OLVColumn olv_duree;
        private BrightIdeasSoftware.OLVColumn olv_dateSortie;
        private BrightIdeasSoftware.OLVColumn olv_NoChambre;
        private BrightIdeasSoftware.OLVColumn olv_client;
        private BrightIdeasSoftware.OLVColumn olv_delete;
        private System.Windows.Forms.ImageList imageList1;
    }
}