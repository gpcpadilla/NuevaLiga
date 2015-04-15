using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NuevaLiga.Data;
using NuevaLiga.Model;
using NuevaLiga.Web;

namespace NuevaLiga.Web
{
    public partial class IFicha : System.Web.UI.Page
    {
        protected void Page_Load(object agregado, EventArgs e)
        {

            Caracterizacion datos = new Caracterizacion(tbname.Text,
                tbalias.Text,
                tbplaneta.Text,
                tbgenero.Text,
                tbhabilidad.Text,
                tbdebilidad.Text,
               int.Parse(tbpeso.Text),
              int.Parse(tbtamaño.Text));

            PersonajesRepositorios pp = new PersonajesRepositorios();

            pp.AddCaraterizacion(datos);

            Server.Transfer("Recibir.aspx", true);


        }
    }
}