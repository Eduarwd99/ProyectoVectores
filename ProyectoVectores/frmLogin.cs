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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(login(this.txtUsuario.Text, this.txtClave.Text))
            {
                this.Visible = false;
                frmMenu frm1 = new frmMenu();
                frm1.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o clave invalidos...");
            }
        }
        private bool login(string usuario, string clave)
        {
            return (usuario == "Admin" && clave == "123");
        }
    }
}
