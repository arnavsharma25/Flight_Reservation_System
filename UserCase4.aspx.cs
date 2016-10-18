using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Default5 : System.Web.UI.Page
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

        string str = "SELECT s.CUSTOMER_NAME, s.CUSTOMER_PHONE, s.SEAT_NUMBER, f.DEPARTURE_AIRPORT_CODE, f.ARRIVAL_AIRPORT_CODE FROM SEAT_RESERVATION AS s INNER JOIN FLIGHT AS f ON s.FLIGHT_NUMBER = f.FLIGHT_NUMBER AND f.FLIGHT_NUMBER = @flightnumber1 AND s.DATE = @date1";
        cmd = new SqlCommand(str, connection);
        cmd.Parameters.AddWithValue("@flightnumber1", TextBox6.Text);
        cmd.Parameters.AddWithValue("@date1", TextBox7.Text);

        da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        GridView4.DataSource = ds;
        GridView4.DataBind();
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox7.Text = Calendar2.SelectedDate.ToString("MM-dd-yyyy");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        String con = ConfigurationManager.AppSettings["SQLSTRING"];
        SqlConnection connection = new SqlConnection(con);
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        string str = "SELECT a.FLIGHT_NUMBER, a.SEAT_NUMBER, CONVERT(VARCHAR(10),a.DATE,110) AS DATE, b.DEPARTURE_AIRPORT_CODE, b.ARRIVAL_AIRPORT_CODE FROM SEAT_RESERVATION AS a INNER JOIN FLIGHT AS b ON a.FLIGHT_NUMBER = b.FLIGHT_NUMBER AND a.CUSTOMER_NAME = @custname";
        cmd = new SqlCommand(str, connection);
        cmd.Parameters.AddWithValue("@custname", TextBox8.Text);


        da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        GridView5.DataSource = ds;
        GridView5.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}