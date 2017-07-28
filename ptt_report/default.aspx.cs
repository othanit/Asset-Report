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
    public partial class _default : System.Web.UI.Page
    {

        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        defaultDLL Serv = new defaultDLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtusername.Focus();
                txtusername.Attributes.Add("onkeypress", "return next_tools(event,'" + txtpassword.ClientID + "')");
                txtpassword.Attributes.Add("onkeypress", "return clickButton(event,'" + btnlogin.ClientID + "')");

                ddldomain.Items.Insert(0, new System.Web.UI.WebControls.ListItem("PTT", "PTT"));
                ddldomain.Items.Insert(1, new System.Web.UI.WebControls.ListItem("Local User", "Local User"));
            }
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                POPUPMSG("กรุณากรอก Username");
                return;
            }
            else if (txtpassword.Text == "")
            {
                POPUPMSG("กรุณากรอก Password");
                return;
            }
            else
            {
                if (ddldomain.SelectedIndex == 1)
                {
                    var user = Serv.GetUserByUsernamePassword(txtusername.Text, txtpassword.Text);
                    if (user.Rows.Count != 0)
                    {
                        if (user.Rows[0]["flag_active"].ToString() == "y")
                        {
                            HttpContext.Current.Session["assetuserid"] = user.Rows[0]["userid"].ToString();
                            HttpContext.Current.Session["assetusername"] = user.Rows[0]["username"].ToString();
                            HttpContext.Current.Session["assetfname"] = user.Rows[0]["fname"].ToString();
                            HttpContext.Current.Session["assetlname"] = user.Rows[0]["lname"].ToString();
                            HttpContext.Current.Session["assetposision"] = "";
                            HttpContext.Current.Session["asset_who"] = "local";

                            HttpContext.Current.Session["assetposision"] = "";
                            
                            if(user.Rows[0]["authorize1"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetrole"] = "Visitor";
                            }
                            else if (user.Rows[0]["authorize2"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetrole"] = "Reporter";
                            }
                            else if (user.Rows[0]["authorize3"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetrole"] = "Approver";
                            }
                            else if (user.Rows[0]["authorize4"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetrole"] = "Admin";
                            }

                            if (user.Rows[0]["authorize1"].ToString() == "y" || user.Rows[0]["authorize2"].ToString() == "y" || user.Rows[0]["authorize3"].ToString() == "y" || user.Rows[0]["authorize4"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetdownload"] = "y";
                            }
                            else
                            {
                                HttpContext.Current.Session["assetdownload"] = "n";
                            }

                            if (user.Rows[0]["authorize2"].ToString() == "y" || user.Rows[0]["authorize3"].ToString() == "y" || user.Rows[0]["authorize4"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetmanagement"] = "y";
                            }
                            else
                            {
                                HttpContext.Current.Session["assetmanagement"] = "n";
                            }

                            if (user.Rows[0]["authorize3"].ToString() == "y" || user.Rows[0]["authorize4"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetapprove"] = "y";
                            }
                            else
                            {
                                HttpContext.Current.Session["assetapprove"] = "n";
                            }

                            if (user.Rows[0]["authorize4"].ToString() == "y")
                            {
                                HttpContext.Current.Session["assetsysmanage"] = "y";
                            }
                            else
                            {
                                HttpContext.Current.Session["assetsysmanage"] = "n";
                            }

                            Response.Redirect("~/home.aspx");
                        }
                        else
                        {
                            POPUPMSG("Username ของท่านถูกลบออกจากระบบแล้ว");
                            return;
                        }
                    }
                    else
                    {
                        POPUPMSG("Username หรือ Password ไม่ถูกต้อง");
                        return;
                    }
                }
                else
                {
                    var result = Serv.SetupSession(txtusername.Text, txtpassword.Text);
                    if (result)
                    {
                        var user = Serv.GetUserPTT_info(txtusername.Text);
                        if (user.Rows.Count != 0)
                        {
                            HttpContext.Current.Session["assetuserid"] = user.Rows[0]["CODE"].ToString();
                            HttpContext.Current.Session["assetusername"] = user.Rows[0]["CODE"].ToString();
                            HttpContext.Current.Session["assetfname"] = user.Rows[0]["FNAME"].ToString();
                            HttpContext.Current.Session["assetlname"] = user.Rows[0]["LNAME"].ToString();
                            HttpContext.Current.Session["assetposision"] = user.Rows[0]["unitname"].ToString();
                            HttpContext.Current.Session["asset_who"] = "ptt";

                            HttpContext.Current.Session["assetrole"] = "";// user.Rows[0]["unitname"].ToString();

                            var autho = Serv.GetUserPTT_autho(txtusername.Text);
                            if (autho.Rows.Count != 0)
                            {
                                if (autho.Rows[0]["authorize1"].ToString() == "y" || autho.Rows[0]["authorize2"].ToString() == "y" || autho.Rows[0]["authorize3"].ToString() == "y" || autho.Rows[0]["authorize4"].ToString() == "y")
                                {
                                    HttpContext.Current.Session["assetdownload"] = "y";
                                }
                                else
                                {
                                    HttpContext.Current.Session["assetdownload"] = "n";
                                }

                                if (autho.Rows[0]["authorize2"].ToString() == "y" || autho.Rows[0]["authorize3"].ToString() == "y" || autho.Rows[0]["authorize4"].ToString() == "y")
                                {
                                    HttpContext.Current.Session["assetmanagement"] = "y";
                                }
                                else
                                {
                                    HttpContext.Current.Session["assetmanagement"] = "n";
                                }

                                if (autho.Rows[0]["authorize3"].ToString() == "y" || autho.Rows[0]["authorize4"].ToString() == "y")
                                {
                                    HttpContext.Current.Session["assetapprove"] = "y";
                                }
                                else
                                {
                                    HttpContext.Current.Session["assetapprove"] = "n";
                                }

                                if (autho.Rows[0]["authorize4"].ToString() == "y")
                                {
                                    HttpContext.Current.Session["assetsysmanage"] = "y";
                                }
                                else
                                {
                                    HttpContext.Current.Session["assetsysmanage"] = "n";
                                }


                                Response.Redirect("~/home.aspx");
                            }
                            else
                            {
                                POPUPMSG("Username ยังไม่ถูกตั้งสิทธิ์ในระบบ");
                                return;
                            }
                        }

                    }
                    else
                    {
                        POPUPMSG("Username หรือ Password ไม่ถูกต้อง");
                        return;
                    }
                }

            }
        }

        protected void lnkforgot_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/forget_pass.aspx");
        }
        private void POPUPMSG(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("alert(\'");
            sb.Append(msg.Replace("\n", "\\n").Replace("\r", "").Replace("\'", "\\\'"));
            sb.Append("\');");
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "showalert", sb.ToString(), true);
        }

    }
}