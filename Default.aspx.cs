using System;
using System.Data;
using System.Data.SqlClient;

namespace EcomAssignment1
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection contentConnection;
        private int slideShowImageIndex = 2;

        protected void Page_Load(object sender, EventArgs e)
        {
            switch (slideShowImageIndex)
            {
                case 0: // Monkey
                    imgHomeImage.ImageUrl = "~/Images/elephants.jpg";
                    slide1.BackColor = System.Drawing.Color.OrangeRed;
                    break;
                case 1:
                    imgHomeImage.ImageUrl = "~/Images/wierdDeers.jpg";
                    slide2.BackColor = System.Drawing.Color.OrangeRed;
                    break;
                case 2:
                    imgHomeImage.ImageUrl = "~/Images/Monkey.jpg";
                    slide3.BackColor = System.Drawing.Color.OrangeRed;
                    break;
                default:
                    break;
            }
            // Create a connection
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\App_Data\DBContent.mdf;Integrated Security=True";
            try
            {
                contentConnection = new SqlConnection(connectionString);
                contentConnection.Open();
            }
            catch (Exception ex)
            {
                // If connection failed in someway, alert debug console
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected string RetrieveText(int id)
        {
            // Ensure the database connection exists before querying it
            if (contentConnection != null)
            {
                SqlCommand cmd = contentConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TextStorage where id=" + id;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0) // Got a result from the id, return the contained text
                    return ds.Tables[0].Rows[0]["text"].ToString();
            }

            // No database connection, or no valid ID
            return "";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // If the database connection exists on page unload,
            if (contentConnection != null)
            {
                try
                {
                    contentConnection.Close();
                }
                catch (SqlException se)
                {
                    System.Diagnostics.Debug.WriteLine(se.Message);
                }
            }
        }

        protected void SlideOnePressed(object sender, EventArgs e)
        {
            imgHomeImage.ImageUrl = "~/Images/elephants.jpg";
            slide1.BackColor = System.Drawing.Color.OrangeRed;
            slide2.BackColor = System.Drawing.Color.White;
            slide3.BackColor = System.Drawing.Color.White;
        }

        protected void SlideTwoPressed(object sender, EventArgs e)
        {
            imgHomeImage.ImageUrl = "~/Images/wierdDeers.jpg";
            slide2.BackColor = System.Drawing.Color.OrangeRed;
            slide1.BackColor = System.Drawing.Color.White;
            slide3.BackColor = System.Drawing.Color.White;
        }

        protected void SlideThreePressed(object sender, EventArgs e)
        {
            imgHomeImage.ImageUrl = "~/Images/Monkey.jpg";
            slide3.BackColor = System.Drawing.Color.OrangeRed;
            slide2.BackColor = System.Drawing.Color.White;
            slide1.BackColor = System.Drawing.Color.White;
        }
    }
}