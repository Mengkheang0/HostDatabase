using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            update();
            Image();
        }
        void update()
        {
            listBox1.DataSource = myDataAccess.GetPeople();
            listBox1.DisplayMember = "Path";
            label3.Text = String.Format("Itemcount : {0}", listBox1.Items.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();

            if(fd.SelectedPath != null)
            {
                var listFiles = System.IO.Directory.GetFiles(fd.SelectedPath);

                foreach(var file in listFiles)
                {
                    myDataAccess.AddPeople(new PersonModel() { Name = System.IO.Path.GetFileName(file),Path =file });
                }
                update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            myDataAccess.AddPeople(new PersonModel() { Name = textBox2.Text, Path = textBox1.Text });
            listBox1.DataSource = myDataAccess.GetPeople();
            listBox1.DisplayMember = "Path";
            label3.Text = String.Format("Itemcount : {0}", listBox1.Items.Count);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != null)
            {
                listBox1.DataSource = myDataAccess.FilterPeople(new PersonModel() { Name =textBox3.Text});
                listBox1.DisplayMember = "Path";
                label3.Text = String.Format("Itemcount : {0}", listBox1.Items.Count);
                 label3.Text = String.Format("Itemcount : {0}", listBox1.Items.Count);
            }
        }
        
         void Image()
        {
            PictureBox pc = new PictureBox();
            pc.Size = new Size(48, 431);
            pc.ImageLocation = "https://i.gifer.com/Wo8a.gif";
            pc.Location = new Point(48, 431);
            this.Controls.Add(pc);

        }
    }
}


/* using(MySqlConnection con = new MySqlConnection("server=sql6.freesqldatabase.com;user=sql6449059,database=sql6449059; port=3306;password=gksVCnnWTG"))
           {
               MySqlCommand cmd = new MySqlCommand("select * from dbo.Person", con);

               con.Open();
               *//*MySqlDataReader reader = cmd.ExecuteReader();

               while (reader.Read())
               {
                   Console.WriteLine("hi");
               }*//*
           }*/
