using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcomAssignment1
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection contentConnection;

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\App_Data\DBContent.mdf;Integrated Security=True";
            try
            {
                contentConnection = new SqlConnection(connectionString);
                contentConnection.Open();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected string RetrieveText(int id)
        {
            if(contentConnection != null)
            {
                SqlCommand cmd = contentConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TextStorage where Id=" + id;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if(ds.Tables[0].Rows.Count > 0)
                    return ds.Tables[0].Rows[0]["text"].ToString();
            }

            return "";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            if(contentConnection != null)
            {
                try
                {
                    contentConnection.Close();
                } catch(SqlException se)
                {
                    System.Diagnostics.Debug.WriteLine(se.Message);
                }
            }
        }
    }
}