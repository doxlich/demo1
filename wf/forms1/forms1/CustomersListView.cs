using Newtonsoft.Json;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace forms1
{
    public partial class CustomersListView : Form
    {
        public CustomersListView()
        {
            InitializeComponent();
        }

        private void CustomersListView_Load(object sender, EventArgs e)
        {
            var usersUlStrings = DbData.ReadUsersUL();
            var usersUlData = usersUlStrings.Select(x => 
                JsonConvert.DeserializeObject<CustomersData.CustomerULData>(x)).ToList();

            dataGridViewUL.DataSource = usersUlData;

            var usersFlStrings = DbData.ReadUsersFL();
            var usersFlData = usersFlStrings.Select(x =>
                JsonConvert.DeserializeObject<CustomersData.CustomerFLData>(x)).ToList();

            dataGridViewFl.DataSource = usersFlData;
        }
    }
}
