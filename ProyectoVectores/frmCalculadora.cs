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
    //Tipo de dato enumerado
    public enum TipoTecla
    {
        NINGUNO = 0,
        DIGITO = 1,
        OPERADOR = 2,
        AC = 3
    }

    public partial class frmCalculadora : Form
    {
        private TipoTecla mUltimaPulsacion; //Atributos de la clase
        private int mOperando1;
        private int mOperando2;
        private int mNumOperandos; //Validar el numero del operando actual
        private string mOperador, auxOperador; // + - X /

        public frmCalculadora()
        {
            InitializeComponent();
        }
        
        bool validaDigito (string teclapulsada)
        {
            if (teclapulsada.Equals("0")) return true;
            if (teclapulsada.Equals("1")) return true;
            if (teclapulsada.Equals("2")) return true;
            if (teclapulsada.Equals("3")) return true;
            if (teclapulsada.Equals("4")) return true;
            if (teclapulsada.Equals("5")) return true;
            if (teclapulsada.Equals("6")) return true;
            if (teclapulsada.Equals("7")) return true;
            if (teclapulsada.Equals("8")) return true;
            if (teclapulsada.Equals("9")) return true;
            return false;
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            this.mUltimaPulsacion = TipoTecla.NINGUNO;
            this.mOperando1 = 0;
            this.mOperando2 = 0;
            this.mNumOperandos = 0;

            btn1.Click += new EventHandler(button1_Click);
            btn2.Click += new EventHandler(button1_Click);
            btn3.Click += new EventHandler(button1_Click);
            btn5.Click += new EventHandler(button1_Click);
            btn4.Click += new EventHandler(button1_Click);
            btn7.Click += new EventHandler(button1_Click);
            btn6.Click += new EventHandler(button1_Click);
            btn8.Click += new EventHandler(button1_Click);
            btn9.Click += new EventHandler(button1_Click);

            btnSuma.Click += new EventHandler(button1_Click);
            btnResta.Click += new EventHandler(button1_Click);
            btnMultiplicacion.Click += new EventHandler(button1_Click);
            btnDivision.Click += new EventHandler(button1_Click);
            btnIgual.Click += new EventHandler(button1_Click);
            btnLimpiar.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string strnum = btn.Text;

            if (this.mUltimaPulsacion != TipoTecla.DIGITO)
                this.txtPantalla.Text = "";

            if (validaDigito(strnum))
            {
                this.txtPantalla.Text += strnum; //método abreviado
                this.mUltimaPulsacion = TipoTecla.DIGITO;
            }
            else if (strnum == "AC")
            {
                this.txtPantalla.Text = "";
                this.mUltimaPulsacion = TipoTecla.AC;
                this.mOperando1 = 0;
                this.mOperando2 = 0;
                this.mNumOperandos = 0;
            }
            else if (strnum == "+" || strnum == "-" || strnum == "X" || strnum == "/" || strnum == "=")
            {
                if (this.mUltimaPulsacion == TipoTecla.DIGITO)
                    this.mNumOperandos++;
                
                if (this.mNumOperandos == 1 /*&& this.mUltimaPulsacion != TipoTecla.OPERADOR*/)
                {
                    this.mOperando1 = Int32.Parse(this.txtPantalla.Text);
                    this.txtPantalla.Text = "";
                    auxOperador = strnum;
                }
                else if (this.mNumOperandos == 2 /*&& this.mUltimaPulsacion != TipoTecla.OPERADOR*/)
                {
                    this.mOperando2 = Int32.Parse(this.txtPantalla.Text);
                    switch (this.mOperador)
                    {
                        case "+":
                            this.mOperando1 += this.mOperando2;
                        break;

                        case "-":
                            this.mOperando1 -= this.mOperando2;
                        break;

                        case "X":
                            this.mOperando1 *= this.mOperando2;
                        break;

                        case "/":
                            this.mOperando1 /= this.mOperando2;
                        break;

                        case "=":
                            if(auxOperador == "+")
                                this.mOperando1 += this.mOperando2;
                            else if(auxOperador == "-")
                                this.mOperando1 -= this.mOperando2;
                            else if (auxOperador == "X")
                                this.mOperando1 *= this.mOperando2;
                            else if (auxOperador == "/")
                                this.mOperando1 /= this.mOperando2;
                            /*else if (auxOperador == "=")
                                this.mOperando1 = this.mOperando2;*/
                            break;
                    }
                    this.txtPantalla.Text = this.mOperando1.ToString();
                    this.mNumOperandos = 1;
                }
                this.mUltimaPulsacion = TipoTecla.OPERADOR;
                this.mOperador = strnum;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // cast (forzar o probar como un tipo especifico) ejpm: (int), (double), (Button)
            /*Button btn = (Button)sender;
            string strnum = btn.Text;
            this.txtPantalla.Text += strnum;
            if (this.mUltimaPulsacion != TipoTecla.DIGITO)
                this.Text = "";
            if (validaDigito(strnum))
            {
                this.txtPantalla.Text += strnum;
                this.mUltimaPulsacion = TipoTecla.DIGITO;
            }
            else if((strnum == "+") || (strnum == "-"))
            {
                if (this.mUltimaPulsacion == TipoTecla.DIGITO)
                    this.mNumOperandos++;
                if(this.mNumOperandos == 1)
                {
                    this.mOperando1 = Int32.Parse(this.txtPantalla.Text);
                    this.txtPantalla.Text = "";
                }
                else if (this.mNumOperandos == 2)
                {
                    this.mOperando2 = Int32.Parse(this.txtPantalla.Text);
                    switch(this.mOperador)
                    {
                        case "+":
                            this.mOperando1 += this.mOperando2;
                            break;
                        case "-":
                            this.mOperando1 += this.mOperando2;
                            break;
                    }
                    this.txtPantalla.Text = this.mOperando1.ToString();
                    this.mNumOperandos = 1;
                }
                this.mUltimaPulsacion = TipoTecla.OPERADOR;
                this.mOperador = strnum;
            }*/
            //detectar que botón se pulsó
            // cast -- casting -- casteo
        }
    }
}
