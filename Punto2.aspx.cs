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
    public partial class Punto2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ListItem item1 = new ListItem();
                item1.Text = "Igual a";
                item1.Value = "=";
                ListItem item2 = new ListItem();
                item2.Text = "Mayor a";
                item2.Value = ">";
                ListItem item3 = new ListItem();
                item3.Text = "Menor a";
                item3.Value = "<";
                ddlCategoria.Items.Add(item1);
                ddlCategoria.Items.Add(item2);
                ddlCategoria.Items.Add(item3);
                ddlProducto.Items.Add(item1);
                ddlProducto.Items.Add(item2);
                ddlProducto.Items.Add(item3);

                SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Productos ", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                grdProductos.DataSource = dr;
                grdProductos.DataBind();



                cn.Close();
            }

        }

        protected void ddlProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
            cn.Open();
            string a;
            string b;
            bool pasa = true;
            a = ddlProducto.SelectedValue;
            b = ddlCategoria.SelectedValue;



            if (a != "--Seleccione--" && b != "--Seleccione--")
            {
                if (txtProducto.Text != "" && txtCategoria.Text != "")
                {
                    pasa = false;
                    SqlCommand cmd = new SqlCommand("Select * from Productos  where IdProducto  " + a + "'" + txtProducto.Text + " ' and IdCategoría" + b + "'" + txtCategoria.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    grdProductos.DataSource = dr;
                    grdProductos.DataBind();
                }
            }

            if (a != "--Seleccione-- ")
            {

                if (txtProducto.Text != "")
                {
                    if (pasa == true)
                    {
                        SqlCommand cmd = new SqlCommand("Select * from Productos  where IdProducto   " + a + "'" + txtProducto.Text + " ' ", cn);

                        SqlDataReader dr = cmd.ExecuteReader();
                        grdProductos.DataSource = dr;
                        grdProductos.DataBind();
                    }
                }
            }

            if (b != " --Seleccione--")
            {
                if (txtCategoria.Text != "")
                {
                    if (pasa == true)
                    {

                        //  cn.Open();
                        SqlCommand cmd = new SqlCommand("Select * from Productos  where IdCategoría   " + b + "'" + txtCategoria.Text + " ' ", cn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        grdProductos.DataSource = dr;
                        grdProductos.DataBind();
                    }
                }
            }







            cn.Close();
        }

        protected void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnQuitarfiltro_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Productos  ", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            grdProductos.DataSource = dr;
            grdProductos.DataBind();



            cn.Close();
        }
    }

}