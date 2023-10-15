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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form5 f5;
        public string[] dizi=new string[42];
        public bool durum42 = true;
        public bool durum43 = true;
        public bool durum44 = true;
        public bool durum45 = true;
        public bool durum46 = true;
        public bool durum47 = true;
        public bool durum48 = true;
        public bool durum40 = true;
        public bool durum39 = true;
        public bool durum38 = true;
        public bool durum37 = true;
        public bool durum36 = true;
        public bool durum35 = true;
        public bool durum34 = true;
        public bool durum32 = true;
        public bool durum31 = true;
        public bool durum30 = true;
        public bool durum29 = true;
        public bool durum28 = true;
        public bool durum27 = true;
        public bool durum26 = true;
        public bool durum25 = true;
        public bool durum24 = true;
        public bool durum23 = true;
        public bool durum22 = true;
        public bool durum21 = true;
        public bool durum20 = true;
        public bool durum19 = true;
        public bool durum18 = true;
        public bool durum16 = true;
        public bool durum15 = true;
        public bool durum14 = true;
        public bool durum13 = true;
        public bool durum12 = true;
        public bool durum11 = true;
        public bool durum10 = true;
        public bool durum9 = true;
        public bool durum8 = true;
        public bool durum7 = true;
        public bool durum6 = true;
        public bool durum5 = true;
        public bool durum4 = true;
        public bool durum2 = true;
        public string koltuklar;
        public string film;
        int adet;
        int ucret;

        public string filmAdiGonder
        {

            get { return film; }
            set { film = value; }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            f5 = new Form5();
            this.Close();

        }

        private void button42_Click(object sender, EventArgs e)
        {

            if (durum42 == true)
            {
                this.button42.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum42 = false;
                koltuklar = label12.Text + " 42";
                label12.Text = koltuklar;
            }
            else if (durum42 == false)
            {
                this.button42.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum42 = true;
                koltuklar = koltuklar.Replace(" 42", "");
                label12.Text = koltuklar;
            }

        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (durum42 == false)
            {
                this.button42.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button42.Enabled = false;
            }
            if (durum2 == false)
            {
                this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button2.Enabled = false;
            }
            if (durum4 == false)
            {
                this.button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button4.Enabled = false;
            }
            if (durum5 == false)
            {
                this.button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button5.Enabled = false;
            }
            if (durum6 == false)
            {
                this.button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button6.Enabled = false;
            }
            if (durum7 == false)
            {
                this.button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button7.Enabled = false;
            }
            if (durum8 == false)
            {
                this.button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button8.Enabled = false;
            }
            if (durum9 == false)
            {
                this.button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button9.Enabled = false;
            }
            if (durum10 == false)
            {
                this.button10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button10.Enabled = false;
            }
            if (durum11 == false)
            {
                this.button11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button11.Enabled = false;
            }
            if (durum12 == false)
            {
                this.button12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button12.Enabled = false;
            }
            if (durum13 == false)
            {
                this.button13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button13.Enabled = false;
            }
            if (durum14 == false)
            {
                this.button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button14.Enabled = false;
            }
            if (durum15 == false)
            {
                this.button15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button15.Enabled = false;
            }
            if (durum16 == false)
            {
                this.button16.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button16.Enabled = false;
            }
            if (durum18 == false)
            {
                this.button18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button18.Enabled = false;
            }
            if (durum19 == false)
            {
                this.button19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button19.Enabled = false;
            }
            if (durum20 == false)
            {
                this.button20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button20.Enabled = false;
            }
            if (durum21 == false)
            {
                this.button21.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button21.Enabled = false;
            }
            if (durum22 == false)
            {
                this.button22.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button22.Enabled = false;
            }
            if (durum23 == false)
            {
                this.button23.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button23.Enabled = false;
            }
            if (durum24 == false)
            {
                this.button24.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button24.Enabled = false;
            }
            if (durum26 == false)
            {
                this.button26.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button26.Enabled = false;
            }
            if (durum27 == false)
            {
                this.button27.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button27.Enabled = false;
            }
            if (durum28 == false)
            {
                this.button28.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button28.Enabled = false;
            }
            if (durum29 == false)
            {
                this.button29.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button29.Enabled = false;
            }
            if (durum30 == false)
            {
                this.button30.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button30.Enabled = false;
            }
            if (durum31 == false)
            {
                this.button31.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button31.Enabled = false;
            }
            if (durum32 == false)
            {
                this.button32.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button32.Enabled = false;
            }
            if (durum34 == false)
            {
                this.button34.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button34.Enabled = false;
            }
            if (durum35 == false)
            {
                this.button35.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button35.Enabled = false;
            }
            if (durum36 == false)
            {
                this.button36.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button36.Enabled = false;
            }
            if (durum37 == false)
            {
                this.button37.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button37.Enabled = false;
            }
            if (durum38 == false)
            {
                this.button38.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button38.Enabled = false;
            }
            if (durum39 == false)
            {
                this.button39.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button39.Enabled = false;
            }
            if (durum40 == false)
            {
                this.button40.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button40.Enabled = false;
            }
            if (durum48 == false)
            {
                this.button48.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button48.Enabled = false;
            }
            if (durum47 == false)
            {
                this.button47.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button47.Enabled = false;
            }
            if (durum46 == false)
            {
                this.button46.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button46.Enabled = false;
            }
            if (durum45 == false)
            {
                this.button45.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button45.Enabled = false;
            }
            if (durum44 == false)
            {
                this.button44.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button44.Enabled = false;
            }
            if (durum43 == false)
            {
                this.button43.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.kırmızı));
                this.button43.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adet = Convert.ToInt32(label16.Text);
            adet += 1;
            label16.Text = adet.ToString();

            ucret += Convert.ToInt32(label13.Text);
            label15.Text = ucret.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (durum43 == true)
            {
                this.button43.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum43 = false;
                koltuklar = label12.Text + " 41";
                label12.Text = koltuklar;
            }
            else if (durum43 == false)
            {
                this.button43.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum43 = true;
                koltuklar = koltuklar.Replace(" 41", "");
                label12.Text = koltuklar;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label18.Text = film;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            adet = Convert.ToInt32(label16.Text);
            adet -= 1;
            label16.Text = adet.ToString();

            ucret -= Convert.ToInt32(label13.Text);
            label15.Text = ucret.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            adet = Convert.ToInt32(label17.Text);
            adet += 1;
            label17.Text = adet.ToString();

            ucret += Convert.ToInt32(label14.Text);
            label15.Text = ucret.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            adet = Convert.ToInt32(label17.Text);
            adet -= 1;
            label17.Text = adet.ToString();

            ucret -= Convert.ToInt32(label14.Text);
            label15.Text = ucret.ToString();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (durum44 == true)
            {
                this.button44.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum44 = false;
                koltuklar = label12.Text + " 40";
                label12.Text = koltuklar;
            }
            else if (durum44 == false)
            {
                this.button44.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum44 = true;
                koltuklar = koltuklar.Replace(" 40", "");
                label12.Text = koltuklar;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (durum45 == true)
            {
                this.button45.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum45 = false;
                koltuklar = label12.Text + " 39";
                label12.Text = koltuklar;
            }
            else if (durum45 == false)
            {
                this.button45.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum45 = true;
                koltuklar = koltuklar.Replace(" 39", "");
                label12.Text = koltuklar;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (durum46 == true)
            {
                this.button46.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum46 = false;
                koltuklar = label12.Text + " 38";
                label12.Text = koltuklar;
            }
            else if (durum46 == false)
            {
                this.button46.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum46 = true;
                koltuklar = koltuklar.Replace(" 38", "");
                label12.Text = koltuklar;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (durum47 == true)
            {
                this.button47.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum47 = false;
                koltuklar = label12.Text + " 37";
                label12.Text = koltuklar;
            }
            else if (durum47 == false)
            {
                this.button47.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum47 = true;
                koltuklar = koltuklar.Replace(" 37", "");
                label12.Text = koltuklar;
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (durum48 == true)
            {
                this.button48.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum48 = false;
                koltuklar = label12.Text + " 36";
                label12.Text = koltuklar;
            }
            else if (durum48 == false)
            {
                this.button48.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum48 = true;
                koltuklar = koltuklar.Replace(" 36", "");
                label12.Text = koltuklar;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (durum34 == true)
            {
                this.button34.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum34 = false;
                koltuklar = label12.Text + " 35";
                label12.Text = koltuklar;
            }
            else if (durum34 == false)
            {
                this.button34.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum34 = true;
                koltuklar = koltuklar.Replace(" 35", "");
                label12.Text = koltuklar;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (durum35 == true)
            {
                this.button35.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum35 = false;
                koltuklar = label12.Text + " 34";
                label12.Text = koltuklar;
            }
            else if (durum35 == false)
            {
                this.button35.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum35 = true;
                koltuklar = koltuklar.Replace(" 34", "");
                label12.Text = koltuklar;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (durum36 == true)
            {
                this.button36.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum36 = false;
                koltuklar = label12.Text + " 33";
                label12.Text = koltuklar;
            }
            else if (durum36 == false)
            {
                this.button36.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum36 = true;
                koltuklar = koltuklar.Replace(" 33", "");
                label12.Text = koltuklar;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (durum37 == true)
            {
                this.button37.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum37 = false;
                koltuklar = label12.Text + " 32";
                label12.Text = koltuklar;
            }
            else if (durum37 == false)
            {
                this.button37.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum37 = true;
                koltuklar = koltuklar.Replace(" 32", "");
                label12.Text = koltuklar;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (durum38 == true)
            {
                this.button38.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum38 = false;
                koltuklar = label12.Text + " 31";
                label12.Text = koltuklar;
            }
            else if (durum38 == false)
            {
                this.button38.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum38 = true;
                koltuklar = koltuklar.Replace(" 31", "");
                label12.Text = koltuklar;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (durum39 == true)
            {
                this.button39.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum39 = false;
                koltuklar = label12.Text + " 30";
                label12.Text = koltuklar;
            }
            else if (durum39 == false)
            {
                this.button39.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum39 = true;
                koltuklar = koltuklar.Replace(" 30", "");
                label12.Text = koltuklar;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (durum40 == true)
            {
                this.button40.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum40 = false;
                koltuklar = label12.Text + " 29";
                label12.Text = koltuklar;
            }
            else if (durum40 == false)
            {
                this.button40.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum40 = true;
                koltuklar = koltuklar.Replace(" 29", "");
                label12.Text = koltuklar;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (durum26 == true)
            {
                this.button26.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum26 = false;
                koltuklar = label12.Text + " 28";
                label12.Text = koltuklar;
            }
            else if (durum26 == false)
            {
                this.button26.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum26 = true;
                koltuklar = koltuklar.Replace(" 28", "");
                label12.Text = koltuklar;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (durum27 == true)
            {
                this.button27.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum27 = false;
                koltuklar = label12.Text + " 27";
                label12.Text = koltuklar;
            }
            else if (durum27 == false)
            {
                this.button27.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum27 = true;
                koltuklar = koltuklar.Replace(" 27", "");
                label12.Text = koltuklar;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (durum28 == true)
            {
                this.button28.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum28 = false;
                koltuklar = label12.Text + " 26";
                label12.Text = koltuklar;
            }
            else if (durum28 == false)
            {
                this.button28.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum28 = true;
                koltuklar = koltuklar.Replace(" 26", "");
                label12.Text = koltuklar;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (durum29 == true)
            {
                this.button29.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum29 = false;
                koltuklar = label12.Text + " 25";
                label12.Text = koltuklar;
            }
            else if (durum29 == false)
            {
                this.button29.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum29 = true;
                koltuklar = koltuklar.Replace(" 25", "");
                label12.Text = koltuklar;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (durum30 == true)
            {
                this.button30.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum30 = false;
                koltuklar = label12.Text + " 24";
                label12.Text = koltuklar;
            }
            else if (durum30 == false)
            {
                this.button30.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum30 = true;
                koltuklar = koltuklar.Replace(" 24", "");
                label12.Text = koltuklar;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (durum31 == true)
            {
                this.button31.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum31 = false;
                koltuklar = label12.Text + " 23";
                label12.Text = koltuklar;
            }
            else if (durum31 == false)
            {
                this.button31.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum31 = true;
                koltuklar = koltuklar.Replace(" 23", "");
                label12.Text = koltuklar;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (durum32 == true)
            {
                this.button32.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum32 = false;
                koltuklar = label12.Text + " 22";
                label12.Text = koltuklar;
            }
            else if (durum32 == false)
            {
                this.button32.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum32 = true;
                koltuklar = koltuklar.Replace(" 22", "");
                label12.Text = koltuklar;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (durum18 == true)
            {
                this.button18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum18 = false;
                koltuklar = label12.Text + " 21";
                label12.Text = koltuklar;
            }
            else if (durum18 == false)
            {
                this.button18.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum18 = true;
                koltuklar = koltuklar.Replace(" 21", "");
                label12.Text = koltuklar;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (durum19 == true)
            {
                this.button19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum19 = false;
                koltuklar = label12.Text + " 20";
                label12.Text = koltuklar;
            }
            else if (durum19 == false)
            {
                this.button19.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum19 = true;
                koltuklar = koltuklar.Replace(" 20", "");
                label12.Text = koltuklar;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (durum20 == true)
            {
                this.button20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum20 = false;
                koltuklar = label12.Text + " 19";
                label12.Text = koltuklar;
            }
            else if (durum20 == false)
            {
                this.button20.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum20 = true;
                koltuklar = koltuklar.Replace(" 19", "");
                label12.Text = koltuklar;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (durum21 == true)
            {
                this.button21.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum21 = false;
                koltuklar = label12.Text + " 18";
                label12.Text = koltuklar;
            }
            else if (durum21 == false)
            {
                this.button21.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum21 = true;
                koltuklar = koltuklar.Replace(" 18", "");
                label12.Text = koltuklar;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (durum22 == true)
            {
                this.button22.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum22 = false;
                koltuklar = label12.Text + " 17";
                label12.Text = koltuklar;
            }
            else if (durum22 == false)
            {
                this.button22.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum22 = true;
                koltuklar = koltuklar.Replace(" 17", "");
                label12.Text = koltuklar;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (durum23 == true)
            {
                this.button23.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum23 = false;
                koltuklar = label12.Text + " 16";
                label12.Text = koltuklar;
            }
            else if (durum23 == false)
            {
                this.button23.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum23 = true;
                koltuklar = koltuklar.Replace(" 16", "");
                label12.Text = koltuklar;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (durum24 == true)
            {
                this.button24.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum24 = false;
                koltuklar = label12.Text + " 15";
                label12.Text = koltuklar;
            }
            else if (durum24 == false)
            {
                this.button24.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum24 = true;
                koltuklar = koltuklar.Replace(" 15", "");
                label12.Text = koltuklar;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (durum10 == true)
            {
                this.button10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum10 = false;
                koltuklar = label12.Text + " 14";
                label12.Text = koltuklar;
            }
            else if (durum10 == false)
            {
                this.button10.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum10 = true;
                koltuklar = koltuklar.Replace(" 14", "");
                label12.Text = koltuklar;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (durum11 == true)
            {
                this.button11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum11 = false;
                koltuklar = label12.Text + " 13";
                label12.Text = koltuklar;
            }
            else if (durum11 == false)
            {
                this.button11.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum11 = true;
                koltuklar = koltuklar.Replace(" 13", "");
                label12.Text = koltuklar;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (durum12 == true)
            {
                this.button12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum12 = false;
                koltuklar = label12.Text + " 12";
                label12.Text = koltuklar;
            }
            else if (durum12 == false)
            {
                this.button12.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum12 = true;
                koltuklar = koltuklar.Replace(" 12", "");
                label12.Text = koltuklar;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (durum13 == true)
            {
                this.button13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum13 = false;
                koltuklar = label12.Text + " 11";
                label12.Text = koltuklar;
            }
            else if (durum13 == false)
            {
                this.button13.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum13 = true;
                koltuklar = koltuklar.Replace(" 11", "");
                label12.Text = koltuklar;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (durum14 == true)
            {
                this.button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum14 = false;
                koltuklar = label12.Text + " 10";
                label12.Text = koltuklar;
            }
            else if (durum14 == false)
            {
                this.button14.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum14 = true;
                koltuklar = koltuklar.Replace(" 10", "");
                label12.Text = koltuklar;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (durum15 == true)
            {
                this.button15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum15 = false;
                koltuklar = label12.Text + " 9";
                label12.Text = koltuklar;
            }
            else if (durum15 == false)
            {
                this.button15.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum15 = true;
                koltuklar = koltuklar.Replace(" 9", "");
                label12.Text = koltuklar;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (durum16 == true)
            {
                this.button16.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum16 = false;
                koltuklar = label12.Text + " 8";
                label12.Text = koltuklar;
            }
            else if (durum16 == false)
            {
                this.button16.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum16 = true;
                koltuklar = koltuklar.Replace(" 8", "");
                label12.Text = koltuklar;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (durum9 == true)
            {
                this.button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum9 = false;
                koltuklar = label12.Text + " 7";
                label12.Text = koltuklar;
            }
            else if (durum9 == false)
            {
                this.button9.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum9 = true;
                koltuklar = koltuklar.Replace(" 7", "");
                label12.Text = koltuklar;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (durum8 == true)
            {
                this.button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum8 = false;
                koltuklar = label12.Text + " 6";
                label12.Text = koltuklar;
            }
            else if (durum8 == false)
            {
                this.button8.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum8 = true;
                koltuklar = koltuklar.Replace(" 6", "");
                label12.Text = koltuklar;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (durum7 == true)
            {
                this.button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum7 = false;
                koltuklar = label12.Text + " 5";
                label12.Text = koltuklar;
            }
            else if (durum7 == false)
            {
                this.button7.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum7 = true;
                koltuklar = koltuklar.Replace(" 5", "");
                label12.Text = koltuklar;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (durum6 == true)
            {
                this.button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum6 = false;
                koltuklar = label12.Text + " 4";
                label12.Text = koltuklar;
            }
            else if (durum6 == false)
            {
                this.button6.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum6 = true;
                koltuklar = koltuklar.Replace(" 4", "");
                label12.Text = koltuklar;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (durum5 == true)
            {
                this.button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum5 = false;
                koltuklar = label12.Text + " 3";
                label12.Text = koltuklar;
            }
            else if (durum5 == false)
            {
                this.button5.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum5 = true;
                koltuklar = koltuklar.Replace(" 3", "");
                label12.Text = koltuklar;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (durum4 == true)
            {
                this.button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum4 = false;
                koltuklar = label12.Text + " 2";
                label12.Text = koltuklar;
            }
            else if (durum4 == false)
            {
                this.button4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum4 = true;
                koltuklar = koltuklar.Replace(" 2", "");
                label12.Text = koltuklar;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (durum2 == true)
            {
                this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.yesil));
                durum2 = false;
                koltuklar = label12.Text + " 1";
                label12.Text = koltuklar;
            }
            else if (durum2 == false)
            {
                this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.gri));
                durum2 = true;
                koltuklar = koltuklar.Replace(" 1", "");
                label12.Text = koltuklar;
            }
        }
    }
}
