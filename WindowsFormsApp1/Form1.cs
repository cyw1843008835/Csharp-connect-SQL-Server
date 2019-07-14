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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EXIT_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGIN_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server =DESKTOP-DBENKHM;database=mydatabase1;uid=sa;pwd=dhc3b@dhc");
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from login where username='" + USERNAME_textBox1.Text + "' and password='" + PASSWORD_textBox2.Text + "'",con);
            DataTable da = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(da);
            if (da.Rows[0][0].ToString() == "1") 
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("the username or password is wrong");
            }

        }
    }
}
