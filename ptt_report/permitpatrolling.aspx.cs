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
    public partial class permitpatrolling : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
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
                }
            }
        }

        protected void bind_default()
        {
            var rep_doc = Serv.GetRep_HisALL();
            if (rep_doc.Rows.Count != 0)
            {
                hddfile_path.Value = rep_doc.Rows[0]["uri"].ToString();

            }
            var patrolling = Serv.GetTPPatrolling(hddmas_rep_id.Value);

            if (patrolling.Rows.Count != 0)
            {
                hddtpprotrolling_id.Value = patrolling.Rows[0]["id"].ToString();

                PermitPatrolGasDetector.Text = patrolling.Rows[0]["gasdetector"].ToString();
                PermitPatrolWorkNearPipe.Text = patrolling.Rows[0]["gassiteamount"].ToString();
                PermitPatrolWorkNearPipeNote.Text = patrolling.Rows[0]["gassitedetail"].ToString();
                PermitPatrolNotiLabelAmount.Text = patrolling.Rows[0]["labelandstealamount"].ToString();
                PermitPatrolNotiLabelNote.Text = patrolling.Rows[0]["labelandstealdetail"].ToString();
                PermitPatrolTestPostAmount.Text = patrolling.Rows[0]["testpostdamageamount"].ToString();
                PermitPatrolTestPostNote.Text = patrolling.Rows[0]["testpostdamagedetail"].ToString();


                PermitPatrolAreaScourPipeAmount.Text = patrolling.Rows[0]["scourareaamount"].ToString();
                PermitPatrolAreadScourNote.Text = patrolling.Rows[0]["scourareadetail"].ToString();
                PermitPatrolPoachAmount.Text = patrolling.Rows[0]["buildingpipepathamount"].ToString();
                PermitPatrolPoachNote.Text = patrolling.Rows[0]["buildingpipepathdetail"].ToString();
                PermitPatrolROVAmount.Text = patrolling.Rows[0]["rovfreespanamount"].ToString();
                PermitPatrolROVNote.Text = patrolling.Rows[0]["rovfreespandetail"].ToString();
                PermitPatrolFeedback.Text = patrolling.Rows[0]["opinion"].ToString();

            }
            else
            {
               var x =  Serv.InserttpPatrolling(hddmas_rep_id.Value, "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                

                if (x.Rows.Count != 0)
                    hddtpprotrolling_id.Value = x.Rows[0]["id"].ToString();

            }


        }


        protected void btnImport_Click(object sender, EventArgs e)
        {
            PermitPatrolGasDetector.Text = "ไม่พบการรั่วไหล";
            PermitPatrolWorkNearPipe.Text = "64";
            PermitPatrolNotiLabelAmount.Text = "6";
            PermitPatrolTestPostAmount.Text = "3";
            PermitPatrolAreaScourPipeAmount.Text = "4";
            PermitPatrolAreadScourNote.Text = "เป็นเส้นท่อ RC400 จำนวน 2 จุด, RC0650 จำนวน 2จุด โดยทุกจุดยังคงมีความเสี่ยงต่ำ จึงคอยเฝ้าระวัง เพื่อไม่ให้เกิดผลกระทบต่อท่อส่งก๊าซธรรมชาติ";
            PermitPatrolPoachAmount.Text = "2";
            PermitPatrolROVAmount.Text = "10";
        }


        protected void PermitPatrolFormSaveSubmit_Click(object sender, EventArgs e)
        {
            Serv.UpdatetpPatrolling(hddmas_rep_id.Value, PermitPatrolGasDetector.Text, PermitPatrolWorkNearPipe.Text, PermitPatrolWorkNearPipeNote.Text, PermitPatrolNotiLabelAmount.Text, PermitPatrolNotiLabelNote.Text, PermitPatrolTestPostAmount.Text, PermitPatrolTestPostNote.Text, PermitPatrolAreaScourPipeAmount.Text, PermitPatrolAreadScourNote.Text, PermitPatrolPoachAmount.Text, PermitPatrolPoachNote.Text, PermitPatrolROVAmount.Text, PermitPatrolROVNote.Text, PermitPatrolFeedback.Text, hddtpprotrolling_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "patrolling_status");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/history_2.aspx?param=2&tprepid=" + hddmas_rep_id.Value);
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            if (hddfile_path.Value != "")
            {
                Response.Redirect(hddfile_path.Value);
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
                        "~/gen_1/TP_report_" + time + ".docx", "2", "",hddmas_rep_id.Value);

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
        protected void bind_list()
        {

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
            var rep_history = Serv.GetHistoryLinkByIdApprove(hddmas_rep_id.Value, "patrolling_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_rep(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "patrolling_status");

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
            var rep_history = Serv.GetHistoryLinkByIdReject(hddmas_rep_id.Value, "patrolling_status");

            if (rep_history.Rows.Count != 0)
            {
                Serv.UpdateStatus_Reject(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "patrolling_status");

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