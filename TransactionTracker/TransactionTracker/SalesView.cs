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
        SqlDataReader reader;
        public SqlCommand cmd;
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
            //addUpSales();
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

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT SUM(Price) FROM Transactions";

                SqlCommand comm = new SqlCommand("SELECT SUM(Price) FROM Transactions WHERE TransactionType = 'sell'", connection);
                

                //reader = command.ExecuteReader();
                Int32 count = (Int32)comm.ExecuteScalar();

                saleTotalLabel.Text = count.ToString();

            }

            connection.Close();


        }

        public void addUpSales()
        {/*
            //SqlCommand cmd;
            //Console.WriteLine(cmd);
            //private static SqlCommand cmd = new SqlCommand;
            cmd.CommandText = "SELECT SUM(Price) FROM Transactions";

            int i = 0;

            //this is a test

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //saleTotalLabel.Text = reader.GetString(0);
                    Console.WriteLine(reader.GetString(0));
                    Console.WriteLine(reader.ToString());
                    saleTotalLabel.Text = "lol";
                }
                saleTotalLabel.Text = "lol";
            }
            saleTotalLabel.Text = "lol";
            Console.WriteLine(reader.GetString(0));
            Console.WriteLine(reader.ToString());

            //using (connection = new SqlConnection(connectionString)) {

            //connection.Open();

            /*
                            SqlCommand salesTotalCmd = new SqlCommand("SELECT SUM(Price) FROM Transactions", connection);

                            try
                            {

                                SqlDataReader dr = salesTotalCmd.ExecuteReader();
                                while (dr.Read())
                                {
                                    saleTotalLabel.Text = dr.ToString();
                                }
                            }
                            catch (SqlException ex)
                            {
                                saleTotalLabel.Text = ex.Message;
                            }
                            finally
                            {
                                connection.Close();
                            }
            */
            //saleTotalLabel.Text = dr[0].ToString();

            /*
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT SUM(Price) FROM Transactions", connection))
            {


                SqlDataReader reader = adapter.executeReader();

            //saleTotalLabel.Text = adapter.ToString();
            }
            */

            //}
         }

        private void SalesView_Load_1(object sender, EventArgs e)
        {
            PopulateSaleTransactions();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
