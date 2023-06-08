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
    public partial class Oders : Form
    {
        public Oders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Oders = DbData.ReadOders();
            var odersData = Oders.Select(x =>
                JsonConvert.DeserializeObject<OrderData>(x)).ToList();

            dataGridView1.DataSource = odersData;
        }

        private void Oders_Load(object sender, EventArgs e)
        {
            var Oders = DbData.ReadOders();
            var odersData = Oders.Select(x =>
                JsonConvert.DeserializeObject<OrderData>(x)).ToList();

            dataGridView1.DataSource = odersData;
        }
    }
}
