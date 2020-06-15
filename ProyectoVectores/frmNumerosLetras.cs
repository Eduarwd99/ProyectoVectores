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
                    this.txtNumero.Text = "";
                }
            }
        }
    }
}
