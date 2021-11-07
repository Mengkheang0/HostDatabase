using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class CopyDataTable : Form
    {
        public CopyDataTable()
        {
            InitializeComponent();

        }

        private void openFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();

            if (fd.FileName.Length > 0)
            {
                folderPath.Text= fd.FileName;
                RootPath.Text = System.IO.Path.GetDirectoryName( fd.FileName);
                listDatabase.Items.Add(System.IO.Path.GetFileName( fd.FileName));
            }
        }

        private void listDatabase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rc_Menu.Show(listDatabase, e.Location);
            }
        }

        void GetTable()
        {
          
        }
    }
}
