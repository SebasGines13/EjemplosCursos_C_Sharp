using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblSaludo.Text = "Hola " + nombre;
            Response.Redirect("ejemploASPX.aspx", false); // esta acción no se recomienda del todo, ya que carga más el servidor. Ya que lanza un event End. Además tira excepciones, las cuales se pueden capturar. Para eso se pone como parámetro false, para que no cancele el hilo de ejecución.
        }
    }
}