using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculador
{
    public partial class frmVolumenes : Form
    {
        public frmVolumenes()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            cVolumenes obj3 = new cVolumenes();
            double r,h;
            r = double.Parse(textBoxVCR1.Text);
            h = double.Parse(textBoxVCA1.Text);
            textBoxVCono.Text = "Volúmen: " + Convert.ToString(obj3.vcono(r,h));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cVolumenes obj3 = new cVolumenes();
            double h, r;
            h = double.Parse(textBoxVCA2.Text);
            r = double.Parse(textBoxVCR2.Text);
            textBoxVCilindro.Text = "Volúmen: " + Convert.ToString(obj3.vcilindro(r, h));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cVolumenes obj3 = new cVolumenes();
            double r;
            r = double.Parse(textBoxVER.Text);
            textBoxVEsfera.Text = "Volúmen: " + Convert.ToString(obj3.vesfera(r));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
