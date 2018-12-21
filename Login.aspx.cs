using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    OracleConnection con = new OracleConnection("DATA SOURCE=DESKTOP-FHTCRDC:1521/XE;PERSIST SECURITY INFO=True;USER ID=SYSTEM;Password=arushi");
    OracleCommand cmd = new OracleCommand();
    OracleDataAdapter da = new OracleDataAdapter();
    DataTable ds1 = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Visible = false;
        con.Open();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd.CommandText = "select * from ARUSHIDB.LOGIN where E_ID='" + TextBoxID.Text + "' and PASS='" + TextBoxPASS.Text + "' ";
        cmd.Connection = con;
        da.SelectCommand = cmd;
        da.Fill(ds1);
        if (ds1.Rows.Count > 0)
        {
            Session["USER_ID"] = TextBoxID.Text;
            Response.Redirect("Train.aspx");
        }
        else
        {
            Label3.Visible = true;
            Label3.Text = "Employee is not found...Try Again";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ForgetPassword.aspx");
    }
}