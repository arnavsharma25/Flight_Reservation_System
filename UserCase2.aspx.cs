using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


public partial class Default3 : System.Web.UI.Page
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

        //string str = "SELECT f.DEPARTURE_AIRPORT_CODE, f.SCHEDULED_DEPARTURE_TIME, f.ARRIVAL_AIRPORT_CODE, f.SCHEDULED_ARRIVAL_TIME, i.NUMBER_OF_AVAILABLE_SEATS FROM FLIGHT_INSTANCE AS i INNER JOIN FLIGHT AS f ON f.FLIGHT_NUMBER = i.FLIGHT_NUMBER WHERE (f.FLIGHT_NUMBER = @flightnumber) AND (i.DATE = @date)";
        string str = "Select flight_number, CONVERT(VARCHAR(10), DATE, 110) AS Date,(SELECT a.total_number_of_seats FROM FLIGHT_INSTANCE AS f INNER JOIN AIRPLANE AS a ON f.AIRPLANE_ID = a.AIRPLANE_ID WHERE (f.FLIGHT_NUMBER = @flightnumber) AND (f.DATE = @Date)) - (SELECT COUNT(*) AS Expr1 FROM SEAT_RESERVATION AS seatreserve WHERE (FLIGHT_NUMBER = @flightnumber) AND (DATE = @Date)) AS Number_of_available_seats, airplane_id, departure_time, arrival_time from flight_instance where (flight_number = @flightnumber) and (date = @date)";
        cmd = new SqlCommand(str, connection);
        cmd.Parameters.AddWithValue("@flightnumber", TextBox3.Text);
        cmd.Parameters.AddWithValue("@date", TextBox4.Text);

        da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox4.Text = Calendar1.SelectedDate.ToString("MM-dd-yyyy");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}