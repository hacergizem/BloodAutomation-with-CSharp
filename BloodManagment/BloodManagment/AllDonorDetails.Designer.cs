namespace BloodManagment
{
    partial class AllDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllDonorDetails));
            this.addNewDonorTitle = new System.Windows.Forms.Label();
            this.allDonorDetailsDataGrid = new System.Windows.Forms.DataGridView();
            this.allDonorPrintBtn = new MetroFramework.Controls.MetroButton();
            this.allDonorsExitButton = new System.Windows.Forms.Button();
            this.allDonorPrint = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.allDonorDetailsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewDonorTitle
            // 
            this.addNewDonorTitle.AutoSize = true;
            this.addNewDonorTitle.BackColor = System.Drawing.Color.Transparent;
            this.addNewDonorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewDonorTitle.ForeColor = System.Drawing.Color.White;
            this.addNewDonorTitle.Location = new System.Drawing.Point(335, 48);
            this.addNewDonorTitle.Name = "addNewDonorTitle";
            this.addNewDonorTitle.Size = new System.Drawing.Size(337, 38);
            this.addNewDonorTitle.TabIndex = 1;
            this.addNewDonorTitle.Text = "Tüm Donör Detayları";
            // 
            // allDonorDetailsDataGrid
            // 
            this.allDonorDetailsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allDonorDetailsDataGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.allDonorDetailsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allDonorDetailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDonorDetailsDataGrid.Location = new System.Drawing.Point(12, 133);
            this.allDonorDetailsDataGrid.Name = "allDonorDetailsDataGrid";
            this.allDonorDetailsDataGrid.RowHeadersWidth = 51;
            this.allDonorDetailsDataGrid.RowTemplate.Height = 24;
            this.allDonorDetailsDataGrid.Size = new System.Drawing.Size(1006, 406);
            this.allDonorDetailsDataGrid.TabIndex = 2;
            // 
            // allDonorPrintBtn
            // 
            this.allDonorPrintBtn.BackColor = System.Drawing.Color.Linen;
            this.allDonorPrintBtn.Location = new System.Drawing.Point(12, 567);
            this.allDonorPrintBtn.Name = "allDonorPrintBtn";
            this.allDonorPrintBtn.Size = new System.Drawing.Size(111, 51);
            this.allDonorPrintBtn.TabIndex = 12;
            this.allDonorPrintBtn.Text = "Yazdır";
            this.allDonorPrintBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.allDonorPrintBtn.UseSelectable = true;
            this.allDonorPrintBtn.Click += new System.EventHandler(this.allDonorPrintBtn_Click);
            // 
            // allDonorsExitButton
            // 
            this.allDonorsExitButton.BackColor = System.Drawing.Color.Thistle;
            this.allDonorsExitButton.Image = ((System.Drawing.Image)(resources.GetObject("allDonorsExitButton.Image")));
            this.allDonorsExitButton.Location = new System.Drawing.Point(968, 12);
            this.allDonorsExitButton.Name = "allDonorsExitButton";
            this.allDonorsExitButton.Size = new System.Drawing.Size(50, 42);
            this.allDonorsExitButton.TabIndex = 13;
            this.allDonorsExitButton.UseVisualStyleBackColor = false;
            this.allDonorsExitButton.Click += new System.EventHandler(this.allDonorsExitButton_Click);
            // 
            // allDonorPrint
            // 
            this.allDonorPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.allDonorPrint_PrintPage);
            // 
            // AllDonorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1030, 630);
            this.Controls.Add(this.allDonorsExitButton);
            this.Controls.Add(this.allDonorPrintBtn);
            this.Controls.Add(this.allDonorDetailsDataGrid);
            this.Controls.Add(this.addNewDonorTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllDonorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllDonorDetails";
            this.Load += new System.EventHandler(this.AllDonorDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allDonorDetailsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewDonorTitle;
        private System.Windows.Forms.DataGridView allDonorDetailsDataGrid;
        private MetroFramework.Controls.MetroButton allDonorPrintBtn;
        private System.Windows.Forms.Button allDonorsExitButton;
        private System.Drawing.Printing.PrintDocument allDonorPrint;
    }
}