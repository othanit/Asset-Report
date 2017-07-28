using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class NestedMasterPage2 : System.Web.UI.MasterPage
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
                //lbYear.Text = HttpContext.Current.Session["repYear"].ToString();
                
            }
        }

        protected void lnkPermit_Info_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permit.aspx");
        }

        protected void lnkPatrolling_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitpatrolling.aspx");
        }

        protected void lnkCP_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitcp.aspx");
        }

        protected void lnkILIPIG_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitilipig.aspx");
        }

        protected void lnkWallThickness_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitwallthickness.aspx");
        }

        protected void lnkProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitproject.aspx");
        }

        protected void lnkAppendix1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitappendixB.aspx");
        }

        protected void lnkAppendix2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitappendixD.aspx");
        }

        protected void lnkAppendix3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitappendixH.aspx");
        }

        protected void lnkAppendix4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitappendixI.aspx");
        }

        protected void LinkExecusiveSummary_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/permitexecutivesummary.aspx");
        }


    }
}