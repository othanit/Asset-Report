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
    public partial class permitproject : System.Web.UI.Page
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
                    hddmas_rep_id.Value = "99";
                    bind_default();
                    bind_list();
                }
            }
        }

        protected void bind_default()
        {
            var exist = Serv.GetTPProject(hddmas_rep_id.Value);

            if (exist.Rows.Count != 0)
            {
                hddpp_id.Value = exist.Rows[0]["id"].ToString();

                var sub1 = Serv.GetTPProject_sub(hddpp_id.Value, "1");

                if (sub1.Rows.Count != 0)
                {
                    project_sub_id1.Value = sub1.Rows[0]["id"].ToString();
                    ProjectName1.Text = sub1.Rows[0]["projectname"].ToString();
                    ProjectDetail1.Text = sub1.Rows[0]["detail"].ToString();
                    ProjectOpinion1.Text = sub1.Rows[0]["opinion"].ToString();
                    divOther1.Visible = true;
                }
                else
                {
                    Serv.Inserttpproject_sub(hddpp_id.Value, "1", "", "", "");
                    var sub1New = Serv.GetTPProject_sub(hddpp_id.Value, "1");

                    if (sub1New.Rows.Count != 0)
                    {
                        project_sub_id1.Value = sub1New.Rows[0]["id"].ToString();
                    }
                }

                var sub2 = Serv.GetTPProject_sub(hddpp_id.Value, "2");

                if (sub2.Rows.Count != 0)
                {
                    project_sub_id2.Value = sub2.Rows[0]["id"].ToString();
                    ProjectName2.Text = sub2.Rows[0]["projectname"].ToString();
                    ProjectDetail2.Text = sub2.Rows[0]["detail"].ToString();
                    ProjectOpinion2.Text = sub2.Rows[0]["opinion"].ToString();
                    divOther2.Visible = true;
                }
                else
                {
                    Serv.Inserttpproject_sub(hddpp_id.Value, "2", "", "", "");
                    var sub2New = Serv.GetTPProject_sub(hddpp_id.Value, "2");

                    if (sub2New.Rows.Count != 0)
                    {
                        project_sub_id2.Value = sub2New.Rows[0]["id"].ToString();
                    }
                }

                var sub3 = Serv.GetTPProject_sub(hddpp_id.Value, "3");

                if (sub3.Rows.Count != 0)
                {
                    project_sub_id3.Value = sub3.Rows[0]["id"].ToString();
                    ProjectName3.Text = sub3.Rows[0]["projectname"].ToString();
                    ProjectDetail3.Text = sub3.Rows[0]["detail"].ToString();
                    ProjectOpinion3.Text = sub3.Rows[0]["opinion"].ToString();
                    divOther3.Visible = true;

                }
                else
                {
                    Serv.Inserttpproject_sub(hddpp_id.Value, "3", "", "", "");
                    var sub3New = Serv.GetTPProject_sub(hddpp_id.Value, "3");

                    if (sub3New.Rows.Count != 0)
                    {
                        project_sub_id3.Value = sub3New.Rows[0]["id"].ToString();
                    }
                }

                var sub4 = Serv.GetTPProject_sub(hddpp_id.Value, "4");

                if (sub4.Rows.Count != 0)
                {
                    project_sub_id4.Value = sub4.Rows[0]["id"].ToString();
                    ProjectName4.Text = sub4.Rows[0]["projectname"].ToString();
                    ProjectDetail4.Text = sub4.Rows[0]["detail"].ToString();
                    ProjectOpinion4.Text = sub4.Rows[0]["opinion"].ToString();
                    divOther4.Visible = true;
                }
                else
                {
                    Serv.Inserttpproject_sub(hddpp_id.Value, "4", "", "", "");
                    var sub4New = Serv.GetTPProject_sub(hddpp_id.Value, "4");

                    if (sub4New.Rows.Count != 0)
                    {
                        project_sub_id4.Value = sub4New.Rows[0]["id"].ToString();
                    }
                }

                var sub5 = Serv.GetTPProject_sub(hddpp_id.Value, "5");

                if (sub5.Rows.Count != 0)
                {
                    project_sub_id5.Value = sub5.Rows[0]["id"].ToString();
                    ProjectName5.Text = sub5.Rows[0]["projectname"].ToString();
                    ProjectDetail5.Text = sub5.Rows[0]["detail"].ToString();
                    ProjectOpinion5.Text = sub5.Rows[0]["opinion"].ToString();
                    divOther5.Visible = true;
                }
                else
                {
                    Serv.Inserttpproject_sub(hddpp_id.Value, "5", "", "", "");
                    var sub5New = Serv.GetTPProject_sub(hddpp_id.Value, "5");

                    if (sub5New.Rows.Count != 0)
                    {
                        project_sub_id5.Value = sub5New.Rows[0]["id"].ToString();
                    }
                }
            }
            else
            {
                var project = Serv.Inserttpproject(hddmas_rep_id.Value);

                if (project.Rows.Count != 0)
                {
                    hddpp_id.Value = project.Rows[0]["id"].ToString();
                    Serv.Inserttpproject_sub(hddpp_id.Value, "", "", "", "");
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
            if (!divOther2.Visible)
            {
                divOther2.Visible = true;

                Serv.Inserttpproject_sub(hddpp_id.Value, "2", ProjectName2.Text, ProjectDetail2.Text, ProjectOpinion2.Text);

                var project2 = Serv.GetTPProject_sub(hddpp_id.Value, "2");

                if (project2.Rows.Count != 0)
                {
                    project_sub_id2.Value = project2.Rows[0]["id"].ToString();
                }

            }
            else if (!divOther3.Visible)
            {
                divOther3.Visible = true;

                Serv.Inserttpproject_sub(hddpp_id.Value, "3", ProjectName3.Text, ProjectDetail3.Text, ProjectOpinion3.Text);

                var project3 = Serv.GetTPProject_sub(hddpp_id.Value, "3");

                if (project3.Rows.Count != 0)
                {
                    project_sub_id3.Value = project3.Rows[0]["id"].ToString();
                }

            }
            else if (!divOther4.Visible)
            {
                divOther4.Visible = true;

                Serv.Inserttpproject_sub(hddpp_id.Value, "4", ProjectName4.Text, ProjectDetail4.Text, ProjectOpinion4.Text);

                var project4 = Serv.GetTPProject_sub(hddpp_id.Value, "4");

                if (project4.Rows.Count != 0)
                {
                    project_sub_id2.Value = project4.Rows[0]["id"].ToString();
                }

            }
            else if (!divOther5.Visible)
            {
                divOther5.Visible = true;

                Serv.Inserttpproject_sub(hddpp_id.Value, "5", ProjectName5.Text, ProjectDetail5.Text, ProjectOpinion5.Text);

                var project5 = Serv.GetTPProject_sub(hddpp_id.Value, "5");

                if (project5.Rows.Count != 0)
                {
                    project_sub_id5.Value = project5.Rows[0]["id"].ToString();
                }

            }
        }

        protected void PermitFormSaveSubmit_Click(object sender, EventArgs e)
        {
            //1

            Serv.Updatetpproject_sub(hddpp_id.Value, "1", ProjectName1.Text, ProjectDetail1.Text, ProjectOpinion1.Text, project_sub_id1.Value, "project_status");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //2
            Serv.Updatetpproject_sub(hddpp_id.Value, "2", ProjectName2.Text, ProjectDetail2.Text, ProjectOpinion2.Text, project_sub_id2.Value, "project_status");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //3
            Serv.Updatetpproject_sub(hddpp_id.Value, "3", ProjectName3.Text, ProjectDetail3.Text, ProjectOpinion3.Text, project_sub_id3.Value, "project_status");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //4
            Serv.Updatetpproject_sub(hddpp_id.Value, "4", ProjectName4.Text, ProjectDetail4.Text, ProjectOpinion4.Text, project_sub_id4.Value, "project_status");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //5
            Serv.Updatetpproject_sub(hddpp_id.Value, "5", ProjectName5.Text, ProjectDetail5.Text, ProjectOpinion5.Text, project_sub_id5.Value, "project_status");
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
            var rep_history = Serv.GetHistoryLinkByIdApprove(hddmas_rep_id.Value, "project_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_rep(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "project_status");

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
            var rep_history = Serv.GetHistoryLinkByIdReject(hddmas_rep_id.Value, "project_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_Reject(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "project_status");

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