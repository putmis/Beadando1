using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace kocsis.enti
{
  public  class kocsi : Label

    {
        public kocsi()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Kocsi_Paint;
        }

        private void Kocsi_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void  DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("car.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
        }
        public void MoveKocsi()
        {
            Left += 1;
        }

        
    }
}
