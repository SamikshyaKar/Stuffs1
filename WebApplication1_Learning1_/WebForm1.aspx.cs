using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_Learning1_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ListBox1.SelectedItem !=null)
            {
                Response.Write("Text = " + ListBox1.SelectedItem.Text + "<br/>");
                Response.Write("Value = " + ListBox1.SelectedItem.Value + "<br/>");
                Response.Write("Index = " + ListBox1.SelectedIndex.ToString());

            }
            else
            {
                Response.Write("Please select an item");

            }
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListItem li in ListBox1.Items)
            {
                if(li.Selected)
                {
                    Response.Write(" Text = " + li.Text + "<br/>");
                    Response.Write("Value = " + li.Value + "<br/>");
                    Response.Write("Index = " + ListBox1.Items.IndexOf(li).ToString() +"<br/>");
                    Response.Write("<br/>"+ "________________________");
                    Response.Write("<br/>");

                }
               
            }

           
        }
    }
}