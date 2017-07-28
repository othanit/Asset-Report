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
    public partial class pipeline_report : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        pipeline_reportDLL Serv = new pipeline_reportDLL();
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

            var type = Serv.GetRep_type();
            if (type.Rows.Count != 0)
            {
                ddltype.DataTextField = "type";
                ddltype.DataValueField = "type";
                ddltype.DataSource = type;
                ddltype.DataBind();
            }
            else
            {
                ddltype.DataSource = null;
                ddltype.DataBind();
            }
            ddltype.Items.Insert(0, new ListItem("", ""));

            var permit = Serv.GetRep_permit();
            if (permit.Rows.Count != 0)
            {
                ddlpermit.DataTextField = "permit";
                ddlpermit.DataValueField = "permit";
                ddlpermit.DataSource = permit;
                ddlpermit.DataBind();
            }
            else
            {
                ddlpermit.DataSource = null;
                ddlpermit.DataBind();
            }
            ddlpermit.Items.Insert(0, new ListItem("", ""));
            
        }

        protected void bind_list()
        {
            var list = Serv.GetRep_list(ddltype.SelectedValue,ddlyear.SelectedValue,ddlpermit.SelectedValue);
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

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            bind_list();
        }

        protected void ddltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_list();
        }

        protected void ddlpermit_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_list();
        }

        protected void btnmanage_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("hddrepid");
            HiddenField hddyear = (HiddenField)row.FindControl("hddyear");
            HiddenField hddtype = (HiddenField)row.FindControl("hddtype");
            HiddenField hddpermit = (HiddenField)row.FindControl("hddpermit");

            HttpContext.Current.Session["repid"] = hddrepid.Value;
            HttpContext.Current.Session["repYear"] = hddyear.Value;
            HttpContext.Current.Session["repType"] = hddtype.Value;
            HttpContext.Current.Session["repPermit"] = hddpermit.Value;

            Response.Redirect("~/pironshoreunpig.aspx");
        }

        protected void btnEditPremit_Click(object sender, EventArgs e)
        {

        }

        protected void ddlyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_list();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {

        }

        protected void GridView_rep_list_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView_rep_list.PageIndex = e.NewPageIndex;
            this.bind_list();
        }

        protected void GridView_rep_list_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Button btnmanage = (Button)(e.Row.FindControl("btnmanage"));
                Button btndownload = (Button)(e.Row.FindControl("btndownload"));
                Button btndelete = (Button)(e.Row.FindControl("btndelete"));

                if (HttpContext.Current.Session["assetdownload"].ToString() == "y")
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