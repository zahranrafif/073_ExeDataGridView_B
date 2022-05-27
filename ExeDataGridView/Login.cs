using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeDataGridView
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        //User Admin, Password Admin
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=DESKTOP-8VLH0CG;Initial Catalog=LoginDB;Integrated Security=True ");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login where NamaUser = '" + textBox1.Text + "' and password = '" + textBox2.Text+ "'",koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Fmenu menu = new Fmenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Mungkin Ada Yang Salah!","Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Exit
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
