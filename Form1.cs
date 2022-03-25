using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CurrencyManager cm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string con = "server=localhost; port=3306; database=userstatuschecker; user=root; password=";
            MySqlConnection c = new MySqlConnection(con);
            c.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from userinfo", c);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            cm = (CurrencyManager)BindingContext[dt];

            textBox2.DataBindings.Add("Text",dt,"Username");
            textBox5.DataBindings.Add("Text", dt, "Rank");
            textBox4.DataBindings.Add("Text", dt, "Status");
            
            c.Close();
            c.Dispose();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm.Position++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cm.Position--;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
