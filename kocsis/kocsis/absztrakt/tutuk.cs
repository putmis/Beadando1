using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kocsis.absztrakt
{
    public abstract class tutuk : Label
    {
        public tutuk()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Tutuk_Paint;
        }

        private void Tutuk_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }





        protected abstract void DrawImage(Graphics g);

        public virtual void Movetutuk()
        {
            Left += 1;
        }

    }
}
