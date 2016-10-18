using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String con = ConfigurationManager.AppSettings["SQLSTRING"];
        SqlConnection connection = new SqlConnection(con);
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        string str = "select fare_code, amount, restrictions from fare where (flight_number = @flightnumber)";
        cmd = new SqlCommand(str, connection);
        cmd.Parameters.AddWithValue("@flightnumber", TextBox5.Text);


        da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        GridView3.DataSource = ds;
        GridView3.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}