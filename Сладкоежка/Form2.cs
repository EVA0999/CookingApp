using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сладкоежка
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            button1.BackgroundImageLayout = ImageLayout.Center;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9 ();
            form.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11 ();
            form.Show();
            this.Close();
        }
    }
}
