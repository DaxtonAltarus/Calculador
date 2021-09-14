using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculador
{
    public partial class frmLongitudes : Form
    {
        public frmLongitudes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cLongitudes obj = new cLongitudes();
            double valor_ingresado;
            valor_ingresado = double.Parse(txtvalor.Text);
            if (cmborigen.Text=="Metros" &&cmbdestino.Text=="Centímetros")
            {
                txtresultado.Text = Convert.ToString(obj.mts_cms(valor_ingresado));
            }
            else if (cmborigen.Text == "Metros" && cmbdestino.Text == "Milímetros")
            {
                txtresultado.Text = Convert.ToString(obj.mts_mili(valor_ingresado));
            }
            else if (cmborigen.Text == "Metros" && cmbdestino.Text == "Metros")
            {
                MessageBox.Show("No es necesario intentar convertir a una misma unidad");
            }
            else if (cmborigen.Text == "Centímetros" && cmbdestino.Text == "Metros")
            {
                txtresultado.Text = Convert.ToString(obj.cms_mts(valor_ingresado));
            }
            else if (cmborigen.Text == "Centímetros" && cmbdestino.Text == "Milímetros")
            {
                txtresultado.Text = Convert.ToString(obj.cms_mili(valor_ingresado));
            }
            else if (cmborigen.Text == "Centímetros" && cmbdestino.Text == "Centímetros")
            {
                MessageBox.Show("No es necesario intentar convertir a una misma unidad");
            }
            else if (cmborigen.Text == "Milímetros" && cmbdestino.Text == "Metros")
            {
                txtresultado.Text = Convert.ToString(obj.mili_mts(valor_ingresado));
            }
            else if (cmborigen.Text == "Milímetros" && cmbdestino.Text == "Centímetros")
            {
                txtresultado.Text = Convert.ToString(obj.mili_cms(valor_ingresado));
            }
            else if (cmborigen.Text == "Centímetros" && cmbdestino.Text == "Centímetros")
            {
                MessageBox.Show("No es necesario intentar convertir a una misma unidad");
            }
            else
            {
                MessageBox.Show("No es necesario convertir");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
