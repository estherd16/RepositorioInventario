using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;
using capaEntidades;

namespace capaPresentacionWeb
{
    public partial class Contacto : System.Web.UI.Page
    {
        Comentarios CE = new Comentarios();
        logicaNegocioComentarios CN = new logicaNegocioComentarios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btcontacto_Click(object sender, EventArgs e)
        {
            try
            {
                CE.nombres = txtnombres.Value;
                CE.correo = txtcorreo.Value;
                CE.telefono = txttelefono.Value;
                CE.mensaje = txtmensaje.Value;

                if (CN.insertarComentarios(CE)==1)
                {
                    indicador.Text = "Enviado!!";
                    indicador.CssClass = "label label-success";

                    txtnombres.Value = "";
                    txtcorreo.Value = "";
                    txtmensaje.Value = "";
                    txttelefono.Value = "";
                }

                else
                {
                    indicador.Text = "Error al enviar";
                    indicador.CssClass = "label label-danger";
                }
            }
            catch (Exception ex)
            {
                indicador.Text = ex.Message.ToString();
               
            }
        }
    }
}