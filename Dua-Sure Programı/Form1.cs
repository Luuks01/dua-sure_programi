using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dua_Sure_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 goster = new Form2();
            goster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 goster = new Form3();
            goster.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 goster = new Form4();
            goster.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 goster = new Form5();
            goster.Show();
        }
    }
}
