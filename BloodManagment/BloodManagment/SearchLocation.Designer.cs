namespace BloodManagment
{
    partial class SearchLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchLocation));
            this.searchLocationDataGrid = new System.Windows.Forms.DataGridView();
            this.addNewDonorTitle = new System.Windows.Forms.Label();
            this.searchLocationExitButton = new System.Windows.Forms.Button();
            this.searchLocationTxt = new MetroFramework.Controls.MetroTextBox();
            this.searchLocationPrintBtn = new MetroFramework.Controls.MetroButton();
            this.searchDonorPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchLocationDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchLocationDataGrid
            // 
            this.searchLocationDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchLocationDataGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.searchLocationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchLocationDataGrid.Location = new System.Drawing.Point(14, 206);
            this.searchLocationDataGrid.Name = "searchLocationDataGrid";
            this.searchLocationDataGrid.RowHeadersWidth = 51;
            this.searchLocationDataGrid.RowTemplate.Height = 24;
            this.searchLocationDataGrid.Size = new System.Drawing.Size(994, 355);
            this.searchLocationDataGrid.TabIndex = 15;
            // 
            // addNewDonorTitle
            // 
            this.addNewDonorTitle.AutoSize = true;
            this.addNewDonorTitle.BackColor = System.Drawing.Color.Transparent;
            this.addNewDonorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewDonorTitle.ForeColor = System.Drawing.Color.White;
            this.addNewDonorTitle.Location = new System.Drawing.Point(350, 34);
            this.addNewDonorTitle.Name = "addNewDonorTitle";
            this.addNewDonorTitle.Size = new System.Drawing.Size(295, 38);
            this.addNewDonorTitle.TabIndex = 14;
            this.addNewDonorTitle.Text = "Konuma Göre Ara";
            // 
            // searchLocationExitButton
            // 
            this.searchLocationExitButton.BackColor = System.Drawing.Color.Thistle;
            this.searchLocationExitButton.Image = ((System.Drawing.Image)(resources.GetObject("searchLocationExitButton.Image")));
            this.searchLocationExitButton.Location = new System.Drawing.Point(958, 12);
            this.searchLocationExitButton.Name = "searchLocationExitButton";
            this.searchLocationExitButton.Size = new System.Drawing.Size(50, 42);
            this.searchLocationExitButton.TabIndex = 16;
            this.searchLocationExitButton.UseVisualStyleBackColor = false;
            this.searchLocationExitButton.Click += new System.EventHandler(this.searchLocationExitButton_Click);
            // 
            // searchLocationTxt
            // 
            // 
            // 
            // 
            this.searchLocationTxt.CustomButton.Image = null;
            this.searchLocationTxt.CustomButton.Location = new System.Drawing.Point(173, 2);
            this.searchLocationTxt.CustomButton.Name = "";
            this.searchLocationTxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.searchLocationTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchLocationTxt.CustomButton.TabIndex = 1;
            this.searchLocationTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchLocationTxt.CustomButton.UseSelectable = true;
            this.searchLocationTxt.CustomButton.Visible = false;
            this.searchLocationTxt.Lines = new string[0];
            this.searchLocationTxt.Location = new System.Drawing.Point(465, 30);
            this.searchLocationTxt.MaxLength = 32767;
            this.searchLocationTxt.Name = "searchLocationTxt";
            this.searchLocationTxt.PasswordChar = '\0';
            this.searchLocationTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchLocationTxt.SelectedText = "";
            this.searchLocationTxt.SelectionLength = 0;
            this.searchLocationTxt.SelectionStart = 0;
            this.searchLocationTxt.ShortcutsEnabled = true;
            this.searchLocationTxt.Size = new System.Drawing.Size(201, 30);
            this.searchLocationTxt.TabIndex = 40;
            this.searchLocationTxt.UseSelectable = true;
            this.searchLocationTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchLocationTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchLocationTxt.TextChanged += new System.EventHandler(this.searchLocationTxt_TextChanged);
            // 
            // searchLocationPrintBtn
            // 
            this.searchLocationPrintBtn.BackColor = System.Drawing.Color.Linen;
            this.searchLocationPrintBtn.Location = new System.Drawing.Point(14, 567);
            this.searchLocationPrintBtn.Name = "searchLocationPrintBtn";
            this.searchLocationPrintBtn.Size = new System.Drawing.Size(111, 51);
            this.searchLocationPrintBtn.TabIndex = 41;
            this.searchLocationPrintBtn.Text = "Yazdır";
            this.searchLocationPrintBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchLocationPrintBtn.UseSelectable = true;
            this.searchLocationPrintBtn.Click += new System.EventHandler(this.searchLocationPrintBtn_Click);
            // 
            // searchDonorPrintDocument
            // 
            this.searchDonorPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.searchDonorPrintDocument_PrintPage);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.locationLabel);
            this.panel1.Controls.Add(this.searchLocationTxt);
            this.panel1.Location = new System.Drawing.Point(-7, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 98);
            this.panel1.TabIndex = 42;
            // 
            // locationLabel
            // 
            this.locationLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationLabel.Location = new System.Drawing.Point(339, 30);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(120, 30);
            this.locationLabel.TabIndex = 64;
            this.locationLabel.Text = "Konum:";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1030, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchLocationPrintBtn);
            this.Controls.Add(this.searchLocationExitButton);
            this.Controls.Add(this.searchLocationDataGrid);
            this.Controls.Add(this.addNewDonorTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchLocation";
            this.Load += new System.EventHandler(this.SearchLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchLocationDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchLocationExitButton;
        private System.Windows.Forms.DataGridView searchLocationDataGrid;
        private System.Windows.Forms.Label addNewDonorTitle;
        private MetroFramework.Controls.MetroTextBox searchLocationTxt;
        private MetroFramework.Controls.MetroButton searchLocationPrintBtn;
        private System.Drawing.Printing.PrintDocument searchDonorPrintDocument;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label locationLabel;
    }
}