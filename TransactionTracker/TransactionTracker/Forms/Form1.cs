using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using TransactionTracker.Forms;

namespace TransactionTracker
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["TransactionTracker.Properties.Settings.TransactionsConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TotalSoldLabel_Click(object sender, EventArgs e)
        {

        }

        private void ViewPurchasesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.PurchasesView purchaseView = new Forms.PurchasesView();
            purchaseView.ShowDialog();
        }

        private void RecentActivityButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionHistory recentHistory = new TransactionHistory();
            recentHistory.ShowDialog();
        }

        private void ViewSalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesView salesHistory = new SalesView();
            //salesView salesHistory = new salesView();
            salesHistory.ShowDialog();
        }
    }
}
