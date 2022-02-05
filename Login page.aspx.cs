using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Project_Version_1
{
    public partial class Login_page : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KTGJBSG\SQLEXPRESS01; Initial Catalog=Egitimler;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e) {
        Label1.Visible = false;
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand cmd = new SqlCommand("select * from Account where userName='" + TextBox1.Text.Trim() + "' AND userPassword='" + TextBox2.Text.Trim() + "'", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        Session["username"] = dr.GetValue(1).ToString();
                        Session["id"] = Convert.ToInt32(dr.GetValue(0));
                        Session["Role"] = dr.GetValue(3).ToString();
                    }
                    if (Session["Role"].Equals("Student"))
                    {
                        Response.Redirect("Student.aspx");
                    }
                    else if (Session["Role"].Equals("Teacher"))
                    {
                        Response.Redirect("Instructor.aspx");
                    }
                }
       
                else
                {
                    Label1.Visible=true;
                }

                baglanti.Dispose();
                baglanti.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

            }
        }
}