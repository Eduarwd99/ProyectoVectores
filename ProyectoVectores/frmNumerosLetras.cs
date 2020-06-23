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
                    this.txtNumNLetras.Text = " (" + this.txtNumero.Text + ") $";
                    this.txtNumero.Text = "";
                    this.lblFecha.Text = DateTime.Today.ToString("dd / MM / yyyy");
                    this.txtNombre.Focus();
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

        /*private void button2_Click(object sender, EventArgs e)
        {
            captureScreen();

            PdfDocument doc = new PdfDocument();

            PdfPage oPage = new PdfPage();

            doc.Pages.Add(oPage);
            oPage.Rotate = 90;
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"C://Rectangle.bmp");

            xgr.DrawImage(img, 0, 0);

            doc.Save("C://RectangleDocument.pdf");
            doc.Close();
        }

        private void captureScreen()
        {
            try
            {
                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }
                    bitmap.Save("C://Rectangle.bmp", ImageFormat.Bmp);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }*/

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.txtNombre.Text == "")
                {
                    
                }
                else
                {
                    this.btnImprimir.Focus();
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
