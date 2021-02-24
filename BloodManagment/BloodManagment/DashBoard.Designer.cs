namespace BloodManagment
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.dashBoardMenu = new System.Windows.Forms.MenuStrip();
            this.addDonerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockBloodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashBoardMenu
            // 
            this.dashBoardMenu.BackColor = System.Drawing.Color.LightCoral;
            this.dashBoardMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dashBoardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonerToolStripMenuItem,
            this.searchDonorToolStripMenuItem,
            this.stockBloodToolStripMenuItem,
            this.deleteDonorToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.dashBoardMenu.Location = new System.Drawing.Point(0, 0);
            this.dashBoardMenu.Name = "dashBoardMenu";
            this.dashBoardMenu.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.dashBoardMenu.Size = new System.Drawing.Size(1382, 88);
            this.dashBoardMenu.TabIndex = 1;
            // 
            // addDonerToolStripMenuItem
            // 
            this.addDonerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonorToolStripMenuItem,
            this.updateDetailsToolStripMenuItem,
            this.allDonorDetailsToolStripMenuItem});
            this.addDonerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addDonerToolStripMenuItem.Image")));
            this.addDonerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addDonerToolStripMenuItem.Name = "addDonerToolStripMenuItem";
            this.addDonerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.addDonerToolStripMenuItem.Size = new System.Drawing.Size(170, 68);
            this.addDonerToolStripMenuItem.Text = "Donör Ekle";
            // 
            // addNewDonorToolStripMenuItem
            // 
            this.addNewDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDonorToolStripMenuItem.Image")));
            this.addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            this.addNewDonorToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.addNewDonorToolStripMenuItem.Text = "Yeni Donör Ekle";
            this.addNewDonorToolStripMenuItem.Click += new System.EventHandler(this.addNewDonorToolStripMenuItem_Click);
            // 
            // updateDetailsToolStripMenuItem
            // 
            this.updateDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateDetailsToolStripMenuItem.Image")));
            this.updateDetailsToolStripMenuItem.Name = "updateDetailsToolStripMenuItem";
            this.updateDetailsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.updateDetailsToolStripMenuItem.Text = "Detayları Güncelle";
            this.updateDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateDetailsToolStripMenuItem_Click);
            // 
            // allDonorDetailsToolStripMenuItem
            // 
            this.allDonorDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDonorDetailsToolStripMenuItem.Image")));
            this.allDonorDetailsToolStripMenuItem.Name = "allDonorDetailsToolStripMenuItem";
            this.allDonorDetailsToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.allDonorDetailsToolStripMenuItem.Text = "Tüm Donör Detayları";
            this.allDonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDonorDetailsToolStripMenuItem_Click);
            // 
            // searchDonorToolStripMenuItem
            // 
            this.searchDonorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchLocationToolStripMenuItem,
            this.searchBloodToolStripMenuItem});
            this.searchDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchDonorToolStripMenuItem.Image")));
            this.searchDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.searchDonorToolStripMenuItem.Name = "searchDonorToolStripMenuItem";
            this.searchDonorToolStripMenuItem.Size = new System.Drawing.Size(156, 68);
            this.searchDonorToolStripMenuItem.Text = "Donör Ara";
            // 
            // searchLocationToolStripMenuItem
            // 
            this.searchLocationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.searchLocationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchLocationToolStripMenuItem.Image")));
            this.searchLocationToolStripMenuItem.Name = "searchLocationToolStripMenuItem";
            this.searchLocationToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.searchLocationToolStripMenuItem.Text = "Konuma Göre";
            this.searchLocationToolStripMenuItem.Click += new System.EventHandler(this.searchLocationToolStripMenuItem_Click);
            // 
            // searchBloodToolStripMenuItem
            // 
            this.searchBloodToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchBloodToolStripMenuItem.Image")));
            this.searchBloodToolStripMenuItem.Name = "searchBloodToolStripMenuItem";
            this.searchBloodToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.searchBloodToolStripMenuItem.Text = "Kan Grubuna Göre";
            this.searchBloodToolStripMenuItem.Click += new System.EventHandler(this.searchBloodToolStripMenuItem_Click);
            // 
            // stockBloodToolStripMenuItem
            // 
            this.stockBloodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseToolStripMenuItem,
            this.decreaseToolStripMenuItem,
            this.detailsToolStripMenuItem});
            this.stockBloodToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockBloodToolStripMenuItem.Image")));
            this.stockBloodToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockBloodToolStripMenuItem.Name = "stockBloodToolStripMenuItem";
            this.stockBloodToolStripMenuItem.Size = new System.Drawing.Size(155, 68);
            this.stockBloodToolStripMenuItem.Text = "Kan Stoğu";
            // 
            // increaseToolStripMenuItem
            // 
            this.increaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increaseToolStripMenuItem.Image")));
            this.increaseToolStripMenuItem.Name = "increaseToolStripMenuItem";
            this.increaseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.increaseToolStripMenuItem.Text = "Arttır";
            this.increaseToolStripMenuItem.Click += new System.EventHandler(this.increaseToolStripMenuItem_Click);
            // 
            // decreaseToolStripMenuItem
            // 
            this.decreaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decreaseToolStripMenuItem.Image")));
            this.decreaseToolStripMenuItem.Name = "decreaseToolStripMenuItem";
            this.decreaseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.decreaseToolStripMenuItem.Text = "Azalt";
            this.decreaseToolStripMenuItem.Click += new System.EventHandler(this.decreaseToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detailsToolStripMenuItem.Image")));
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.detailsToolStripMenuItem.Text = "Detaylar";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // deleteDonorToolStripMenuItem
            // 
            this.deleteDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonorToolStripMenuItem.Image")));
            this.deleteDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            this.deleteDonorToolStripMenuItem.Size = new System.Drawing.Size(149, 68);
            this.deleteDonorToolStripMenuItem.Text = "Donör Sil";
            this.deleteDonorToolStripMenuItem.Click += new System.EventHandler(this.deleteDonorToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(145, 68);
            this.logOutToolStripMenuItem.Text = "Çıkış Yap";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = global::BloodManagment.Properties.Resources.Passion;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.dashBoardMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DashBoard";
            this.Text = "Yönetim Paneli";
            this.dashBoardMenu.ResumeLayout(false);
            this.dashBoardMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip dashBoardMenu;
        private System.Windows.Forms.ToolStripMenuItem addDonerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDonorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBloodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
    }
}