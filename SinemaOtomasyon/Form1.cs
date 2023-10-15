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

namespace SinemaOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        MySqlConnection baglanti = new MySqlConnection("user=root; password=dodo; port=3306; server=localhost; database=sinema");
        MySqlDataAdapter da;
        DataTable dt;
        Form2 f2;
        Form5 f5;
        public string yetki;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            da = new MySqlDataAdapter("Select * from kullanici where kullanici_kullanici='" + textBox1.Text + "' and kullanici_parola='" + textBox2.Text + "'", baglanti);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                
                yetki = dt.Rows[0]["kullanici_yetki"].ToString();
                if (yetki == "admin" || yetki == "müdür")
                {
                    f2 = new Form2();
                    f2.panel1.Visible = false;
                    f2.Show();
                }               
            }
            else
            {
                MessageBox.Show("Başaramadık");
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f5 = new Form5();
            f5.Show();
        }
    }
}
