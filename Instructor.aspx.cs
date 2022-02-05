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
    public partial class Instructor : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KTGJBSG\SQLEXPRESS01; Initial Catalog=Egitimler;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Role"] == null)
            {
                Response.Redirect("Login page.aspx");
            }

            if (Session["Role"].Equals("Student"))
            {
                Response.Redirect("Student.aspx");
            }
            else if (Session["Role"].Equals("Teacher"))
            {
                Label1.Text = Session["username"].ToString();
            }

            if (!IsPostBack)
            {
                content.Visible = false;
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select * from courseInstructor where instructorId = '" + Session["id"] + "'", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    Courses.Items.Insert(i, new ListItem(dr.GetString(0), dr.GetString(1)));
                    i++;
                }
                baglanti.Close();
            }
            
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login page.aspx");
        }

        protected void Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            content.Visible = true;

        }

        protected void Addlecture_Click(object sender, EventArgs e)
        {

        }

        protected void ViewLectures_Click(object sender, EventArgs e)
        {

        }
    }
}