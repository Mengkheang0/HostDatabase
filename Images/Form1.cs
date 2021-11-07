using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ListData = data.DataAccess.LoadImages();
            ListData.ForEach(x => Images(x.Url));
        }

        void Images(string url)
        {
            PictureBox pc = new PictureBox();
            pc.Size = new Size(199, 130);
            pc.SizeMode = PictureBoxSizeMode.AutoSize;
            pc.BorderStyle = BorderStyle.FixedSingle;
            pc.ImageLocation = url;
            pc.ErrorImage = Image.FromFile(@"D:\BG\kr.jpg");
            flowLayoutPanel1.Controls.Add(pc); 
        }
    }
}
