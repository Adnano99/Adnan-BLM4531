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
    public partial class student : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KTGJBSG\SQLEXPRESS01; Initial Catalog=Egitimler;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            content.Visible = false;

            if (Session["Role"] == null)
            {
                Response.Redirect("Login page.aspx");
            }
            else if (Session["Role"].Equals("instructor"))
            {
                Response.Redirect("instructor.aspx");
            }
            else if (Session["Role"].Equals("Student"))
            {
            Label1.Text = Session["username"].ToString();
            }

            if (!IsPostBack)
            {
                try
                {
                    if (baglanti.State == System.Data.ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    SqlCommand cmd = new SqlCommand("select * from CourseStudent where courseName='" + Session["id"] + "'", baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        int i = 0;
                        while (dr.Read())
                        {
                            DropDownList1.Items.Insert(i, new ListItem(dr.GetValue(2).ToString(), dr.GetValue(1).ToString()));
                            i++;
                        }
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login page.aspx");
        }
    }
}