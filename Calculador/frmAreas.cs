using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculador
{
    public partial class frmAreas : Form
    {
        public frmAreas()
        {
            InitializeComponent();
        }

        private void buttonAreaCirculo_Click(object sender, EventArgs e)
        {
            cAreas obj2 = new cAreas();
            double r;
            r = double.Parse(textBoxACR1.Text);
            textBoxACirculo.Text = "Área: " + Convert.ToString(obj2.acirculo(r));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cAreas obj2 = new cAreas();
            double b, a;
            b = double.Parse(textBoxARB.Text);
            a = double.Parse(textBoxARA.Text);
            textBoxARectangulo.Text = "Área: " + Convert.ToString(obj2.arectangulo(b, a));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cAreas obj2 = new cAreas();
            double b, a;
            b = double.Parse(textBoxATB.Text);
            a = double.Parse(textBoxATA.Text);
            textBoxATriangulo.Text = "Área: " + Convert.ToString(obj2.atriangulo(b, a));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
