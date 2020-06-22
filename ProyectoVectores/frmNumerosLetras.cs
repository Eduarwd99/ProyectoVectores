using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{
    public partial class frmNumerosLetras : Form
    {
        public frmNumerosLetras()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(this.txtNumero.Text, out int num))
                {
                    this.txtResultado.Text = NumLetras.getLetras(num);
                    this.txtNumNLetras.Text = this.txtNumero.Text;
                    this.txtNumero.Text = "";
                }
                else
                {
                    MessageBox.Show("Los digitos ingresados no son validos...");
                    this.txtNumero.Focus();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
