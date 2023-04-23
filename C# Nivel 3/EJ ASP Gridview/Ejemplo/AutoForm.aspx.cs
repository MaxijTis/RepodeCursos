using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Ejemplo
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Blanco");
                ddlColores.Items.Add("Rojo");
            }

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Auto> temporal = (List<Auto>)Session["listaAutos"];
                Auto seleccionado = temporal.Find(x => x.Id == id);
                txtModelo.Text = seleccionado.Modelo;
                txtId.Text = seleccionado.Id.ToString();
                txtId.ReadOnly = true;
                txtDescripcion.Text = seleccionado.Descripcion;
                ddlColores.SelectedValue = seleccionado.Color;
                txtFecha.Text = seleccionado.Fecha.ToString("yyyy-MM-dd"); 
                chkUsado.Checked = seleccionado.Usado;

                if (seleccionado.Importado == true)
                    rdbImportado.Checked = true;
                else if (seleccionado.Importado == false)
                    rdbNacional.Checked = true;
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto a = new Auto();
            a.Id = int.Parse(txtId.Text);
            a.Modelo = txtModelo.Text;
            a.Descripcion = txtDescripcion.Text;
            a.Color = ddlColores.SelectedValue;
            a.Fecha = DateTime.Parse(txtFecha.Text);
            a.Usado = chkUsado.Checked;

            if (rdbImportado.Checked)
                a.Importado = true;
            else if (rdbNacional.Checked)
                a.Importado = false;

            //((List<Auto>)Session["listaAutos"]).Add(a); //forma corta

            List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            temporal.Add(a);
            //Forma Larga!!
            Response.Redirect("Formulario.aspx");
        }
        protected void rdbImportado_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}