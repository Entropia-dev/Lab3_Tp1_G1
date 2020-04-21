using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Trabajo_Practico_G1
{
    public partial class Punto3 : System.Web.UI.Page
    {
        string rutaLibreria = "Data Source=localhost\\SQLEXPRESS;Initial Catalog = Libreria; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {

            string consultasql = "select * from Temas";

            if (!IsPostBack)
            {
                SqlConnection cnLibreria = new SqlConnection(rutaLibreria);
                SqlCommand cmd = new SqlCommand(consultasql, cnLibreria);
                cnLibreria.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ddlTemas.DataSource = dr;
                ddlTemas.DataTextField = "tema";
                ddlTemas.DataValueField = "Idtema";
                ddlTemas.DataBind();
                cnLibreria.Close();
            }
        }

        protected void btnLibro_Click(object sender, EventArgs e)
        {
            Response.Redirect("Punto3a.aspx?Tema=" + ddlTemas.SelectedValue);
        }
    }

}