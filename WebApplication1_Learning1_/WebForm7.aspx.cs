using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_Learning1_
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void CommandBtn_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    Label1.Text = "You clicked Print Button";
                    break;

                case "Delete":
                    Label1.Text = "You clicked Delete Button";
                    break;

                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        Label1.Text = "Clicked Top 10";
                    }

                    else 
                    {
                        Label1.Text = "Clicked Bottom 10";
                    }
                    break;

                default:
                    Label1.Text = " Please Click a valid button";
                    break;
            }

        }

        protected void PrintBtn_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        protected void Showtop10Btn_Click(object sender, EventArgs e)
        {

        }

        protected void ShowBottomBtn_Click(object sender, EventArgs e)
        {

        }

        protected void Showtop10Btn_Click1(object sender, EventArgs e)
        {

        }
    }
}