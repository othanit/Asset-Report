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
    public partial class piroffshorepig : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        piroffspDLL Serv = new piroffspDLL();

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

            var pipeline = Serv.GetPIROffSPPipeline(hddmas_rep_id.Value);
            if (pipeline.Rows.Count != 0)
            {
                pipeline_id.Value = pipeline.Rows[0]["id"].ToString();
                TextBox1.Text = pipeline.Rows[0]["startupyear"].ToString();
                TextBox2.Text = pipeline.Rows[0]["designpresure"].ToString();
                TextBox3.Text = pipeline.Rows[0]["station"].ToString();
                TextBox4.Text = pipeline.Rows[0]["maop"].ToString();
                TextBox5.Text = pipeline.Rows[0]["length"].ToString();
                TextBox6.Text = pipeline.Rows[0]["maopdesign"].ToString();
                TextBox7.Text = pipeline.Rows[0]["wallthickness"].ToString();
                TextBox8.Text = pipeline.Rows[0]["olc"].ToString();
                TextBox9.Text = pipeline.Rows[0]["materialspec"].ToString();
                TextBox10.Text = pipeline.Rows[0]["designlife"].ToString();
                TextBox11.Text = pipeline.Rows[0]["externalcoating"].ToString();
                TextBox12.Text = pipeline.Rows[0]["cathodicprotection"].ToString();
                TextBox13.Text = pipeline.Rows[0]["op"].ToString();
                TextBox14.Text = pipeline.Rows[0]["ot"].ToString();
                TextBox15.Text = pipeline.Rows[0]["gfr"].ToString();
                TextBox16.Text = pipeline.Rows[0]["lastilipig"].ToString();
                TextBox17.Text = pipeline.Rows[0]["crusedforrem"].ToString();
                TextBox18.Text = pipeline.Rows[0]["proboffailure"].ToString();
                TextBox19.Text = pipeline.Rows[0]["assessmentdate"].ToString();
                TextBox20.Text = pipeline.Rows[0]["overalldesignlife"].ToString();
                TextBox21.Text = pipeline.Rows[0]["inspectionyear"].ToString();
                TextBox22.Text = pipeline.Rows[0]["b31gpsi"].ToString();
                TextBox23.Text = pipeline.Rows[0]["burstpressure"].ToString();
                TextBox24.Text = pipeline.Rows[0]["erf"].ToString();
                TextBox25.Text = pipeline.Rows[0]["opinion"].ToString();
                TextBox26.Text = pipeline.Rows[0]["overallremainlife"].ToString();
                TextBox27.Text = pipeline.Rows[0]["remainlife"].ToString();

            }
            else
            {
                var x = Serv.Insertpiroffsp_pipeline(hddmas_rep_id.Value, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                {
                    pipeline_id.Value = x.Rows[0]["id"].ToString();

                }
            }

            var iccs = Serv.GetPIROnSUInternelCorrosionControlSystem(hddmas_rep_id.Value);

            if (iccs.Rows.Count != 0)
            {
                iccs_id.Value = iccs.Rows[0]["id"].ToString();
                var ciValue = iccs.Rows[0]["ci"].ToString();

                if (ciValue == "1")
                    ciyes.Checked = true;
                else
                    cino.Checked = true;

                ciiccscomment.Text = iccs.Rows[0]["cicomment"].ToString();

                var ccValue = iccs.Rows[0]["cc"].ToString();

                if (ccValue == "1")
                    ccyes.Checked = true;
                else
                    ccno.Checked = true;

                cciccscomment.Text = iccs.Rows[0]["cccomment"].ToString();

                var cpValue = iccs.Rows[0]["cp"].ToString();

                if (cpValue == "1")
                    cp1.Checked = true;
                else
                    cp2.Checked = true;

                cpiccscomment.Text = iccs.Rows[0]["cpcomment"].ToString();
                opinioniccs.Text = iccs.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpiroffsp_iccs(hddmas_rep_id.Value, "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                {
                    iccs_id.Value = x.Rows[0]["id"].ToString();
                }
            }

            var lma = Serv.GetPIROffSPLastestMaintainanceActivity(hddmas_rep_id.Value);

            if (lma.Rows.Count != 0)
            {
                lma_id.Value = lma.Rows[0]["id"].ToString();
                lmacips.Text = lma.Rows[0]["yearofcips"].ToString();
                lmamfl.Text = lma.Rows[0]["yearofmfl"].ToString();
                lmageo.Text = lma.Rows[0]["yearofgeo"].ToString();
                lmaopinion.Text = lma.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpiroffsp_lma(hddmas_rep_id.Value, "", "", "", "");
                if (x.Rows.Count != 0)
                {
                    lma_id.Value = x.Rows[0]["id"].ToString();
                }

            }


            var ecra = Serv.GetPIROffSP_ecra(hddmas_rep_id.Value);

            if (ecra.Rows.Count != 0)
            {
                ecra_id.Value = ecra.Rows[0]["id"].ToString();

                var sumecra = ecra.Rows[0]["sumresult"].ToString();

                if (sumecra == "1")
                    sumecra1.Checked = true;
                else
                    sumecra2.Checked = true;

                var cpecra = ecra.Rows[0]["cp"].ToString();

                if (cpecra == "1")
                    cpecra1.Checked = true;
                else
                    cpecra2.Checked = true;

                var ecdmp = ecra.Rows[0]["ecdmp"].ToString();

                if (ecdmp == "1")
                    ecdmpecra1.Checked = true;
                else if (ecdmp == "2")
                    ecdmpecra2.Checked = true;
                else if (ecdmp == "3")
                    ecdmpecra3.Checked = true;
                else
                    ecdmpecra4.Checked = true;

                var ecrp = ecra.Rows[0]["ecrp"].ToString();

                if (ecrp == "1")
                    ecrpecra1.Checked = true;
                else if (ecrp == "2")
                    ecrpecra2.Checked = true;
                else if (ecrp == "3")
                    ecrpecra3.Checked = true;
                else
                    ecrpecra4.Checked = true;


                detailecra.Text = ecra.Rows[0]["detail"].ToString();
                mflresultecra.Text = ecra.Rows[0]["mflpresult"].ToString();
                opinionecra.Text = ecra.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpiroffsp_ecra(hddmas_rep_id.Value, "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                    ecra_id.Value = x.Rows[0]["id"].ToString(); ;

            }

            var icra = Serv.GetPIROffSP_icra(hddmas_rep_id.Value);

            if (icra.Rows.Count != 0)
            {
                icra_id.Value = icra.Rows[0]["id"].ToString();

                var sumicra = icra.Rows[0]["sumresult"].ToString();

                if (sumicra == "1")
                    sumicra1.Checked = true;
                else
                    sumicra2.Checked = true;


                var wcmicra = icra.Rows[0]["wcm"].ToString();

                if (wcmicra == "1")
                    wcmicra1.Checked = true;
                else
                    wcmicra2.Checked = true;

                var icdmpicra = icra.Rows[0]["icdmp"].ToString();

                if (icdmpicra == "1")
                    icdmpicra1.Checked = true;
                else if (icdmpicra == "2")
                    icdmpicra2.Checked = true;
                else if (icdmpicra == "3")
                    icdmpicra3.Checked = true;
                else
                    icdmpicra4.Checked = true;


                var icrpicra = icra.Rows[0]["icrp"].ToString();

                if (icrpicra == "1")
                    icrpicra1.Checked = true;
                else if (icrpicra == "2")
                    icrpicra2.Checked = true;
                else if (icrpicra == "3")
                    icrpicra3.Checked = true;
                else
                    icrpicra4.Checked = true;

                detailicra.Text = icra.Rows[0]["detail"].ToString();
                opinionicra.Text = icra.Rows[0]["opinion"].ToString();


            }
            else
            {
                var x = Serv.Insertpiroffsp_icra(hddmas_rep_id.Value, "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                    icra_id.Value = x.Rows[0]["id"].ToString();

            }

            var md = Serv.GetPIROffSPMechanical(hddmas_rep_id.Value);

            if (md.Rows.Count != 0)
            {
                md_id.Value = md.Rows[0]["id"].ToString();

                var summd = md.Rows[0]["sumresult"].ToString();

                if (summd == "1")
                    summd1.Checked = true;
                else
                    summd2.Checked = true;

                var ccdmd = md.Rows[0]["ccd"].ToString();

                if (ccdmd == "1")
                    ccdmd1.Checked = true;
                else
                    ccdmd2.Checked = true;

                var dentmd = md.Rows[0]["dent"].ToString();

                if (dentmd == "1")
                    dentmd1.Checked = true;
                else
                    dentmd2.Checked = true;

                detailmd.Text = md.Rows[0]["detail"].ToString();
                manualdetailmd.Text = md.Rows[0]["manualdetail"].ToString();
                opinionmd.Text = md.Rows[0]["opinion"].ToString();


            }
            else
            {
                var x = Serv.Insertpiroffsp_md(hddmas_rep_id.Value, "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                    md_id.Value = x.Rows[0]["id"].ToString();

            }

            var fsra = Serv.GetPIROffSP_fsra(hddmas_rep_id.Value);

            if (fsra.Rows.Count != 0)
            {
                fsra_id.Value = fsra.Rows[0]["id"].ToString();

                var sumfsra = fsra.Rows[0]["sumresult"].ToString();

                if (sumfsra == "1")
                    sumfsra1.Checked = true;
                else
                    sumfsra2.Checked = true;

                detailfsra.Text = fsra.Rows[0]["detail"].ToString();
                opinionfsra.Text = fsra.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpiroffsp_fsra(hddmas_rep_id.Value, "", "", "");


                if (x.Rows.Count != 0)
                    fsra_id.Value = x.Rows[0]["id"].ToString();

            }

            var leakge = Serv.GetPIROffLeakage(hddmas_rep_id.Value);

            if (leakge.Rows.Count != 0)
            {
                leakage_id.Value = leakge.Rows[0]["id"].ToString();

                var sumleakage = leakge.Rows[0]["sumresult"].ToString();

                if (sumleakage == "1")
                    sumleakage1.Checked = true;
                else
                    sumleakage2.Checked = true;

                var lspleakage = leakge.Rows[0]["lsp"].ToString();

                if (lspleakage == "1")
                    lspleakage1.Checked = true;
                else if (lspleakage == "2")
                    lspleakage2.Checked = true;
                else
                    lspleakage3.Checked = true;

                var lplemleakage = leakge.Rows[0]["lplem"].ToString();

                if (lplemleakage == "1")
                    lplemleakage1.Checked = true;
                else if (lplemleakage == "2")
                    lplemleakage2.Checked = true;
                else
                    lplemleakage3.Checked = true;

                var llrleakage = leakge.Rows[0]["llr"].ToString();

                if (llrleakage == "1")
                    llrleakage1.Checked = true;
                else if (llrleakage == "2")
                    llrleakage2.Checked = true;
                else
                    llrleakage3.Checked = true;

                detailleakage.Text = leakge.Rows[0]["detail"].ToString();
                opinionleakage.Text = leakge.Rows[0]["opinion"].ToString();


            }
            else
            {

                var x = Serv.Insertpiroffsp_leakage(hddmas_rep_id.Value, "", "", "", "", "", "");


                if (x.Rows.Count != 0)
                {
                    leakage_id.Value = x.Rows[0]["id"].ToString();
                }

            }

            var prh = Serv.GetPIROffprh(hddmas_rep_id.Value);

            if (prh.Rows.Count != 0)
            {
                prh_id.Value = prh.Rows[0]["id"].ToString();

                var sumprh = prh.Rows[0]["sumresult"].ToString();

                if (sumprh == "1")
                    sumprh1.Checked = true;
                else
                    sumprh2.Checked = true;

                detailprh.Text = prh.Rows[0]["detail"].ToString();
                opinionprh.Text = prh.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpiroffsp_prh(hddmas_rep_id.Value, "", "", "");


                if (x.Rows.Count != 0)
                {
                    prh_id.Value = x.Rows[0]["id"].ToString();
                }

            }

            var comment = Serv.GetPIROffSPRecommedation(hddmas_rep_id.Value);

            if (comment.Rows.Count != 0)
            {
                comment_id.Value = comment.Rows[0]["id"].ToString();

                detailcomment.Text = comment.Rows[0]["detail"].ToString();
                opinioncomment.Text = comment.Rows[0]["opinion"].ToString();
            }
            else
            {
                var x = Serv.Insertpiroffsp_comment(hddmas_rep_id.Value, "", "");


                if (x.Rows.Count != 0)
                {
                    comment_id.Value = x.Rows[0]["id"].ToString();
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

        protected void PatrollingFormSaveSubmit_Click1(object sender, EventArgs e)
        {


        }

        protected void btnImport_Click(object sender, EventArgs e)
        {

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
                    var pipeline = Serv.GetPIROffSPPipeline(hddmas_rep_id.Value);
                    if (pipeline.Rows.Count != 0)
                    {
                        sel.Find.Text = "[c1]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["startupyear"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c2]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["designpresure"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c3]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["station"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c4]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["maop"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c5]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["length"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c6]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["maopdesign"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c7]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["wallthickness"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c8]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["olc"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c9]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["materialspec"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c10]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["designlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c11]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["externalcoating"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c12]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["cathodicprotection"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c13]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["op"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c14]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["ot"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c15]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["gfr"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c16]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["lastilipig"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c17]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["crusedforrem"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c18]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["proboffailure"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c19]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["assessmentdate"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c20]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["overalldesignlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c21]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["remainlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c22]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["overallremainlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c23]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["inspectionyear"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c24]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["b31gpsi"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c25]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["burstpressure"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[c26]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["erf"].ToString().Replace("\r\n", "\v");
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
                        "~/gen_1/pipeline_report_" + time + ".docx", "5", "",hddmas_rep_id.Value);

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

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            //Serv.UpdateStatus_rep(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
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
            Response.Redirect("~/history_3.aspx?param=5");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_pipeline(hddmas_rep_id.Value, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text, TextBox17.Text, TextBox18.Text, TextBox19.Text, TextBox26.Text, TextBox27.Text, TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox23.Text, TextBox24.Text, TextBox25.Text, pipeline_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void ciyes_CheckedChanged(object sender, EventArgs e)
        {
            ciValue.Value = "1";
        }

        protected void cino_CheckedChanged(object sender, EventArgs e)
        {
            ciValue.Value = "2";
        }

        protected void ccyes_CheckedChanged(object sender, EventArgs e)
        {
            ccValue.Value = "1";
        }

        protected void ccno_CheckedChanged(object sender, EventArgs e)
        {
            ccValue.Value = "2";
        }

        protected void cp1_CheckedChanged(object sender, EventArgs e)
        {
            cpValue.Value = "1";
        }

        protected void cp2_CheckedChanged(object sender, EventArgs e)
        {
            cpValue.Value = "2";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_iccs(hddmas_rep_id.Value, ciValue.Value, ciiccscomment.Text, ccValue.Value, cciccscomment.Text, cpValue.Value, cpiccscomment.Text, opinioniccs.Text, iccs_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_lma(hddmas_rep_id.Value, lmacips.Text, lmamfl.Text, lmageo.Text, lmaopinion.Text, lma_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void sumecra1_CheckedChanged(object sender, EventArgs e)
        {
            sumecraValue.Value = "1";
        }

        protected void sumecra2_CheckedChanged(object sender, EventArgs e)
        {
            sumecraValue.Value = "2";
        }

        protected void cpecra1_CheckedChanged(object sender, EventArgs e)
        {
            cpecraValue.Value = "1";
        }

        protected void cpecra2_CheckedChanged(object sender, EventArgs e)
        {
            cpecraValue.Value = "2";
        }

        protected void ecdmpecra1_CheckedChanged(object sender, EventArgs e)
        {
            ecdmpecraValue.Value = "1";
        }

        protected void ecdmpecra2_CheckedChanged(object sender, EventArgs e)
        {
            ecdmpecraValue.Value = "2";
        }

        protected void ecdmpecra3_CheckedChanged(object sender, EventArgs e)
        {
            ecdmpecraValue.Value = "3";
        }

        protected void ecdmpecra4_CheckedChanged(object sender, EventArgs e)
        {
            ecdmpecraValue.Value = "4";
        }

        protected void ecrpecra1_CheckedChanged(object sender, EventArgs e)
        {
            ecraecrpValue.Value = "1";
        }

        protected void ecrpecra2_CheckedChanged(object sender, EventArgs e)
        {
            ecraecrpValue.Value = "2";
        }

        protected void ecrpecra3_CheckedChanged(object sender, EventArgs e)
        {
            ecraecrpValue.Value = "3";
        }

        protected void ecrpecra4_CheckedChanged(object sender, EventArgs e)
        {
            ecraecrpValue.Value = "4";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_ecra(hddmas_rep_id.Value, sumecraValue.Value, cpecraValue.Value, ecdmpecraValue.Value, ecraecrpValue.Value, detailecra.Text, mflresultecra.Text, opinionecra.Text, ecra_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_icra(hddmas_rep_id.Value, sumicraValue.Value, wcmicraVale.Value, icdmpicraValue.Value, icrpicraValue.Value, detailicra.Text, opinionicra.Text, icra_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void sumicra1_CheckedChanged(object sender, EventArgs e)
        {
            sumicraValue.Value = "1";
        }

        protected void sumicra2_CheckedChanged(object sender, EventArgs e)
        {
            sumicraValue.Value = "2";
        }

        protected void wcmicra1_CheckedChanged(object sender, EventArgs e)
        {
            wcmicraVale.Value = "1";
        }

        protected void wcmicra2_CheckedChanged(object sender, EventArgs e)
        {
            wcmicraVale.Value = "2";
        }

        protected void icdmpicra1_CheckedChanged(object sender, EventArgs e)
        {
            icdmpicraValue.Value = "1";
        }

        protected void icdmpicra2_CheckedChanged(object sender, EventArgs e)
        {
            icdmpicraValue.Value = "2";
        }

        protected void icdmpicra3_CheckedChanged(object sender, EventArgs e)
        {
            icdmpicraValue.Value = "3";
        }

        protected void icdmpicra4_CheckedChanged(object sender, EventArgs e)
        {
            icdmpicraValue.Value = "4";
        }

        protected void icrpicra1_CheckedChanged(object sender, EventArgs e)
        {
            icrpicraValue.Value = "1";
        }

        protected void icrpicra2_CheckedChanged(object sender, EventArgs e)
        {
            icrpicraValue.Value = "2";
        }

        protected void icrpicra3_CheckedChanged(object sender, EventArgs e)
        {
            icrpicraValue.Value = "3";
        }

        protected void icrpicra4_CheckedChanged(object sender, EventArgs e)
        {
            icrpicraValue.Value = "4";
        }

        protected void summd1_CheckedChanged(object sender, EventArgs e)
        {
            summdValue.Value = "1";
        }

        protected void summd2_CheckedChanged(object sender, EventArgs e)
        {
            summdValue.Value = "2";
        }

        protected void ccdmd1_CheckedChanged(object sender, EventArgs e)
        {
            ccdmdValue.Value = "1";
        }

        protected void ccdmd2_CheckedChanged(object sender, EventArgs e)
        {
            ccdmdValue.Value = "2";
        }

        protected void dentmd1_CheckedChanged(object sender, EventArgs e)
        {
            dentmdValue.Value = "1";
        }

        protected void dentmd2_CheckedChanged(object sender, EventArgs e)
        {
            dentmdValue.Value = "2";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_md(hddmas_rep_id.Value, summdValue.Value, ccdmdValue.Value, dentmdValue.Value, detailmd.Text, manualdetailmd.Text, opinionmd.Text, md_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_fsra(hddmas_rep_id.Value, sumfsraValue.Value, detailfsra.Text, opinionfsra.Text, fsra_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void sumfsra1_CheckedChanged(object sender, EventArgs e)
        {
            sumfsraValue.Value = "1";
        }

        protected void sumfsra2_CheckedChanged(object sender, EventArgs e)
        {
            sumfsraValue.Value = "2";
        }

        protected void sumleakage1_CheckedChanged(object sender, EventArgs e)
        {
            sumleakageValue.Value = "1";
        }

        protected void sumleakage2_CheckedChanged(object sender, EventArgs e)
        {
            sumleakageValue.Value = "2";
        }

        protected void lspleakage1_CheckedChanged(object sender, EventArgs e)
        {
            lspleakageValue.Value = "1";
        }

        protected void lspleakage2_CheckedChanged(object sender, EventArgs e)
        {
            lspleakageValue.Value = "2";
        }

        protected void lspleakage3_CheckedChanged(object sender, EventArgs e)
        {
            lspleakageValue.Value = "3";
        }

        protected void lplemleakage1_CheckedChanged(object sender, EventArgs e)
        {
            lplemleakageValue.Value = "1";
        }

        protected void lplemleakage2_CheckedChanged(object sender, EventArgs e)
        {
            lplemleakageValue.Value = "2";
        }

        protected void lplemleakage3_CheckedChanged(object sender, EventArgs e)
        {
            lplemleakageValue.Value = "3";
        }

        protected void llrleakage1_CheckedChanged(object sender, EventArgs e)
        {
            llrleakageValue.Value = "1";
        }

        protected void llrleakage2_CheckedChanged(object sender, EventArgs e)
        {
            llrleakageValue.Value = "2";
        }

        protected void llrleakage3_CheckedChanged(object sender, EventArgs e)
        {
            llrleakageValue.Value = "3";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_leakage(hddmas_rep_id.Value, sumleakageValue.Value, lspleakageValue.Value, lplemleakageValue.Value, llrleakageValue.Value, detailleakage.Text, opinionleakage.Text, leakage_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_prh(hddmas_rep_id.Value, sumprhValue.Value, detailprh.Text, opinionprh.Text, prh_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void sumprh1_CheckedChanged(object sender, EventArgs e)
        {
            sumprhValue.Value = "1";
        }

        protected void sumprh2_CheckedChanged(object sender, EventArgs e)
        {
            sumprhValue.Value = "2";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Serv.Updatepiroffsp_comment(hddmas_rep_id.Value, detailcomment.Text, opinioncomment.Text, comment_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }
    }
}