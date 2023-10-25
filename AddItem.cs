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

namespace Order_Processing_System
{
    public partial class AddItem : MetroFramework.Forms.MetroForm
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=THINKPAD-T430;Initial Catalog=Order_Processing_System;Integrated Security=True;";
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Items([Item Code],[Name],[Price]) VALUES(@Code,@Name,@Price)";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", this.TextBoxItemCode.Text);
            command.Parameters.AddWithValue("@Name", this.TextBoxName.Text);
            command.Parameters.AddWithValue("@Price", this.TextBoxPrice.Text);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Record Successfuly Added");
        }
    }
}
