using System;
using System.Windows.Forms;

namespace Order_Processing_System
{
    public partial class ParentWindow : Form
    {
        public ParentWindow()
        {
            InitializeComponent();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.MdiParent = this;
            addItem.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomers addCustomers = new AddCustomers();
            addCustomers.MdiParent = this;
            addCustomers.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            addOrder.MdiParent = this;
            addOrder.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReports customerReports = new CustomerReports();
            customerReports.MdiParent = this;
            customerReports.Show();
        }

        private void itemReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemReports itemReports = new ItemReports();
            itemReports.MdiParent = this;
            itemReports.Show();
        }

        private void orderReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderReports orderReports = new OrderReports();
            orderReports.MdiParent = this;
            orderReports.Show();
        }

        private void metroButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
