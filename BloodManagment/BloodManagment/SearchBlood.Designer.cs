namespace BloodManagment
{
    partial class SearchBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBlood));
            this.searchBloodPrintBtn = new MetroFramework.Controls.MetroButton();
            this.searchBloodTxt = new MetroFramework.Controls.MetroTextBox();
            this.searchBloodExitButton = new System.Windows.Forms.Button();
            this.searchBloodDataGrid = new System.Windows.Forms.DataGridView();
            this.addNewDonorTitle = new System.Windows.Forms.Label();
            this.searchDonorPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bloodGroupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchBloodDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBloodPrintBtn
            // 
            this.searchBloodPrintBtn.BackColor = System.Drawing.Color.Linen;
            this.searchBloodPrintBtn.Location = new System.Drawing.Point(12, 567);
            this.searchBloodPrintBtn.Name = "searchBloodPrintBtn";
            this.searchBloodPrintBtn.Size = new System.Drawing.Size(111, 51);
            this.searchBloodPrintBtn.TabIndex = 46;
            this.searchBloodPrintBtn.Text = "Yazdır";
            this.searchBloodPrintBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBloodPrintBtn.UseSelectable = true;
            this.searchBloodPrintBtn.Click += new System.EventHandler(this.searchBloodPrintBtn_Click);
            // 
            // searchBloodTxt
            // 
            // 
            // 
            // 
            this.searchBloodTxt.CustomButton.Image = null;
            this.searchBloodTxt.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.searchBloodTxt.CustomButton.Name = "";
            this.searchBloodTxt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.searchBloodTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBloodTxt.CustomButton.TabIndex = 1;
            this.searchBloodTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBloodTxt.CustomButton.UseSelectable = true;
            this.searchBloodTxt.CustomButton.Visible = false;
            this.searchBloodTxt.Lines = new string[0];
            this.searchBloodTxt.Location = new System.Drawing.Point(472, 33);
            this.searchBloodTxt.MaxLength = 32767;
            this.searchBloodTxt.Name = "searchBloodTxt";
            this.searchBloodTxt.PasswordChar = '\0';
            this.searchBloodTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBloodTxt.SelectedText = "";
            this.searchBloodTxt.SelectionLength = 0;
            this.searchBloodTxt.SelectionStart = 0;
            this.searchBloodTxt.ShortcutsEnabled = true;
            this.searchBloodTxt.Size = new System.Drawing.Size(206, 30);
            this.searchBloodTxt.TabIndex = 45;
            this.searchBloodTxt.UseSelectable = true;
            this.searchBloodTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBloodTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchBloodTxt.TextChanged += new System.EventHandler(this.searchBloodTxt_TextChanged);
            // 
            // searchBloodExitButton
            // 
            this.searchBloodExitButton.BackColor = System.Drawing.Color.Thistle;
            this.searchBloodExitButton.Image = ((System.Drawing.Image)(resources.GetObject("searchBloodExitButton.Image")));
            this.searchBloodExitButton.Location = new System.Drawing.Point(961, 15);
            this.searchBloodExitButton.Name = "searchBloodExitButton";
            this.searchBloodExitButton.Size = new System.Drawing.Size(50, 42);
            this.searchBloodExitButton.TabIndex = 44;
            this.searchBloodExitButton.UseVisualStyleBackColor = false;
            this.searchBloodExitButton.Click += new System.EventHandler(this.searchBloodExitButton_Click);
            // 
            // searchBloodDataGrid
            // 
            this.searchBloodDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchBloodDataGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.searchBloodDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchBloodDataGrid.Location = new System.Drawing.Point(12, 201);
            this.searchBloodDataGrid.Name = "searchBloodDataGrid";
            this.searchBloodDataGrid.RowHeadersWidth = 51;
            this.searchBloodDataGrid.RowTemplate.Height = 24;
            this.searchBloodDataGrid.Size = new System.Drawing.Size(999, 360);
            this.searchBloodDataGrid.TabIndex = 43;
            // 
            // addNewDonorTitle
            // 
            this.addNewDonorTitle.AutoSize = true;
            this.addNewDonorTitle.BackColor = System.Drawing.Color.Transparent;
            this.addNewDonorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewDonorTitle.ForeColor = System.Drawing.Color.White;
            this.addNewDonorTitle.Location = new System.Drawing.Point(321, 37);
            this.addNewDonorTitle.Name = "addNewDonorTitle";
            this.addNewDonorTitle.Size = new System.Drawing.Size(373, 38);
            this.addNewDonorTitle.TabIndex = 42;
            this.addNewDonorTitle.Text = "Kan Grubuna Göre Ara";
            // 
            // searchDonorPrintDocument
            // 
            this.searchDonorPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.searchDonorPrintDocument_PrintPage);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.bloodGroupLabel);
            this.panel1.Controls.Add(this.searchBloodTxt);
            this.panel1.Location = new System.Drawing.Point(-6, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 97);
            this.panel1.TabIndex = 47;
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bloodGroupLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodGroupLabel.Location = new System.Drawing.Point(346, 33);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(120, 30);
            this.bloodGroupLabel.TabIndex = 63;
            this.bloodGroupLabel.Text = "Kan Grubu:";
            this.bloodGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1030, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBloodPrintBtn);
            this.Controls.Add(this.searchBloodExitButton);
            this.Controls.Add(this.searchBloodDataGrid);
            this.Controls.Add(this.addNewDonorTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchBlood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBlood";
            this.Load += new System.EventHandler(this.SearchBlood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchBloodDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton searchBloodPrintBtn;
        private MetroFramework.Controls.MetroTextBox searchBloodTxt;
        private System.Windows.Forms.Button searchBloodExitButton;
        private System.Windows.Forms.DataGridView searchBloodDataGrid;
        private System.Windows.Forms.Label addNewDonorTitle;
        private System.Drawing.Printing.PrintDocument searchDonorPrintDocument;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bloodGroupLabel;
    }
}