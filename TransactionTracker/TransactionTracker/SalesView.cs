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

namespace TransactionTracker.Forms
{
    public partial class SalesView : Form
    {
        SqlConnection connection;
        string connectionString;

        public SalesView()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TransactionTracker.Properties.Settings.TransactionsConnectionString"].ConnectionString;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
        }

        private void SalesView_Load(object sender, EventArgs e)
        {
            PopulateSaleTransactions();
        }

        private void PopulateSaleTransactions()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Transactions WHERE TransactionType = 'sell'", connection))
            {
                connection.Open();

                DataTable SalesTable = new DataTable();

                adapter.Fill(SalesTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = SalesTable;
                salesTable.DataSource = bSource;
                adapter.Update(SalesTable);

                ////////////////////////////

                //listTransactions.DisplayMember = "ID";
                //listTransactions.DisplayMember = "car";
                //listTransactions.DisplayMember = "date";

                //listTransactionsView.
                //listTransactions.ValueMember = "ID";
                //listTransactions.DataSource = recentTransactionsTable;
            }
        }

        private void SalesView_Load_1(object sender, EventArgs e)
        {
            PopulateSaleTransactions();
        }
    }
}
