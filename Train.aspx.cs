using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;

public partial class Train : System.Web.UI.Page
{
    OracleConnection con = new OracleConnection("DATA SOURCE=DESKTOP-FHTCRDC:1521/XE;PERSIST SECURITY INFO=True;USER ID=SYSTEM;Password=arushi");
    String ID="";
    int convertedID;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string query1 = " select * from ARUSHIDB.TRAIN_SERVICE ";
        OracleDataAdapter da2 = new OracleDataAdapter(query1, con);
        DataTable ds2 = new DataTable();
        da2.Fill(ds2);
        GridView2.DataSource = ds2;
        GridView2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        string query = "select * from ARUSHIDB.ROUTE WHERE train_id='" + DropDownList1.Text + "'";
        OracleDataAdapter da = new OracleDataAdapter(query, con);
        DataTable ds1 = new DataTable();
        da.Fill(ds1);
        GridView1.DataSource = ds1;
        GridView1.DataBind();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
            con.Open();
            string str2 = DropDownList1.Text;
            int a = Convert.ToInt32(Convert.ToDouble(str2));

            string str3 = Session["USER_ID"].ToString();
            int b = Convert.ToInt32(Convert.ToDouble(str3));

            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ARUSHIDB.POOL values ('" + b + "','" + a + "')";
            cmd.ExecuteNonQuery();
            Response.Redirect("Manage.aspx");
            con.Close();

     }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

