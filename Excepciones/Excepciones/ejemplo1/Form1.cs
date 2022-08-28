using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a + b;
                lblResultado.Text = "= " + r;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor cargar solo números..");
            }           
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a - b;
                lblResultado.Text = "= " + r;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor cargar solo números..");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {                
                lblResultado.Text = "= " + calcular();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor cargar solo números..");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero (0)...");
            }
            catch (OverflowException ex){
                MessageBox.Show("El resultado es un número muy grande...");
            }
            finally
            {
                // se ejecuta si es que existen excepciones o no
                // operación sensible... por ejemplo interacción con base de datos.

            }
        }

        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a / b;
                return r;
            }
            catch (Exception ex)
            {
                // por ejemplo registro de error en un archivo
                throw ex; // lanzar la excepción
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(txtUno.Text);
                b = int.Parse(txtDos.Text);
                r = a * b;
                lblResultado.Text = "= " + r;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor cargar solo números..");
            }

        }
    }
}
