namespace TransactionTracker.Forms
{
    partial class SalesView
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
            this.salesTable = new System.Windows.Forms.DataGridView();
            this.SalesHistoryLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // salesTable
            // 
            this.salesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesTable.Location = new System.Drawing.Point(27, 92);
            this.salesTable.Name = "salesTable";
            this.salesTable.Size = new System.Drawing.Size(926, 379);
            this.salesTable.TabIndex = 8;
            // 
            // SalesHistoryLabel
            // 
            this.SalesHistoryLabel.AutoSize = true;
            this.SalesHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesHistoryLabel.Location = new System.Drawing.Point(59, 37);
            this.SalesHistoryLabel.Name = "SalesHistoryLabel";
            this.SalesHistoryLabel.Size = new System.Drawing.Size(154, 29);
            this.SalesHistoryLabel.TabIndex = 9;
            this.SalesHistoryLabel.Text = "Sales History";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(848, 44);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 529);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SalesHistoryLabel);
            this.Controls.Add(this.salesTable);
            this.Name = "SalesView";
            this.Text = "SalesView";
            this.Load += new System.EventHandler(this.SalesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesTable;
        private System.Windows.Forms.Label SalesHistoryLabel;
        private System.Windows.Forms.Button BackButton;
    }
}