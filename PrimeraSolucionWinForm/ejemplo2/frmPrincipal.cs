﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta, termine de trabajar allí...");
                    return;
                }
            }          
            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
            // ventana.Show(); // para mostrar la ventana, debo usarlo si es que tengo una ventana padre contenedor
        }

        private void tbsPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog(); // para mostrar la ventana, pero hasta no cerrarse, no permite regresar a la ventana que lo invocó.
        }
    }
}
