using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcomAssignment1
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEntryName.Attributes.Add("placeholder", "Name");
            txtEntryEmail.Attributes.Add("placeholder", "Email");
            txtEntryPhone.Attributes.Add("placeholder", "Phone");
        }
    }
}