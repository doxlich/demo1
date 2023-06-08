using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class uslugiOTK : Form
    {
        public uslugiOTK()
        {
            InitializeComponent();
        }

        private void uslugiOTK_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_MakeOrder_Click(object sender, EventArgs e)
        {
            var servicesData = new ServicesData()
            {
                NameServ = NameServ.Text,
                CostServ = CostServ.Text,
                CodeServ= CodeServ.Text,
                TimeCompleteServ = TimeComplete.Text,
            };

            DbData.SaveOrder(JsonConvert.SerializeObject(servicesData));
        }
    }
}
