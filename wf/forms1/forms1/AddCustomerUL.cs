using Newtonsoft.Json;
using System.Windows.Forms;

namespace forms1
{
    public partial class AddCustomerUL : Form
    {
        public static bool FormOpened { get; set; }

        public AddCustomerUL()
        {
            InitializeComponent();
        }

        private void label1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void AddCustomer_Load(object sender, System.EventArgs e)
        {
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            CustomersData.CustomerULData data = new CustomersData.CustomerULData() 
            {
                Company = tBox_CompanyName.Text,
                Address = tBox_Address.Text,
                Inn = tBox_INN.Text,
                Rs = tBox_RS.Text,
                Bik = tBox_BIK.Text,
                NameLead = tBox_Name_Lead.Text,
                NameContact = tBox_Name_Contact.Text,
                PhoneContact = tBox_Phone_Contact.Text,
                Email = tBox_Email.Text,
            };

            var dataJson = JsonConvert.SerializeObject(data);
            DbData.SaveULUser(dataJson);
        }
    }
}
