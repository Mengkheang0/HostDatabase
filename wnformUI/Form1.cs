using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wnformUI
{
    public partial class Form1 : Form
    {
        DataAccess.PeronDataAccess dataAccess = new DataAccess.PeronDataAccess();
        public Form1()
        {
            InitializeComponent();
            UpdateData();
        }
        void UpdateData()
        {
            listBox1.DataSource = dataAccess.GetData();
            listBox1.DisplayMember = "FullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataAccess.AddData(new Models.PersonModel() { Id = dataAccess.GetData().Max(x=>x.Id) +1,FirstName = textBox1.Text,LastName = textBox2.Text});
            UpdateData();

        }
    }
}
