using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class reptmp : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        reptmpDLL Serv = new reptmpDLL();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                Object objUserTheme = HttpContext.Current.Session["assetuserid"];
                if (objUserTheme == null)
                {
                    Response.Redirect("~/default.aspx");
                }
                else
                {
                    ddlRepType.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Quarterly Report", "1"));
                    ddlRepType.Items.Insert(1, new System.Web.UI.WebControls.ListItem("ธพ. Report", "2"));
                    ddlRepType.Items.Insert(2, new System.Web.UI.WebControls.ListItem("Pipeline Integrity Report - Onshore UNPIG", "3"));
                    ddlRepType.Items.Insert(2, new System.Web.UI.WebControls.ListItem("Pipeline Integrity Report - Onshore PIG", "4"));
                    ddlRepType.Items.Insert(2, new System.Web.UI.WebControls.ListItem("Pipeline Integrity Report - Offshore UNPIG", "5"));

                    bing_rep_tmp();
                }
            }
        }
        
        protected void bing_rep_tmp()
        {
            var x = Serv.GetRep_tmpALL(ddlRepType.SelectedValue);
            if (x.Rows.Count != 0)
            {
                gridview_rep_tmp.DataSource = x;
                gridview_rep_tmp.DataBind();
            }
            else
            {
                gridview_rep_tmp.DataSource = null;
                gridview_rep_tmp.DataBind();
            }
        }

        protected void btnAddTmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/reptmp_add.aspx");
        }

        protected void gridview_rep_tmp_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HiddenField hddflag_active = (HiddenField)(e.Row.FindControl("hddflag_active"));

                //Button Button2 = (Button)(e.Row.FindControl("Button2"));
                //Button Button1 = (Button)(e.Row.FindControl("Button1"));
                Label StatusLabel = (Label)(e.Row.FindControl("statusLabel"));

               
                if (hddflag_active.Value == "y")
                {
                    StatusLabel.Text = "Active";                    
                }
                else
                {
                    StatusLabel.Text = "In-Active";
                }
            }
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddfile_path = (HiddenField)row.FindControl("hddfile_path");

            Response.Redirect(hddfile_path.Value);
        }

        protected void ddlRepType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bing_rep_tmp();
        }

        protected void gridview_rep_tmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridview_rep_tmp.PageIndex = e.NewPageIndex;
            this.bing_rep_tmp();
        }
    }
}