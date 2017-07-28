using Microsoft.Office.Interop.Word;
using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class piping : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        pipingDLL Serv = new pipingDLL();
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
                    lbCustype.Text = HttpContext.Current.Session["repCustype"].ToString();
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

            var exist = Serv.GetExistRep_L(hddmas_rep_id.Value);
            if (exist.Rows.Count != 0)
            {
                hddpiping_id.Value = exist.Rows[0]["id"].ToString();
                txtComment.Text = exist.Rows[0]["opinion"].ToString();


                var sub_piping1 = Serv.Get_tbl_piping_qurter_plan1(hddpiping_id.Value);
                if (sub_piping1.Rows.Count != 0)
                {
                    for (int i = 0; i <= sub_piping1.Rows.Count - 1; i++)
                    {
                        if (i == 0)
                        {
                            lbQuarter.Text = sub_piping1.Rows[i]["l1"].ToString();
                            lbM1.Text = sub_piping1.Rows[i]["l2"].ToString();

                            if (sub_piping1.Rows[i]["type"].ToString() == "1")
                            {
                                lbm111.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm112.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "2")
                            {
                                lbm121.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm122.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "3")
                            {
                                lbm131.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm132.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "4")
                            {
                                lbm141.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm142.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "5")
                            {
                                lbm151.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm152.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "6")
                            {
                                lbm161.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm162.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "7")
                            {
                                lbm171.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm172.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "8")
                            {
                                lbm181.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm182.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "9")
                            {
                                lbm191.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm192.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "10")
                            {
                                lbm101.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm102.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }

                        }
                        else if (i == 1)
                        {
                            lbQuarter.Text = sub_piping1.Rows[i]["l1"].ToString();
                            lbM2.Text = sub_piping1.Rows[i]["l2"].ToString();

                            if (sub_piping1.Rows[i]["type"].ToString() == "1")
                            {
                                lbm211.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm212.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "2")
                            {
                                lbm221.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm222.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "3")
                            {
                                lbm231.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm232.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "4")
                            {
                                lbm241.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm242.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "5")
                            {
                                lbm251.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm252.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "6")
                            {
                                lbm261.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm262.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "7")
                            {
                                lbm271.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm272.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "8")
                            {
                                lbm281.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm282.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "9")
                            {
                                lbm291.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm292.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "10")
                            {
                                lbm201.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm202.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }

                        }
                        else if (i == 2)
                        {
                            lbQuarter.Text = sub_piping1.Rows[i]["l1"].ToString();
                            lbM3.Text = sub_piping1.Rows[i]["l2"].ToString();

                            if (sub_piping1.Rows[i]["type"].ToString() == "1")
                            {
                                lbm311.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm312.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "2")
                            {
                                lbm321.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm322.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "3")
                            {
                                lbm331.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm332.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "4")
                            {
                                lbm341.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm342.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "5")
                            {
                                lbm351.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm352.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "6")
                            {
                                lbm361.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm362.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "7")
                            {
                                lbm371.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm372.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "8")
                            {
                                lbm381.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm382.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "9")
                            {
                                lbm391.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm392.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }
                            else if (sub_piping1.Rows[i]["type"].ToString() == "10")
                            {
                                lbm301.Text = sub_piping1.Rows[i]["l3"].ToString();
                                lbm302.Text = sub_piping1.Rows[i]["l4"].ToString();
                            }

                        }
                    }
                }

                var sub_piping2 = Serv.Get_tbl_piping_qurter_plan2(hddpiping_id.Value);
                if (sub_piping2.Rows.Count != 0)
                {
                    for (int i = 0; i <= sub_piping2.Rows.Count - 1; i++)
                    {
                        if (i == 0)
                        {
                            lbQuarter2.Text = sub_piping2.Rows[i]["l30"].ToString();
                            lbM1_.Text = sub_piping2.Rows[i]["l31"].ToString();

                            if (sub_piping2.Rows[i]["type"].ToString() == "1")
                            {
                                lbm111_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm112_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "2")
                            {
                                lbm121_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm122_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "3")
                            {
                                lbm131_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm132_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "4")
                            {
                                lbm141_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm142_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "5")
                            {
                                lbm151_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm152_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "6")
                            {
                                lbm161_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm162_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "7")
                            {
                                lbm171_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm172_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "8")
                            {
                                lbm181_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm182_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "9")
                            {
                                lbm191_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm192_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "10")
                            {
                                lbm101_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm102_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }

                        }
                        else if (i == 1)
                        {
                            lbQuarter2.Text = sub_piping2.Rows[i]["l30"].ToString();
                            lbM2_.Text = sub_piping2.Rows[i]["l31"].ToString();

                            if (sub_piping2.Rows[i]["type"].ToString() == "1")
                            {
                                lbm211_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm212_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "2")
                            {
                                lbm221_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm222_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "3")
                            {
                                lbm231_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm232_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "4")
                            {
                                lbm241_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm242_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "5")
                            {
                                lbm251_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm252_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "6")
                            {
                                lbm261_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm262_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "7")
                            {
                                lbm271_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm272_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "8")
                            {
                                lbm281_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm282_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "9")
                            {
                                lbm291_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm292_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "10")
                            {
                                lbm201_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm202_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }

                        }
                        else if (i == 2)
                        {
                            lbQuarter2.Text = sub_piping2.Rows[i]["l30"].ToString();
                            lbM3_.Text = sub_piping2.Rows[i]["l31"].ToString();

                            if (sub_piping2.Rows[i]["type"].ToString() == "1")
                            {
                                lbm311_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm312_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "2")
                            {
                                lbm321_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm322_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "3")
                            {
                                lbm331_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm332_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "4")
                            {
                                lbm341_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm342_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "5")
                            {
                                lbm351_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm352_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "6")
                            {
                                lbm361_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm362_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "7")
                            {
                                lbm371_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm372_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "8")
                            {
                                lbm381_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm382_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "9")
                            {
                                lbm391_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm392_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }
                            else if (sub_piping2.Rows[i]["type"].ToString() == "10")
                            {
                                lbm301_.Text = sub_piping2.Rows[i]["l32"].ToString();
                                lbm302_.Text = sub_piping2.Rows[i]["l33"].ToString();
                            }

                        }
                    }
                }



                var sub1 = Serv.GetSub1(hddpiping_id.Value);
                if (sub1.Rows.Count != 0)
                {
                    //txtRegion.Text = sub1.Rows[0]["l5"].ToString();
                    //txtAVG.Text = sub1.Rows[0]["l6"].ToString();
                    //txtstation.Text = sub1.Rows[0]["l9"].ToString();
                    //txtmin.Text = sub1.Rows[0]["l7"].ToString();
                    //txtCorr.Text = sub1.Rows[0]["l8"].ToString();
                    pipingPM.DataSource = sub1;
                    pipingPM.DataBind();
                }
                else
                {

                    Serv.Insert_tbl_piping_sub1(hddpiping_id.Value, "", "", "", "", "");

                    var newSub1 = Serv.GetSub1(hddpiping_id.Value);

                    if (newSub1.Rows.Count != 0)
                    {
                        pipingPM.DataSource = newSub1;
                        pipingPM.DataBind();
                    }
                    else
                    {
                        pipingPM.DataSource = null;
                        pipingPM.DataBind();
                    }
                    
                }

                var sub2 = Serv.GetSub2(hddpiping_id.Value);
                if (sub2.Rows.Count != 0)
                {


                    //txtRegion2.Text = sub2.Rows[0]["l10"].ToString();
                    //txtCoatingCondition.Text = sub2.Rows[0]["l11"].ToString();
                    //txtstation2.Text = sub2.Rows[0]["l13"].ToString();
                    //txtCorrosion.Text = sub2.Rows[0]["l12"].ToString();
                    pipingCI.DataSource = sub2;
                    pipingCI.DataBind();
                }
                else
                {

                    Serv.Insert_tbl_piping_sub2(hddpiping_id.Value, "", "", "", "");

                    var newSub2 = Serv.GetSub2(hddpiping_id.Value);

                    if (newSub2.Rows.Count != 0)
                    {
                        pipingCI.DataSource = newSub2;
                        pipingCI.DataBind();
                    }
                    else
                    {
                        pipingCI.DataSource = null;
                        pipingCI.DataBind();
                    }
                }

                var sub3 = Serv.GetSub3(hddpiping_id.Value);
                if (sub3.Rows.Count != 0)
                {
                    //txtRegion3.Text = sub3.Rows[0]["l14"].ToString();
                    //txtPipeSup.Text = sub3.Rows[0]["l15"].ToString();
                    //txtstation3.Text = sub3.Rows[0]["l17"].ToString();
                    //txtCorrosion2.Text = sub3.Rows[0]["l16"].ToString();
                    pipingCUPS.DataSource = sub3;
                    pipingCUPS.DataBind();
                }
                else
                {
                    Serv.Insert_tbl_piping_sub3(hddpiping_id.Value, "", "", "", "");

                    var newSub3 = Serv.GetSub3(hddpiping_id.Value);

                    if (newSub3.Rows.Count != 0)
                    {
                        pipingCUPS.DataSource = newSub3;
                        pipingCUPS.DataBind();
                    }
                    else
                    {
                        pipingCUPS.DataSource = null;
                        pipingCUPS.DataBind();
                    }
                }

                var sub4 = Serv.GetSub4(hddpiping_id.Value);
                if (sub4.Rows.Count != 0)
                {
                    //txtRegion4.Text = sub4.Rows[0]["l18"].ToString();
                    //txtCoating4.Text = sub4.Rows[0]["l19"].ToString();
                    //txtstation4.Text = sub4.Rows[0]["l21"].ToString();
                    //txtCorrosion4.Text = sub4.Rows[0]["l20"].ToString();
                    pipingSAI.DataSource = sub4;
                    pipingSAI.DataBind();

                }
                else
                {
                    Serv.Insert_tbl_piping_sub4(hddpiping_id.Value, "", "", "", "");

                    var newSub4 = Serv.GetSub4(hddpiping_id.Value);

                    if (newSub4.Rows.Count != 0)
                    {
                        pipingSAI.DataSource = newSub4;
                        pipingSAI.DataBind();
                    }
                    else
                    {
                        pipingSAI.DataSource = null;
                        pipingSAI.DataBind();
                    }
                }

                var sub5 = Serv.GetSub5(hddpiping_id.Value);
                if (sub5.Rows.Count != 0)
                {
                    //txtRegion5.Text = sub5.Rows[0]["l22"].ToString();
                    //txtInsulation.Text = sub5.Rows[0]["l23"].ToString();
                    //txtstation5.Text = sub5.Rows[0]["l25"].ToString();
                    //txtCorrosion5.Text = sub5.Rows[0]["l24"].ToString();
                    pipeCUI.DataSource = sub5;
                    pipeCUI.DataBind();
                }
                else
                {
                    Serv.Insert_tbl_piping_sub5(hddpiping_id.Value, "", "", "", "");

                    var newSub5 = Serv.GetSub5(hddpiping_id.Value);

                    if (newSub5.Rows.Count != 0)
                    {
                        pipeCUI.DataSource = newSub5;
                        pipeCUI.DataBind();
                    }
                    else
                    {
                        pipeCUI.DataSource = null;
                        pipeCUI.DataBind();
                    }
                }

                var sub6 = Serv.GetSub6(hddpiping_id.Value);
                if (sub6.Rows.Count != 0)
                {
                    //txtRegion6.Text = sub6.Rows[0]["l26"].ToString();
                    //txtInspection.Text = sub6.Rows[0]["l27"].ToString();
                    //txtCMStation.Text = sub6.Rows[0]["l28"].ToString();
                    //txtdate.Text = sub6.Rows[0]["l29"].ToString();
                    pipingCMCM.DataSource = sub6;
                    pipingCMCM.DataBind();
                }
                else
                {
                    Serv.Insert_tbl_piping_sub6(hddpiping_id.Value, "", "", "", "");

                    var newSub6 = Serv.GetSub6(hddpiping_id.Value);

                    if (newSub6.Rows.Count != 0)
                    {
                        pipingCMCM.DataSource = newSub6;
                        pipingCMCM.DataBind();
                    }
                    else
                    {
                        pipingCMCM.DataSource = null;
                        pipingCMCM.DataBind();
                    }
                }
            }
            else
            {
                var x = Serv.Insert_tbl_piping(hddmas_rep_id.Value, "");
                if (x.Rows.Count != 0)
                {
                    hddpiping_id.Value = x.Rows[0]["id"].ToString();
                }
            }
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {

            //txtRegion.Text = "1";
            //txtstation.Text = "BV3";

            //txtRegion2.Text = "1";
            //txtCoatingCondition.Text = "Local Disbonding";
            //txtstation2.Text = "BV3";
            //txtCorrosion.Text = "No corrosion";

            //txtRegion3.Text = "1";
            //txtPipeSup.Text = "Moderate";
            //txtstation3.Text = "BV3";
            //txtCorrosion2.Text = "No corrosion";

            //txtRegion4.Text = "1";
            //txtCoating4.Text = "Moderate";
            //txtstation4.Text = "BV3";
            //txtCorrosion4.Text = "No corrosion";

            //txtRegion5.Text = "1";
            //txtInsulation.Text = "Moderate";
            //txtstation5.Text = "BV3";
            //txtCorrosion5.Text = "No corrosion";

            //txtRegion6.Text = "1";
            //txtInspection.Text = "Soil to Air";
            //txtCMStation.Text = "ABPR1";
            //txtdate.Text = "20/03/2017";

            lbQuarter.Text = "Quarter 1";
            lbQuarter2.Text = "Quarter 2";

            lbM1.Text = "Jan";
            lbM2.Text = "Feb";
            lbM3.Text = "Mar";

            lbM1_.Text = "Arp";
            lbM2_.Text = "May";
            lbM3_.Text = "Jun";

            lbm131.Text = "18";
            lbm132.Text = "18";

            lbm221.Text = "2";
            lbm222.Text = "2";


            lbm311.Text = "7";
            lbm312.Text = "7";


            lbm131_.Text = "18";
            lbm132_.Text = "18";

            lbm221_.Text = "2";
            lbm222_.Text = "2";


            lbm311_.Text = "7";
            lbm312_.Text = "7";
        }


        private void POPUPMSG(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("alert(\'");
            sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("\'", "\\\'"));
            sb.Append("\');");
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Serv.Truncate_tbl_piping_qurter_plan();
            //Serv.Truncate_tbl_piping_sub();

            Serv.Update_tbl_piping(txtComment.Text, hddpiping_id.Value, HttpContext.Current.Session["assetuserid"].ToString(), hddmas_rep_id.Value);

            Serv.Insert_tbl_piping_qurter_plan1(hddpiping_id.Value, lbQuarter.Text, lbM1.Text, lbm131.Text, lbm132.Text, "3");
            Serv.Insert_tbl_piping_qurter_plan1(hddpiping_id.Value, lbQuarter.Text, lbM2.Text, lbm221.Text, lbm222.Text, "2");
            Serv.Insert_tbl_piping_qurter_plan1(hddpiping_id.Value, lbQuarter.Text, lbM3.Text, lbm311.Text, lbm312.Text, "1");

            Serv.Insert_tbl_piping_qurter_plan2(hddpiping_id.Value, lbQuarter2.Text, lbM1_.Text, lbm131_.Text, lbm132_.Text, "3");
            Serv.Insert_tbl_piping_qurter_plan2(hddpiping_id.Value, lbQuarter2.Text, lbM2_.Text, lbm221_.Text, lbm222_.Text, "2");
            Serv.Insert_tbl_piping_qurter_plan2(hddpiping_id.Value, lbQuarter2.Text, lbM3_.Text, lbm311_.Text, lbm312_.Text, "1");



            // Loop save

            var sub1 = Serv.GetSub1(hddpiping_id.Value);
            if (sub1.Rows.Count != 0)
            {

                foreach (GridViewRow row in pipingPM.Rows)
                {
                    HiddenField id = (HiddenField)row.FindControl("pipingPMId");
                    TextBox txtRegion = (TextBox)row.FindControl("pmRegion");
                    TextBox txtAVG = (TextBox)row.FindControl("pmCAvg");
                    TextBox txtmin = (TextBox)row.FindControl("pmCMin");
                    TextBox txtCorr = (TextBox)row.FindControl("pmCorrRate");
                    TextBox txtstation = (TextBox)row.FindControl("pmStatus");

                    Serv.Update_tbl_piping_sub1(txtRegion.Text, txtAVG.Text, txtmin.Text, txtCorr.Text, txtstation.Text, id.Value);

                }
            }


            var sub2 = Serv.GetSub2(hddpiping_id.Value);
            if (sub2.Rows.Count != 0)
            {

                foreach (GridViewRow row in pipingCI.Rows)
                {
                    HiddenField id = (HiddenField)row.FindControl("pipingCIId");
                    TextBox txtRegion = (TextBox)row.FindControl("ciRegion");
                    TextBox txtCoat = (TextBox)row.FindControl("ciCoat");
                    TextBox txtCorr = (TextBox)row.FindControl("ciCorr");
                    TextBox txtstation = (TextBox)row.FindControl("ciStation");

                    Serv.Update_tbl_piping_sub2(txtRegion.Text, txtCoat.Text, txtCorr.Text, txtstation.Text, id.Value);
                }
            }



            var sub3 = Serv.GetSub3(hddpiping_id.Value);
            if (sub3.Rows.Count != 0)
            {
                foreach (GridViewRow row in pipingCUPS.Rows)
                {
                    HiddenField id = (HiddenField)row.FindControl("pipingCUPSId");
                    TextBox txtRegion = (TextBox)row.FindControl("cupsRegion");
                    TextBox txtCoat = (TextBox)row.FindControl("cupsCoat");
                    TextBox txtCorr = (TextBox)row.FindControl("cupsCorr");
                    TextBox txtstation = (TextBox)row.FindControl("cupsStation");

                    Serv.Update_tbl_piping_sub3(txtRegion.Text, txtCoat.Text, txtCorr.Text, txtstation.Text, id.Value);
                }
            }


            var sub4 = Serv.GetSub4(hddpiping_id.Value);
            if (sub4.Rows.Count != 0)
            {
                foreach (GridViewRow row in pipingSAI.Rows)
                {
                    HiddenField id = (HiddenField)row.FindControl("pipingSAIId");
                    TextBox txtRegion = (TextBox)row.FindControl("saiRegion");
                    TextBox txtCoat = (TextBox)row.FindControl("saiCoat");
                    TextBox txtCorr = (TextBox)row.FindControl("saiCorr");
                    TextBox txtstation = (TextBox)row.FindControl("saiStation");

                    Serv.Update_tbl_piping_sub4(txtRegion.Text, txtCoat.Text, txtCorr.Text, txtstation.Text, id.Value);
                }
            }

            var sub5 = Serv.GetSub5(hddpiping_id.Value);
            if (sub5.Rows.Count != 0)
            {
                foreach (GridViewRow row in pipeCUI.Rows)
                {
                    HiddenField id = (HiddenField)row.FindControl("pipingCUIId");
                    TextBox txtRegion = (TextBox)row.FindControl("cuiRegion");
                    TextBox txtCoat = (TextBox)row.FindControl("cuiCoat");
                    TextBox txtCorr = (TextBox)row.FindControl("cuiCorr");
                    TextBox txtstation = (TextBox)row.FindControl("cuiStation");

                    Serv.Update_tbl_piping_sub5(txtRegion.Text, txtCoat.Text, txtCorr.Text, txtstation.Text, id.Value);
                }
            }

            var sub6 = Serv.GetSub6(hddpiping_id.Value);
            if (sub6.Rows.Count != 0)
            {
                foreach (GridViewRow row in pipingCMCM.Rows)
                {
                    HiddenField id = (HiddenField)row.FindControl("pipingCMCMd");
                    TextBox txtRegion = (TextBox)row.FindControl("cmcmRegion");
                    TextBox txtInspection = (TextBox)row.FindControl("cmcmInspection");
                    TextBox txtStation = (TextBox)row.FindControl("cmcmStation");
                    TextBox txtDate = (TextBox)row.FindControl("cmcmDate");

                    Serv.Update_tbl_piping_sub6(txtRegion.Text, txtInspection.Text, txtStation.Text, txtDate.Text, id.Value);
                }
            }

            //Serv.Insert_tbl_piping_sub1(hddpiping_id.Value, txtRegion.Text, txtAVG.Text, txtmin.Text, txtCorr.Text, txtstation.Text);

            //Serv.Insert_tbl_piping_sub2(hddpiping_id.Value, txtRegion2.Text, txtCoatingCondition.Text, txtCorrosion.Text, txtstation.Text);


            //Serv.Insert_tbl_piping_sub3(hddpiping_id.Value, txtRegion3.Text, txtPipeSup.Text, txtCorrosion2.Text, txtstation3.Text);


            //Serv.Insert_tbl_piping_sub4(hddpiping_id.Value, txtRegion4.Text, txtCoating4.Text, txtCorrosion4.Text, txtstation4.Text);


            //Serv.Insert_tbl_piping_sub5(hddpiping_id.Value, txtRegion5.Text, txtInsulation.Text, txtCorrosion5.Text, txtstation5.Text);


            //Serv.Insert_tbl_piping_sub6(hddpiping_id.Value, txtRegion6.Text, txtInspection.Text, txtCMStation.Text, txtdate.Text);


            POPUPMSG("บันทึกเรียบร้อย");
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            Serv.UpdateStatus_rep(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }
        protected void btnReject_Click(object sender, EventArgs e)
        {
            Serv.UpdateStatus_Reject(hddmas_rep_id.Value, HttpContext.Current.Session["assetuserid"].ToString());
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/history_1.aspx?param=1&quarterrepid=" + hddmas_rep_id.Value);
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            var historyObj = QServ.GetHistoryLinkById(hddmas_rep_id.Value);

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

                    //do this for each keyword you want to replace.
                    var sel = app.Selection;
                    var rep_a = Serv.GetExistRep(hddmas_rep_id.Value);
                    if (rep_a.Rows.Count != 0)
                    {
                        sel.Find.Text = "[qx]";
                        sel.Find.Replacement.Text = HttpContext.Current.Session["repQuar"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        sel.Find.Text = "[yx]";
                        sel.Find.Replacement.Text = HttpContext.Current.Session["repYear"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        //=======================================================================================

                        sel.Find.Text = "[qa0]";
                        sel.Find.Replacement.Text = rep_a.Rows[0]["partolling_info1"].ToString().Replace("\r\n", "\v");
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Find.Forward = true;
                        sel.Find.Format = false;
                        sel.Find.MatchCase = false;
                        sel.Find.MatchWholeWord = false;
                        sel.Find.Execute(Replace: WdReplace.wdReplaceAll);




                        Utility.FindAndReplaceText(ref sel, "[qa1]", rep_a.Rows[0]["partolling_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa2]", rep_a.Rows[0]["partolling_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa3]", rep_a.Rows[0]["rov_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa4]", rep_a.Rows[0]["rov_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa5]", rep_a.Rows[0]["rov_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa6]", rep_a.Rows[0]["da_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa7]", rep_a.Rows[0]["da_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa8]", rep_a.Rows[0]["da_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa9]", rep_a.Rows[0]["erosion_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa10]", rep_a.Rows[0]["erosion_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa11]", rep_a.Rows[0]["erosion_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa12]", rep_a.Rows[0]["subsite_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa13]", rep_a.Rows[0]["subsite_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa14]", rep_a.Rows[0]["subsite_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa15]", rep_a.Rows[0]["exterCorr_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa16]", rep_a.Rows[0]["exterCorr_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa17]", rep_a.Rows[0]["exterCorr_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa18]", rep_a.Rows[0]["exterCorr_info4"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa19]", rep_a.Rows[0]["interCorr_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa20]", rep_a.Rows[0]["interCorr_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa21]", rep_a.Rows[0]["interCorr_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa22]", rep_a.Rows[0]["interCorr_info4"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa23]", rep_a.Rows[0]["da2_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa24]", rep_a.Rows[0]["da2_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa25]", rep_a.Rows[0]["da2_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa26]", rep_a.Rows[0]["offshore_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa27]", rep_a.Rows[0]["offshore_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa28]", rep_a.Rows[0]["offshore_info3"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa29]", rep_a.Rows[0]["offshore2_info1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa30]", rep_a.Rows[0]["offshore2_info2"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[qa31]", rep_a.Rows[0]["offshore2_info3"].ToString());

                        var executive = Serv.GetExecutiveOtherRep(hddmas_rep_id.Value);
                        if (executive.Rows.Count != 0)
                        {
                            if (executive.Rows.Count == 5)
                            {
                                Utility.FindAndReplaceText(ref sel, "[qa32]", executive.Rows[0]["project_name"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa33]", executive.Rows[0]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa34]", executive.Rows[0]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa35]", executive.Rows[0]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa36]", executive.Rows[1]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa37]", executive.Rows[1]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa38]", executive.Rows[1]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa39]", executive.Rows[2]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa40]", executive.Rows[2]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa41]", executive.Rows[2]["other_info3"].ToString());



                            }
                            else if (executive.Rows.Count == 4)
                            {
                                Utility.FindAndReplaceText(ref sel, "[qa32]", executive.Rows[0]["project_name"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa33]", executive.Rows[0]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa34]", executive.Rows[0]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa35]", executive.Rows[0]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa36]", executive.Rows[1]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa37]", executive.Rows[1]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa38]", executive.Rows[1]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa39]", executive.Rows[2]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa40]", executive.Rows[2]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa41]", executive.Rows[2]["other_info3"].ToString());

                            }
                            else if (executive.Rows.Count == 3)
                            {
                                Utility.FindAndReplaceText(ref sel, "[qa32]", executive.Rows[0]["project_name"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa33]", executive.Rows[0]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa34]", executive.Rows[0]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa35]", executive.Rows[0]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa36]", executive.Rows[1]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa37]", executive.Rows[1]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa38]", executive.Rows[1]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa39]", executive.Rows[2]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa40]", executive.Rows[2]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa41]", executive.Rows[2]["other_info3"].ToString());


                            }
                            else if (executive.Rows.Count == 2)
                            {
                                Utility.FindAndReplaceText(ref sel, "[qa32]", executive.Rows[0]["project_name"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa33]", executive.Rows[0]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa34]", executive.Rows[0]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa35]", executive.Rows[0]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa36]", executive.Rows[1]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa37]", executive.Rows[1]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa38]", executive.Rows[1]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa39]", "");

                                Utility.FindAndReplaceText(ref sel, "[qa40]", "");

                                Utility.FindAndReplaceText(ref sel, "[qa41]", "");

                            }
                            else if (executive.Rows.Count == 1)
                            {
                                Utility.FindAndReplaceText(ref sel, "[qa32]", executive.Rows[0]["project_name"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa33]", executive.Rows[0]["other_info1"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa34]", executive.Rows[0]["other_info2"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa35]", executive.Rows[0]["other_info3"].ToString());

                                Utility.FindAndReplaceText(ref sel, "[qa36]", "");

                                Utility.FindAndReplaceText(ref sel, "[qa37]", "");

                                Utility.FindAndReplaceText(ref sel, "[qa38]", "");

                                Utility.FindAndReplaceText(ref sel, "[qa39]", "");

                                Utility.FindAndReplaceText(ref sel, "[qa40]", "");

                                Utility.FindAndReplaceText(ref sel, "[qa41]", "");

                            }
                        }
                    }

                    var rep_b = Serv.GetExistRep1(hddmas_rep_id.Value);
                    if (rep_b.Rows.Count != 0)
                    {
                        var img = Server.MapPath(rep_b.Rows[0]["groung_img_path"].ToString());
                        if (rep_b.Rows[0]["groung_img_path"].ToString() != "")
                        {
                            sel.Find.Text = "[imgb1]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            sel.InlineShapes.AddPicture(
                                FileName: img,
                                LinkToFile: false,
                                SaveWithDocument: true
                                );
                        }

                        Utility.FindAndReplaceText(ref sel, "[b2]", rep_b.Rows[0]["aerial_result"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[b3]", rep_b.Rows[0]["remark1"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[b4]", rep_b.Rows[0]["problem"].ToString());


                    }

                    //===================================== DA ========================================

                    var da = Serv.GetExistRep2(hddmas_rep_id.Value);
                    if (da.Rows.Count != 0)
                    {

                        Utility.FindAndReplaceText(ref sel, "[c7]", da.Rows[0]["dainfo11"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[c8]", da.Rows[0]["dainfo12"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[c9]", da.Rows[0]["dainfo13"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[c10]", da.Rows[0]["dainfo14"].ToString());

                        Utility.FindAndReplaceText(ref sel, "[c11]", da.Rows[0]["dainfo21"].ToString());
                        //sel.Find.Text = "[c11]";
                        //sel.Find.Replacement.Text = da.Rows[0]["dainfo21"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c12]", da.Rows[0]["dainfo22"].ToString());
                        //sel.Find.Text = "[c12]";
                        //sel.Find.Replacement.Text = da.Rows[0]["dainfo22"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c13]", da.Rows[0]["dainfo23"].ToString());
                        //sel.Find.Text = "[c13]";
                        //sel.Find.Replacement.Text = da.Rows[0]["dainfo23"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c14]", da.Rows[0]["dainfo24"].ToString());
                        //sel.Find.Text = "[c14]";
                        //sel.Find.Replacement.Text = da.Rows[0]["dainfo24"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[c16]", da.Rows[0]["dainfo1"].ToString());
                        //sel.Find.Text = "[c16]";
                        //sel.Find.Replacement.Text = da.Rows[0]["dainfo1"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        var sub_da = Serv.GetDARep_sub(da.Rows[0]["id"].ToString());
                        if (sub_da.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable;

                            sel.Find.Text = "[table1]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            axTable = sel.Tables.Add(app.Selection.Range, sub_da.Rows.Count + 1, 6);

                            axTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable.Cell(1, 1).Range.Text = "เขต";
                            axTable.Cell(1, 2).Range.Text = "เส้นท่อ,ตำแหน่ง";
                            axTable.Cell(1, 3).Range.Text = "ขุดซ่อมเนื่องจาก";
                            axTable.Cell(1, 4).Range.Text = "Length(m)";
                            axTable.Cell(1, 5).Range.Text = "% Actual";
                            axTable.Cell(1, 6).Range.Text = "Plan/Status";

                            int start_row = 2;
                            // This is For Header columns
                            for (int j = 0; j <= sub_da.Rows.Count - 1; j++)
                            {
                                axTable.Cell(start_row, 1).Range.Text = sub_da.Rows[j]["dainfo1"].ToString();
                                axTable.Cell(start_row, 2).Range.Text = sub_da.Rows[j]["dainfo2"].ToString();
                                axTable.Cell(start_row, 3).Range.Text = sub_da.Rows[j]["dainfo3"].ToString();
                                axTable.Cell(start_row, 4).Range.Text = sub_da.Rows[j]["dainfo4"].ToString();
                                axTable.Cell(start_row, 5).Range.Text = sub_da.Rows[j]["dainfo5"].ToString();
                                axTable.Cell(start_row, 6).Range.Text = sub_da.Rows[j]["dainfo6"].ToString();

                                start_row++;
                            }

                        }

                    }



                    //=================================================================================

                    //============================= Soil =============================================

                    var soil = Serv.GetExistRep3(hddmas_rep_id.Value);
                    if (soil.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[d1]", soil.Rows[0]["d1"].ToString());
                        //sel.Find.Text = "[d1]";
                        //sel.Find.Replacement.Text = soil.Rows[0]["d1"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[d2]", soil.Rows[0]["d2"].ToString());
                        //sel.Find.Text = "[d2]";
                        //sel.Find.Replacement.Text = soil.Rows[0]["d2"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[d9]", soil.Rows[0]["d9"].ToString());
                        //sel.Find.Text = "[d9]";
                        //sel.Find.Replacement.Text = soil.Rows[0]["d9"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[d10]", soil.Rows[0]["d10"].ToString());
                        //sel.Find.Text = "[d10]";
                        //sel.Find.Replacement.Text = soil.Rows[0]["d10"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[d11]", soil.Rows[0]["d11"].ToString());
                        //sel.Find.Text = "[d11]";
                        //sel.Find.Replacement.Text = soil.Rows[0]["d11"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        var soil_sub = Serv.GetExistRep3_sub(soil.Rows[0]["id"].ToString());
                        if (soil_sub.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable2;

                            sel.Find.Text = "[table2]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            axTable2 = sel.Tables.Add(app.Selection.Range, soil_sub.Rows.Count + 1, 4);

                            axTable2.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable2.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable2.Cell(1, 1).Range.Text = "Region";
                            axTable2.Cell(1, 2).Range.Text = "เส้นท่อ,ตำแหน่ง";
                            axTable2.Cell(1, 3).Range.Text = "Progress";
                            axTable2.Cell(1, 4).Range.Text = "ผลการดำเนินงาน/สิ่งที่ไม่เป็นไปตามแผน/ปัญหาอุปสรรค/แนวทางแก้ไข";

                            int start_row = 2;

                            for (int j = 0; j <= soil_sub.Rows.Count - 1; j++)
                            {
                                axTable2.Cell(start_row, 1).Range.Text = soil_sub.Rows[j]["d3"].ToString();
                                axTable2.Cell(start_row, 2).Range.Text = soil_sub.Rows[j]["d4"].ToString();
                                axTable2.Cell(start_row, 3).Range.Text = soil_sub.Rows[j]["d7"].ToString();
                                axTable2.Cell(start_row, 4).Range.Text = soil_sub.Rows[j]["d8"].ToString();

                                start_row = start_row + 1;

                            }
                        }
                    }

                    #region E
                    ///=========================== E ==============================
                    ///
                    var exist = Serv.GetExistRep4(hddmas_rep_id.Value);
                    if (exist.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[e7]", exist.Rows[0]["progressresult"].ToString());
                        //sel.Find.Text = "[e7]";
                        //sel.Find.Replacement.Text = exist.Rows[0]["progressresult"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[e8]", exist.Rows[0]["futureplan"].ToString());
                        //sel.Find.Text = "[e8]";
                        //sel.Find.Replacement.Text = exist.Rows[0]["futureplan"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[e9]", exist.Rows[0]["problem"].ToString());
                        //sel.Find.Text = "[e9]";
                        //sel.Find.Replacement.Text = exist.Rows[0]["problem"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        var sub = Serv.GetExistRep4_sub(soil.Rows[0]["id"].ToString());
                        if (sub.Rows.Count != 0)
                        {

                            Microsoft.Office.Interop.Word.Table axTable2;

                            sel.Find.Text = "[table3]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            axTable2 = sel.Tables.Add(app.Selection.Range, sub.Rows.Count + 1, 5);

                            axTable2.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable2.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable2.Cell(1, 1).Range.Text = "Region";
                            axTable2.Cell(1, 2).Range.Text = "Station";
                            axTable2.Cell(1, 3).Range.Text = "Action";
                            axTable2.Cell(1, 4).Range.Text = "Progress";
                            axTable2.Cell(1, 5).Range.Text = "ผลการดำเนินงาน/สิ่งที่ไม่เป็นไปตามแผน/ปัญหาอุปสรรค/แนวทางแก้ไข";

                            int start_row = 2;

                            for (int j = 0; j <= sub.Rows.Count - 1; j++)
                            {
                                axTable2.Cell(start_row, 1).Range.Text = sub.Rows[j]["area"].ToString();
                                axTable2.Cell(start_row, 2).Range.Text = sub.Rows[j]["station"].ToString() + " " + sub.Rows[j]["pipe"].ToString();
                                axTable2.Cell(start_row, 3).Range.Text = sub.Rows[j]["action"].ToString();
                                axTable2.Cell(start_row, 4).Range.Text = sub.Rows[j]["progress"].ToString();
                                axTable2.Cell(start_row, 5).Range.Text = sub.Rows[j]["remark"].ToString();
                                start_row = start_row + 1;

                            }
                        }
                    }
                    #endregion
                    #region F
                    var rov = Serv.GetExistRep5(hddmas_rep_id.Value);
                    if (rov.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[f1]", rov.Rows[0]["planwork"].ToString());
                        //sel.Find.Text = "[f1]";
                        //sel.Find.Replacement.Text = rov.Rows[0]["planwork"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[f2]", rov.Rows[0]["workresult"].ToString());
                        //sel.Find.Text = "[f2]";
                        //sel.Find.Replacement.Text = rov.Rows[0]["workresult"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[f3]", rov.Rows[0]["planworkfuture"].ToString());
                        //sel.Find.Text = "[f3]";
                        //sel.Find.Replacement.Text = rov.Rows[0]["planworkfuture"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[f4]", rov.Rows[0]["problem"].ToString());
                        //sel.Find.Text = "[f4]";
                        //sel.Find.Replacement.Text = rov.Rows[0]["problem"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                    }
                    #endregion

                    #region G
                    var exist_g = Serv.GetExistRep6(hddmas_rep_id.Value);
                    if (exist_g.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[g1]", exist_g.Rows[0]["planwork"].ToString());
                        //sel.Find.Text = "[g1]";
                        //sel.Find.Replacement.Text = exist_g.Rows[0]["planwork"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[g2]", exist_g.Rows[0]["workresult"].ToString());
                        //sel.Find.Text = "[g2]";
                        //sel.Find.Replacement.Text = exist_g.Rows[0]["workresult"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[g3]", exist_g.Rows[0]["planworkfuture"].ToString());
                        //sel.Find.Text = "[g3]";
                        //sel.Find.Replacement.Text = exist_g.Rows[0]["planworkfuture"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[g4]", exist_g.Rows[0]["problem"].ToString());
                        //sel.Find.Text = "[g4]";
                        //sel.Find.Replacement.Text = exist_g.Rows[0]["problem"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                    }
                    #endregion

                    #region h
                    var exist_h = Serv.GetExistRep_h(hddmas_rep_id.Value);
                    if (exist_h.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[h1]", exist_h.Rows[0]["workresult"].ToString());
                        //sel.Find.Text = "[h1]";
                        //sel.Find.Replacement.Text = exist_h.Rows[0]["workresult"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[h2]", exist_h.Rows[0]["pspotentialsurvey"].ToString());
                        //sel.Find.Text = "[h2]";
                        //sel.Find.Replacement.Text = exist_h.Rows[0]["pspotentialsurvey"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[h3]", exist_h.Rows[0]["bondboxinspection"].ToString());
                        //sel.Find.Text = "[h3]";
                        //sel.Find.Replacement.Text = exist_h.Rows[0]["bondboxinspection"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[h4]", exist_h.Rows[0]["rectifierispection"].ToString());
                        //sel.Find.Text = "[h4]";
                        //sel.Find.Replacement.Text = exist_h.Rows[0]["rectifierispection"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[h5]", exist_h.Rows[0]["insulatingjoint"].ToString());
                        //sel.Find.Text = "[h5]";
                        //sel.Find.Replacement.Text = exist_h.Rows[0]["insulatingjoint"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        var subCIPSStatus = Serv.GetExistRep_sub_cipsstatus(exist_h.Rows[0]["id"].ToString());

                        if (subCIPSStatus.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable2;

                            sel.Find.Text = "[table4]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            sel.Find.Forward = true;
                            axTable2 = sel.Tables.Add(app.Selection.Range, subCIPSStatus.Rows.Count + 1, 3);

                            axTable2.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable2.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable2.Cell(1, 1).Range.Text = "Route Code";
                            axTable2.Cell(1, 2).Range.Text = "Pipeline name";
                            axTable2.Cell(1, 3).Range.Text = "สถานะ";

                            int start_row = 2;

                            for (int j = 0; j <= subCIPSStatus.Rows.Count - 1; j++)
                            {
                                axTable2.Cell(start_row, 1).Range.Text = subCIPSStatus.Rows[j]["routecode"].ToString();
                                axTable2.Cell(start_row, 2).Range.Text = subCIPSStatus.Rows[j]["pipelinename"].ToString();
                                axTable2.Cell(start_row, 3).Range.Text = subCIPSStatus.Rows[j]["status"].ToString();

                                start_row = start_row + 1;
                            }
                        }

                        var image_h13 = Server.MapPath(exist_h.Rows[0]["ecresultfilepath"].ToString());
                        if (exist_h.Rows[0]["ecresultfilepath"].ToString() != "")
                        {
                            sel.Find.Text = "[h13]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            sel.Find.Forward = true;
                            sel.InlineShapes.AddPicture(
                                FileName: image_h13,
                                LinkToFile: false,
                                SaveWithDocument: true
                                );
                        }


                        var image_h14 = Server.MapPath(exist_h.Rows[0]["cdresultfilepath"].ToString());
                        if (exist_h.Rows[0]["cdresultfilepath"].ToString() != "")
                        {
                            sel.Find.Text = "[h14]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            sel.Find.Forward = true;
                            sel.InlineShapes.AddPicture(
                                FileName: image_h14,
                                LinkToFile: false,
                                SaveWithDocument: true
                                );
                        }



                        var subCIPSStatusActivity = Serv.GetExistRep_sub_cipsstatus_activity(exist_h.Rows[0]["id"].ToString());

                        if (subCIPSStatusActivity.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable3;

                            sel.Find.Text = "[table5]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            sel.Find.Forward = true;
                            axTable3 = sel.Tables.Add(app.Selection.Range, subCIPSStatusActivity.Rows.Count + 1, 3);

                            axTable3.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable3.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable3.Cell(1, 1).Range.Text = "Active";
                            axTable3.Cell(1, 2).Range.Text = "แผนดำเนินการ";
                            axTable3.Cell(1, 3).Range.Text = "คาดการเสร็จสิ้น";

                            int start_row = 2;

                            for (int j = 0; j <= subCIPSStatusActivity.Rows.Count - 1; j++)
                            {
                                axTable3.Cell(start_row, 1).Range.Text = subCIPSStatusActivity.Rows[j]["activity"].ToString();
                                axTable3.Cell(start_row, 2).Range.Text = subCIPSStatusActivity.Rows[j]["progress"].ToString();
                                axTable3.Cell(start_row, 3).Range.Text = subCIPSStatusActivity.Rows[j]["estimateplan"].ToString();

                                start_row = start_row + 1;
                            }
                        }

                        Utility.FindAndReplaceText(ref sel, "[h15]", exist_h.Rows[0]["planworkfuture"].ToString());
                        //sel.Find.Text = "[h15]";
                        //sel.Find.Replacement.Text = exist_h.Rows[0]["planworkfuture"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[h19]", exist_h.Rows[0]["problem"].ToString());
                        //sel.Find.Text = "[h19]";
                        //sel.Find.Replacement.Text = exist_h.Rows[0]["problem"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        //var subCathodic = Serv.GetExistRep_sub_cathodicresult(exist_h.Rows[0]["id"].ToString());

                        //if (subCathodic.Rows.Count != 0)
                        //{
                        //    gvCathodic.DataSource = subCathodic;
                        //    gvCathodic.DataBind();
                        //}
                    }


                    #endregion

                    #region i
                    var exist_i = Serv.GetExistRep_i(hddmas_rep_id.Value);
                    if (exist_i.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[i1]", exist_i.Rows[0]["planwork"].ToString());
                        //sel.Find.Text = "[i1]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["planwork"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        //txtRoutecode.Text = exist_i.Rows[0]["pwroutecode"].ToString();
                        //txtDimeter.Text = exist_i.Rows[0]["pwdimeter"].ToString();
                        //txtPipeline.Text = exist_i.Rows[0]["pwpipelinesection"].ToString();
                        //txtNumberOfPig.Text = exist_i.Rows[0]["pwnumberpig"].ToString();
                        //txtPlanning.Text = exist_i.Rows[0]["pwplaning"].ToString();

                        Utility.FindAndReplaceText(ref sel, "[i7]", exist_i.Rows[0]["planwork"].ToString());
                        //sel.Find.Text = "[i7]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["planwork"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        var subPig = Serv.GetExistRep_sub_pigresult(exist_i.Rows[0]["id"].ToString());

                        if (subPig.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable2;

                            sel.Find.Text = "[table6]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            axTable2 = sel.Tables.Add(app.Selection.Range, subPig.Rows.Count + 1, 3);

                            axTable2.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable2.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable2.Cell(1, 1).Range.Text = "Route Code";
                            axTable2.Cell(1, 2).Range.Text = "Section - Length";
                            axTable2.Cell(1, 3).Range.Text = "Status";

                            int start_row = 2;

                            for (int j = 0; j <= subPig.Rows.Count - 1; j++)
                            {
                                axTable2.Cell(start_row, 1).Range.Text = subPig.Rows[j]["routecode"].ToString();
                                axTable2.Cell(start_row, 2).Range.Text = subPig.Rows[j]["sectionlength"].ToString();
                                axTable2.Cell(start_row, 3).Range.Text = subPig.Rows[j]["status"].ToString();

                                start_row = start_row + 1;
                            }
                        }

                        Utility.FindAndReplaceText(ref sel, "[i11]", exist_i.Rows[0]["notethat"].ToString());
                        //sel.Find.Text = "[i11]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["notethat"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[i12]", exist_i.Rows[0]["froutecode"].ToString());
                        //sel.Find.Text = "[i12]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["froutecode"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[i13]", exist_i.Rows[0]["fdimeter"].ToString());
                        //sel.Find.Text = "[i13]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["fdimeter"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[i14]", exist_i.Rows[0]["fpipelinesection"].ToString());
                        //sel.Find.Text = "[i14]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["fpipelinesection"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[i15]", exist_i.Rows[0]["fnumberpig"].ToString());
                        //sel.Find.Text = "[i15]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["fnumberpig"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[i16]", exist_i.Rows[0]["fplaning"].ToString());
                        //sel.Find.Text = "[i16]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["fplaning"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[i17]", exist_i.Rows[0]["problem"].ToString());
                        //sel.Find.Text = "[i17]";
                        //sel.Find.Replacement.Text = exist_i.Rows[0]["problem"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);



                        var subReplan = Serv.GetExistRep_sub_replan(exist_i.Rows[0]["id"].ToString());

                        if (subReplan.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable2;

                            sel.Find.Text = "[table8]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            axTable2 = sel.Tables.Add(app.Selection.Range, subReplan.Rows.Count + 1, 3);

                            axTable2.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable2.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable2.Cell(1, 1).Range.Text = "เส้นท่อ";
                            axTable2.Cell(1, 2).Range.Text = "ปรับแผน";
                            axTable2.Cell(1, 3).Range.Text = "รายละเอียด";

                            int start_row = 2;

                            for (int j = 0; j <= subReplan.Rows.Count - 1; j++)
                            {
                                axTable2.Cell(start_row, 1).Range.Text = subReplan.Rows[j]["routecode"].ToString();
                                axTable2.Cell(start_row, 2).Range.Text = subReplan.Rows[j]["replan"].ToString();
                                axTable2.Cell(start_row, 3).Range.Text = subReplan.Rows[j]["detail"].ToString();

                                start_row = start_row + 1;
                            }
                        }

                    }
                    #endregion

                    #region j
                    var exist_j = Serv.GetExistRep_j(hddmas_rep_id.Value);

                    if (exist_j.Rows.Count != 0)
                    {
                        Microsoft.Office.Interop.Word.Table axTable2;

                        sel.Find.Text = "[table9]";
                        sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Range.Select();
                        axTable2 = sel.Tables.Add(app.Selection.Range, 3, 18);

                        axTable2.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                        axTable2.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                        axTable2.Cell(1, 1).Merge(axTable2.Cell(2, 1));
                        axTable2.Cell(1, 2).Merge(axTable2.Cell(2, 2));
                        axTable2.Cell(1, 3).Merge(axTable2.Cell(2, 3));
                        axTable2.Cell(1, 4).Merge(axTable2.Cell(2, 4));
                        axTable2.Cell(1, 5).Merge(axTable2.Cell(2, 5));

                        axTable2.Cell(1, 6).Merge(axTable2.Cell(1, 7));
                        axTable2.Cell(1, 6).Merge(axTable2.Cell(1, 8));
                        axTable2.Cell(1, 6).Merge(axTable2.Cell(1, 9));
                        axTable2.Cell(1, 6).Merge(axTable2.Cell(1, 10));
                        axTable2.Cell(1, 6).Merge(axTable2.Cell(1, 7));

                        axTable2.Cell(1, 7).Merge(axTable2.Cell(2, 18));


                        axTable2.Cell(1, 1).Range.Text = "No.";
                        axTable2.Cell(1, 2).Range.Text = "Route Code";
                        axTable2.Cell(1, 3).Range.Text = "ID";
                        axTable2.Cell(1, 4).Range.Text = "Pipeline Section";
                        axTable2.Cell(1, 5).Range.Text = "Launch";
                        axTable2.Cell(1, 6).Range.Text = "ปี " + DateTime.Now.ToString("yyyy", EngCI);

                        axTable2.Cell(1, 7).Range.Text = "Actual จำนวนลูก";

                        axTable2.Cell(2, 6).Range.Text = "Jan";
                        axTable2.Cell(2, 7).Range.Text = "Feb";
                        axTable2.Cell(2, 8).Range.Text = "Mar";
                        axTable2.Cell(2, 9).Range.Text = "Apr";
                        axTable2.Cell(2, 10).Range.Text = "May";
                        axTable2.Cell(2, 11).Range.Text = "Jun";
                        axTable2.Cell(2, 12).Range.Text = "Jul";
                        axTable2.Cell(2, 13).Range.Text = "Aug";
                        axTable2.Cell(2, 14).Range.Text = "Sep";
                        axTable2.Cell(2, 15).Range.Text = "Oct";
                        axTable2.Cell(2, 16).Range.Text = "Nov";
                        axTable2.Cell(2, 17).Range.Text = "Dec";

                        axTable2.Cell(3, 1).Range.Text = "1";
                        axTable2.Cell(3, 2).Range.Text = exist_j.Rows[0]["pwroutecode"].ToString();
                        axTable2.Cell(3, 3).Range.Text = exist_j.Rows[0]["pwdimeter"].ToString();
                        axTable2.Cell(3, 4).Range.Text = exist_j.Rows[0]["pwpipelinesection"].ToString();
                        axTable2.Cell(3, 18).Range.Text = exist_j.Rows[0]["pwnumberpig"].ToString();

                        if (exist_j.Rows[0]["pwplaning"].ToString().Contains("มกราคม"))
                        {
                            axTable2.Cell(3, 6).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("กุมภา"))
                        {
                            axTable2.Cell(3, 7).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("มีนา"))
                        {
                            axTable2.Cell(3, 8).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("เมษา"))
                        {
                            axTable2.Cell(3, 9).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("พฤษภา"))
                        {
                            axTable2.Cell(3, 10).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("มีนา"))
                        {
                            axTable2.Cell(3, 11).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("กรก"))
                        {
                            axTable2.Cell(3, 12).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("สิงหา"))
                        {
                            axTable2.Cell(3, 13).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("กันยา"))
                        {
                            axTable2.Cell(3, 14).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("ตุลา"))
                        {
                            axTable2.Cell(3, 15).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("พฤศจิ"))
                        {
                            axTable2.Cell(3, 16).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }
                        else if (exist_j.Rows[0]["pwplaning"].ToString().Contains("ธันวา"))
                        {
                            axTable2.Cell(3, 17).Range.Shading.BackgroundPatternColor = WdColor.wdColorPink;
                        }


                        Microsoft.Office.Interop.Word.Table axTable3;

                        sel.Find.Text = "[table10]";
                        sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                        sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        sel.Range.Select();
                        axTable3 = sel.Tables.Add(app.Selection.Range, 2, 2);

                        axTable3.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                        axTable3.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                        axTable3.Cell(1, 1).Range.Text = "เส้นท่อ";
                        axTable3.Cell(1, 2).Range.Text = "ผลการดำเนินงาน";


                        axTable3.Cell(2, 1).Range.Text = exist_j.Rows[0]["wroutecode"].ToString() + " " + exist_j.Rows[0]["wpipelinesection"].ToString();
                        axTable3.Cell(2, 2).Range.Text = exist_j.Rows[0]["wresult"].ToString();

                        Utility.FindAndReplaceText(ref sel, "[j9]", exist_j.Rows[0]["froutecode"].ToString());
                        //sel.Find.Text = "[j9]";
                        //sel.Find.Replacement.Text = exist_j.Rows[0]["froutecode"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[j10]", exist_j.Rows[0]["fdimeter"].ToString());
                        //sel.Find.Text = "[j10]";
                        //sel.Find.Replacement.Text = exist_j.Rows[0]["fdimeter"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[j11]", exist_j.Rows[0]["fpipelinesection"].ToString());
                        //sel.Find.Text = "[j11]";
                        //sel.Find.Replacement.Text = exist_j.Rows[0]["fpipelinesection"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[j12]", exist_j.Rows[0]["fnumberpig"].ToString());
                        //sel.Find.Text = "[j12]";
                        //sel.Find.Replacement.Text = exist_j.Rows[0]["fnumberpig"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[j13]", exist_j.Rows[0]["fplaning"].ToString());
                        //sel.Find.Text = "[j13]";
                        //sel.Find.Replacement.Text = exist_j.Rows[0]["fplaning"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[j14]", exist_j.Rows[0]["problem"].ToString());
                        //sel.Find.Text = "[j14]";
                        //sel.Find.Replacement.Text = exist_j.Rows[0]["problem"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                    }
                    #endregion

                    #region K
                    var exist_k = Serv.GetExistRep_k(hddmas_rep_id.Value);

                    if (exist_k.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[k1]", exist_k.Rows[0]["detail"].ToString());
                        //sel.Find.Text = "[k1]";
                        //sel.Find.Replacement.Text = exist_k.Rows[0]["detail"].ToString().Replace("\r\n", "\v");
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                    }
                    #endregion

                    #region L
                    var exist_L = Serv.GetExistRep_L(hddmas_rep_id.Value);
                    if (exist_L.Rows.Count != 0)
                    {
                        var sub_piping1 = Serv.Get_tbl_piping_qurter_plan1(exist_L.Rows[0]["id"].ToString());
                        if (sub_piping1.Rows.Count != 0)
                        {
                            Utility.FindAndReplaceText(ref sel, "[l1]", sub_piping1.Rows[0]["l1"].ToString());
                            //sel.Find.Text = "[l1]";
                            //sel.Find.Replacement.Text = sub_piping1.Rows[0]["l1"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "[l21]", sub_piping1.Rows[0]["l2"].ToString());
                            //sel.Find.Text = "[l21]";
                            //sel.Find.Replacement.Text = sub_piping1.Rows[0]["l2"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "[l22]", sub_piping1.Rows[1]["l2"].ToString());
                            //sel.Find.Text = "[l22]";
                            //sel.Find.Replacement.Text = sub_piping1.Rows[1]["l2"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "[l23]", sub_piping1.Rows[2]["l2"].ToString());
                            //sel.Find.Text = "[l23]";
                            //sel.Find.Replacement.Text = sub_piping1.Rows[2]["l2"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "[l331]", "18");
                            //sel.Find.Text = "[l331]";
                            //sel.Find.Replacement.Text = "18";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                            Utility.FindAndReplaceText(ref sel, "[l332]", "18");
                            //sel.Find.Text = "[l332]";
                            //sel.Find.Replacement.Text = "18";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            string xl = "0";
                            string wl = "0";

                            xl = "3";
                            wl = "3";

                            for (int i = 0; i <= 9; i++)
                            {
                                if (Convert.ToString(i) != xl)
                                {
                                    Utility.FindAndReplaceText(ref sel, "[l" + wl + "" + i + "1]", "");
                                    //sel.Find.Text = "[l" + wl + "" + i + "1]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                                    Utility.FindAndReplaceText(ref sel, "[l" + wl + "" + i + "2]", "");
                                    //sel.Find.Text = "[l" + wl + "" + i + "2]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                                }
                            }

                            Utility.FindAndReplaceText(ref sel, "[l421]", "2");
                            //sel.Find.Text = "[l421]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "[l422]", "2");
                            //sel.Find.Text = "[l422]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            xl = "2";
                            wl = "4";

                            for (int i = 0; i <= 9; i++)
                            {
                                if (Convert.ToString(i) != xl)
                                {
                                    Utility.FindAndReplaceText(ref sel, "[l" + wl + "" + i + "1]", "");
                                    //sel.Find.Text = "[l" + wl + "" + i + "1]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                                    Utility.FindAndReplaceText(ref sel, "[l" + wl + "" + i + "2]", "");
                                    //sel.Find.Text = "[l" + wl + "" + i + "2]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                                }
                            }

                            Utility.FindAndReplaceText(ref sel, "[l511]", "2");
                            //sel.Find.Text = "[l511]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "[l512]", "2");
                            //sel.Find.Text = "[l512]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            xl = "1";
                            wl = "5";

                            for (int i = 0; i <= 9; i++)
                            {
                                if (Convert.ToString(i) != xl)
                                {
                                    Utility.FindAndReplaceText(ref sel, "[l" + wl + "" + i + "1]", "");
                                    //sel.Find.Text = "[l" + wl + "" + i + "1]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                                    Utility.FindAndReplaceText(ref sel, "[l" + wl + "" + i + "2]", "");
                                    //sel.Find.Text = "[l" + wl + "" + i + "2]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                                }
                            }

                        }

                        var sub_piping2 = Serv.Get_tbl_piping_qurter_plan2(exist_L.Rows[0]["id"].ToString());
                        if (sub_piping2.Rows.Count != 0)
                        {

                            Utility.FindAndReplaceText(ref sel, "l10", sub_piping2.Rows[0]["l30"].ToString());
                            //sel.Find.Text = "[l10]";
                            //sel.Find.Replacement.Text = sub_piping2.Rows[0]["l30"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "l021", sub_piping2.Rows[0]["l31"].ToString());
                            //sel.Find.Text = "[l021]";
                            //sel.Find.Replacement.Text = sub_piping2.Rows[0]["l31"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "l022", sub_piping2.Rows[1]["l31"].ToString());
                            //sel.Find.Text = "[l022]";
                            //sel.Find.Replacement.Text = sub_piping2.Rows[1]["l31"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "l023", sub_piping2.Rows[2]["l31"].ToString());
                            //sel.Find.Text = "[l023]";
                            //sel.Find.Replacement.Text = sub_piping2.Rows[2]["l31"].ToString().Replace("\r\n", "\v");
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "l0331", "18");
                            //sel.Find.Text = "[l0331]";
                            //sel.Find.Replacement.Text = "18";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "l0332", "18");
                            //sel.Find.Text = "[l0332]";
                            //sel.Find.Replacement.Text = "18";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            string xl = "0";
                            string wl = "0";

                            xl = "3";
                            wl = "3";

                            for (int i = 0; i <= 9; i++)
                            {
                                if (Convert.ToString(i) != xl)
                                {

                                    Utility.FindAndReplaceText(ref sel, "[l0" + wl + "" + i + "1]", "");
                                    //sel.Find.Text = "[l0" + wl + "" + i + "1]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                                    Utility.FindAndReplaceText(ref sel, "[l0" + wl + "" + i + "2]", "");
                                    //sel.Find.Text = "[l0" + wl + "" + i + "2]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                                }
                            }

                            Utility.FindAndReplaceText(ref sel, "04210", "2");
                            //sel.Find.Text = "[l0421]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "l0422", "2");
                            //sel.Find.Text = "[l0422]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            xl = "2";
                            wl = "4";

                            for (int i = 0; i <= 9; i++)
                            {
                                if (Convert.ToString(i) != xl)
                                {
                                    Utility.FindAndReplaceText(ref sel, "[l0" + wl + "" + i + "1]", "");
                                    //sel.Find.Text = "[l0" + wl + "" + i + "1]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                                    Utility.FindAndReplaceText(ref sel, "[l0" + wl + "" + i + "2]", "");
                                    //sel.Find.Text = "[l0" + wl + "" + i + "2]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                                }
                            }

                            Utility.FindAndReplaceText(ref sel, "[l0511]", "2");
                            //sel.Find.Text = "[l0511]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            Utility.FindAndReplaceText(ref sel, "[l0512]", "2");
                            //sel.Find.Text = "[l0512]";
                            //sel.Find.Replacement.Text = "2";
                            //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                            //sel.Find.Forward = true;
                            //sel.Find.Format = false;
                            //sel.Find.MatchCase = false;
                            //sel.Find.MatchWholeWord = false;
                            //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                            xl = "1";
                            wl = "5";

                            for (int i = 0; i <= 9; i++)
                            {
                                if (Convert.ToString(i) != xl)
                                {
                                    Utility.FindAndReplaceText(ref sel, "[l0" + wl + "" + i + "1]", "");
                                    //sel.Find.Text = "[l0" + wl + "" + i + "1]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                                    Utility.FindAndReplaceText(ref sel, "[l0" + wl + "" + i + "2]", "");
                                    //sel.Find.Text = "[l0" + wl + "" + i + "2]";
                                    //sel.Find.Replacement.Text = "";
                                    //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                                    //sel.Find.Forward = true;
                                    //sel.Find.Format = false;
                                    //sel.Find.MatchCase = false;
                                    //sel.Find.MatchWholeWord = false;
                                    //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                                }
                            }
                        }

                        var sub6 = Serv.GetSub6(exist_L.Rows[0]["id"].ToString());
                        if (sub6.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable2;

                            sel.Find.Text = "[table11]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            axTable2 = sel.Tables.Add(app.Selection.Range, sub6.Rows.Count + 1, 4);

                            axTable2.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            axTable2.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                            axTable2.Cell(1, 1).Range.Text = "Region";
                            axTable2.Cell(1, 2).Range.Text = "Inspection";
                            axTable2.Cell(1, 3).Range.Text = "CM Sattion";
                            axTable2.Cell(1, 4).Range.Text = "Date";

                            int start_row = 2;

                            for (int j = 0; j <= sub6.Rows.Count - 1; j++)
                            {
                                axTable2.Cell(start_row, 1).Range.Text = sub6.Rows[j]["l26"].ToString();
                                axTable2.Cell(start_row, 2).Range.Text = sub6.Rows[j]["l27"].ToString();
                                axTable2.Cell(start_row, 3).Range.Text = sub6.Rows[j]["l28"].ToString();
                                axTable2.Cell(start_row, 3).Range.Text = sub6.Rows[j]["l29"].ToString();

                                start_row = start_row + 1;
                            }

                        }
                    }
                    #endregion

                    #region M
                    var exist_M = Serv.GetExistRep_M(hddmas_rep_id.Value);

                    if (exist_M.Rows.Count != 0)
                    {
                        Utility.FindAndReplaceText(ref sel, "[m1]", exist_M.Rows[0]["cplanwork"].ToString());
                        //sel.Find.Text = "[m1]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["cplanwork"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[m2]", exist_M.Rows[0]["cprogressresult"].ToString());
                        //sel.Find.Text = "[m2]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["cprogressresult"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[m3]", exist_M.Rows[0]["cfutureplan"].ToString());
                        //sel.Find.Text = "[m3]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["cfutureplan"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[m4]", exist_M.Rows[0]["cproblem"].ToString());
                        //sel.Find.Text = "[m4]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["cproblem"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[m5]", exist_M.Rows[0]["mplanwork"].ToString());
                        //sel.Find.Text = "[m5]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["mplanwork"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[m6]", exist_M.Rows[0]["mprogressresult"].ToString());
                        //sel.Find.Text = "[m6]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["mprogressresult"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[m7]", exist_M.Rows[0]["mfutureplan"].ToString());
                        //sel.Find.Text = "[m7]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["mfutureplan"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);
                        Utility.FindAndReplaceText(ref sel, "[m8]", exist_M.Rows[0]["mproblem"].ToString());
                        //sel.Find.Text = "[m8]";
                        //sel.Find.Replacement.Text = exist_M.Rows[0]["mproblem"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);



                    }
                    #endregion

                    #region SIM

                    var exist_sim = QServ.GetExistRep_Sim(hddmas_rep_id.Value);

                    if (exist_sim.Rows.Count != 0)
                    {

                        Utility.FindAndReplaceText(ref sel, "[sim1]", exist_sim.Rows[0]["aplanwork"].ToString());
                        //sel.Find.Text = "[sim1]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["aplanwork"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim2]", exist_sim.Rows[0]["aprogressresult"].ToString());
                        //sel.Find.Text = "[sim2]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["aprogressresult"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim3]", exist_sim.Rows[0]["afutureplan"].ToString());
                        //sel.Find.Text = "[sim3]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["afutureplan"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim4]", exist_sim.Rows[0]["aproblem"].ToString());
                        //sel.Find.Text = "[sim4]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["aproblem"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim5]", exist_sim.Rows[0]["aopinion"].ToString());
                        //sel.Find.Text = "[sim5]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["aopinion"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim6]", exist_sim.Rows[0]["mplanwork"].ToString());
                        //sel.Find.Text = "[sim6]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["mplanwork"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim7]", exist_sim.Rows[0]["mprogressresult"].ToString());
                        //sel.Find.Text = "[sim7]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["mprogressresult"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim8]", exist_sim.Rows[0]["mfutureplan"].ToString());
                        //sel.Find.Text = "[sim8]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["mfutureplan"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);


                        Utility.FindAndReplaceText(ref sel, "[sim9]", exist_sim.Rows[0]["mproblem"].ToString());
                        //sel.Find.Text = "[sim9]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["mproblem"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                        Utility.FindAndReplaceText(ref sel, "[sim10]", exist_sim.Rows[0]["mopinion"].ToString());
                        //sel.Find.Text = "[sim10]";
                        //sel.Find.Replacement.Text = exist_sim.Rows[0]["mopinion"].ToString();
                        //sel.Find.Wrap = WdFindWrap.wdFindContinue;
                        //sel.Find.Forward = true;
                        //sel.Find.Format = false;
                        //sel.Find.MatchCase = false;
                        //sel.Find.MatchWholeWord = false;
                        //sel.Find.Execute(Replace: WdReplace.wdReplaceAll);

                    }



                    #endregion


                    #region G
                    var exist_G = Serv.GetExistRep_G(hddmas_rep_id.Value);
                    if (exist_G.Rows.Count != 0)
                    {
                        var sub_other = Serv.GetExistRep_sub_G(exist_G.Rows[0]["id"].ToString());
                        if (sub_other.Rows.Count != 0)
                        {
                            Microsoft.Office.Interop.Word.Table axTable2;

                            sel.Find.Text = "[table12]";
                            sel.Find.Execute(Replace: WdReplace.wdReplaceNone);
                            sel.Range.Select();
                            axTable2 = sel.Tables.Add(app.Selection.Range, sub_other.Rows.Count * 10, 1);


                            int start_row = 1;

                            for (int j = 0; j <= sub_other.Rows.Count - 1; j++)
                            {
                                axTable2.Cell(start_row, 1).Range.Text = "1.7." + (j + 2);
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "\t" + sub_other.Rows[j]["projectname"].ToString();
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "1.7." + (j + 2) + ".1 แผนงาน";
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "\t" + sub_other.Rows[j]["planwork"].ToString();
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "1.7." + (j + 2) + ".2 ผลการดำเนินงาน";
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "\t" + sub_other.Rows[j]["workresult"].ToString();
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "1.7." + (j + 2) + ".3 การดำเนินงานในอนาคต";
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "\t" + sub_other.Rows[j]["futureplan"].ToString();
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;

                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "1.7." + (j + 2) + ".4 ปัญหาอุปสรรค์ (ถ้ามี)";
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                                start_row = start_row + 1;
                                axTable2.Cell(start_row, 1).Range.Text = "\t" + sub_other.Rows[j]["problem"].ToString();
                                axTable2.Cell(start_row, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;


                                start_row = start_row + 1;
                            }
                        }
                    }
                    #endregion

                    string time = DateTime.Now.ToString("yyyyMMddHHmm", EngCI);

                    //************************************************



                    var x = Serv.InsertHistory(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetusername"].ToString(), "Quaterly_report",
                        "~/gen_1/Quaterly_report_v" + time + ".docx", "1", "", hddmas_rep_id.Value);



                    hddfile_path.Value = "~/gen_1/Quaterly_report_v" + x.Rows[0]["id"].ToString() + "-" + time + ".docx";

                    if (x.Rows.Count != 0)
                    {
                        Serv.UpdateHistory(x.Rows[0]["id"].ToString(), "Quaterly_report_V" + x.Rows[0]["id"].ToString(), x.Rows[0]["id"].ToString(), hddmas_rep_id.Value, "~/gen_1/Quaterly_report_v" + x.Rows[0]["id"].ToString() + "-" + time + ".docx");

                    }
                    doc.SaveAs(Server.MapPath("~/gen_1/Quaterly_report_v" + x.Rows[0]["id"].ToString() + "-" + time + ".docx"));
                    doc.Close();
                    POPUPMSG("บันทึกเรียบร้อย");
                }

            }
            finally
            {
                app.Quit();
            }
        }

        protected void btnCreate1_Click(object sender, EventArgs e)
        {
            //Preventive maintenance PM
            Serv.Insert_tbl_piping_sub1(hddpiping_id.Value, "", "", "", "", "");

            var newSub1 = Serv.GetSub1(hddpiping_id.Value);

            if (newSub1.Rows.Count != 0)
            {
                pipingPM.DataSource = newSub1;
                pipingPM.DataBind();
            }
            else
            {
                pipingPM.DataSource = null;
                pipingPM.DataBind();
            }

        }

        protected void btnCreate2_Click(object sender, EventArgs e)
        {
            Serv.Insert_tbl_piping_sub2(hddpiping_id.Value,"","","","");

            var newSub2 = Serv.GetSub2(hddpiping_id.Value);

            if (newSub2.Rows.Count != 0)
            {
                pipingCI.DataSource = newSub2;
                pipingCI.DataBind();
            }
            else
            {
                pipingCI.DataSource = null;
                pipingCI.DataBind();
            }
        }

        protected void btnCreate3_Click(object sender, EventArgs e)
        {
            Serv.Insert_tbl_piping_sub3(hddpiping_id.Value,"","","","");

            var newSub3 = Serv.GetSub3(hddpiping_id.Value);

            if (newSub3.Rows.Count != 0)
            {
                pipingCUPS.DataSource = newSub3;
                pipingCUPS.DataBind();
            }
            else
            {
                pipingCUPS.DataSource = null;
                pipingCUPS.DataBind();
            }
        }

        protected void btnCreate4_Click(object sender, EventArgs e)
        {
            Serv.Insert_tbl_piping_sub4(hddpiping_id.Value,"","","","");

            var newSub4 = Serv.GetSub4(hddpiping_id.Value);

            if (newSub4.Rows.Count != 0)
            {
                pipingSAI.DataSource = newSub4;
                pipingSAI.DataBind();
            }
            else
            {
                pipingSAI.DataSource = null;
                pipingSAI.DataBind();
            }
        }

        protected void btnCreate5_Click(object sender, EventArgs e)
        {
            Serv.Insert_tbl_piping_sub5(hddpiping_id.Value,"","","","");

            var newSub5 = Serv.GetSub5(hddpiping_id.Value);

            if (newSub5.Rows.Count != 0)
            {
                pipeCUI.DataSource = newSub5;
                pipeCUI.DataBind();
            }
            else
            {
                pipeCUI.DataSource = null;
                pipeCUI.DataBind();
            }
        }

        protected void btnCreate6_Click(object sender, EventArgs e)
        {
            Serv.Insert_tbl_piping_sub6(hddpiping_id.Value,"","","","");

            var newSub6 = Serv.GetSub6(hddpiping_id.Value);

            if (newSub6.Rows.Count != 0)
            {
                pipingCMCM.DataSource = newSub6;
                pipingCMCM.DataBind();
            }
            else
            {
                pipingCMCM.DataSource = null;
                pipingCMCM.DataBind();
            }
        }

        protected void btndel1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("pipingPMId");

            Serv.Deletetbl_piping_sub1(hddrepid.Value);

            var newSub1 = Serv.GetSub1(hddpiping_id.Value);

            if (newSub1.Rows.Count != 0)
            {
                pipingPM.DataSource = newSub1;
                pipingPM.DataBind();
            }
            else
            {
                pipingPM.DataSource = null;
                pipingPM.DataBind();
            }

        }

        protected void btndel2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("pipingCIId");

            Serv.Deletetbl_piping_sub2(hddrepid.Value);

            var newSub2 = Serv.GetSub2(hddpiping_id.Value);

            if (newSub2.Rows.Count != 0)
            {
                pipingCI.DataSource = newSub2;
                pipingCI.DataBind();
            }
            else
            {
                pipingCI.DataSource = null;
                pipingCI.DataBind();
            }
        }

        protected void btndel3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("pipingCUPSId");

            Serv.Deletetbl_piping_sub3(hddrepid.Value);

            var newSub3 = Serv.GetSub3(hddpiping_id.Value);

            if (newSub3.Rows.Count != 0)
            {
                pipingCUPS.DataSource = newSub3;
                pipingCUPS.DataBind();
            }
            else
            {
                pipingCUPS.DataSource = null;
                pipingCUPS.DataBind();
            }
        }

        protected void btndel4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("pipingSAIId");

            Serv.Deletetbl_piping_sub4(hddrepid.Value);

            var newSub4 = Serv.GetSub4(hddpiping_id.Value);

            if (newSub4.Rows.Count != 0)
            {
                pipingSAI.DataSource = newSub4;
                pipingSAI.DataBind();
            }
            else
            {
                pipingSAI.DataSource = null;
                pipingSAI.DataBind();
            }
        }

        protected void btndel5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("pipingCUIId");

            Serv.Deletetbl_piping_sub5(hddrepid.Value);

            var newSub5 = Serv.GetSub5(hddpiping_id.Value);

            if (newSub5.Rows.Count != 0)
            {
                pipeCUI.DataSource = newSub5;
                pipeCUI.DataBind();
            }
            else
            {
                pipeCUI.DataSource = null;
                pipeCUI.DataBind();
            }
        }

        protected void btndel6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddrepid = (HiddenField)row.FindControl("pipingCMCMd");

            Serv.Deletetbl_piping_sub6(hddrepid.Value);

            var newSub6 = Serv.GetSub6(hddpiping_id.Value);

            if (newSub6.Rows.Count != 0)
            {
                pipingCMCM.DataSource = newSub6;
                pipingCMCM.DataBind();
            }
            else
            {
                pipingCMCM.DataSource = null;
                pipingCMCM.DataBind();
            }
        }

    }
}