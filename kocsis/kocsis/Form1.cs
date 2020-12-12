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
            BackColor = Color.FromArgb(13,239,1);
            button1.BackColor = Color.FromArgb(252,252,252);
            button2.BackColor = Color.FromArgb(252,252,252);
            

        }

        private List<kocsi> _kocsik = new List<kocsi>();

        private kocsigyar _gyar;
        public kocsigyar Gyar
        {
            get { return _gyar; }
            set { _gyar = value; }
        }

        private void createtimer_Tick(object sender, EventArgs e)
        {
            var kocsi = Gyar.CreateNew();
            _kocsik.Add(kocsi);
            kocsi.Left = -kocsi.Width;
            panel1.Controls.Add(kocsi);
        }

        private void conveyortimer_Tick(object sender, EventArgs e)
        {
            var maxHely = 0;
            foreach (var tutu in _kocsik)
            {
                tutu.MoveKocsi();
                if (tutu.Left > maxHely)
                    maxHely = tutu.Left;
            }
            if (maxHely > 850)
            {
                var regi = _kocsik[0];
                panel1.Controls.Remove(regi);
                _kocsik.Remove(regi);
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
      
    }
}
