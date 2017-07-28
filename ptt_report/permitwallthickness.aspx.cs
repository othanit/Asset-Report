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
    public partial class permitwallthickness : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        tpreportDLL Serv = new tpreportDLL();
        QuarterlyReportDLL QServ = new QuarterlyReportDLL();

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
                    if (HttpContext.Current.Session["assetapprove"].ToString() == "y")
                    {
                        btnApprove.Visible = true;
                        btnReject.Visible = true;
                    }
                    else
                    {
                        btnApprove.Visible = false;
                        btnReject.Visible = false;
                    }
                }
            }
        }

        protected void bind_default()
        {
            var rep_wtn = Serv.GetTPwtn(hddmas_rep_id.Value);

            if (rep_wtn.Rows.Count != 0)
            {
                hddwn_id.Value = rep_wtn.Rows[0]["id"].ToString();

                PermitWallThicknessResult.Text = rep_wtn.Rows[0]["checkresult"].ToString();

                wtnpipe.Text = rep_wtn.Rows[0]["pipe"].ToString();

                wtnstation.Text = rep_wtn.Rows[0]["station"].ToString();

                wtnpipeposition.Text = rep_wtn.Rows[0]["pipeposition"].ToString();

                wtnopinion.Text = rep_wtn.Rows[0]["opinion"].ToString();

                var sub = Serv.GetTPwtn_sub(hddwn_id.Value);

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
                var wtn = Serv.Inserttpwtm(hddmas_rep_id.Value, "", "", "", "", "");

                if (wtn.Rows.Count != 0)
                {
                    hddwn_id.Value = wtn.Rows[0]["id"].ToString();

                    Serv.Inserttpwtn_sub(hddwn_id.Value, "", "", "", "", "", "", "");

                    var sub = Serv.GetTPwtn_sub(hddwn_id.Value);

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
            wtnopinion.Text = "ท่อก๊าซดังกล่าว ส่วนใหญ่ยังคงมีความหนาท่อในระดับปกติ ทั้งนี้พบท่อที่มีการสูญเสียเนื้อเหล็กอย่างมีนัยสำคัญดังนี้";
        }

        protected void PermitFormSaveSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Serv.Inserttpwtn_sub(hddwn_id.Value, "", "", "", "", "", "", "");

            var sub = Serv.GetTPwtn_sub(hddwn_id.Value);
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

        protected void PermitFormSaveSubmit_Click1(object sender, EventArgs e)
        {
            foreach (GridViewRow row in gv.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    HiddenField hddid = (HiddenField)row.FindControl("hddid");

                    TextBox bvstation = (TextBox)row.FindControl("subbvstation");

                    TextBox routecode = (TextBox)row.FindControl("subroutecode");

                    TextBox inspectiondate = (TextBox)row.FindControl("subinspectiondate");

                    TextBox point = (TextBox)row.FindControl("subpoint");

                    TextBox diameter = (TextBox)row.FindControl("subdiameter");

                    TextBox tavg = (TextBox)row.FindControl("subtavg");

                    TextBox tmin = (TextBox)row.FindControl("subtmin");

                    Serv.Updatetpwtn_sub(hddwn_id.Value, bvstation.Text, routecode.Text, inspectiondate.Text, point.Text, diameter.Text, tavg.Text, tmin.Text, hddid.Value);
                }
            }

            Serv.Updatetpwtn(hddmas_rep_id.Value, PermitWallThicknessResult.Text, wtnpipe.Text, wtnstation.Text, wtnpipeposition.Text, wtnopinion.Text, hddwn_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "wall_thick_status");

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
                        Utility.FindAndReplaceText(ref sel, "[a1]", permit.Rows[0]["gaspipemaintain"].ToString());
                        //sel.Find.Text = "[a1]";
                        //sel.Find.Replacement.Text = permit.Rows[0]["gaspipemaintain"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[a2]", permit.Rows[0]["projectname"].ToString());
                        //sel.Find.Text = "[a2]";
                        //sel.Find.Replacement.Text = permit.Rows[0]["projectname"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[a3]", permit.Rows[0]["pipepath"].ToString());
                        //sel.Find.Text = "[a3]";
                        //sel.Find.Replacement.Text = permit.Rows[0]["pipepath"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[a4]", permit.Rows[0]["cerfno"].ToString());
                        //sel.Find.Text = "[a4]";
                        //sel.Find.Replacement.Text = permit.Rows[0]["cerfno"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                    }
                    #endregion

                    #region B
                    var es = Serv.GetTPExecutiveSummary(hddmas_rep_id.Value);
                    if (es.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[b1]", es.Rows[0]["detail"].ToString());
                        //sel.Find.Text = "[b1]";
                        //sel.Find.Replacement.Text = es.Rows[0]["detail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                    }
                    #endregion

                    #region c
                    var patrolling = Serv.GetTPPatrolling(hddmas_rep_id.Value);

                    if (patrolling.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[c1]", patrolling.Rows[0]["gasdetector"].ToString());
                        //sel.Find.Text = "[c1]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["gasdetector"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c2]", patrolling.Rows[0]["gassiteamount"].ToString());
                        //sel.Find.Text = "[c2]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["gassiteamount"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[c3]", patrolling.Rows[0]["gassitedetail"].ToString());
                        //sel.Find.Text = "[c3]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["gassitedetail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[c4]", patrolling.Rows[0]["labelandstealamount"].ToString());
                        //sel.Find.Text = "[c4]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["labelandstealamount"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c5]", patrolling.Rows[0]["labelandstealdetail"].ToString());
                        //sel.Find.Text = "[c5]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["labelandstealdetail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c6]", patrolling.Rows[0]["testpostdamageamount"].ToString());
                        //sel.Find.Text = "[c6]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["testpostdamageamount"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[c7]", patrolling.Rows[0]["testpostdamagedetail"].ToString());
                        //sel.Find.Text = "[c7]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["testpostdamagedetail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c8]", patrolling.Rows[0]["scourareaamount"].ToString());
                        //sel.Find.Text = "[c8]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["scourareaamount"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c9]", patrolling.Rows[0]["scourareadetail"].ToString());
                        //sel.Find.Text = "[c9]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["scourareadetail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c10]", patrolling.Rows[0]["buildingpipepathamount"].ToString());
                        //sel.Find.Text = "[c10]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["buildingpipepathamount"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c11]", patrolling.Rows[0]["buildingpipepathdetail"].ToString());
                        //sel.Find.Text = "[c11]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["buildingpipepathdetail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c12]", patrolling.Rows[0]["rovfreespanamount"].ToString());
                        //sel.Find.Text = "[c12]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["rovfreespanamount"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[c14]", patrolling.Rows[0]["rovfreespandetail"].ToString());
                        //sel.Find.Text = "[c13]";
                        //sel.Find.Replacement.Text = patrolling.Rows[0]["rovfreespandetail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                    }
                    #endregion



                    string time = DateTime.Now.ToString("yyyyMMddHHmm", EngCI);

                    //************************************************

                    
                    var x = Serv.InsertHistory(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetusername"].ToString(), "TP_report",
                        "~/gen_1/TP_report_" + time + ".docx", "2", "", hddmas_rep_id.Value);

                    hddfile_path.Value = "~/gen_1/TP_report_V" + x.Rows[0]["id"].ToString() + "-" + time + ".docx";

                    if (x.Rows.Count != 0)
                    {
                        Serv.UpdateHistory(x.Rows[0]["id"].ToString(), "TP_report_V" + x.Rows[0]["id"].ToString(), x.Rows[0]["id"].ToString(), hddmas_rep_id.Value, "~/gen_1/TP_report_V" + x.Rows[0]["id"].ToString() + "-" + time + ".docx");
                    }
                    doc.SaveAs(Server.MapPath("~/gen_1/TP_report_V" + x.Rows[0]["id"].ToString() + "-" + time + ".docx"));
                    doc.Close();

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
            
            var rep_history = Serv.GetHistoryLinkByIdApprove(hddmas_rep_id.Value, "wall_thick_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_rep(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "wall_thick_status");

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
            var rep_history = Serv.GetHistoryLinkByIdReject(hddmas_rep_id.Value, "wall_thick_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_Reject(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "wall_thick_status");

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