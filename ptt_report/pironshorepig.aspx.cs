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
    public partial class pironshorepig : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        pironspDLL Serv = new pironspDLL();

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

            var pipeline = Serv.GetPIROnSPPipeline(hddmas_rep_id.Value);
            if (pipeline.Rows.Count != 0)
            {
                pipeline_id.Value = pipeline.Rows[0]["id"].ToString();
                TextBox1.Text = pipeline.Rows[0]["startupyear"].ToString();
                TextBox2.Text = pipeline.Rows[0]["designpresure"].ToString();
                TextBox3.Text = pipeline.Rows[0]["station"].ToString();
                TextBox4.Text = pipeline.Rows[0]["maop"].ToString();
                TextBox5.Text = pipeline.Rows[0]["length"].ToString();
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
                var x = Serv.Insertpironsp_pipeline(hddmas_rep_id.Value, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");


                if (x.Rows.Count != 0)
                {
                    pipeline_id.Value = x.Rows[0]["id"].ToString();

                }
            }


            var iccs = Serv.GetPIROnSPInternelCorrosionControlSystem(hddmas_rep_id.Value);

            if (iccs.Rows.Count != 0)
            {
                iccs_id.Value = iccs.Rows[0]["id"].ToString();
                var ciValue = iccs.Rows[0]["ci"].ToString();

                if (ciValue == "1")
                    ciiccs1.Checked = true;
                else
                    ciiccs2.Checked = true;



                var ccValue = iccs.Rows[0]["cc"].ToString();

                if (ccValue == "1")
                    cciccs1.Checked = true;
                else
                    cciccs2.Checked = true;

                var cpValue = iccs.Rows[0]["cp"].ToString();

                if (cpValue == "1")
                    cpiccs1.Checked = true;
                else
                    cpiccs2.Checked = true;

                opinioniccs.Text = iccs.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpironsp_iccs(hddmas_rep_id.Value, "", "", "", "");
                if (x.Rows.Count != 0)
                {
                    iccs_id.Value = x.Rows[0]["id"].ToString();
                }
            }

            var lma = Serv.GetPIROnSPLastestMaintainanceActivity(hddmas_rep_id.Value);

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
                var x = Serv.Insertpironsp_lma(hddmas_rep_id.Value, "", "", "", "");
                if (x.Rows.Count != 0)
                {
                    lma_id.Value = x.Rows[0]["id"].ToString();
                }

            }

            var ecra = Serv.GetPIROnSP_ecra(hddmas_rep_id.Value);

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

                var nscpecra = ecra.Rows[0]["nscp"].ToString();

                if (nscpecra == "1")
                    nscpecra1.Checked = true;
                else if (nscpecra == "2")
                    nscpecra2.Checked = true;
                else if (nscpecra == "3")
                    nscpecra3.Checked = true;
                else
                    nscpecra4.Checked = true;

                var cdsecra = ecra.Rows[0]["cds"].ToString();

                if (cdsecra == "1")
                    cdsecra1.Checked = true;
                else if (cdsecra == "2")
                    cdsecra2.Checked = true;
                else if (cdsecra == "3")
                    cdsecra3.Checked = true;
                else if (cdsecra == "4")
                    cdsecra4.Checked = true;
                else if (cdsecra == "5")
                    cdsecra5.Checked = true;
                else
                    cdsecra6.Checked = true;

                var ac = ecra.Rows[0]["ac"].ToString();

                if (ac == "1")
                    ac1.Checked = true;
                else if (ac == "2")
                    ac2.Checked = true;
                else if (ac == "3")
                    ac3.Checked = true;
                else
                    ac4.Checked = true;


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
                opinionecra.Text = ecra.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpironsp_ecra(hddmas_rep_id.Value, "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                    ecra_id.Value = x.Rows[0]["id"].ToString(); ;

            }

            var icra = Serv.GetPIRonSP_icra(hddmas_rep_id.Value);

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

                var dewecra = icra.Rows[0]["dew"].ToString();

                if (dewecra == "1")
                    dewecra1.Checked = true;
                else if (dewecra == "2")
                    dewecra2.Checked = true;
                else if (dewecra == "3")
                    dewecra3.Checked = true;
                else
                    dewecra4.Checked = true;

                var co2icra = icra.Rows[0]["co2"].ToString();

                if (co2icra == "1")
                    co2icra1.Checked = true;
                else
                    co2icra2.Checked = true;

                var h2sicra = icra.Rows[0]["co2"].ToString();

                if (h2sicra == "1")
                    h2sicra1.Checked = true;
                else
                    h2sicra2.Checked = true;


                var icdmpicra = icra.Rows[0]["isdmp"].ToString();

                if (icdmpicra == "1")
                    icdmp1.Checked = true;
                else if (icdmpicra == "2")
                    icdmp2.Checked = true;
                else if (icdmpicra == "3")
                    icdmp3.Checked = true;
                else
                    icdmp4.Checked = true;


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
                var x = Serv.Insertpironsp_icra(hddmas_rep_id.Value, "", "", "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                    icra_id.Value = x.Rows[0]["id"].ToString();

            }


            var md = Serv.GetPIRonSPMechanical(hddmas_rep_id.Value);

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

                var almd = md.Rows[0]["al"].ToString();

                if (almd == "1")
                    al1.Checked = true;
                else if (almd == "2")
                    al2.Checked = true;
                else if (almd == "3")
                    al3.Checked = true;
                else
                    al4.Checked = true;

                var rowmd = md.Rows[0]["rowcondition"].ToString();

                if (rowmd == "1")
                    rowmd1.Checked = true;
                else if (rowmd == "2")
                    rowmd2.Checked = true;
                else if (rowmd == "3")
                    rowmd3.Checked = true;
                else
                    rowmd4.Checked = true;



                detailmd.Text = md.Rows[0]["detail"].ToString();
                opinionmd.Text = md.Rows[0]["opinion"].ToString();


            }
            else
            {
                var x = Serv.Insertpironsu_md(hddmas_rep_id.Value, "", "", "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                    md_id.Value = x.Rows[0]["id"].ToString();

            }

            var tpi = Serv.GetPIRonSPMechanical(hddmas_rep_id.Value);

            if (tpi.Rows.Count != 0)
            {
                tpi_id.Value = tpi.Rows[0]["id"].ToString();

                var sumtpi = tpi.Rows[0]["sumresult"].ToString();

                if (sumtpi == "1")
                    sumtpi1.Checked = true;
                else
                    sumtpi2.Checked = true;

                detailtpi.Text = tpi.Rows[0]["detail"].ToString();

                opiniontpi.Text = tpi.Rows[0]["opinion"].ToString();


            }
            else
            {
                var x = Serv.Insertpironsp_tpi(hddmas_rep_id.Value, "", "", "");


                if (x.Rows.Count != 0)
                    tpi_id.Value = x.Rows[0]["id"].ToString();

            }

            var lgs = Serv.GetPIRonSP_lgs(hddmas_rep_id.Value);

            if (lgs.Rows.Count != 0)
            {
                lgs_id.Value = lgs.Rows[0]["id"].ToString();

                var sumlgs = lgs.Rows[0]["sumresult"].ToString();

                if (sumlgs == "1")
                    lgssum1.Checked = true;
                else
                    lgssum2.Checked = true;

                var epslgs = lgs.Rows[0]["eps"].ToString();

                if (epslgs == "1")
                    eps1.Checked = true;
                else if (epslgs == "2")
                    eps2.Checked = true;
                else if (epslgs == "3")
                    eps3.Checked = true;
                else
                    eps4.Checked = true;

                var fslgs = lgs.Rows[0]["fs"].ToString();

                if (fslgs == "1")
                    fs1.Checked = true;
                else if (fslgs == "2")
                    fs2.Checked = true;
                else
                    fs3.Checked = true;

                var sslgs = lgs.Rows[0]["ss"].ToString();

                if (sslgs == "1")
                    ss1.Checked = true;
                else if (sslgs == "2")
                    ss2.Checked = true;
                else if (sslgs == "3")
                    ss3.Checked = true;
                else
                    ss4.Checked = true;

                detaillgs.Text = lgs.Rows[0]["detail"].ToString();
                opinionlgs.Text = lgs.Rows[0]["opinion"].ToString();

            }
            else
            {
                var x = Serv.Insertpironsp_lgs(hddmas_rep_id.Value, "", "", "", "", "", "");

                if (x.Rows.Count != 0)
                    lgs_id.Value = x.Rows[0]["id"].ToString();
            }

            var prh = Serv.GetPIRonprh(hddmas_rep_id.Value);

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
                var x = Serv.Insertpironsp_prh(hddmas_rep_id.Value, "", "", "");

                if (x.Rows.Count != 0)
                {
                    prh_id.Value = x.Rows[0]["id"].ToString();
                }

            }

            var comment = Serv.GetPIRonSPRecommedation(hddmas_rep_id.Value);

            if (comment.Rows.Count != 0)
            {
                comment_id.Value = comment.Rows[0]["id"].ToString();

                detailcomment.Text = comment.Rows[0]["detail"].ToString();
                opinioncomment.Text = comment.Rows[0]["opinion"].ToString();
            }
            else
            {
                var x = Serv.Insertpironsp_comment(hddmas_rep_id.Value, "", "");

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
            Response.Redirect("~/history_3.aspx?param=4");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_pipeline(hddmas_rep_id.Value, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, TextBox13.Text, TextBox14.Text, TextBox15.Text, TextBox16.Text, TextBox17.Text, TextBox18.Text, TextBox19.Text, TextBox26.Text, TextBox27.Text, TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox23.Text, TextBox24.Text, TextBox25.Text, pipeline_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_iccs(hddmas_rep_id.Value, ciiccsValue.Value, ccciccValue.Value, cpiccs.Value, opinioniccs.Text, iccs_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_lma(hddmas_rep_id.Value, lmacips.Text, lmamfl.Text, lmageo.Text, lmaopinion.Text, lma_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_ecra(hddmas_rep_id.Value, sumecraValue.Value, cpecraValue.Value, nscpecraValue.Value, cdsecraValue.Value, acecraValue.Value, ecdmpecraValue.Value, ecraecrpValue.Value, detailecra.Text, opinionecra.Text, ecra_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
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

        protected void nscpecra1_CheckedChanged(object sender, EventArgs e)
        {
            nscpecraValue.Value = "1";
        }

        protected void nscpecra2_CheckedChanged(object sender, EventArgs e)
        {
            nscpecraValue.Value = "2";
        }

        protected void nscpecra3_CheckedChanged(object sender, EventArgs e)
        {
            nscpecraValue.Value = "3";
        }

        protected void nscpecra4_CheckedChanged(object sender, EventArgs e)
        {
            nscpecraValue.Value = "4";
        }

        protected void cdsecra1_CheckedChanged(object sender, EventArgs e)
        {
            cdsecraValue.Value = "1";
        }

        protected void cdsecra2_CheckedChanged(object sender, EventArgs e)
        {
            cdsecraValue.Value = "2";
        }

        protected void cdsecra3_CheckedChanged(object sender, EventArgs e)
        {
            cdsecraValue.Value = "3";
        }

        protected void cdsecra4_CheckedChanged(object sender, EventArgs e)
        {
            cdsecraValue.Value = "4";
        }

        protected void cdsecra5_CheckedChanged(object sender, EventArgs e)
        {
            cdsecraValue.Value = "5";
        }

        protected void cdsecra6_CheckedChanged(object sender, EventArgs e)
        {
            cdsecraValue.Value = "6";
        }

        protected void ac1_CheckedChanged(object sender, EventArgs e)
        {
            acecraValue.Value = "1";
        }

        protected void ac2_CheckedChanged(object sender, EventArgs e)
        {
            acecraValue.Value = "2";
        }

        protected void ac3_CheckedChanged(object sender, EventArgs e)
        {
            acecraValue.Value = "3";
        }

        protected void ac4_CheckedChanged(object sender, EventArgs e)
        {
            acecraValue.Value = "4";
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

        protected void Button5_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_icra(hddmas_rep_id.Value, sumicraValue.Value, wcmicraValue.Value, dewecraValue.Value, co2icraValue.Value, h2sicraValue.Value, icdmpValue.Value, icrpicraValue.Value, detailicra.Text, opinioniccs.Text, icra_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_tip(hddmas_rep_id.Value, sumtpiValue.Value, detailtpi.Text, opiniontpi.Text, tpi_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_lgs(hddmas_rep_id.Value, sumlgsValue.Value, epslgsValue.Value, fslgsValue.Value, sslgsValue.Value, detaillgs.Text, opinionlgs.Text, lgs_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_prh(hddmas_rep_id.Value, sumprhValue.Value, detailprh.Text, opinionprh.Text, prh_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_comment(hddmas_rep_id.Value, detailcomment.Text, opinioncomment.Text, comment_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void ciiccs1_CheckedChanged(object sender, EventArgs e)
        {
            ciiccsValue.Value = "1";
        }

        protected void ciiccs2_CheckedChanged(object sender, EventArgs e)
        {
            ciiccsValue.Value = "2";
        }

        protected void cciccs1_CheckedChanged(object sender, EventArgs e)
        {
            ccciccValue.Value = "1";
        }

        protected void cciccs2_CheckedChanged(object sender, EventArgs e)
        {
            ccciccValue.Value = "2";
        }

        protected void cpiccs1_CheckedChanged(object sender, EventArgs e)
        {
            cpiccs.Value = "1";
        }

        protected void cpiccs2_CheckedChanged(object sender, EventArgs e)
        {
            cpiccs.Value = "2";
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
            wcmicraValue.Value = "1";
        }

        protected void wcmicra2_CheckedChanged(object sender, EventArgs e)
        {
            wcmicraValue.Value = "2";
        }

        protected void dewecra1_CheckedChanged(object sender, EventArgs e)
        {
            dewecraValue.Value = "1";
        }

        protected void dewecra2_CheckedChanged(object sender, EventArgs e)
        {
            dewecraValue.Value = "2";
        }

        protected void dewecra3_CheckedChanged(object sender, EventArgs e)
        {
            dewecraValue.Value = "3";
        }

        protected void dewecra4_CheckedChanged(object sender, EventArgs e)
        {
            dewecraValue.Value = "4";
        }

        protected void co2icra1_CheckedChanged(object sender, EventArgs e)
        {
            co2icraValue.Value = "1";
        }

        protected void co2icra2_CheckedChanged(object sender, EventArgs e)
        {
            co2icraValue.Value = "2";
        }

        protected void h2sicra1_CheckedChanged(object sender, EventArgs e)
        {
            h2sicraValue.Value = "1";
        }

        protected void h2sicra2_CheckedChanged(object sender, EventArgs e)
        {
            h2sicraValue.Value = "2";
        }

        protected void icdmp1_CheckedChanged(object sender, EventArgs e)
        {
            icdmpValue.Value = "1";
        }

        protected void icdmp2_CheckedChanged(object sender, EventArgs e)
        {
            icdmpValue.Value = "2";
        }

        protected void icdmp3_CheckedChanged(object sender, EventArgs e)
        {
            icdmpValue.Value = "3";
        }

        protected void icdmp4_CheckedChanged(object sender, EventArgs e)
        {
            icdmpValue.Value = "4";
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

        protected void al1_CheckedChanged(object sender, EventArgs e)
        {
            almdValue.Value = "1";
        }

        protected void al2_CheckedChanged(object sender, EventArgs e)
        {
            almdValue.Value = "2";
        }

        protected void al3_CheckedChanged(object sender, EventArgs e)
        {
            almdValue.Value = "3";
        }

        protected void al4_CheckedChanged(object sender, EventArgs e)
        {
            almdValue.Value = "4";
        }

        protected void rowmd1_CheckedChanged(object sender, EventArgs e)
        {
            rowmdValue.Value = "1";
        }

        protected void rowmd2_CheckedChanged(object sender, EventArgs e)
        {
            rowmdValue.Value = "2";
        }

        protected void rowmd3_CheckedChanged(object sender, EventArgs e)
        {
            rowmdValue.Value = "3";
        }

        protected void rowmd4_CheckedChanged(object sender, EventArgs e)
        {
            rowmdValue.Value = "4";
        }

        protected void sumtpi1_CheckedChanged(object sender, EventArgs e)
        {
            sumtpiValue.Value = "1";
        }

        protected void sumtpi2_CheckedChanged(object sender, EventArgs e)
        {
            sumtpiValue.Value = "2";
        }

        protected void lgssum1_CheckedChanged(object sender, EventArgs e)
        {
            sumlgsValue.Value = "1";
        }

        protected void lgssum2_CheckedChanged(object sender, EventArgs e)
        {
            sumlgsValue.Value = "2";
        }

        protected void eps1_CheckedChanged(object sender, EventArgs e)
        {
            epslgsValue.Value = "1";
        }

        protected void eps2_CheckedChanged(object sender, EventArgs e)
        {
            epslgsValue.Value = "2";
        }

        protected void eps3_CheckedChanged(object sender, EventArgs e)
        {
            epslgsValue.Value = "3";
        }

        protected void eps4_CheckedChanged(object sender, EventArgs e)
        {
            epslgsValue.Value = "4";
        }

        protected void fs1_CheckedChanged(object sender, EventArgs e)
        {
            fslgsValue.Value = "1";
        }

        protected void fs2_CheckedChanged(object sender, EventArgs e)
        {
            fslgsValue.Value = "2";
        }

        protected void fs3_CheckedChanged(object sender, EventArgs e)
        {
            fslgsValue.Value = "3";
        }

        protected void ss1_CheckedChanged(object sender, EventArgs e)
        {
            sslgsValue.Value = "1";
        }

        protected void ss2_CheckedChanged(object sender, EventArgs e)
        {
            sslgsValue.Value = "2";
        }

        protected void ss3_CheckedChanged(object sender, EventArgs e)
        {
            sslgsValue.Value = "3";
        }

        protected void ss4_CheckedChanged(object sender, EventArgs e)
        {
            sslgsValue.Value = "4";
        }

        protected void sumprh1_CheckedChanged(object sender, EventArgs e)
        {
            sumprhValue.Value = "1";
        }

        protected void sumprh2_CheckedChanged(object sender, EventArgs e)
        {
            sumprhValue.Value = "2";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Serv.Updatepironsp_md(hddmas_rep_id.Value, summdValue.Value, ccdmdValue.Value, dentmdValue.Value, almdValue.Value, rowmdValue.Value, detailmd.Text, "", opinionmd.Text, md_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
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
                    var pipeline = Serv.GetPIROnSPPipeline(hddmas_rep_id.Value);
                    if (pipeline.Rows.Count != 0)
                    {
                        sel.Find.Text = "[b1]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["startupyear"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b2]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["designpresure"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b3]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["station"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b4]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["maop"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b5]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["length"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b6]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["wallthickness"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b7]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["olc"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b8]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["materialspec"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b9]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["designlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b10]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["externalcoating"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b11]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["cathodicprotection"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b12]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["op"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b13]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["ot"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b14]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["gfr"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        
                        sel.Find.Text = "[b15]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["lastilipig"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b16]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["crusedforrem"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b17]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["proboffailure"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b18]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["assessmentdate"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b19]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["overallremainlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b20]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["remainlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        
                        sel.Find.Text = "[b21]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["overalldesignlife"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b22]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["inspectionyear"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b23]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["b31gpsi"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b24]";
                        sel.Find.Replacement.Text = pipeline.Rows[0]["burstpressure"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[b25]";
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
                        "~/gen_1/pipeline_report_" + time + ".docx", "4", "",hddmas_rep_id.Value);

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
    }
}