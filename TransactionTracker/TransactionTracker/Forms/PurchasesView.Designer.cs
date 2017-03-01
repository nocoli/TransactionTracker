namespace TransactionTracker.Forms
{
    partial class PurchasesView
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
            this.BackButton = new System.Windows.Forms.Button();
            this.RecentActivityLabel = new System.Windows.Forms.Label();
            this.purchasesTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(795, 29);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RecentActivityLabel
            // 
            this.RecentActivityLabel.AutoSize = true;
            this.RecentActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentActivityLabel.Location = new System.Drawing.Point(12, 22);
            this.RecentActivityLabel.Name = "RecentActivityLabel";
            this.RecentActivityLabel.Size = new System.Drawing.Size(200, 29);
            this.RecentActivityLabel.TabIndex = 6;
            this.RecentActivityLabel.Text = "Purchase History:";
            // 
            // purchasesTable
            // 
            this.purchasesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesTable.Location = new System.Drawing.Point(17, 54);
            this.purchasesTable.Name = "purchasesTable";
            this.purchasesTable.Size = new System.Drawing.Size(926, 379);
            this.purchasesTable.TabIndex = 7;
            // 
            // PurchasesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 445);
            this.Controls.Add(this.purchasesTable);
            this.Controls.Add(this.RecentActivityLabel);
            this.Controls.Add(this.BackButton);
            this.Name = "PurchasesView";
            this.Text = "PurchasesView";
            this.Load += new System.EventHandler(this.PurchasesView_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label RecentActivityLabel;
        private System.Windows.Forms.DataGridView purchasesTable;
    }
}