using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo_Practico_G1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True");
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Provincias", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                ddlPciaInicio.DataSource = dr;
                ddlPciaInicio.DataTextField = "NombreProvincia";
                ddlPciaInicio.DataValueField = "IdProvincia";
                ddlPciaInicio.DataBind();
                cn.Close();
            }

        }

        protected void ddlLocalidadinicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consultasql = "select * from localidades where IdProvincia =" + ddlPciaInicio.SelectedValue;

            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True");
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Localidades", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                ddlLocalidadinicio.DataSource = dr;
                ddlLocalidadinicio.DataTextField = "NombreLocalidad";
                ddlLocalidadinicio.DataValueField = "IdLocalidad";
                ddlLocalidadinicio.DataBind();
                cn.Close();
            }

        }
    }
}