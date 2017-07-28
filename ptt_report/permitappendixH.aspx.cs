using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;
using Microsoft.Office.Interop.Word;

namespace ptt_report
{
    public partial class permitappendixH : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        QuarterlyReportDLL QServ = new QuarterlyReportDLL();
        tpreportDLL Serv = new tpreportDLL();

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
                    //lbCustype.Text = HttpContext.Current.Session["repCustype"].ToString();
                    hddmas_rep_id.Value = HttpContext.Current.Session["repid"].ToString();
                    bind_default();
                    bind_list();
                }
            }
        }

        protected void bind_default()
        {
            var apdh = Serv.GetTPAppendixH(hddmas_rep_id.Value);

            if (apdh.Rows.Count != 0)
            {
                hddapdh_id.Value = apdh.Rows[0]["id"].ToString();
                AdphOpinion.Text = apdh.Rows[0]["opinion"].ToString();


                var sub = Serv.GetTPAppendixH_sub(hddapdh_id.Value);

                if (sub.Rows.Count != 0)
                {
                    gv.DataSource = sub;
                    gv.DataBind();
                }
                else
                {
                    gv.DataSource = null;
                    gv.DataBind();
                }

            }
            else
            {
                Serv.InsertTPAppendixH(hddmas_rep_id.Value, "");

                var apdhNew = Serv.GetTPAppendixH(hddmas_rep_id.Value);

                if (apdhNew.Rows.Count != 0)
                {
                    hddapdh_id.Value = apdhNew.Rows[0]["id"].ToString();

                    Serv.InsertTPAppendixH_sub(hddapdh_id.Value, "", "", "");

                    var subNew = Serv.GetTPAppendixH_sub(hddapdh_id.Value);

                    if (subNew.Rows.Count != 0)
                    {
                        gv.DataSource = subNew;
                        gv.DataBind();
                    }
                    else
                    {
                        gv.DataSource = null;
                        gv.DataBind();
                    }
                }
            }
        }

        protected void bind_list()
        {

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

            Serv.delete_tblquarter_rep(hddrepid.Value);

            bind_list();

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
            HttpContext.Current.Session["repYear"] = hddyear.Value ;
            HttpContext.Current.Session["repQuar"] = hddquarter.Value;
            HttpContext.Current.Session["repCustype"] = hddcustype.Value;

            Response.Redirect("~/Execut_sum.aspx");
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {
            
        }

        protected void PermitFormSaveSubmit_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gv.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    HiddenField hddid = (HiddenField)row.FindControl("hddid");

                    TextBox subroutecode = (TextBox)row.FindControl("subroutecode");

                    FileUpload subsecondhalfyear = (FileUpload)row.FindControl("subsecondhalfyear");

                    FileUpload subfirsthalfyear = (FileUpload)row.FindControl("subfirsthalfyear");

                    Serv.UpdateTPAppendixH_sub(hddapdh_id.Value, subroutecode.Text, subsecondhalfyear.FileName, subfirsthalfyear.FileName, hddid.Value, "apendixH_status");

                }
            }

            Serv.UpdateTPAppendixH(hddmas_rep_id.Value, AdphOpinion.Text, hddapdh_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "apendixH_status");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Serv.InsertTPAppendixH_sub(hddapdh_id.Value, "", "", "");

            var sub = Serv.GetTPAppendixH_sub(hddapdh_id.Value);
            if (sub.Rows.Count != 0)
            {
                gv.DataSource = sub;
                gv.DataBind();
            }
            else
            {
                gv.DataSource = null;
                gv.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/history_2.aspx?param=2&tprepid=" + hddmas_rep_id.Value);
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            var historyObj = Serv.GetHistoryLinkById(hddmas_rep_id.Value);

            if (historyObj.Rows.Count != 0)
            {
                Response.Redirect(historyObj.Rows[0]["uri"].ToString());
            }
        }

        protected void btnSaveVer_Click(object sender, EventArgs e)
        {
            var app = new Application();
            try
            {
                var rep_tmp = Serv.GetTempRep();
                if (rep_tmp.Rows.Count != 0)
                {
                    //This code creates a document based on the specified template.
                    var doc = app.Documents.Add(Server.MapPath(rep_tmp.Rows[0]["file_path"].ToString()), Visible: false);
                    doc.Activate();

                    var sel = app.Selection;

                    #region A
                    var permit = Serv.GetTPPermit(hddmas_rep_id.Value);
                    if (permit.Rows.Count != 0)
                    {
                        sel.Find.Text = "[a1]";
                        sel.Find.Replacement.Text = permit.Rows[0]["gaspipemaintain"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a2]";
                        sel.Find.Replacement.Text = permit.Rows[0]["projectname"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a3]";
                        sel.Find.Replacement.Text = permit.Rows[0]["pipepath"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a4]";
                        sel.Find.Replacement.Text = permit.Rows[0]["cerfno"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                    }
                    #endregion

                    #region B
                    var es = Serv.GetTPExecutiveSummary(hddmas_rep_id.Value);
                    if (es.Rows.Count != 0)
                    {
                        sel.Find.Text = "[b1]";
                        sel.Find.Replacement.Text = es.Rows[0]["detail"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                    }
                    #endregion

                    #region c
                    var patrolling = Serv.GetTPPatrolling(hddmas_rep_id.Value);

                    if (patrolling.Rows.Count != 0)
                    {

                        sel.Find.Text = "[c1]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["gasdetector"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c2]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["gassiteamount"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c3]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["gassitedetail"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c4]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["labelandstealamount"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c5]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["labelandstealdetail"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c6]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["testpostdamageamount"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c7]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["testpostdamagedetail"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c8]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["scourareaamount"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c9]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["scourareadetail"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c10]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["buildingpipepathamount"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c11]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["buildingpipepathdetail"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        sel.Find.Text = "[c12]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["rovfreespanamount"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c13]";
                        sel.Find.Replacement.Text = patrolling.Rows[0]["rovfreespandetail"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                    }
                    #endregion



                    string time = DateTime.Now.ToString("yyyy-MM-ddHHmmss", EngCI);

                    //************************************************

                    doc.SaveAs(Server.MapPath("~/gen_1/TP_report_" + time + ".docx"));
                    doc.Close();

                    var x = Serv.InsertHistory(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetusername"].ToString(), "TP_report",
                        "~/gen_1/TP_report_" + time + ".docx", "2", "", hddmas_rep_id.Value);

                    hddfile_path.Value = "~/gen_1/TP_report_" + time + ".docx";

                    if (x.Rows.Count != 0)
                    {
                        Serv.UpdateHistory(x.Rows[0]["id"].ToString(), "TP_report_V" + x.Rows[0]["id"].ToString(), x.Rows[0]["id"].ToString(), hddmas_rep_id.Value, "~/gen_1/TP_report_V" + x.Rows[0]["id"].ToString() + "-" + time + ".docx");
                    }

                    POPUPMSG("บันทึกเรียบร้อย");
                }

            }
            finally
            {
                app.Quit();
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

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            var rep_history = Serv.GetHistoryLinkByIdApprove(hddmas_rep_id.Value, "apendixH_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_rep(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "apendixH_status");

                bind_list();
                POPUPMSG("ระบบ Approve ข้อมูลเรียบร้อย");
            }
            else
            {
                POPUPMSG("ไม่สามารถ Approve ข้อมูลได้");
            }
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            var rep_history = Serv.GetHistoryLinkByIdReject(hddmas_rep_id.Value, "apendixH_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_Reject(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "apendixH_status");

                bind_list();
                POPUPMSG("ระบบ Reject ข้อมูลเรียบร้อย");
            }
            else
            {
                POPUPMSG("ไม่สามารถ Reject ข้อมูลได้");
            }
        }
    }
}