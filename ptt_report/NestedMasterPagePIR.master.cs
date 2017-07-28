using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class NestedMasterPagePIR : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Object objUserTheme = HttpContext.Current.Session["assetuserid"];
            if (objUserTheme == null)
            {
                Response.Redirect("~/default.aspx");
            }
            else
            {
                lbYear.Text = HttpContext.Current.Session["repYear"].ToString();
                lbPermit.Text = HttpContext.Current.Session["repPermit"].ToString();
            }
        }

        protected void lnkPIROnShoreUnpig_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pironshoreunpig.aspx");
        }

        protected void lnkPIROnShorePig_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/pironshorepig.aspx");
        }

        protected void lnkPIROffShorePig_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/piroffshorepig.aspx");
        }
    }
}