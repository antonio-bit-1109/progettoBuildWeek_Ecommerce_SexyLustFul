using System;

namespace U4_BW1_LL
{
    public partial class AcquistoAbbonamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoAbbonamento"] != null)
            {

            }
            else
            {

                Response.Redirect("Default.aspx");
            }
        }
    }
}