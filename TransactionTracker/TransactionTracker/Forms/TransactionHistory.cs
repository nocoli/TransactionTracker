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

namespace TransactionTracker
{
    public partial class TransactionHistory : Form
    {
        SqlConnection connection;
        string connectionString;

        public TransactionHistory()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["TransactionTracker.Properties.Settings.TransactionsConnectionString"].ConnectionString;
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {
            PopulateTransactions();
        }

        private void PopulateTransactions()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Transactions", connection))
            {
                connection.Open();

                DataTable recentTransactionsTable = new DataTable();
                
                adapter.Fill(recentTransactionsTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = recentTransactionsTable;
                dataGridView1.DataSource = bSource;
                adapter.Update(recentTransactionsTable);

                ////////////////////////////

                //listTransactions.DisplayMember = "ID";
                //listTransactions.DisplayMember = "car";
                //listTransactions.DisplayMember = "date";

                //listTransactionsView.
                //listTransactions.ValueMember = "ID";
                //listTransactions.DataSource = recentTransactionsTable;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homeForm = new Form1();
            homeForm.ShowDialog();
        }
    }
}
