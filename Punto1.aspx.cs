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
            string ruta_vijaes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            if (!IsPostBack)
            {
                SqlConnection coneccion_vijaes = new SqlConnection(ruta_vijaes);
                coneccion_vijaes.Open();

                SqlCommand cmd = new SqlCommand("Select * from provincias", coneccion_vijaes);
                SqlDataReader leer_datos = cmd.ExecuteReader();
                ddlPciaInicio.DataSource = leer_datos;
                ddlPciaInicio.DataTextField = "NombreProvincia";
                ddlPciaInicio.DataValueField = "IdProvincia";
                ddlPciaInicio.DataBind();
                coneccion_vijaes.Close();
            }

        }

        protected void ddlPciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack) { 
            string ruta_vijaes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";   //ruta de coneccion a la db viajes
            SqlConnection coneccion_viajes = new SqlConnection(ruta_vijaes);    //
            coneccion_viajes.Open();
            SqlCommand consulta_viajes = new SqlCommand("Select * from provincias where NombreProvincia NOT LIKE  '" + ddlPciaInicio.SelectedItem.Text + "'", coneccion_viajes);
            SqlDataReader leer_viajes = consulta_viajes.ExecuteReader();

            ddlPciaDestino.DataSource = leer_viajes;
            ddlPciaDestino.DataTextField = "NombreProvincia";
            ddlPciaDestino.DataValueField = "IdProvincia";
            ddlPciaDestino.DataBind();

            coneccion_viajes.Close();



            // aca voy a cargar las localidades
        
            SqlConnection coneccion_viajes1 = new SqlConnection(ruta_vijaes);    //
            coneccion_viajes1.Open();
            SqlCommand consulta_viajes1 = new SqlCommand("select * from localidades where IdProvincia =" + ddlPciaInicio.SelectedValue, coneccion_viajes1);
            SqlDataReader leer_viajes1 = consulta_viajes1.ExecuteReader();

            ddlLocalidadinicio.DataSource = leer_viajes1;
            ddlLocalidadinicio.DataTextField = "NombreLocalidad";
            ddlLocalidadinicio.DataValueField = "IdLocalidad";
            ddlLocalidadinicio.DataBind();

            coneccion_viajes1.Close();
            }
        }

        protected void ddlPciaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string ruta_vijaes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";   //ruta de coneccion a la db viajes
                SqlConnection coneccion_viajes = new SqlConnection(ruta_vijaes);    //
                coneccion_viajes.Open();
                
                SqlCommand consulta_viajes1 = new SqlCommand("select * from localidades where IdProvincia =" + ddlPciaDestino.SelectedValue, coneccion_viajes);
                SqlDataReader leer_viajes1 = consulta_viajes1.ExecuteReader();

                ddlLocalidaddestino.DataSource = leer_viajes1;
                ddlLocalidaddestino.DataTextField = "NombreLocalidad";
                ddlLocalidaddestino.DataValueField = "IdLocalidad";
                ddlLocalidaddestino.DataBind();

                coneccion_viajes.Close();
            }
        }
    }
}