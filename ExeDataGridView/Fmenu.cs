using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridView
{
    public partial class Fmenu : Form
    {
        public Fmenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 gv = new Form1();
            gv.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            DataBinding dbinding = new DataBinding();
            dbinding.Show();
        }
    }
}
