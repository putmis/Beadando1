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

            double km = Convert.ToDouble(textBox2.Text);
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
