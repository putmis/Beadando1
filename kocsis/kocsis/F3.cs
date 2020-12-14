using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kocsis
{
    public partial class F3 :Form
    {
       
        public F3()
        {
            InitializeComponent();
            szam();
            BackgroundImage = Image.FromFile("kut.png");



        }

        private void szam()
        {

            //textBox2.Text = "hajrá";
            //textBox3.Text = textBox2.Text;


            int a = 100;

            double km = double.Parse(textBox2.Text);
            double fogy = double.Parse(textBox3.Text);
            double ar = double.Parse(textBox4.Text);
            int utas = Convert.ToInt32(textBox1.Text);

            textBox5.Text = (((km / a) * fogy*ar)/utas).ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            szam();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            szam();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            szam();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            szam();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            szam();
        }
    }
}
