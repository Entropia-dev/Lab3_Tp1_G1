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
            if (!IsPostBack)
            {
                IniciarLlenadoDdl_Inicio();
                IniciarLlenadoDdl_Final();
            }

        }

        private void IniciarLlenadoDdl_Inicio()
        {
            ddlPciaInicio.DataSource = Consultar("SELECT * FROM Provincias");
            ddlPciaInicio.DataTextField = "NombreProvincia";
            ddlPciaInicio.DataValueField = "IdProvincia";
            ddlPciaInicio.DataBind();
            ddlPciaInicio.Items.Insert(0,new ListItem("[Seleccionar]","0"));
            ddlLocalidadinicio.Items.Insert(0,new ListItem("[Seleccionar]","0"));
        }
        private void IniciarLlenadoDdl_Final()
        {
            ddlPciaDestino.DataSource = Consultar("SELECT * FROM Provincias");
            ddlPciaDestino.DataTextField = "NombreProvincia";
            ddlPciaDestino.DataValueField = "IdProvincia";
            ddlPciaDestino.DataBind();
            ddlPciaDestino.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            ddlLocalidaddestino.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

            
        }

        protected void ProvinciaSeleccionada(object sender, EventArgs e)
        {
            int PciaId = Convert.ToInt32(ddlPciaInicio.SelectedValue);
            ddlLocalidadinicio.DataSource = Consultar("SELECT * FROM Localidades WHERE IdProvincia="+PciaId);
            ddlLocalidadinicio.DataTextField = "NombreLocalidad";
            ddlLocalidadinicio.DataValueField = "IdLocalidad";
            ddlLocalidadinicio.DataBind();
            ddlLocalidadinicio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void LocalidadSeleccionada(object sender, EventArgs e)
        {

        }
        public DataSet Consultar(string strSQL)
        {
            string strconn = @"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        protected void PciaDestino(object sender, EventArgs e)
        {
            int PciaId = Convert.ToInt32(ddlPciaDestino.SelectedValue);
            ddlLocalidaddestino.DataSource = Consultar("SELECT * FROM Localidades WHERE IdProvincia=" + PciaId);
            ddlLocalidaddestino.DataTextField = "NombreLocalidad";
            ddlLocalidaddestino.DataValueField = "IdLocalidad";
            ddlLocalidaddestino.DataBind();
            ddlLocalidaddestino.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void LocDestino(object sender, EventArgs e)
        {

        }
    }
}