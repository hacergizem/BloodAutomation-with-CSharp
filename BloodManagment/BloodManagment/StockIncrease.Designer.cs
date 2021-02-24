namespace BloodManagment
{
    partial class StockIncrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIncrease));
            this.stockIncreaseDataGrid = new System.Windows.Forms.DataGridView();
            this.increaseStockTitle = new System.Windows.Forms.Label();
            this.increaseExitButton = new System.Windows.Forms.Button();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.increaseButton = new MetroFramework.Controls.MetroButton();
            this.printButton = new MetroFramework.Controls.MetroButton();
            this.printStockIncrease = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.stockIncreaseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stockIncreaseDataGrid
            // 
            this.stockIncreaseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockIncreaseDataGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.stockIncreaseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockIncreaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockIncreaseDataGrid.Location = new System.Drawing.Point(12, 167);
            this.stockIncreaseDataGrid.Name = "stockIncreaseDataGrid";
            this.stockIncreaseDataGrid.RowHeadersWidth = 51;
            this.stockIncreaseDataGrid.RowTemplate.Height = 24;
            this.stockIncreaseDataGrid.Size = new System.Drawing.Size(1006, 373);
            this.stockIncreaseDataGrid.TabIndex = 47;
            // 
            // increaseStockTitle
            // 
            this.increaseStockTitle.AutoSize = true;
            this.increaseStockTitle.BackColor = System.Drawing.Color.Transparent;
            this.increaseStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.increaseStockTitle.ForeColor = System.Drawing.Color.White;
            this.increaseStockTitle.Location = new System.Drawing.Point(430, 26);
            this.increaseStockTitle.Name = "increaseStockTitle";
            this.increaseStockTitle.Size = new System.Drawing.Size(212, 38);
            this.increaseStockTitle.TabIndex = 46;
            this.increaseStockTitle.Text = "Stok Yükselt";
            // 
            // increaseExitButton
            // 
            this.increaseExitButton.BackColor = System.Drawing.Color.Thistle;
            this.increaseExitButton.Image = ((System.Drawing.Image)(resources.GetObject("increaseExitButton.Image")));
            this.increaseExitButton.Location = new System.Drawing.Point(974, 12);
            this.increaseExitButton.Name = "increaseExitButton";
            this.increaseExitButton.Size = new System.Drawing.Size(50, 42);
            this.increaseExitButton.TabIndex = 49;
            this.increaseExitButton.UseVisualStyleBackColor = false;
            this.increaseExitButton.Click += new System.EventHandler(this.increaseExitButton_Click);
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "0+",
            "0-",
            "AB+"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(232, 111);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(170, 24);
            this.bloodGroupComboBox.TabIndex = 50;
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.AutoSize = true;
            this.bloodGroupLabel.BackColor = System.Drawing.Color.Transparent;
            this.bloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodGroupLabel.ForeColor = System.Drawing.Color.White;
            this.bloodGroupLabel.Location = new System.Drawing.Point(103, 111);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(123, 25);
            this.bloodGroupLabel.TabIndex = 51;
            this.bloodGroupLabel.Text = "Kan Grubu:";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.BackColor = System.Drawing.Color.Transparent;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unitLabel.ForeColor = System.Drawing.Color.White;
            this.unitLabel.Location = new System.Drawing.Point(461, 112);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(69, 25);
            this.unitLabel.TabIndex = 53;
            this.unitLabel.Text = "Ünite:";
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.unitComboBox.Location = new System.Drawing.Point(536, 112);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(170, 24);
            this.unitComboBox.TabIndex = 52;
            // 
            // increaseButton
            // 
            this.increaseButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.increaseButton.Location = new System.Drawing.Point(775, 103);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(124, 40);
            this.increaseButton.TabIndex = 54;
            this.increaseButton.Text = "Yükselt";
            this.increaseButton.UseSelectable = true;
            this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
            // 
            // printButton
            // 
            this.printButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.printButton.Location = new System.Drawing.Point(30, 567);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(124, 40);
            this.printButton.TabIndex = 55;
            this.printButton.Text = "Yazdır";
            this.printButton.UseSelectable = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printStockIncrease
            // 
            this.printStockIncrease.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStockIncrease_PrintPage);
            // 
            // StockIncrease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1030, 630);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.increaseButton);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.bloodGroupLabel);
            this.Controls.Add(this.bloodGroupComboBox);
            this.Controls.Add(this.increaseExitButton);
            this.Controls.Add(this.stockIncreaseDataGrid);
            this.Controls.Add(this.increaseStockTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockIncrease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockIncrease";
            this.Load += new System.EventHandler(this.StockIncrease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockIncreaseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView stockIncreaseDataGrid;
        private System.Windows.Forms.Label increaseStockTitle;
        private System.Windows.Forms.Button increaseExitButton;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Label bloodGroupLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ComboBox unitComboBox;
        private MetroFramework.Controls.MetroButton increaseButton;
        private MetroFramework.Controls.MetroButton printButton;
        private System.Drawing.Printing.PrintDocument printStockIncrease;
    }
}