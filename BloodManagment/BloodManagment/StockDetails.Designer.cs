namespace BloodManagment
{
    partial class StockDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDetails));
            this.printButton = new MetroFramework.Controls.MetroButton();
            this.detailsExitButton = new System.Windows.Forms.Button();
            this.stockDetailsDataGrid = new System.Windows.Forms.DataGridView();
            this.detailsStockTitle = new System.Windows.Forms.Label();
            this.printStockDetails = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.printButton.Location = new System.Drawing.Point(12, 542);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(124, 40);
            this.printButton.TabIndex = 73;
            this.printButton.Text = "Yazdır";
            this.printButton.UseSelectable = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // detailsExitButton
            // 
            this.detailsExitButton.BackColor = System.Drawing.Color.Thistle;
            this.detailsExitButton.Image = ((System.Drawing.Image)(resources.GetObject("detailsExitButton.Image")));
            this.detailsExitButton.Location = new System.Drawing.Point(968, 12);
            this.detailsExitButton.Name = "detailsExitButton";
            this.detailsExitButton.Size = new System.Drawing.Size(50, 42);
            this.detailsExitButton.TabIndex = 67;
            this.detailsExitButton.UseVisualStyleBackColor = false;
            this.detailsExitButton.Click += new System.EventHandler(this.detailsExitButton_Click);
            // 
            // stockDetailsDataGrid
            // 
            this.stockDetailsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDetailsDataGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.stockDetailsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockDetailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDetailsDataGrid.Location = new System.Drawing.Point(12, 137);
            this.stockDetailsDataGrid.Name = "stockDetailsDataGrid";
            this.stockDetailsDataGrid.RowHeadersWidth = 51;
            this.stockDetailsDataGrid.RowTemplate.Height = 24;
            this.stockDetailsDataGrid.Size = new System.Drawing.Size(1006, 373);
            this.stockDetailsDataGrid.TabIndex = 66;
            // 
            // detailsStockTitle
            // 
            this.detailsStockTitle.AutoSize = true;
            this.detailsStockTitle.BackColor = System.Drawing.Color.Transparent;
            this.detailsStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detailsStockTitle.ForeColor = System.Drawing.Color.White;
            this.detailsStockTitle.Location = new System.Drawing.Point(398, 55);
            this.detailsStockTitle.Name = "detailsStockTitle";
            this.detailsStockTitle.Size = new System.Drawing.Size(235, 38);
            this.detailsStockTitle.TabIndex = 65;
            this.detailsStockTitle.Text = "Stok Detayları";
            // 
            // printStockDetails
            // 
            this.printStockDetails.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStockDetails_PrintPage);
            // 
            // StockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1030, 630);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.detailsExitButton);
            this.Controls.Add(this.stockDetailsDataGrid);
            this.Controls.Add(this.detailsStockTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockDetails";
            this.Load += new System.EventHandler(this.StockDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockDetailsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton printButton;
        private System.Windows.Forms.Button detailsExitButton;
        private System.Windows.Forms.DataGridView stockDetailsDataGrid;
        private System.Windows.Forms.Label detailsStockTitle;
        private System.Drawing.Printing.PrintDocument printStockDetails;
    }
}