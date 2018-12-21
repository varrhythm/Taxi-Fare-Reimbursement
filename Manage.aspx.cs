using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;

public partial class Manage : System.Web.UI.Page
{
    OracleConnection con = new OracleConnection("DATA SOURCE=DESKTOP-FHTCRDC:1521/XE;PERSIST SECURITY INFO=True;USER ID=SYSTEM;Password=arushi");

    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
    
        string query1 = "select E_ID from ARUSHIDB.POOL WHERE train_id='" + 1337 + "' ";
        string query2 = "select E_ID from ARUSHIDB.POOL WHERE train_id='" + 1338 + "' ";
        string query3 = "select E_ID from ARUSHIDB.POOL WHERE train_id='" + 1339 + "' ";
        string query4 = "select E_ID from ARUSHIDB.POOL WHERE train_id='" + 1340 + "' ";

        carpool(con,query1);
        con.Close();
        Response.Redirect("Request.aspx");
    }

    public void carpool(object sender, string query)
    {
        int b = 0;
        int c = 0;
        int d = 0;
        string str4 = "";
        string str5 = "";
        string str1 = "";

        OracleDataReader reader;
        OracleDataAdapter da = new OracleDataAdapter(query, con);
        DataTable ds = new DataTable();
        da.Fill(ds);

        if (ds.Rows.Count <= 3)
        {
            string str = Session["USER_ID"].ToString();
            b = Convert.ToInt32(Convert.ToDouble(str));

            OracleCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into ARUSHIDB.E_IDWITHCAR values ('" + b + "','" + 10234 + "')";
            cmd2.ExecuteNonQuery();

            Session["CAR"] = 10234;
            OracleCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from ARUSHIDB.CAR WHERE CAR_NUM='" + 10234 + "' ";
            OracleDataReader reader1 = cmd3.ExecuteReader();
            while (reader1.Read())
            {
                String str2 = reader1["CAR_NUM"].ToString();
                c = Convert.ToInt32(Convert.ToDouble(str2));

                String str3 = reader1["DRIVER_ID"].ToString();
                d = Convert.ToInt32(Convert.ToDouble(str3));

                str4 = reader1["DRIVER_NAME"].ToString();

                str5 = reader1["DRIVER_MOBILE"].ToString();

                cmd3.ExecuteNonQuery();
            }
            OracleCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select EMAIL from ARUSHIDB.REGISTRATION WHERE E_ID='" + b + "' ";
            reader = cmd4.ExecuteReader();
            cmd4.CommandText = "select * from ARUSHIDB.REGISTRATION WHERE E_ID='" + b + "' ";
            reader = cmd4.ExecuteReader();
            while (reader.Read())
            {
                str1 = reader["EMAIL"].ToString();
            }
            cmd4.ExecuteNonQuery();

            MailMessage MM = new MailMessage("arushi.rastogi02@gmail.com", str1);
            MM.Subject = " Car Pool Details";
            MM.Body = string.Format("<br/>Your Car has been pooled or booked.<br/><br/> The pooling details are : <br/><br/><table style=(width:100%) align='centre'> <tr><th> Employee Id </th> &nbsp;&nbsp; <th> CAR Number </th> &nbsp;&nbsp; <th> Driver ID </th> &nbsp;&nbsp; <th> Driver Name </th> &nbsp;&nbsp; <th> Driver Mobile Number </th> &nbsp;&nbsp; </tr><br/> <tr> <td>  " + b + "</td> &nbsp;&nbsp; <td>" + c + "</td> &nbsp;&nbsp; <td>" + d + "</td> &nbsp;&nbsp; <td>" + str4 + "</td> &nbsp;&nbsp; <td>" + str5 + "</td></tr><br/> </table>");
            MM.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential nC = new NetworkCredential();
            nC.UserName = "arushi.rastogi02@gmail.com";
            nC.Password = "arushi1416@";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nC;
            smtp.Port = 587;
            smtp.Send(MM);
        }

        else if (ds.Rows.Count > 3)
        {
            string str = Session["USER_ID"].ToString();
            b = Convert.ToInt32(Convert.ToDouble(str));

            OracleCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into ARUSHIDB.E_IDWITHCAR values ('" + b + "','" + 10256 + "')";
            cmd2.ExecuteNonQuery();

            Session["CAR"] = 10256;
            OracleCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select * from ARUSHIDB.CAR WHERE CAR_NUM='" + 10256 + "' ";
            OracleDataReader reader1 = cmd3.ExecuteReader();
            while (reader1.Read())
            {
                String str2 = reader1["CAR_NUM"].ToString();
                c = Convert.ToInt32(Convert.ToDouble(str2));

                String str3 = reader1["DRIVER_ID"].ToString();
                d = Convert.ToInt32(Convert.ToDouble(str3));

                str4 = reader1["DRIVER_NAME"].ToString();
                Response.Write(str4);

                str5 = reader1["DRIVER_MOBILE"].ToString();
                Response.Write(str5);

                cmd3.ExecuteNonQuery();
            }
            OracleCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select EMAIL from ARUSHIDB.REGISTRATION WHERE E_ID='" + b + "' ";
            reader = cmd4.ExecuteReader();
            cmd4.CommandText = "select * from ARUSHIDB.REGISTRATION WHERE E_ID='" + b + "' ";
            reader = cmd4.ExecuteReader();
            while (reader.Read())
            {
                str1 = reader["EMAIL"].ToString();
                Response.Write(str1);
            }
            cmd4.ExecuteNonQuery();

            MailMessage MM = new MailMessage("arushi.rastogi02@gmail.com", str1);
            MM.Subject = " Car Pool Details";
            MM.Body = string.Format("Your Car has been pooled or booked.<br/> The pooling details are : <br/> Employee Id - <h3>" + str1 + "</h3> <br/> CAR Number - <h3>" + c + "</h3> <br/> Driver ID - <h3>" + d + "</h3> <br/> Driver Name - <h3>" + str4 + "</h3> <br/> Driver Mobile Number - <h3>" + str5 + "</h3>");
            MM.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential nC = new NetworkCredential();
            nC.UserName = "arushi.rastogi02@gmail.com";
            nC.Password = "arushi1416@";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nC;
            smtp.Port = 587;
            smtp.Send(MM);
        }
    }
}