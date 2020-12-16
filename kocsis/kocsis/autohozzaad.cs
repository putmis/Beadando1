using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kocsis
{
    public partial class autohozzaad : Form
    {
        public autohozzaad()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile("hat.png");
            button1.BackColor = Color.FromArgb(252, 234, 109);
            button2.BackColor = Color.FromArgb(252, 234, 109);
        }

        private void Nev_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (String.IsNullOrEmpty(Nev.Text))
            {

                e.Cancel = false;

                Nev.BackColor = Color.White;
            }
            else
            {
                if (regex.IsMatch(Nev.Text))
                {
                    e.Cancel = false;
                  Nev.BackColor = Color.Green;
                }
                else
                {
                    e.Cancel = true;
                    Nev.BackColor = Color.Red;
                }
            }
        }

        private void Nev_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void anyag_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?!\s*$).+");

            if (String.IsNullOrEmpty(anyag.Text))
            {

                e.Cancel = false;

                anyag.BackColor = Color.White;
            }
            else
            {
                if (regex.IsMatch(Nev.Text))
                {
                    e.Cancel = false;
                    anyag.BackColor = Color.Green;
                }
                else
                {
                    e.Cancel = true;
                    anyag.BackColor = Color.Red;
                }
            }
        }

        private void fogyaszt_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\d+\.?\d*");
            if (String.IsNullOrEmpty(fogyaszt.Text))
            {

                e.Cancel = false;

               fogyaszt.BackColor = Color.White;
            }
            else
            {
                if (regex.IsMatch(fogyaszt.Text))
                {
                    e.Cancel = false;
                    fogyaszt.BackColor = Color.Green;
                }
                else
                {
                    e.Cancel = true;
                   fogyaszt.BackColor = Color.Red;
                }
            }
        }

        private void kor_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[0-50]");
            if (String.IsNullOrEmpty(kor.Text))
            {

                e.Cancel = false;

                kor.BackColor = Color.White;
            }
            else
            {
                if (regex.IsMatch(fogyaszt.Text))
                {
                    e.Cancel = false;
                  kor.BackColor = Color.Green;
                }
                else
                {
                    e.Cancel = true;
                   kor.BackColor = Color.Red;
                }
            }
        }

        private void anyag_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void fogyaszt_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void kor_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }
    }
}
