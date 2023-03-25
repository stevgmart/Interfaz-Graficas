using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_De_Tienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtprod.Clear();
            txtprec.Clear();
            txtdesc.Clear();
            lbltot.Text = "C$";
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtprec.Text) > 0)
            {
                Double D, P, T ;
                P = Convert.ToDouble(txtprec.Text);
                D = Convert.ToDouble(txtdesc.Text);
     
                T = ((P - (P * (D / 100))) * 0.15) + (P - (P * (D / 100)));
                lbltot.Text = T + "C$";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Es Una Demostracion\nAun No Habilitamos Esta Seccion Del Sistema");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Es Una Demostracion\nAun No Habilitamos Esta Seccion Del Sistema");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Es Una Demostracion\nAun No Habilitamos Esta Seccion Del Sistema");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya Te Encuentras En Este Sitio");
        }

        private void txtprec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Puede Introducir Numeros ");
                e.Handled = true;
                return;
            }
        }

        private void txtdesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 ) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Puede Introducir Numeros ");
                e.Handled = true;
                return;
            }
        }
    }
}
