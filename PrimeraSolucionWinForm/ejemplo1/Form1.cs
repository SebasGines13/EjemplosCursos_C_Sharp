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
    public partial class Form1 : Form // partial es que se puede programar la clase en varios ficheros o distintas partes
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hola Mundo!");
            string texto = txtNombre.Text;
            lblSaludo.Text = "Hola " + texto;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           // MessageBox.Show("Chau hasta luego...");
        }
    }
}
