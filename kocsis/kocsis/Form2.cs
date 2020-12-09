using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kocsis
{
    public partial class Autovalasztas : Form
    {
        kocsikEntities context = new kocsikEntities();

        public Autovalasztas()
        {
            InitializeComponent();
            context.cars.Load();
            Getkocsik();
        }

        private void Getkocsik()
        {
           dataGridView1.DataSource = (from x in context.cars
                                   where x.AutoNeve.StartsWith(textBox1.Text)
                                   select x).ToList();
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Getkocsik();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "csv";

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var s in context.cars)
                {
                    
                    sw.Write(s.AutoNeve);
                    sw.Write(";");
                    sw.Write(s.Kor.ToString());
                    sw.Write(";");
                    sw.Write(s.Üzemanyag);
                    sw.Write(";");
                    sw.Write(s.Fogyasztas.ToString());
                    sw.Write(";");
                    sw.WriteLine();
                }
            }
        }

       

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    listBox1.DataSource = (from x in context.cars
        //                                where x.AutoNeve.StartsWith(textBox2.Text)
        //                                select x).ToList();
        //    listBox1.DisplayMember = "AutoNeve";
        //    dataGridView1.DataSource =listBox1.SelectedIndex;
        //}
    }
}
