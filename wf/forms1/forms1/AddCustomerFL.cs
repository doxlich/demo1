using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace forms1
{
    public partial class AddCustomerFL : Form
    {
        public AddCustomerFL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new CustomersData.CustomerFLData()
            {
                Email = tBox_Email.Text,
                Name = tBox_Name.Text,
                Birthday = tBox_Birthday.Text,
                PasportSeries = tBox_Pass_series.Text,
                PasportNumber = tBox_Pass_number.Text,
                Phone = tBox_Phone.Text,
            };

            var dataJson = JsonConvert.SerializeObject(data);
            DbData.SaveFLUser(dataJson);
        }
    }
}
