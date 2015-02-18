using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        int c;
        int d;
        int[] bir = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int[] iki = { 2, 3, 6, 7, 10, 11, 14, 15 };
        int[] uc = { 4, 5, 6, 7, 12, 13, 14, 15 };
        int[] dort = { 8, 9, 10, 11, 12, 13, 14, 15 };

        public Form1()
        {
            InitializeComponent();
            btnVar1.Visible = false;
            btnYok1.Visible = false;
            btnVar2.Visible = false;
            btnYok2.Visible = false;
            btnVar3.Visible = false;
            btnYok3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {


            label2.Text = "Tuttuğun Sayı Burada Var Mı? ";
            label3.Text = "1, 3, 5, 7, 9, 11, 13, 15";
            btnYok1.Visible = true;
            btnVar1.Visible = true;
    
        }

        private void btnVar1_Click(object sender, EventArgs e)
        {
            a = 1;
            label4.Text = "Tuttuğun Sayı Burada Var Mı? ";
            label5.Text = "2, 3, 6, 7, 10, 11, 14, 15";
            btnVar2.Visible = true;
            btnYok2.Visible = true;
        }

        private void btnYok1_Click(object sender, EventArgs e)
        {
            label4.Text = "Tuttuğun Sayı Burada Var Mı? ";
            label5.Text = "2, 3, 6, 7, 10, 11, 14, 15";
            btnVar2.Visible = true;
            btnYok2.Visible = true;
        }

        private void btnVar2_Click(object sender, EventArgs e)
        {
            b = 2;
            label8.Text = "Tuttuğun Sayı Burada Var Mı? ";
            label9.Text = "4, 5, 6, 7, 12, 13, 14, 15";
            btnVar3.Visible = true;
            btnYok3.Visible = true;
        }

        private void btnYok3_Click(object sender, EventArgs e)
        {
            label10.Text = "Tuttuğun Sayı Burada Var Mı? ";
            label11.Text = "8, 9, 10, 11, 12, 13, 14, 15";
          
        }

        private void btnYok2_Click(object sender, EventArgs e)
        {
            label8.Text = "Tuttuğun Sayı Burada Var Mı? ";
            label9.Text = "4, 5, 6, 7, 12, 13, 14, 15";
            btnVar3.Visible = true;
            btnYok3.Visible = true;
         
        }

        private void btnVar3_Click(object sender, EventArgs e)
        {
            c = 4;
            label10.Text = "Tuttuğun Sayı Burada Var Mı? ";
            label11.Text = "8, 9, 10, 11, 12, 13, 14, 15";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d = 8;
            label12.Text = "TUTTUĞUNUZ SAYI: " + (a + b + c + d).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = "TUTTUĞUNUZ SAYI: " + (a + b + c + d).ToString();

        }
    }
}
