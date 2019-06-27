using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılan_Oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //this.Opacity = 0.0;
            label3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            Form1 frm = new Form1();
            frm.anaForm = this;

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                this.Hide();
                frm.Show();
            }
            else
            {
                label3.Text = "Lütfen Oyuncu İsmini Giriniz.";
            }
        }
    }
}
