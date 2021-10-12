using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_Learning1_
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();

            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    ListBox1.Items.Add(li.Text);

                }
            }

                if(CheckBoxList1.SelectedIndex == -1)
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Green;
                }

            Label1.Text = ListBox1.Items.Count.ToString() + "  Items selected";
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}