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
    public partial class history_1 : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        history_1DLL Serv = new history_1DLL();
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
                    if (!string.IsNullOrEmpty(Request.QueryString["param"]))
                    {
                        hddrep_type.Value = Request.QueryString["param"].ToString();
                    }
                    else
                    {
                        hddrep_type.Value = "";
                    }

                    bing_rep_tmp();
                }
            }
        }

        protected void bing_rep_tmp()
        {
            var x = Serv.GetRep_HisALL(hddrep_type.Value, Request.QueryString["quarterrepid"]);
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

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddfile_path = (HiddenField)row.FindControl("hddfile_path");

            Response.Redirect(hddfile_path.Value);
        }

        protected void gridview_rep_tmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            gridview_rep_tmp.PageIndex = e.NewPageIndex;
            this.bing_rep_tmp();
        }
    }
}