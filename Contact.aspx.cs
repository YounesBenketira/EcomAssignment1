using System;
using System.Data;
using System.Data.SqlClient;
namespace EcomAssignment1
{
    public partial class Contact : System.Web.UI.Page
    {
        SqlConnection connection;
        private static char[] charsToTrim = { '*', ' ', '\'' };
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEntryName.Attributes.Add("placeholder", "Name");
            txtEntryEmail.Attributes.Add("placeholder", "Email");
            txtEntryPhone.Attributes.Add("placeholder", "Phone");

            connection = WebText.TextDatabase();

            // Title line
            titleDesc.Text = WebText.RetrieveText(4).Desc;

            // Address, phone, fax
            WebText contact = WebText.RetrieveText(5);
            lblAddress.Text = contact.Header;
            lblPhone.Text = contact.Title;
            lblFax.Text = contact.Desc;

            // Email
            WebText email = WebText.RetrieveText(6);
            lblEmail.Text = email.Header;
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            WebText.DisposeTextDatabase();
        }

        protected void btnSendContact_Click(object sender, EventArgs e)
        {
            string name = txtEntryName.Text;
            string email = txtEntryEmail.Text;
            string phone = txtEntryPhone.Text;
            string msg = txtEntryMsg.Text;

            if(name.Length > 0 && email.Length > 0 && phone.Length > 0 && msg.Length > 0) 
                AddContact(name, email, phone, msg);
        }
        protected void btnClearContact_Click(object sender, EventArgs e)
        {
            txtEntryName.Text = "";
            txtEntryEmail.Text = "";
            txtEntryPhone.Text = "";
            txtEntryMsg.Text = "";
        }
        private void AddContact(string name, string email, string phone, string msg)
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = WebText.TextDatabase();
            }

            // Ensure the database connection exists before querying it
            if (connection != null && connection.State == ConnectionState.Open)
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Contact VALUES (@name, @email, @phone, @msg)";

                cmd.Parameters.AddWithValue("name", name.Trim(charsToTrim));
                cmd.Parameters.AddWithValue("email", email.Trim(charsToTrim));
                cmd.Parameters.AddWithValue("phone", phone.Trim(charsToTrim));
                cmd.Parameters.AddWithValue("msg", msg.Trim(charsToTrim));
                try
                {
                    int values = cmd.ExecuteNonQuery();
                    btnClearContact_Click(btnClearContact, new EventArgs());
                }
                catch(Exception ex)
                {
                    txtEntryMsg.Text = "ERROR: " + ex.Message + "\n" + txtEntryMsg.Text;
                }

                connection.Close();
            }
        }
    }
}