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
    public partial class edituser : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        usermanagementDLL Serv = new usermanagementDLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtfname.Focus();
                txtfname.Attributes.Add("onkeypress", "return next_tools(event,'" + txtlastname.ClientID + "')");
                txtlastname.Attributes.Add("onkeypress", "return next_tools(event,'" + txtusername.ClientID + "')");
                txtusername.Attributes.Add("onkeypress", "return next_tools(event,'" + txtpassword.ClientID + "')");
                txtpassword.Attributes.Add("onkeypress", "return next_tools(event,'" + txtconpassword.ClientID + "')");
                txtconpassword.Attributes.Add("onkeypress", "return next_tools(event,'" + txtemail.ClientID + "')");
                txtemail.Attributes.Add("onkeypress", "return clickButton(event,'" + btnsave.ClientID + "')");

                Object objUserTheme = HttpContext.Current.Session["assetuserid"];
                if (objUserTheme == null)
                {
                    Response.Redirect("~/default.aspx");
                }
                else
                {
                    if (!string.IsNullOrEmpty(Request.QueryString["param"]))
                    {
                        hdduserid.Value = Request.QueryString["param"].ToString();
                        lbtitle.Text = "Edit User";
                    }
                    else
                    {
                        hdduserid.Value = "";
                    }

                    bind_data();
                }
            }
        }

        protected void bind_data()
        {
            if (hdduserid.Value != "")
            {
                txtusername.Enabled = false;
                var u = Serv.GetUserBASByUsername2(hdduserid.Value);
                if (u.Rows.Count != 0)
                {
                    txtemail.Text = u.Rows[0]["email"].ToString();
                    txtfname.Text = u.Rows[0]["fname"].ToString();
                    txtlastname.Text = u.Rows[0]["lname"].ToString();
                    txtusername.Text = u.Rows[0]["username"].ToString();

                    if (u.Rows[0]["flag_active"].ToString() == "y")
                    {
                        RadioButton1.Checked = true;
                        RadioButton2.Checked = false;
                    }
                    else
                    {
                        RadioButton1.Checked = false;
                        RadioButton2.Checked = true;
                    }

                    if (u.Rows[0]["authorize1"].ToString() == "y")
                    {
                        CheckBox1.Checked = true;
                    }
                    if (u.Rows[0]["authorize2"].ToString() == "y")
                    {
                        CheckBox2.Checked = true;
                    }
                    if (u.Rows[0]["authorize3"].ToString() == "y")
                    {
                        CheckBox3.Checked = true;
                    }
                    if (u.Rows[0]["authorize4"].ToString() == "y")
                    {
                        CheckBox4.Checked = true;
                    }

                }
                else
                {
                    hdduserid.Value = "";
                }
            }
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/usermanagement.aspx");
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/usermanagement.aspx");
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (hdduserid.Value != "")
            {
                string status = "";
                string au1 = "";
                string au2 = "";
                string au3 = "";
                string au4 = "";

                if (txtfname.Text == "")
                {
                    POPUPMSG("กรุณากรอก Name");
                    return;
                }
                else if (txtlastname.Text == "")
                {
                    POPUPMSG("กรุณากรอก Last Name");
                    return;
                }
                else if (txtemail.Text == "")
                {
                    POPUPMSG("กรุณากรอก Email");
                    return;
                }

                if (RadioButton1.Checked == true)
                {
                    status = "y";
                }
                else
                {
                    status = "n";
                }

                if (CheckBox1.Checked == true)
                {
                    au1 = "y";
                }
                else
                {
                    au1 = "n";
                }
                if (CheckBox2.Checked == true)
                {
                    au2 = "y";
                }
                else
                {
                    au2 = "n";
                }
                if (CheckBox3.Checked == true)
                {
                    au3 = "y";
                }
                else
                {
                    au3 = "n";
                }
                if (CheckBox4.Checked == true)
                {
                    au4 = "y";
                }
                else
                {
                    au4 = "n";
                }

                if (au1 == "n" && au2 == "n" && au3 == "n" && au4 == "n")
                {
                    POPUPMSG("กรุณาเลือก Authorization");
                    return;
                }

                var du = Serv.GetDelUserByUsername(hdduserid.Value);
                if (du.Rows.Count != 0)
                {
                    Serv.UpdateDelUserAll(au1, au2, au3, au4, status, DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                        hdduserid.Value);
                }
                else
                {
                    Serv.InsertDelUser(txtusername.Text, au1, au2, au3, au4, status, DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(), hdduserid.Value);
                }
                bind_data();

                if (txtpassword.Text != "")
                {
                    if (txtpassword.Text != txtconpassword.Text)
                    {
                        POPUPMSG("Password และ Re-password ไม่ตรงกัน");
                        return;
                    }
                    else
                    {
                        Serv.UpdatePassword(txtpassword.Text, hdduserid.Value);
                    }
                }
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('บันทึกเรียบร้อย');window.location ='usermanagement.aspx';", true);

            }
            else
            {
                Regex pattern1 = new Regex(@"\W|_");
                Regex pattern2 = new Regex(@"[0-9]");
                Regex pattern3 = new Regex(@"[A-Z]");
                Regex pattern4 = new Regex(@"[a-z]");

                string status = "";
                string au1 = "";
                string au2 = "";
                string au3 = "";
                string au4 = "";

                if (txtfname.Text == "")
                {
                    POPUPMSG("กรุณากรอก Name");
                    return;
                }
                else if (txtlastname.Text == "")
                {
                    POPUPMSG("กรุณากรอก Last Name");
                    return;
                }
                else if (txtemail.Text == "")
                {
                    POPUPMSG("กรุณากรอก Email");
                    return;
                }
                else if (txtpassword.Text == "")
                {
                    POPUPMSG("กรุณากรอก Password");
                    return;
                }
                else if (txtpassword.Text.Length < 8)
                {
                    POPUPMSG(" กรุณาใส่ Password มากกว่า 8 ตัวอักษร ");
                    return;
                }
                else if (pattern2.IsMatch(txtpassword.Text) == false)
                {
                    POPUPMSG(" Password ต้องประกอบด้วยตัวเลข 0-9 ");
                    return;
                }
                else if (pattern3.IsMatch(txtpassword.Text) == false)
                {
                    POPUPMSG(" Password ต้องประกอบด้วยตัวอักษรตัวใหญ่ A-Z ");
                    return;
                }
                else if (pattern4.IsMatch(txtpassword.Text) == false)
                {
                    POPUPMSG(" Password ต้องประกอบด้วยตัวอักษรตัวเล็ก a-z ");
                    return;
                }
                else if (pattern1.IsMatch(txtpassword.Text) == false)
                {
                    POPUPMSG(" Password ต้องประกอบด้วยสัญลักษณ์ !@#$% อย่างน้อย 1 ตัว ");
                    return;
                }
                else if (txtconpassword.Text == "")
                {
                    POPUPMSG("กรุณากรอก Re-password");
                    return;
                }
                else if (txtpassword.Text != txtconpassword.Text)
                {
                    POPUPMSG("Password และ Re-password ไม่ตรงกัน");
                    return;
                }

                else
                {
                    if (RadioButton1.Checked == true)
                    {
                        status = "y";
                    }
                    else
                    {
                        status = "n";
                    }

                    if (CheckBox1.Checked == true)
                    {
                        au1 = "y";
                    }
                    else
                    {
                        au1 = "n";
                    }
                    if (CheckBox2.Checked == true)
                    {
                        au2 = "y";
                    }
                    else
                    {
                        au2 = "n";
                    }
                    if (CheckBox3.Checked == true)
                    {
                        au3 = "y";
                    }
                    else
                    {
                        au3 = "n";
                    }
                    if (CheckBox4.Checked == true)
                    {
                        au4 = "y";
                    }
                    else
                    {
                        au4 = "n";
                    }

                    if (au1 == "n" && au2 == "n" && au3 == "n" && au4 == "n")
                    {
                        POPUPMSG("กรุณาเลือก Authorization");
                        return;
                    }

                    var u_email = Serv.GetUserBASByEmail(txtemail.Text);
                    if (u_email.Rows.Count != 0)
                    {
                        POPUPMSG("Email ที่กรอกซ้ำในระบบ");
                        return;
                    }

                    var user = Serv.InsertUser(txtfname.Text, txtlastname.Text, txtusername.Text, txtpassword.Text, txtemail.Text,
                        "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                         DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString());

                    Serv.InsertDelUser(txtusername.Text, au1, au2, au3, au4, status, DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                     DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(), user.Rows[0]["id"].ToString());

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('บันทึกเรียบร้อย');window.location ='usermanagement.aspx';", true);

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