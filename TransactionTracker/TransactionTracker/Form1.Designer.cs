namespace TransactionTracker
{
    partial class Form1
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
            this.HomepageHeading = new System.Windows.Forms.Label();
            this.RecentActivityButton = new System.Windows.Forms.Button();
            this.ViewPurchasesButton = new System.Windows.Forms.Button();
            this.ViewSalesButton = new System.Windows.Forms.Button();
            this.RemoveTransactionButton = new System.Windows.Forms.Button();
            this.AddPurchaseButton = new System.Windows.Forms.Button();
            this.AddSaleButton = new System.Windows.Forms.Button();
            this.TotalSpentLabel = new System.Windows.Forms.Label();
            this.TotalSoldLabel = new System.Windows.Forms.Label();
            this.TotalNetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomepageHeading
            // 
            this.HomepageHeading.AutoSize = true;
            this.HomepageHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomepageHeading.Location = new System.Drawing.Point(194, 9);
            this.HomepageHeading.Name = "HomepageHeading";
            this.HomepageHeading.Size = new System.Drawing.Size(228, 29);
            this.HomepageHeading.TabIndex = 0;
            this.HomepageHeading.Text = "Transaction Tracker";
            // 
            // RecentActivityButton
            // 
            this.RecentActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentActivityButton.Location = new System.Drawing.Point(39, 66);
            this.RecentActivityButton.Name = "RecentActivityButton";
            this.RecentActivityButton.Size = new System.Drawing.Size(150, 78);
            this.RecentActivityButton.TabIndex = 1;
            this.RecentActivityButton.Text = "Recent Activity";
            this.RecentActivityButton.UseVisualStyleBackColor = true;
            // 
            // ViewPurchasesButton
            // 
            this.ViewPurchasesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPurchasesButton.Location = new System.Drawing.Point(226, 66);
            this.ViewPurchasesButton.Name = "ViewPurchasesButton";
            this.ViewPurchasesButton.Size = new System.Drawing.Size(150, 78);
            this.ViewPurchasesButton.TabIndex = 2;
            this.ViewPurchasesButton.Text = "Purcahses";
            this.ViewPurchasesButton.UseVisualStyleBackColor = true;
            // 
            // ViewSalesButton
            // 
            this.ViewSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSalesButton.Location = new System.Drawing.Point(408, 66);
            this.ViewSalesButton.Name = "ViewSalesButton";
            this.ViewSalesButton.Size = new System.Drawing.Size(150, 78);
            this.ViewSalesButton.TabIndex = 3;
            this.ViewSalesButton.Text = "Sales";
            this.ViewSalesButton.UseVisualStyleBackColor = true;
            // 
            // RemoveTransactionButton
            // 
            this.RemoveTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTransactionButton.Location = new System.Drawing.Point(39, 168);
            this.RemoveTransactionButton.Name = "RemoveTransactionButton";
            this.RemoveTransactionButton.Size = new System.Drawing.Size(150, 78);
            this.RemoveTransactionButton.TabIndex = 4;
            this.RemoveTransactionButton.Text = "Remove";
            this.RemoveTransactionButton.UseVisualStyleBackColor = true;
            // 
            // AddPurchaseButton
            // 
            this.AddPurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPurchaseButton.Location = new System.Drawing.Point(226, 168);
            this.AddPurchaseButton.Name = "AddPurchaseButton";
            this.AddPurchaseButton.Size = new System.Drawing.Size(150, 78);
            this.AddPurchaseButton.TabIndex = 5;
            this.AddPurchaseButton.Text = "+ Purchase";
            this.AddPurchaseButton.UseVisualStyleBackColor = true;
            // 
            // AddSaleButton
            // 
            this.AddSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSaleButton.Location = new System.Drawing.Point(408, 168);
            this.AddSaleButton.Name = "AddSaleButton";
            this.AddSaleButton.Size = new System.Drawing.Size(150, 78);
            this.AddSaleButton.TabIndex = 6;
            this.AddSaleButton.Text = "+ Sale";
            this.AddSaleButton.UseVisualStyleBackColor = true;
            // 
            // TotalSpentLabel
            // 
            this.TotalSpentLabel.AutoSize = true;
            this.TotalSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSpentLabel.Location = new System.Drawing.Point(34, 278);
            this.TotalSpentLabel.Name = "TotalSpentLabel";
            this.TotalSpentLabel.Size = new System.Drawing.Size(139, 29);
            this.TotalSpentLabel.TabIndex = 7;
            this.TotalSpentLabel.Text = "Total spent:";
            // 
            // TotalSoldLabel
            // 
            this.TotalSoldLabel.AutoSize = true;
            this.TotalSoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSoldLabel.Location = new System.Drawing.Point(221, 278);
            this.TotalSoldLabel.Name = "TotalSoldLabel";
            this.TotalSoldLabel.Size = new System.Drawing.Size(130, 29);
            this.TotalSoldLabel.TabIndex = 8;
            this.TotalSoldLabel.Text = "Total Sold:";
            this.TotalSoldLabel.Click += new System.EventHandler(this.TotalSoldLabel_Click);
            // 
            // TotalNetLabel
            // 
            this.TotalNetLabel.AutoSize = true;
            this.TotalNetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNetLabel.Location = new System.Drawing.Point(403, 278);
            this.TotalNetLabel.Name = "TotalNetLabel";
            this.TotalNetLabel.Size = new System.Drawing.Size(118, 29);
            this.TotalNetLabel.TabIndex = 9;
            this.TotalNetLabel.Text = "Total Net:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 331);
            this.Controls.Add(this.TotalNetLabel);
            this.Controls.Add(this.TotalSoldLabel);
            this.Controls.Add(this.TotalSpentLabel);
            this.Controls.Add(this.AddSaleButton);
            this.Controls.Add(this.AddPurchaseButton);
            this.Controls.Add(this.RemoveTransactionButton);
            this.Controls.Add(this.ViewSalesButton);
            this.Controls.Add(this.ViewPurchasesButton);
            this.Controls.Add(this.RecentActivityButton);
            this.Controls.Add(this.HomepageHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomepageHeading;
        private System.Windows.Forms.Button RecentActivityButton;
        private System.Windows.Forms.Button ViewPurchasesButton;
        private System.Windows.Forms.Button ViewSalesButton;
        private System.Windows.Forms.Button RemoveTransactionButton;
        private System.Windows.Forms.Button AddPurchaseButton;
        private System.Windows.Forms.Button AddSaleButton;
        private System.Windows.Forms.Label TotalSpentLabel;
        private System.Windows.Forms.Label TotalSoldLabel;
        private System.Windows.Forms.Label TotalNetLabel;
    }
}

