using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Order_Processing_System
{
    public partial class AddCustomers : MetroFramework.Forms.MetroForm
    {
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=THINKPAD-T430;Initial Catalog=Order_Processing_System;Integrated Security=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Customers([Customer ID],[Name],[Telephone]) VALUES(@ID,@Name,@Telephone)";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", this.TextBoxCustomerID.Text);
            command.Parameters.AddWithValue("@Name", this.TextBoxName.Text);
            command.Parameters.AddWithValue("@Telephone", this.TextBoxTelephone.Text);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Record Successfuly Added");
        }
    }
}
