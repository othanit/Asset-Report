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
    public partial class pironshoreunpig : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        pironsuDLL Serv = new pironsuDLL();

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
                    lbCustype.Text = HttpContext.Current.Session["repPermit"].ToString();
                    hddmas_rep_id.Value = HttpContext.Current.Session["repid"].ToString();
                    lbTypeShore.Text = HttpContext.Current.Session["repType"].ToString();
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

            var pipeline = Serv.GetPIROnSUPipeline(hddmas_rep_id.Value);
            if (pipeline.Rows.Count != 0)
            {
                pipeline_id.Value = pipeline.Rows[0]["id"].ToString();
                TextBox1.Text = pipeline.Rows[0]["startupyear"].ToString();
                TextBox2.Text = pipeline.Rows[0]["designpresure"].ToString();
                TextBox3.Text = pipeline.Rows[0]["station"].ToString();
                TextBox14.Text = pipeline.Rows[0]["length"].ToString();
                TextBox4.Text = pipeline.Rows[0]["maop"].ToString();
                TextBox5.Text = pipeline.Rows[0]["wallthickness"].ToString();
                TextBox6.Text = pipeline.Rows[0]["materialspec"].ToString();
                TextBox7.Text = pipeline.Rows[0]["designlife"].ToString();
                TextBox8.Text = pipeline.Rows[0]["externalcoating"].ToString();
                TextBox9.Text = pipeline.Rows[0]["cathodicprotection"].ToString();
                TextBox10.Text = pipeline.Rows[0]["op"].ToString();
                TextBox11.Text = pipeline.Rows[0]["ot"].ToString();
                TextBox12.Text = pipeline.Rows[0]["gfr"].ToString();
                TextBox13.Text = pipeline.Rows[0]["opinion"].ToString();


            }
            else
            {
                var x = Serv.Insertpironsu_pipeline(hddmas_rep_id.Value, "", "", "", "", "", "", "", "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                {
                    pipeline_id.Value = x.Rows[0]["id"].ToString();
                }
            }

            var ecra = Serv.GetPIROnSUExternalCorrosionRiskAssessment(hddmas_rep_id.Value);

            if (ecra.Rows.Count != 0)
            {
                ecra_id.Value = ecra.Rows[0]["id"].ToString();
                var sumValue = ecra.Rows[0]["sumresult"].ToString();

                if (sumValue == "low")
                {
                    summaryLow.Checked = true;
                }
                else
                {
                    summaryHigh.Checked = true;
                }

                var cp = ecra.Rows[0]["cplevel"].ToString();

                if (cp == "1")
                {
                    cp1.Checked = true;
                }
                else
                {
                    cp2.Checked = true;
                }

                var nscp = ecra.Rows[0]["noofstraycurrent"].ToString();

                if (nscp == "1")
                    nscp1.Checked = true;
                else if (nscp == "2")
                    nscp2.Checked = true;
                else if (nscp == "3")
                    nscp3.Checked = true;
                else
                    nscp4.Checked = true;

                var cds = ecra.Rows[0]["coatingdefectsurvey"].ToString();

                if (cds == "1")
                    cds1.Checked = true;
                else if (cds == "2")
                    cds2.Checked = true;
                else if (cds == "3")
                    cds3.Checked = true;
                else if (cds == "4")
                    cds4.Checked = true;
                else if (cds == "5")
                    cds5.Checked = true;
                else
                    cds6.Checked = true;

                var ac = ecra.Rows[0]["acinterference"].ToString();

                if (ac == "1")
                    ac1.Checked = true;
                else if (ac == "2")
                    ac2.Checked = true;
                else if (ac == "3")
                    ac3.Checked = true;
                else
                    ac4.Checked = true;

                ecraDetail.Text = ecra.Rows[0]["detail"].ToString();
                ecraOpinion.Text = ecra.Rows[0]["opinion"].ToString();


            }
            else
            {
                var x = Serv.Insertpironsu_ecra(hddmas_rep_id.Value, "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                {
                    ecra_id.Value = x.Rows[0]["id"].ToString();
                }

            }

            var icra = Serv.GetPIROnSUInternalCorrosionRiskAssessment(hddmas_rep_id.Value);

            if (icra.Rows.Count != 0)
            {
                icra_id.Value = icra.Rows[0]["id"].ToString();
                var sumValue = icra.Rows[0]["sumresult"].ToString();

                if (sumValue == "low")
                    lowicra.Checked = true;
                else
                    highicra.Checked = true;

                var wcm = icra.Rows[0]["watercontentmonitor"].ToString();

                if (wcm == "1")
                    wcm1.Checked = true;
                else
                    wcm2.Checked = true;

                var dpu = icra.Rows[0]["dewpointupset"].ToString();

                if (dpu == "1")
                    dewicra1.Checked = true;
                else if (dpu == "2")
                    dewicra2.Checked = true;
                else if (dpu == "3")
                    dewicra3.Checked = true;
                else
                    dewicra4.Checked = true;

                var coicra = icra.Rows[0]["co2dontent"].ToString();

                if (coicra == "1")
                    co1.Checked = true;
                else
                    co2.Checked = true;


                var h2sicra = icra.Rows[0]["h2scontent"].ToString();

                if (h2sicra == "1")
                    h2s1.Checked = true;
                else
                    h2s2.Checked = true;

                icradetail.Text = icra.Rows[0]["detail"].ToString();
                icraopinion.Text = icra.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpironsu_icra(hddmas_rep_id.Value, "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                {
                    icra_id.Value = x.Rows[0]["id"].ToString();
                }
            }

            var md = Serv.GetPIROnSUMechanical(hddmas_rep_id.Value);

            if (md.Rows.Count != 0)
            {

                md_id.Value = md.Rows[0]["id"].ToString();

                var sumValue = md.Rows[0]["summaryresult"].ToString();

                if (sumValue == "low")
                    md1.Checked = true;
                else
                    md2.Checked = true;

                var ccd = md.Rows[0]["concretecoatingdamage"].ToString();

                if (ccd == "1")
                    ccdyes.Checked = true;
                else
                    ccdno.Checked = true;

                var al = md.Rows[0]["activitylevel"].ToString();

                if (al == "1")
                    al1.Checked = true;
                else if (al == "2")
                    al2.Checked = true;
                else
                    al3.Checked = true;

                detailmd.Text = md.Rows[0]["detail"].ToString();
                opinionmd.Text = md.Rows[0]["opinion"].ToString();


            }
            else
            {
                var x = Serv.Insertpironsu_md(hddmas_rep_id.Value, "", "", "", "", "");
                if (x.Rows.Count != 0)
                {
                    md_id.Value = x.Rows[0]["id"].ToString();
                }
            }

            var lgs = Serv.GetPIROnSUlgs(hddmas_rep_id.Value);

            if (lgs.Rows.Count != 0)
            {
                lgs_id.Value = lgs.Rows[0]["id"].ToString();

                var sumResult = Serv.GetPIROnSUlgs(hddmas_rep_id.Value);

                if (sumResult.Rows.Count != 0)
                {
                    var sumlgs = lgs.Rows[0]["sumresult"].ToString();

                    if (sumlgs == "1")
                        lgsyes.Checked = true;
                    else
                        lgsno.Checked = true;

                    var eps = lgs.Rows[0]["eps"].ToString();

                    if (eps == "1")
                        eps1.Checked = true;
                    else if (eps == "2")
                        eps2.Checked = true;
                    else if (eps == "3")
                        eps3.Checked = true;
                    else
                        eps4.Checked = true;

                    detaillgs.Text = lgs.Rows[0]["detail"].ToString();
                    opinionlgs.Text = lgs.Rows[0]["opinion"].ToString();
                }
            }
            else
            {
                var x = Serv.Insertpironsu_lgs(hddmas_rep_id.Value, "", "", "", "");
                if (x.Rows.Count != 0)
                {
                    lgs_id.Value = x.Rows[0]["id"].ToString();
                }

            }

            var prh = Serv.GetPIROnSUprh(hddmas_rep_id.Value);

            if (prh.Rows.Count != 0)
            {
                prh_id.Value = prh.Rows[0]["id"].ToString();

                var sumprh = prh.Rows[0]["sumresult"].ToString();

                if (sumprh == "1")
                    prhyes.Checked = true;
                else
                    prhno.Checked = true;

                detailprh.Text = prh.Rows[0]["detail"].ToString();
                opinionprh.Text = prh.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpironsu_prh(hddmas_rep_id.Value, "", "", "");

                if (x.Rows.Count != 0)
                    prh_id.Value = x.Rows[0]["id"].ToString();

            }

            var comment = Serv.GetPIROnSURecommedation(hddmas_rep_id.Value);

            if (comment.Rows.Count != 0)
            {
                rc_id.Value = comment.Rows[0]["id"].ToString();
                detailrc.Text = comment.Rows[0]["detail"].ToString();
                opinionrc.Text = comment.Rows[0]["opinion"].ToString();
            }
            else
            {
                var x = Serv.Insertpironsu_comment(hddmas_rep_id.Value, "", "");

                if (x.Rows.Count != 0)
                    rc_id.Value = x.Rows[0]["id"].ToString();

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

        protected void PatrollingFormSaveSubmit_Click1(object sender, EventArgs e)
        {


        }

        protected void btnImport_Click(object sender, EventArgs e)
        {

        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            if (hddfile_path.Value != "")
            {
                Response.Redirect(hddfile_path.Value);
            }
        }


        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/history_3.aspx?param=3");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Serv.Updatepironsu_pipeline(hddmas_rep_id.Value, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox14.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, pipeline_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "pipeline_status");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Serv.Updatepironsu_ecra(hddmas_rep_id.Value, ecrasumValue.Value, cplevelValue.Value, nscpValue.Value, cdsValue.Value, acValue.Value, ecraDetail.Text, ecraOpinion.Text, ecra_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "pipeline_status");
        }

        protected void summaryLow_CheckedChanged(object sender, EventArgs e)
        {
            ecrasumValue.Value = "low";
        }

        protected void summaryHigh_CheckedChanged(object sender, EventArgs e)
        {
            ecrasumValue.Value = "high";
        }

        protected void cp1_CheckedChanged(object sender, EventArgs e)
        {
            cplevelValue.Value = "1";
        }

        protected void cp2_CheckedChanged(object sender, EventArgs e)
        {
            cplevelValue.Value = "2";
        }

        protected void nscp1_CheckedChanged1(object sender, EventArgs e)
        {
            nscpValue.Value = "1";
        }

        protected void nscp2_CheckedChanged(object sender, EventArgs e)
        {
            nscpValue.Value = "2";
        }

        protected void nscp3_CheckedChanged(object sender, EventArgs e)
        {
            nscpValue.Value = "3";
        }

        protected void nscp4_CheckedChanged(object sender, EventArgs e)
        {
            nscpValue.Value = "4";
        }

        protected void cds1_CheckedChanged(object sender, EventArgs e)
        {
            cdsValue.Value = "1";
        }

        protected void cds2_CheckedChanged(object sender, EventArgs e)
        {
            cdsValue.Value = "2";
        }

        protected void cds3_CheckedChanged(object sender, EventArgs e)
        {
            cdsValue.Value = "3";
        }

        protected void cds4_CheckedChanged(object sender, EventArgs e)
        {
            cdsValue.Value = "4";
        }

        protected void cds5_CheckedChanged(object sender, EventArgs e)
        {
            cdsValue.Value = "5";
        }

        protected void cds6_CheckedChanged(object sender, EventArgs e)
        {
            cdsValue.Value = "6";
        }

        protected void ac1_CheckedChanged(object sender, EventArgs e)
        {
            acValue.Value = "1";
        }

        protected void ac2_CheckedChanged(object sender, EventArgs e)
        {
            acValue.Value = "2";
        }

        protected void ac3_CheckedChanged(object sender, EventArgs e)
        {
            acValue.Value = "3";
        }

        protected void ac4_CheckedChanged(object sender, EventArgs e)
        {
            acValue.Value = "4";
        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            //Serv.Updatepironsu_icra(hddmas_rep_id.Value, sumicraValue.Value, wcmValue.Value, dpuValue.Value, coValue.Value, h2sValue.Value, icradetail.Text, icraopinion.Text, icra_id.Value, HttpContext.Current.Session["assetuserid"].ToString(),"pipeline_status");
        }

        protected void lowicra_CheckedChanged(object sender, EventArgs e)
        {
            sumicraValue.Value = "low";
        }

        protected void highicra_CheckedChanged(object sender, EventArgs e)
        {
            sumicraValue.Value = "high";
        }

        protected void wcm1_CheckedChanged(object sender, EventArgs e)
        {
            wcmValue.Value = "1";
        }

        protected void wcm2_CheckedChanged(object sender, EventArgs e)
        {
            wcmValue.Value = "2";
        }

        protected void dewicra1_CheckedChanged(object sender, EventArgs e)
        {
            dpuValue.Value = "1";
        }

        protected void dewicra2_CheckedChanged(object sender, EventArgs e)
        {
            dpuValue.Value = "2";
        }

        protected void dewicra3_CheckedChanged(object sender, EventArgs e)
        {
            dpuValue.Value = "3";
        }

        protected void dewicra4_CheckedChanged(object sender, EventArgs e)
        {
            dpuValue.Value = "4";
        }

        protected void co1_CheckedChanged(object sender, EventArgs e)
        {
            coValue.Value = "1";
        }

        protected void co2_CheckedChanged(object sender, EventArgs e)
        {
            coValue.Value = "2";
        }

        protected void h2s1_CheckedChanged(object sender, EventArgs e)
        {
            h2sValue.Value = "1";
        }

        protected void h2s2_CheckedChanged(object sender, EventArgs e)
        {
            h2sValue.Value = "2";
        }

        protected void md1_CheckedChanged(object sender, EventArgs e)
        {
            summdValue.Value = "low";
        }

        protected void md2_CheckedChanged(object sender, EventArgs e)
        {
            summdValue.Value = "high";
        }

        protected void ccdyes_CheckedChanged(object sender, EventArgs e)
        {
            ccdValue.Value = "1";
        }

        protected void ccdno_CheckedChanged(object sender, EventArgs e)
        {
            ccdValue.Value = "2";
        }

        protected void al1_CheckedChanged(object sender, EventArgs e)
        {
            alValue.Value = "1";
        }

        protected void al2_CheckedChanged(object sender, EventArgs e)
        {
            alValue.Value = "2";
        }

        protected void al3_CheckedChanged(object sender, EventArgs e)
        {
            alValue.Value = "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Serv.Updatepironsu_md(hddmas_rep_id.Value, summdValue.Value, ccdValue.Value, alValue.Value, detailmd.Text, opinionmd.Text, md_id.Value, HttpContext.Current.Session["assetuserid"].ToString(),"pipeline_status");
        }

        protected void lgsyes_CheckedChanged(object sender, EventArgs e)
        {
            sumlgsValue.Value = "1";
        }

        protected void lgsno_CheckedChanged(object sender, EventArgs e)
        {
            sumlgsValue.Value = "2";
        }

        protected void eps1_CheckedChanged(object sender, EventArgs e)
        {
            epsValue.Value = "1";
        }

        protected void eps2_CheckedChanged(object sender, EventArgs e)
        {
            epsValue.Value = "2";
        }

        protected void eps3_CheckedChanged(object sender, EventArgs e)
        {
            epsValue.Value = "3";
        }

        protected void eps4_CheckedChanged(object sender, EventArgs e)
        {
            epsValue.Value = "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Serv.Updatepironsu_lgs(hddmas_rep_id.Value, sumlgsValue.Value, epsValue.Value, detaillgs.Text, opinionlgs.Text, lgs_id.Value, HttpContext.Current.Session["assetuserid"].ToString(),"pipeline_status");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //Serv.Updatepironsu_comment(hddmas_rep_id.Value, detailrc.Text, opinionrc.Text, rc_id.Value, HttpContext.Current.Session["assetuserid"].ToString(),"pipeline_status");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Serv.Updatepironsu_prh(hddmas_rep_id.Value, prhsumValue.Value, detailprh.Text, opinionprh.Text, prh_id.Value, HttpContext.Current.Session["assetuserid"].ToString(),"pipeline_status");
        }

        protected void prhyes_CheckedChanged(object sender, EventArgs e)
        {
            prhsumValue.Value = "1";
        }

        protected void prhno_CheckedChanged(object sender, EventArgs e)
        {
            prhsumValue.Value = "2";
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
                    var rep_a = Serv.GetPIROnSUPipeline(hddmas_rep_id.Value);
                    if (rep_a.Rows.Count != 0)
                    {
                        sel.Find.Text = "[a1]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["startupyear"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a2]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["designpresure"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a3]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["station"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a4]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["maop"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a5]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["length"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a6]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["wallthickness"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        
                        sel.Find.Text = "[a7]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["materialspec"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        
                        sel.Find.Text = "[a8]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["designlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        
                        sel.Find.Text = "[a9]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["externalcoating"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        
                        sel.Find.Text = "[a10]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["cathodicprotection"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a11]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["op"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a12]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["ot"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[a13]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["gfr"].ToString().Replace("\r\n", "\v");
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

                    doc.SaveAs(Server.MapPath("~/gen_1/pipeline_report_" + time + ".docx"));
                    doc.Close();

                    var x = Serv.InsertHistory(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetusername"].ToString(), "Pipeline_report",
                        "~/gen_1/pipeline_report_" + time + ".docx", "3", "",hddmas_rep_id.Value);

                    hddfile_path.Value = "~/gen_1/pipeline_report_" + time + ".docx";

                    if (x.Rows.Count != 0)
                    {
                        Serv.UpdateHistory(x.Rows[0]["id"].ToString(), "Pipeline_report_V" + x.Rows[0]["id"].ToString(), x.Rows[0]["id"].ToString());
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

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            //var rep_history = Serv.GetHistoryLinkByIdApprove(hddmas_rep_id.Value, "pipeline_status");

            //if (rep_history.Rows.Count != 0)
            //{
            //    Serv.UpdateStatus_rep(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), "ilipig_status");

            //    bind_list();
            //    POPUPMSG("ระบบ Approve ข้อมูลเรียบร้อย");
            //}
            //else
            //{
            //    POPUPMSG("ไม่สามารถ Approve ข้อมูลได้");
            //}
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {

        }
    }
}