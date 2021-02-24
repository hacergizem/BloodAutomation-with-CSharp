namespace BloodManagment
{
    partial class StockDecrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDecrease));
            this.printButton = new MetroFramework.Controls.MetroButton();
            this.decreaseButton = new MetroFramework.Controls.MetroButton();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupLabel = new System.Windows.Forms.Label();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.stockDecreaseDataGrid = new System.Windows.Forms.DataGridView();
            this.increaseStockTitle = new System.Windows.Forms.Label();
            this.decreaseExitButton = new System.Windows.Forms.Button();
            this.printStockDec = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.stockDecreaseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.printButton.Location = new System.Drawing.Point(29, 567);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(124, 40);
            this.printButton.TabIndex = 64;
            this.printButton.Text = "Yazdır";
            this.printButton.UseSelectable = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // decreaseButton
            // 
            this.decreaseButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.decreaseButton.Location = new System.Drawing.Point(774, 103);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(124, 40);
            this.decreaseButton.TabIndex = 63;
            this.decreaseButton.Text = "Azalt";
            this.decreaseButton.UseSelectable = true;
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.BackColor = System.Drawing.Color.Transparent;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unitLabel.ForeColor = System.Drawing.Color.White;
            this.unitLabel.Location = new System.Drawing.Point(460, 112);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(69, 25);
            this.unitLabel.TabIndex = 62;
            this.unitLabel.Text = "Ünite:";
            // 
            // unitComboBox
            // 
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Items.AddRange(new object[] {
            "-1",
            "-2",
            "-3",
            "-4",
            "-5",
            "-6",
            "-7",
            "-8",
            "-9",
            "-10"});
            this.unitComboBox.Location = new System.Drawing.Point(535, 112);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(170, 24);
            this.unitComboBox.TabIndex = 61;
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.AutoSize = true;
            this.bloodGroupLabel.BackColor = System.Drawing.Color.Transparent;
            this.bloodGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodGroupLabel.ForeColor = System.Drawing.Color.White;
            this.bloodGroupLabel.Location = new System.Drawing.Point(102, 111);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(123, 25);
            this.bloodGroupLabel.TabIndex = 60;
            this.bloodGroupLabel.Text = "Kan Grubu:";
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
            this.bloodGroupComboBox.Location = new System.Drawing.Point(231, 111);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(170, 24);
            this.bloodGroupComboBox.TabIndex = 59;
            // 
            // stockDecreaseDataGrid
            // 
            this.stockDecreaseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDecreaseDataGrid.BackgroundColor = System.Drawing.Color.IndianRed;
            this.stockDecreaseDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockDecreaseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDecreaseDataGrid.GridColor = System.Drawing.Color.IndianRed;
            this.stockDecreaseDataGrid.Location = new System.Drawing.Point(12, 169);
            this.stockDecreaseDataGrid.Name = "stockDecreaseDataGrid";
            this.stockDecreaseDataGrid.RowHeadersWidth = 51;
            this.stockDecreaseDataGrid.RowTemplate.Height = 24;
            this.stockDecreaseDataGrid.Size = new System.Drawing.Size(1006, 373);
            this.stockDecreaseDataGrid.TabIndex = 57;
            // 
            // increaseStockTitle
            // 
            this.increaseStockTitle.AutoSize = true;
            this.increaseStockTitle.BackColor = System.Drawing.Color.Transparent;
            this.increaseStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.increaseStockTitle.ForeColor = System.Drawing.Color.White;
            this.increaseStockTitle.Location = new System.Drawing.Point(429, 26);
            this.increaseStockTitle.Name = "increaseStockTitle";
            this.increaseStockTitle.Size = new System.Drawing.Size(175, 38);
            this.increaseStockTitle.TabIndex = 56;
            this.increaseStockTitle.Text = "Stok Azalt";
            // 
            // decreaseExitButton
            // 
            this.decreaseExitButton.BackColor = System.Drawing.Color.Thistle;
            this.decreaseExitButton.Image = ((System.Drawing.Image)(resources.GetObject("decreaseExitButton.Image")));
            this.decreaseExitButton.Location = new System.Drawing.Point(973, 12);
            this.decreaseExitButton.Name = "decreaseExitButton";
            this.decreaseExitButton.Size = new System.Drawing.Size(50, 42);
            this.decreaseExitButton.TabIndex = 58;
            this.decreaseExitButton.UseVisualStyleBackColor = false;
            this.decreaseExitButton.Click += new System.EventHandler(this.decreaseExitButton_Click);
            // 
            // printStockDec
            // 
            this.printStockDec.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStockDec_PrintPage);
            // 
            // StockDecrease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1030, 630);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.decreaseButton);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.bloodGroupLabel);
            this.Controls.Add(this.bloodGroupComboBox);
            this.Controls.Add(this.decreaseExitButton);
            this.Controls.Add(this.stockDecreaseDataGrid);
            this.Controls.Add(this.increaseStockTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockDecrease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockDecrease";
            this.Load += new System.EventHandler(this.StockDecrease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockDecreaseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton printButton;
        private MetroFramework.Controls.MetroButton decreaseButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Label bloodGroupLabel;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Button decreaseExitButton;
        private System.Windows.Forms.DataGridView stockDecreaseDataGrid;
        private System.Windows.Forms.Label increaseStockTitle;
        private System.Drawing.Printing.PrintDocument printStockDec;
    }
}