using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using ProyectoVectores.clases;

namespace ProyectoVectores
{
    public partial class Form1 : Form
    {
        //List<int> listavector = new List<int>();

        const int MAX = 100;
        private int[] vector = new int[MAX];
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(int.TryParse(this.txtNumero.Text, out int num))
                {
                    if(contador < MAX)
                    {
                        this.lstOrdenado.Items.Add(num);
                        //lstOrdenado.DataSource = null;
                        //lstOrdenado.DataSource = listavector;
                        vector[contador] = num;
                        contador ++;                        
                    }
                    this.txtNumero.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor ingrese solo valores numericos");
                }

            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] x = clases.Ordenacion.ordenaSeleccion(vector, contador);

            this.lstOrdenado.Items.Clear();
            for(int i=0; i<contador; i++)
            {
                this.lstOrdenado.Items.Add(x[i]);
            }
            //lstOrdenado.DataSource = null;
            //lstOrdenado.DataSource = x;
        }
    }
}
