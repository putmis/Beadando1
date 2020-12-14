using kocsis.absztrakt;
using kocsis.enti;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Gyar = new kocsigyar();
            //BackColor = Color.FromArgb(13,239,1);
            button1.BackColor = Color.FromArgb(252,234,109);
            button2.BackColor = Color.FromArgb(252, 234, 109);
            button3.BackColor = Color.FromArgb(252, 234, 109);
            button4.BackColor = Color.FromArgb(252, 234, 109);
            button5.BackColor = Color.FromArgb(252, 234, 109);
            BackgroundImage = Image.FromFile("hatter.png");
            

        }
        private tutuk _kovitutuk;

        private List<tutuk> _tutu = new List<tutuk>();

        private tutukFactory _gyar;
        public tutukFactory Gyar
        {
            get { return _gyar; }
            set { _gyar = value;
                kovi();
            
            }
        }

        private void createtimer_Tick(object sender, EventArgs e)
        {
            var tutuk = Gyar.CreateNew();
            _tutu.Add(tutuk);
            tutuk.Left = -tutuk.Width;
            panel1.Controls.Add(tutuk);
        }

        private void conveyortimer_Tick(object sender, EventArgs e)
        {
            var maxHely = 0;
            foreach (var tutuk in _tutu)
            {
                tutuk.Movetutuk();
                if (tutuk.Left > maxHely)
                    maxHely = tutuk.Left;
            }
            if (maxHely > 850)
            {
                var regi = _tutu[0];
                panel1.Controls.Remove(regi);
                _tutu.Remove(regi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autovalasztas aut = new Autovalasztas();
            aut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           F3 aut = new F3();
            aut.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gyar = new fiatgyar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gyar = new kocsigyar();
        }
        private void kovi()
        {
            if (_kovitutuk != null)
                Controls.Remove(_kovitutuk);
            _kovitutuk = Gyar.CreateNew();
            _kovitutuk.Top = label1.Top + label1.Height + 20;
            _kovitutuk.Left = label1.Left;
            Controls.Add(_kovitutuk);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gyar = new suzukigyar();
        }
    }
}
