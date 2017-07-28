using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class reptmp_add : System.Web.UI.Page
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

                    bind_default();
                }
            }
        }

        protected void bind_default()
        {
            var x = Serv.GetRep_tmp(ddlRepType.SelectedValue);
            if (x.Rows.Count != 0)
            {
                hddTmpid.Value = x.Rows[0]["id"].ToString();
                lbFileName.Text = x.Rows[0]["report_name"].ToString();
                hddfile_path.Value = x.Rows[0]["file_path"].ToString();
            }
            else
            {
                hddTmpid.Value = "";
                lbFileName.Text = "";
                hddfile_path.Value = "";
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int version = 0;

            var x = Serv.GetVersion_repType(ddlRepType.SelectedValue);
            if (x.Rows.Count != 0)
            {
                version = Convert.ToInt32(x.Rows[0]["version"].ToString()) + 1;
            }
            else
            {
                version = 1;
            }

            if (FileUpload1.HasFile)
            {
                string[] segments = FileUpload1.FileName.Split('.');
                string fileExt = segments[segments.Length - 1];

                if(fileExt == "dotx")
                {
                    string filename = DateTime.Now.ToString("yyMMddHHsss") + Path.GetFileName(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/tmp_rep/") + filename);

                    Serv.Update_TMP_REP(ddlRepType.SelectedValue);

                    Serv.Insert_TMP_REP(ddlRepType.SelectedValue, ddlRepType.SelectedItem.Text + " Template V." + version, Server.MapPath("~/tmp_rep/") + filename, "~/tmp_rep/" + filename, HttpContext.Current.Session["assetusername"].ToString(),
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetusername"].ToString(), Convert.ToString(version), "y");

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('บันทึกเรียบร้อย');window.location ='reptmp.aspx';", true);
                }
                else
                {
                    POPUPMSG("กรุณา Import File (dotx) เท่านั้น");
                    return;
                }

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

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            if (hddfile_path.Value != "")
            {
                Response.Redirect(hddfile_path.Value);
            }
        }

        protected void ddlRepType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_default();
        }
    }
}