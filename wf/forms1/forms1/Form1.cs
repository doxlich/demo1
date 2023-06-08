using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sosudNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
                && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void sosudNumber_MouseHover(object sender, EventArgs e)
        {
            var tooltipText = $"{DbData.LastOrderNumber + 1}";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(sosudNumber, tooltipText);
        }

        private void btn_MakeOder_Click(object sender, EventArgs e)
        {   
            var orderData = new OrderData()
            {   
                CreationDate = DateTime.Now,
                Name = tBox_FullName.Text,
                Service = cBox_Service.Text,
                Status = "Выполнено",
                ServiceTimespan = TimeSpan.FromHours(1),
                Price = 1_000 * cBox_Service.SelectedIndex + 1,
            };

            DbData.SaveOrder(JsonConvert.SerializeObject(orderData));
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerUL();
            addCustomerForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerFL();
            addCustomerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersListView();
            customersForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var customersForm = new uslugiOTK();
            customersForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var customersForm = new Oders();
            customersForm.Show();
        }

        private void cBox_Service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
