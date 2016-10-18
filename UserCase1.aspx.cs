using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
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

        string str = "SELECT f.FLIGHT_NUMBER, f.AIRLINE, f.WEEKDAYS FROM FLIGHT AS f WHERE (f.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f.DEPARTURE_AIRPORT_CODE = @depaircode)";
        cmd = new SqlCommand(str, connection);
        cmd.Parameters.AddWithValue("@depaircode", TextBox3.Text);
        cmd.Parameters.AddWithValue("@arraircode", TextBox4.Text);

        da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        int r;

        GridView1.DataSource = ds;
        GridView1.DataBind();
        r = GridView1.Rows.Count;
        //if (r == 0)
        {
            
            String con1 = ConfigurationManager.AppSettings["SQLSTRING"];
            SqlConnection connection1 = new SqlConnection(con1);
            SqlDataAdapter da1;
            SqlCommand cmd1;
            DataSet ds1 = new DataSet();
            
            if (CheckBox1.Checked == true)
            {
                string str1 = "SELECT f1.FLIGHT_NUMBER, f1.AIRLINE, f1.WEEKDAYS, f1.DEPARTURE_AIRPORT_CODE, f1.SCHEDULED_DEPARTURE_TIME, f1.ARRIVAL_AIRPORT_CODE, f1.SCHEDULED_ARRIVAL_TIME, f1.FLIGHT_DURATION,f2.FLIGHT_NUMBER AS ConFlightNumber, f2.AIRLINE AS ConAirline, f2.WEEKDAYS AS ConWeekDay, f2.DEPARTURE_AIRPORT_CODE AS ConDepartureAirportCode,f2.SCHEDULED_DEPARTURE_TIME AS ConDepartureTime, f2.ARRIVAL_AIRPORT_CODE AS ConArrivalAirportCode, f2.SCHEDULED_ARRIVAL_TIME AS ConArrivalTime, f2.FLIGHT_DURATION AS ConFlightDuration​ FROM FLIGHT AS f1 INNER JOIN FLIGHT AS f2 ON f1.ARRIVAL_AIRPORT_CODE = f2.DEPARTURE_AIRPORT_CODE AND DATEADD(HOUR, 1, f1.SCHEDULED_ARRIVAL_TIME) < f2.SCHEDULED_DEPARTURE_TIME AND f1.ARRIVAL_AIRPORT_CODE = f2.DEPARTURE_AIRPORT_CODE WHERE (f1.WEEKDAYS LIKE '%Mon%') AND (f2.WEEKDAYS LIKE '%Mon%') AND (f1.DEPARTURE_AIRPORT_CODE = 'OAK') AND (f2.ARRIVAL_AIRPORT_CODE = 'MIA') OR (f1.WEEKDAYS LIKE '%Tue%') AND (f2.WEEKDAYS LIKE '%Tue%') AND (f1.DEPARTURE_AIRPORT_CODE = 'OAK') AND (f2.ARRIVAL_AIRPORT_CODE = 'MIA') OR (f1.WEEKDAYS LIKE '%Wed%') AND (f2.WEEKDAYS LIKE '%Wed%') AND (f1.DEPARTURE_AIRPORT_CODE = 'OAK') AND (f2.ARRIVAL_AIRPORT_CODE = 'MIA') OR (f1.WEEKDAYS LIKE '%Thu%') AND (f2.WEEKDAYS LIKE '%Thu%') AND (f1.DEPARTURE_AIRPORT_CODE = 'OAK') AND (f2.ARRIVAL_AIRPORT_CODE = 'MIA') OR (f1.WEEKDAYS LIKE '%Fri%') AND (f2.WEEKDAYS LIKE '%Fri%') AND (f1.DEPARTURE_AIRPORT_CODE = 'OAK') AND (f2.ARRIVAL_AIRPORT_CODE = 'MIA') OR (f1.WEEKDAYS LIKE '%Sat%') AND (f2.WEEKDAYS LIKE '%Sat%') AND (f1.DEPARTURE_AIRPORT_CODE = 'OAK') AND (f2.ARRIVAL_AIRPORT_CODE = 'MIA') OR (f1.WEEKDAYS LIKE '%Sun%') AND (f2.WEEKDAYS LIKE '%Sun%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f2.ARRIVAL_AIRPORT_CODE = @arraircode)";
                cmd1 = new SqlCommand(str1, connection1);
                cmd1.Parameters.AddWithValue("@depaircode", TextBox3.Text);
                cmd1.Parameters.AddWithValue("@arraircode", TextBox4.Text);

                da1 = new SqlDataAdapter(cmd1);

                da1.Fill(ds1);
                GridView2.DataSource = ds1;
                GridView2.DataBind();
            }
            if (CheckBox2.Checked == true)
            {
                String con2 = ConfigurationManager.AppSettings["SQLSTRING"];
                SqlConnection connection2 = new SqlConnection(con2);
                SqlDataAdapter da2;
                SqlCommand cmd2;
                DataSet ds2 = new DataSet();
                string str2 = "SELECT f1.FLIGHT_NUMBER, f1.AIRLINE, f1.WEEKDAYS, f1.DEPARTURE_AIRPORT_CODE, f1.SCHEDULED_DEPARTURE_TIME, f1.ARRIVAL_AIRPORT_CODE, f1.SCHEDULED_ARRIVAL_TIME, f1.FLIGHT_DURATION,f2.FLIGHT_NUMBER AS f2FLIGHT_NUMBER, f2.AIRLINE AS f2AIRLINE, f2.WEEKDAYS AS f2wEEKDAYS, f2.DEPARTURE_AIRPORT_CODE AS f2DEPARTURE_AIRPORT_CODE,f2.SCHEDULED_DEPARTURE_TIME AS f2SCHEDULED_DEPARTURE_TIME, f2.ARRIVAL_AIRPORT_CODE AS f2ARRIVAL_AIRPORT_CODE, f2.SCHEDULED_ARRIVAL_TIME AS f2SCHEDULED_ARRIVAL_TIME,f2.FLIGHT_DURATION AS f2FLIGHT_DURATION, f3.FLIGHT_NUMBER AS f3FLIGHT_NUMBER, f3.AIRLINE AS f3AIRLINE, f3.WEEKDAYS AS f3WEEKDAYS,f3.DEPARTURE_AIRPORT_CODE AS f3DEPARTURE_AIRPORT_CODE, f3.SCHEDULED_DEPARTURE_TIME AS f3SCHEDULED_DEPARTURE_TIME, f3.ARRIVAL_AIRPORT_CODE AS f3ARRIVAL_AIRPORT_CODE,f3.SCHEDULED_ARRIVAL_TIME AS f3SCHEDULED_ARRIVAL_TIME, f3.FLIGHT_DURATION AS f3FLIGHT_DURATION FROM FLIGHT AS f1 INNER JOIN FLIGHT AS f2 ON f1.ARRIVAL_AIRPORT_CODE = f2.DEPARTURE_AIRPORT_CODE AND DATEADD(HOUR, 1, f1.SCHEDULED_ARRIVAL_TIME) < f2.SCHEDULED_DEPARTURE_TIME INNER JOIN FLIGHT AS f3 ON f2.ARRIVAL_AIRPORT_CODE = f3.DEPARTURE_AIRPORT_CODE AND DATEADD(HOUR, 1, f2.SCHEDULED_ARRIVAL_TIME) < f3.SCHEDULED_DEPARTURE_TIME WHERE (f1.WEEKDAYS LIKE '%Mon%') AND (f2.WEEKDAYS LIKE '%Mon%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f3.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f3.WEEKDAYS LIKE '%Mon%') OR (f1.WEEKDAYS LIKE '%Tue%') AND (f2.WEEKDAYS LIKE '%Tue%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f3.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f3.WEEKDAYS LIKE '%Tue%') OR (f1.WEEKDAYS LIKE '%Wed%') AND (f2.WEEKDAYS LIKE '%Wed%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f3.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f3.WEEKDAYS LIKE '%Wed%') OR (f1.WEEKDAYS LIKE '%Thu%') AND (f2.WEEKDAYS LIKE '%Thu%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f3.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f3.WEEKDAYS LIKE '%Thu%') OR (f1.WEEKDAYS LIKE '%Fri%') AND (f2.WEEKDAYS LIKE '%Fri%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f3.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f3.WEEKDAYS LIKE '%Fri%') OR (f1.WEEKDAYS LIKE '%Sat%') AND (f2.WEEKDAYS LIKE '%Sat%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f3.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f3.WEEKDAYS LIKE '%Sat%') OR (f1.WEEKDAYS LIKE '%Sun%') AND (f2.WEEKDAYS LIKE '%Sun%') AND (f1.DEPARTURE_AIRPORT_CODE = @depaircode) AND (f3.ARRIVAL_AIRPORT_CODE = @arraircode) AND (f3.WEEKDAYS LIKE '%Sun%')";
                cmd2 = new SqlCommand(str2, connection1);
                cmd2.Parameters.AddWithValue("@depaircode", TextBox3.Text);
                cmd2.Parameters.AddWithValue("@arraircode", TextBox4.Text);

                da2 = new SqlDataAdapter(cmd2);
                GridView3.Visible = true;
                da2.Fill(ds2);
                GridView2.Visible = false;
                
                GridView3.DataSource = ds2;
                GridView3.DataBind();
            }
            
            
            //GridView1.Visible = false;

        }
        //else
        //{
          //  GridView1.Visible = true;
        //}
        
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}