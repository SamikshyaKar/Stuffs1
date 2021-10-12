using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_Learning1_
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListItem listitems1 = new ListItem("male", "1");
                ListItem listItems2 = new ListItem("female", "2");


                DDLSelection.Items.Add(listitems1);
                DDLSelection.Items.Add(listItems2);

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}