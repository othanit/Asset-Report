using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ptt_report
{
    public partial class QuarterlyReport : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        QuarterlyReportDLL Serv = new QuarterlyReportDLL();
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
                    bind_default();
                    bind_list();
                }
            }
        }

        protected void bind_default()
        {

            var year = Serv.GetRep_year();
            if (year.Rows.Count != 0)
            {
                ddlyear.DataTextField = "year";
                ddlyear.DataValueField = "year";
                ddlyear.DataSource = year;
                ddlyear.DataBind();
            }
            else
            {
                ddlyear.DataSource = null;
                ddlyear.DataBind();
            }
            ddlyear.Items.Insert(0, new ListItem("", ""));

            var quarter = Serv.GetRep_quarter();
            if (quarter.Rows.Count != 0)
            {
                ddlquarter.DataTextField = "quarter";
                ddlquarter.DataValueField = "quarter";
                ddlquarter.DataSource = quarter;
                ddlquarter.DataBind();
            }
            else
            {
                ddlquarter.DataSource = null;
                ddlquarter.DataBind();
            }
            ddlquarter.Items.Insert(0, new ListItem("", ""));

            var cus_type = Serv.GetRep_cus_type();
            if (cus_type.Rows.Count != 0)
            {
                ddlcustype.DataTextField = "cus_type";
                ddlcustype.DataValueField = "cus_type";
                ddlcustype.DataSource = cus_type;
                ddlcustype.DataBind();
            }
            else
            {
                ddlcustype.DataSource = null;
                ddlcustype.DataBind();
            }
            ddlcustype.Items.Insert(0, new ListItem("", ""));

            var status = Serv.GetRep_status();
            if (status.Rows.Count != 0)
            {
                ddlstatus.DataTextField = "status";
                ddlstatus.DataValueField = "status";
                ddlstatus.DataSource = status;
                ddlstatus.DataBind();
            }
            else
            {
                ddlstatus.DataSource = null;
                ddlstatus.DataBind();
            }
            ddlstatus.Items.Insert(0, new ListItem("", ""));

        }

        protected void bind_list()
        {
            var list = Serv.GetRep_list(ddlcustype.SelectedValue, ddlyear.SelectedValue, ddlquarter.SelectedValue,
                ddlstatus.SelectedValue);
            if (list.Rows.Count != 0)
            {
                GridView_rep_list.DataSource = list;
                GridView_rep_list.DataBind();
                
            }
            else
            {
                GridView_rep_list.DataSource = null;
                GridView_rep_list.DataBind();
            }
        }

        protected void ddlyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_list();
        }

        protected void ddlquarter_SelectedIndexChanged(object sender, EventArgs e)
        {

            bind_list();
        }

        protected void ddlcustype_SelectedIndexChanged(object sender, EventArgs e)
        {

            bind_list();
        }

        protected void ddlstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            bind_list();
        }

        protected void GridView_rep_list_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_rep_list.PageIndex = e.NewPageIndex;
            this.bind_list();
        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/create_quar_rep.aspx");
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("hddrepid");

            
           
            var rep_history = Serv.GetHistoryLinkByIdDelete(hddrepid.Value);

            if (rep_history.Rows.Count != 0)
            {
                Serv.delete_tblquarter_rep(hddrepid.Value);
                
                bind_list();
            }
            else
            {
                POPUPMSG("ไม่สามารถลบข้อมูลได้");
            }
        }
        
        private void POPUPMSG(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("alert(\'");
            sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("\'", "\\\'"));
            sb.Append("\');");
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
        }
        protected void btnmanage_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("hddrepid");
            HiddenField hddyear = (HiddenField)row.FindControl("hddyear");
            HiddenField hddquarter = (HiddenField)row.FindControl("hddquarter");
            HiddenField hddcustype = (HiddenField)row.FindControl("hddcustype");

            HttpContext.Current.Session["repid"] = hddrepid.Value;
            HttpContext.Current.Session["repYear"] = hddyear.Value;
            HttpContext.Current.Session["repQuar"] = hddquarter.Value;
            HttpContext.Current.Session["repCustype"] = hddcustype.Value;
            
            Response.Redirect("~/executivesummary.aspx");
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("hddrepid");

            // Get Url from 
            var rep_history = Serv.GetHistoryLinkById(hddrepid.Value);

            if (rep_history.Rows.Count != 0)
            {
                Response.Redirect(rep_history.Rows[0]["uri"].ToString());
            }
            else
            {
                POPUPMSG("ไม่พบไฟล์ให้ดาวโหลด");
            }
        }

     

        protected void GridView_rep_list_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Button btnmanage = (Button)(e.Row.FindControl("btnmanage"));
                Button btndownload = (Button)(e.Row.FindControl("btndownload"));
                Button btndelete = (Button)(e.Row.FindControl("btndelete"));

                if(HttpContext.Current.Session["assetdownload"].ToString() == "y")
                {
                    btndownload.Visible = true;
                }
                else
                {
                    btndownload.Visible = false;
                }

                if (HttpContext.Current.Session["assetmanagement"].ToString() == "y")
                {
                    btnmanage.Visible = true;
                    btndelete.Visible = true;
                }
                else
                {
                    btnmanage.Visible = false;
                    btndelete.Visible = false;
                }

            }
        }
    }
}