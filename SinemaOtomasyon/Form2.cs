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
using System.IO;

namespace SinemaOtomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("user=root; password=dodo; port=3306; server=localhost; database=sinema");
        MySqlDataAdapter da;
        MySqlCommand cmd;
        Form1 f1;
        DataSet ds;

        private void Form2_Load(object sender, EventArgs e)
        {
            veri_goruntule();
        }
        public void veri_goruntule()
        {
            da = new MySqlDataAdapter("Select * from film", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "film");
            dataGridView1.DataSource = ds.Tables["film"];
            baglanti.Close();
        }

        public void veri_goruntule2()
        {
            da = new MySqlDataAdapter("Select * from kullanici", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "kullanici");
            dataGridView1.DataSource = ds.Tables["kullanici"];
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            this.Close();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "update film set film_ad='"+textBox1.Text+"', film_yonetmen='"+textBox2.Text+"', film_vizyon='"+textBox3.Text+"',film_sure='"+textBox4.Text+"',film_format='"+comboBox1.Text+"',film_tur='"+comboBox3.Text+"',film_yas='"+comboBox2.Text+"' where film_id="+textBox10.Text+";";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Film güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başaramadık");
            }
            baglanti.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO film(film_ad, film_yonetmen, film_vizyon, film_sure, film_format, film_tur, film_yas) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + comboBox1.Text + "', '" + comboBox3.Text + "', '" + comboBox2.Text + "'); ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Film eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başaramadık");
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("delete from film where film_id="+ textBox10.Text+ ";", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
            foreach (Control item in Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            veri_goruntule();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            veri_goruntule2();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "update kullanici set kullanici_ad='" + textBox6.Text + "', kullanici_soyad='" + textBox7.Text + "', kullanici_kullanici='" + textBox8.Text + "',kullanici_parola='" + textBox9.Text + "',kullanici_yetki='" + comboBox5.Text + "' where kullanici_id=" + textBox11.Text + ";";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanici güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başaramadık");
            }
            baglanti.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("select * from kullanici where kullanici_id like '" + textBox11.Text + "'", baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                textBox6.Text = reader["kullanici_ad"].ToString();
                textBox7.Text = reader["kullanici_soyad"].ToString();
                textBox8.Text = reader["kullanici_kullanici"].ToString();
                textBox9.Text = reader["kullanici_parola"].ToString();
                comboBox5.Text = reader["kullanici_yetki"].ToString();

            }
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            baglanti.Open();
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO kullanici(kullanici_ad, kullanici_soyad, kullanici_yetki, kullanici_kullanici, kullanici_parola) VALUES ('" + textBox6.Text + "', '" + textBox7.Text + "', '" + comboBox5.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "'); ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanici eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Başaramadık");
            }
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("delete from kullanici where kullanici_id=" + textBox11.Text + ";", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
            foreach (Control item in Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }
        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("select * from film where film_id like '" + textBox10.Text + "'", baglanti);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                textBox1.Text = reader["film_ad"].ToString();
                textBox2.Text = reader["film_yonetmen"].ToString();
                textBox3.Text = reader["film_vizyon"].ToString();
                textBox4.Text = reader["film_sure"].ToString();
                comboBox1.Text = reader["film_format"].ToString();
                comboBox3.Text = reader["film_tur"].ToString();
                comboBox2.Text = reader["film_yas"].ToString();

            }
            baglanti.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            uyg.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                myRange.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    myRange.Value2 = dataGridView1[i, j].Value;
                }
            }
        }
    }
}
