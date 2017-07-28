using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class changePassword : System.Web.UI.Page
    {
        defaultDLL Serv = new defaultDLL();
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Object objUserTheme = HttpContext.Current.Session["assetuserid"];
                if (objUserTheme == null)
                {
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    txtoldpassword.Focus();
                    txtoldpassword.Attributes.Add("onkeypress", "return next_tools(event,'" + txtnewpassword.ClientID + "')");
                    txtnewpassword.Attributes.Add("onkeypress", "return next_tools(event,'" + txtConpassword.ClientID + "')");
                    txtConpassword.Attributes.Add("onkeypress", "return clickButton(event,'" + btnConfirm.ClientID + "')");
                }

            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Regex pattern1 = new Regex(@"\W|_");
            Regex pattern2 = new Regex(@"[0-9]");
            Regex pattern3 = new Regex(@"[A-Z]");
            Regex pattern4 = new Regex(@"[a-z]");

            if (txtoldpassword.Text == "")
            {
                POPUPMSG(" กรุณาใส่ Old Password ");
                return;
            }
            else if (txtnewpassword.Text.Length < 8)
            {
                POPUPMSG(" กรุณาใส่ Password มากกว่า 8 ตัวอักษร ");
                return;
            }
            else if (txtnewpassword.Text == "")
            {
                POPUPMSG(" กรุณาใส่ New Password ");
                return;
            }
            else if (txtConpassword.Text == "")
            {
                POPUPMSG(" กรุณาใส่ Confirm New Password ");
                return;
            }
            else if (txtnewpassword.Text != txtConpassword.Text)
            {
                POPUPMSG("New password และ Confirm new password ไม่ตรงกัน");
                return;
            }
            else if (pattern2.IsMatch(txtnewpassword.Text) == false)
            {
                POPUPMSG(" Password ต้องประกอบด้วยตัวเลข 0-9 ");
                return;
            }
            else if (pattern3.IsMatch(txtnewpassword.Text) == false)
            {
                POPUPMSG(" Password ต้องประกอบด้วยตัวอักษรตัวใหญ่ A-Z ");
                return;
            }
            else if (pattern4.IsMatch(txtnewpassword.Text) == false)
            {
                POPUPMSG(" Password ต้องประกอบด้วยตัวอักษรตัวเล็ก a-z ");
                return;
            }
            else if (pattern1.IsMatch(txtnewpassword.Text) == false)
            {
                POPUPMSG(" Password ต้องประกอบด้วยสัญลักษณ์ !@#$% อย่างน้อย 1 ตัว ");
                return;
            }
            else
            {
                var u = Serv.GetUserByUsernamePassword(HttpContext.Current.Session["assetusername"].ToString(), txtoldpassword.Text);
                if (u.Rows.Count != 0)
                {
                    Serv.UpdatePassword(HttpContext.Current.Session["assetusername"].ToString(), txtnewpassword.Text);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('บันทึกเรียบร้อย');window.location ='home.aspx';", true);
                }
                else
                {
                    POPUPMSG(" Old Password ของท่านไม่ถูกต้อง");
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

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/home.aspx");
        }
    }
}