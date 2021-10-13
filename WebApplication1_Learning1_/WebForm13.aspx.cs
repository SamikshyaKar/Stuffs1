using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1_Learning1_
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadEmployee();
            }
        }

        private void loadEmployee()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection Con= new SqlConnection(CS))
            {
                string sqlQuery = "Select Id, Name, Gender, DeptName from tblEmployeesforFramework where Id=202";
                SqlCommand cmd = new SqlCommand(sqlQuery, Con);
                Con.Open();
                using(SqlDataReader rdr= cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        TxtName.Text = rdr["Name"].ToString();
                        TxtGender.Text = rdr["Gender"].ToString();
                        TxtDept.Text = rdr["DeptName"].ToString();
                        HiddenField1.Value = rdr["Id"].ToString();
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loadEmployee();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection  Con = new SqlConnection(CS))
            {
                string SqlQuery = "update tblEmployeesforFramework set Name=@Name, Gender=@Gender,DeptName=@DeptName" +
                    " where Id=@Id";
                SqlCommand cmd = new SqlCommand(SqlQuery, Con);

                cmd.Parameters.AddWithValue("@Name", TxtName.Text);
                cmd.Parameters.AddWithValue("@Gender", TxtGender.Text);
                cmd.Parameters.AddWithValue("@DeptName", TxtDept.Text);
                cmd.Parameters.AddWithValue("@Id", HiddenField1.Value);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();

                TxtName.Text = " ";
                TxtGender.Text = " ";
                TxtDept.Text = " ";                
            }
        }
    }
}