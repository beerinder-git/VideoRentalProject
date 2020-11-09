using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalProject
{
    public partial class MainForm : Form
    {
        string ConnectionString = @"Data Source=DHMATUT-09\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection Connection;

        public MainForm()
        {
            InitializeComponent();

            Connection = new SqlConnection(ConnectionString);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Connection.Open();

            DataTable CustomersTable = new DataTable();

            CustomersTable.Clear();

            CustomersTable.Columns.Add("CustID");
            CustomersTable.Columns.Add("FirstName");
            CustomersTable.Columns.Add("LastName");
            CustomersTable.Columns.Add("Address");
            CustomersTable.Columns.Add("Phone");

            string query = "SELECT * FROM Customer";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CustomersTable.Rows.Add(
                    reader["CustID"],
                    reader["FirstName"],
                    reader["LastName"],
                    reader["Address"],
                    reader["Phone"]
                    );
            }

            CustomerGrid.DataSource = CustomersTable;

            Connection.Close();
        }

        private void LoadMovies_Click(object sender, EventArgs e)
        {
            Connection.Open();

            DataTable CustomersTable = new DataTable();

            CustomersTable.Clear();

            CustomersTable.Columns.Add("MovieID");
            CustomersTable.Columns.Add("Rating");
            CustomersTable.Columns.Add("Title");
            CustomersTable.Columns.Add("Year");
            CustomersTable.Columns.Add("Rental_Cost");
            CustomersTable.Columns.Add("Copies");
            CustomersTable.Columns.Add("Plot");
            CustomersTable.Columns.Add("Genre");

            string query = "SELECT * FROM Movies";

            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CustomersTable.Rows.Add(
                    reader["MovieID"],
                    reader["Rating"],
                    reader["Title"],
                    reader["Year"],
                    reader["Rental_Cost"],
                    reader["Copies"],
                    reader["Plot"],
                    reader["Genre"]
                    );
            }

            CustomerGrid.DataSource = CustomersTable;

            Connection.Close();
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            Connection.Open();

            string query = "INSERT INTO Customer (FirstName, LastName, Phone, Address) " +
                    "VALUES(@FirstName, @LastName, @Phone, @Address);";

            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FNTBox.Text;
                command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LNTBox.Text;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = PhTBox.Text;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = AdTBox.Text;

                command.ExecuteNonQuery();
            }

            Connection.Close();

            LoadBtn_Click(null, null);
        }
    }
}
