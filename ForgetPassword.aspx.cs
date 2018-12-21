using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;

public partial class ForgetPassword : System.Web.UI.Page
{
    OracleConnection con = new OracleConnection("DATA SOURCE=DESKTOP-FHTCRDC:1521/XE;PERSIST SECURITY INFO=True;USER ID=SYSTEM;Password=arushi");

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            string str = "select * from ARUSHIDB.LOGIN where E_ID='" + TextBoxID.Text + "'";
            OracleCommand cmd = new OracleCommand(str, con);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TextBoxID.Text == dr["E_ID"].ToString())
                {
                    TextBoxPASS.Text = dr["PASS"].ToString();

                }
                else
                {
                    Label3.Visible = true;

                    Label3.Text = "Employee is not found...Try Again";
                }
            }
            dr.Close();
            cmd.ExecuteNonQuery();
        }
        catch (Exception)
        { }
        finally
        {
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}