using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;

public partial class Registration : System.Web.UI.Page
{
    OracleConnection con = new OracleConnection("DATA SOURCE=DESKTOP-FHTCRDC:1521/XE;PERSIST SECURITY INFO=True;USER ID=SYSTEM;Password=arushi");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        OracleCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into ARUSHIDB.REGISTRATION values ('" + TextBoxID.Text + "','" + TextBoxUN.Text + "','" + TextBoxEM.Text + "','" + TextBoxP.Text + "','" + TextBoxMN.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();
    }
}