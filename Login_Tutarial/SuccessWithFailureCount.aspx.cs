using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Tutarial
{
    public partial class SuccessWithFailureCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request["Name"];
            Response.Write("Hello" +name+ "Welcome to site");
        }
    }
}