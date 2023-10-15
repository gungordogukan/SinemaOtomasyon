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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form1 f1;
        Form3 f3;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string filmAdi = label2.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string filmAdi = label9.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string filmAdi = label13.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string filmAdi = label17.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string filmAdi = label21.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string filmAdi = label41.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string filmAdi = label37.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string filmAdi = label33.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string filmAdi = label29.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string filmAdi = label25.Text;
            f3 = new Form3();
            f3.filmAdiGonder = filmAdi;
            f3.ShowDialog();
        }
    }
}
