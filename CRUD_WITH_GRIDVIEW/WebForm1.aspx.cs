using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_WITH_GRIDVIEW
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["name"].DefaultValue = 
                
               ((TextBox) GridView1.FooterRow.FindControl("FooterName")).Text;

            SqlDataSource1.InsertParameters["gender"].DefaultValue =

              ((DropDownList)GridView1.FooterRow.FindControl("FooterDdlGender")).SelectedValue ;

            SqlDataSource1.InsertParameters["class"].DefaultValue =

              ((TextBox)GridView1.FooterRow.FindControl("FooterClass")).Text;

            // All parameters done now fire insert query that returns integer value
            int a = SqlDataSource1.Insert();

            if (a > 0)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<Script>alert('Insertion Sucessfull!!')</Script>");

            }
            else {


                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<Script>alert('Insertion Failed!!')</Script>");
            }



        }
    }
}