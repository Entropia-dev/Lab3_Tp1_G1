using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Trabajo_Practico_G1
{
    public partial class Punto3a : System.Web.UI.Page
    {
        string rutaLibreria = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Libreria;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            string Tema = Request.QueryString["Tema"];
   

            string consultasql = " select * from libros  where idTema  =" + Tema ;
            if (!IsPostBack)
            {
                SqlConnection cnLibreria = new SqlConnection(rutaLibreria);
                SqlCommand cmd = new SqlCommand(consultasql, cnLibreria);
                cnLibreria.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                gvLibros.DataSource =dr;
                gvLibros.DataBind();
                cnLibreria.Close();
            }
        }
    }
}