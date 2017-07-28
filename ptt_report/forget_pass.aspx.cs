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
    public partial class forget_pass : System.Web.UI.Page
    {

        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        defaultDLL Serv = new defaultDLL();
        callmail mailServ = new callmail();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtemail.Focus();
                txtemail.Attributes.Add("onkeypress", "return clickButton(event,'" + btnforgot.ClientID + "')");
            }
        }

        protected void btnforgot_Click(object sender, EventArgs e)
        {
            if(txtemail.Text  == "")
            {
                POPUPMSG("กรุณากรอก Email");
                return;
            }
            else
            {
                var user = Serv.GetUserByEmail(txtemail.Text);
                if(user.Rows.Count != 0)
                {
                    mailServ.CallMail(user.Rows[0]["email"].ToString(), "User Information", "Password : " + user.Rows[0]["password"].ToString());
                    Response.Redirect("~/default.aspx");
                }
                else
                {
                    POPUPMSG("Email ของท่านไม่ถูกต้อง");
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
        






    }
}