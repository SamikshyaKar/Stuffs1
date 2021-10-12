using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_Learning1_
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button2.Click += Button2_Click;
            Button2.Click += Button2_Click1;

        }

        private void Button2_Click1(object sender, EventArgs e)
        {
            Response.Write("Button2  command event is fired  <br/> ");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("Button2 click event is fired <br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Btn Click Event fired" + "<br/>");
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            Response.Write("Btn Command event fired" + "<br/>");

        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    Response.Write("Button2 click event is fired <br/>");

        //}

        //protected void Button2_Command(object sender, CommandEventArgs e)
        //{
        //    Response.Write("Button2  command event is fired  <br/> ");
        //}
    }
}