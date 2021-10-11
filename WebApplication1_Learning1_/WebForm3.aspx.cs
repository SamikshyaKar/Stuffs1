using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication1_Learning1_
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlContinents.DataSource = GetData("spGetContinents ", null);
                ddlContinents.DataBind();

                ListItem licontinents = new ListItem("Select Continent", "-1");
                ddlContinents.Items.Insert(0, licontinents);

                ListItem licountries = new ListItem("Select Country", "-1");
                ddlCountries.Items.Insert(0, licountries);

                ListItem licities = new ListItem("Select City", "-1");
                ddlCities.Items.Insert(0, licities);

                ddlCountries.Enabled = false;
                ddlCities.Enabled = false;


            }
        }

        private DataSet GetData(string SPName, SqlParameter SPParameter)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlDataAdapter da = new SqlDataAdapter(SPName, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if(SPParameter !=null)
            {
                da.SelectCommand.Parameters.Add(SPParameter);

            }
            DataSet DS = new DataSet();
            da.Fill(DS);
            return DS;

        }
        protected void ddlContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContinents.SelectedIndex==0)
            {
                ddlCountries.SelectedIndex = 0;
                ddlCountries.Enabled = false;

                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;

            }
            else
            {
                ddlCountries.Enabled = true;
                SqlParameter parameter = new SqlParameter("@ContinentId", ddlContinents.SelectedValue);
                DataSet Ds= GetData("spGetCountriesByContinentId", parameter);

                ddlCountries.DataSource = Ds;
                ddlCountries.DataBind();

                ListItem licountries = new ListItem("Select Country", "-1");
                ddlCountries.Items.Insert(0, licountries);

                ddlCities.SelectedIndex = 0;
                ddlCities.Enabled = false;
            }
        }

        protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountries.SelectedIndex == 0)
            {


            }
            else
            {
                ddlCities.Enabled = true;
                SqlParameter parameter = new SqlParameter("@CountryId", ddlCountries.SelectedValue);
                DataSet Ds = GetData("spGetCitiesByCountryId", parameter);

                ddlCities.DataSource = Ds;
                ddlCities.DataBind();

                ListItem licities = new ListItem("Select Country", "-1");
                ddlCities.Items.Insert(0, licities);
            }
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}