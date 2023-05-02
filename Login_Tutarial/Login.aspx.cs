using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Tutarial
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtUser.Text = "";
                txtUser.Focus();
               
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "shakti123@gmail.com" && txtPass.Text == "12345")
                {
                    Response.Redirect("SuccessWithFailureCount.aspx?Name=" + txtUser.Text);
                }
                else
                {
                    int Count;
                    if (ViewState["FailureCount"] != null)
                    {
                        Count = (int)ViewState["FailureCount"] + 1;
                    }
                    else
                    {
                        Count = 1;
                    }
                    if (Count == 3)
                    {
                        Response.Redirect("FailureWithFailureCount.aspx?Name=" + txtUser.Text+ "&Count="+Count);
                    }
                    ViewState["FailureCount"] = Count;
                    Label1.Text = Count + "attemps failed, maximum are 3 only";
                }
            }
            catch
            {

            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = txtPass.Text = "";
            Label1.Text = "";
            txtUser.Focus ();
        }
    }
}