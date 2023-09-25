using Casatoro.BussinessLayer;
using Casatoro.Datalayer;
using Casatoro.Datalayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Casatoro.Entities;

namespace Casatoro.WebForms.Pages
{
    public partial class FormularioVendedor : System.Web.UI.Page
    {
        private static int IdVendedor = 0;
        VendedorBl vendedorBl = new VendedorBl();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Cargar codigo solo en la primera carga
                if (Request.QueryString["Id"] != null)
                {
                    IdVendedor = Convert.ToInt32(Request.QueryString["Id"].ToString());

                    if (IdVendedor != 0) {

                        btnSubmit.Text = "Actualizar";
                        Vendedores vendedor = vendedorBl.ObtenerVendedorPorId(IdVendedor);
                        txtNombreVendedor.Text = vendedor.NombreVendedor;
                        txtCedulaVendedor.Text = vendedor.CedulaVendedor;
                    }
                    else
                    {
                        btnSubmit.Text = "Crear";
                    }
                }
                else
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            var respuesta = new ResponseBase<Vendedores>();

            Vendedores vendedor = new Vendedores()
            {
                Id = IdVendedor,
                NombreVendedor = txtNombreVendedor.Text,
                CedulaVendedor = txtCedulaVendedor.Text
            };

            if (IdVendedor != 0)
            {
                respuesta = vendedorBl.EditarVendedor(vendedor);

                if (respuesta.IsValid)
                    Response.Redirect("~/Pages/ListaVendedores.aspx");
                else
                {
                    errorLabel.Text = respuesta.Message;
                }
            }
            else
            {
                var nombreNuevoVendedor = txtNombreVendedor.Text.ToString();
                var cedulaNuevoVendedor = txtCedulaVendedor.Text.ToString();

                respuesta = vendedorBl.CrearVendedor(nombreNuevoVendedor, cedulaNuevoVendedor);
                
                if (respuesta.IsValid)
                    Response.Redirect("~/Pages/ListaVendedores.aspx");
                else
                {
                    errorLabel.Text = respuesta.Message;
                }
            }
        }
    }
}