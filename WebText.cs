using System;
using System.Data;
using System.Data.SqlClient;

namespace EcomAssignment1
{
    public class WebText
    {
        private static SqlConnection connection;
        public string Title { get; }
        public string Header { get; }
        public string Desc { get; }
        public WebText(string title, string header, string body)
        {
            Title = title;
            Header = header;
            Desc = body;
        }

        public static SqlConnection TextDatabase()
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                // Create a connection
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBContent.mdf;Integrated Security=True";
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    return connection;
                }
                catch (Exception ex)
                {
                    // If connection failed in someway, alert debug console
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }

            return connection;
        }

        public static void DisposeTextDatabase()
        {
            if (connection != null)
            {
                try
                {
                    connection.Close();
                }
                catch (SqlException se)
                {
                    System.Diagnostics.Debug.WriteLine(se.Message);
                }
            }
        }
        public static WebText RetrieveText(int id)
        {
            if(connection == null || connection.State == ConnectionState.Closed)
            {
                TextDatabase();
            }

            // Ensure the database connection exists before querying it
            if (connection != null && connection.State == ConnectionState.Open)
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TextStorage where Id=" + id;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0) // Got a result from the id, return the contained text
                {
                    string title = ds.Tables[0].Rows[0]["Title"].ToString();
                    string head = ds.Tables[0].Rows[0]["Header"].ToString();
                    string desc = ds.Tables[0].Rows[0]["Desc"].ToString();

                    return new WebText(title, head, desc);
                }

                connection.Close();
            }

            // No database connection, or no valid ID
            return new WebText("Title","Header","Desc");
        }
    }
}