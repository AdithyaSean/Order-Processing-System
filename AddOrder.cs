using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Order_Processing_System
{
    public partial class AddOrder : MetroFramework.Forms.MetroForm
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=THINKPAD-T430;Initial Catalog=Order_Processing_System;Integrated Security=True;";
            string customerQuery = "SELECT Name FROM Customers";
            string itemQuery = "SELECT Name FROM Items";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand customerCommand = new SqlCommand(customerQuery, connection))
                {
                    using (SqlDataReader customerReader = customerCommand.ExecuteReader())
                    {
                        while (customerReader.Read())
                        {
                            comboBoxCustomer.Items.Add(customerReader[0].ToString());
                        }
                    }
                }

                using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection))
                {
                    using (SqlDataReader itemReader = itemCommand.ExecuteReader())
                    {
                        while (itemReader.Read())
                        {
                            comboBoxItem.Items.Add(itemReader[0].ToString());
                        }
                    }
                }
            }
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=THINKPAD-T430;Initial Catalog=Order_Processing_System;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string priceQuery = "SELECT Price FROM Items WHERE Name = @Name";

                using (SqlCommand priceCommand = new SqlCommand(priceQuery, connection))
                {
                    priceCommand.Parameters.AddWithValue("@Name", this.comboBoxItem.SelectedItem);

                    using (SqlDataReader priceReader = priceCommand.ExecuteReader())
                    {
                        priceReader.Read();
                        textBoxPrice.Text = priceReader[0].ToString();
                    }
                }
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(this.textBoxPrice.Text);
            double quantity = Convert.ToDouble(this.numericUpDownQuantity.Value);
            double totalBill = price * quantity;
            this.textBoxTotalBill.Text = Convert.ToString(totalBill);
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(this.textBoxPrice.Text);
            double quantity = Convert.ToDouble(this.numericUpDownQuantity.Value);
            double totalBill = price * quantity;
            this.textBoxTotalBill.Text = Convert.ToString(totalBill);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=THINKPAD-T430;Initial Catalog=Order_Processing_System;Integrated Security=True;";

            using (SqlConnection  Connection = new SqlConnection(connectionString))
            {
                Connection.Open();

                string queryAdd = "INSERT INTO Orders([ID],[Customer Name],[Date],[Item Name],[Price],[Quantity],[Total Bill]) VALUES(@ID,@Name,@Date,@Item,@Price,@Quantity,@Total)";

                using (SqlCommand command = new SqlCommand(queryAdd, Connection))
                {
                    command.Parameters.AddWithValue("@ID", this.textBoxID.Text);
                    command.Parameters.AddWithValue("@Name", this.comboBoxCustomer.Text);
                    command.Parameters.AddWithValue("@Date", this.datePicker.Text);
                    command.Parameters.AddWithValue("@Item", this.comboBoxItem.Text);
                    command.Parameters.AddWithValue("@Price", this.textBoxPrice.Text);
                    command.Parameters.AddWithValue("@Quantity", this.numericUpDownQuantity.Text);
                    command.Parameters.AddWithValue("@Total", this.textBoxTotalBill.Text);
                    command.ExecuteNonQuery();
                }

                string viewOrders = "SELECT * FROM Orders";

                using (SqlCommand viewOrdersCommand = new SqlCommand(viewOrders, Connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(viewOrdersCommand);
                    DataSet dataset = new DataSet();
                    dataAdapter.Fill(dataset);

                    this.dataGridView1.DataSource = dataset.Tables[0];
                }
            }
        }
    }
}
