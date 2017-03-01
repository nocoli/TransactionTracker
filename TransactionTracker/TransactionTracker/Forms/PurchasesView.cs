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
    public partial class PurchasesView : Form
    {
        SqlConnection connection;
        string connectionString;

        public PurchasesView()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TransactionTracker.Properties.Settings.TransactionsConnectionString"].ConnectionString;
        }

        private void PurchasesView_Load(object sender, EventArgs e)
        {
            // this load does not work
            //PopulateBuyTransactions();
        }

        private void PopulateBuyTransactions()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Transactions WHERE TransactionType = 'buy'", connection))
            {
                connection.Open();

                DataTable PurchasesTable = new DataTable();

                adapter.Fill(PurchasesTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = PurchasesTable;
                purchasesTable.DataSource = bSource;
                adapter.Update(PurchasesTable);

                ////////////////////////////

                //listTransactions.DisplayMember = "ID";
                //listTransactions.DisplayMember = "car";
                //listTransactions.DisplayMember = "date";

                //listTransactionsView.
                //listTransactions.ValueMember = "ID";
                //listTransactions.DataSource = recentTransactionsTable;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainForm = new Form1();
            mainForm.ShowDialog();
        }

        private void PurchasesView_Load_1(object sender, EventArgs e)
        {
            PopulateBuyTransactions();
        }
    }
}
