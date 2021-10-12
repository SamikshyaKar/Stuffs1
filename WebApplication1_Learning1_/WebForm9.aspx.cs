using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_Learning1_
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if(extension.ToLower() !=".doc" && extension.ToLower() !=".docx" )
                {
                    Label1.Text = "Only doc or docx files to be uoloaded";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int filesize = FileUpload1.PostedFile.ContentLength;
                    if (filesize> 3145728)
                    {
                        Label1.Text = " File cant be greater than 3 MB ";
                        Label1.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {                  
                    FileUpload1.SaveAs(Server.MapPath("~/Uploads" + FileUpload1.FileName));
                    Label1.Text = "File Uploaded";
                    Label1.ForeColor = System.Drawing.Color.Green;
                    }
                }
               
            }
            else
            {
                Label1.Text = " Please select a file";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}