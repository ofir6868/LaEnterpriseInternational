using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaEnterpriseInternational
{
    public partial class WelcomePeople : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        void buttonSubmit_Click(Object sender,
                               EventArgs e)
        {
            // When the button is clicked,
            // change the button text, and disable it.

           }

        protected void buttonSubmit_Click1(object sender, EventArgs e)
        {
            Response.Write("hi!" + email.Value.ToString());
        }

        // Display the greeting label text.

    }
}