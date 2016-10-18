using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserCase1.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserCase2.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserCase3.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserCase4.aspx");
    }
}