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
          



        }

        private void szam()
        {

            textBox2.Text = "hajrá";
            textBox3.Text = textBox2.Text;



            //double km =double.Parse(textBox2.Text);
            //double fogy = double.Parse(textBox3.Text);
            //double ar = double.Parse(textBox4.Text);

            //textBox5.Text = ((km / fogy) * ar).ToString();
            
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
    }
}
