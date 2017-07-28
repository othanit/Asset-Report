using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class create_quar_rep : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        create_quar_repDLL Serv = new create_quar_repDLL();
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
                    bind_default();
                }
            }
        }
        protected void bind_default()
        {
            int y = Convert.ToInt32(DateTime.Now.ToString("yyyy", EngCI));
            for (int i = 0; i <= 3; i++)
            {
                y = y + i;
                ddlyear.Items.Insert(i, new ListItem(Convert.ToString(y), Convert.ToString(y)));
            }

            ddlquarter.Items.Insert(0, new ListItem("1", "1"));
            ddlquarter.Items.Insert(1, new ListItem("2", "2"));
            ddlquarter.Items.Insert(2, new ListItem("3", "3"));
            ddlquarter.Items.Insert(3, new ListItem("4", "4"));

        }

        protected void btnselect_Click(object sender, EventArgs e)
        {
            var list = Serv.GetRep(ddlyear.SelectedValue, ddlquarter.SelectedValue);
            if (list.Rows.Count != 0)
            {
                divRep_list.Visible = true;
                divRep_listfull.Visible = false;

                if (list.Rows.Count == 3)
                {
                    divRep_list.Visible = false;
                    divRep_listfull.Visible = true;
                    lbno.Text = "มีการสร้างรายงาน Quarterly Report ปี " + Convert.ToString(ddlyear.SelectedValue) + " ไตรมาส " + Convert.ToString(ddlquarter.SelectedValue) + " ในระบบแล้ว";
                }
                else if (list.Rows.Count == 2)
                {
                    if (list.Select("cus_type = 'Transmission'").Length == 0)
                    {
                        lbrep1.Text = "Transmission";
                    }
                    else if (list.Select("cus_type = 'NGR'").Length == 0)
                    {
                        lbrep1.Text = "NGR";
                    }
                    else if (list.Select("cus_type = 'NGV'").Length == 0)
                    {
                        lbrep1.Text = "NGV";
                    }
                }
                else if (list.Rows.Count == 1)
                {
                    if (list.Select("cus_type = 'Transmission'").Length == 0)
                    {
                        lbrep1.Text = "Transmission";
                    }
                    else if (list.Select("cus_type = 'NGR'").Length == 0)
                    {
                        lbrep1.Text = "NGR";
                    }
                    else if (list.Select("cus_type = 'NGV'").Length == 0)
                    {
                        lbrep1.Text = "NGV";
                    }

                    if (lbrep1.Text == "Transmission")
                    {
                        if (list.Select("cus_type = 'NGR'").Length == 0)
                        {
                            lbrep2.Text = "NGR";
                        }
                        else if (list.Select("cus_type = 'NGV'").Length == 0)
                        {
                            lbrep2.Text = "NGV";
                        }
                    }
                    else if (lbrep1.Text == "NGR")
                    {
                        if (list.Select("cus_type = 'Transmission'").Length == 0)
                        {
                            lbrep2.Text = "Transmission";
                        }
                        else if (list.Select("cus_type = 'NGV'").Length == 0)
                        {
                            lbrep2.Text = "NGV";
                        }
                    }
                    else if (lbrep1.Text == "NGV")
                    {
                        if (list.Select("cus_type = 'Transmission'").Length == 0)
                        {
                            lbrep2.Text = "Transmission";
                        }
                        else if (list.Select("cus_type = 'NGR'").Length == 0)
                        {
                            lbrep2.Text = "NGR";
                        }
                    }
                }
            }
            else
            {
                divRep_list.Visible = true;
                divRep_listfull.Visible = false;
                lbrep1.Text = "Transmission";
                lbrep2.Text = "NGR";
                lbrep3.Text = "NGV";
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (lbrep1.Text != "")
            {
                Serv.Insert_tblquarter_rep(ddlyear.SelectedValue, ddlquarter.SelectedValue, lbrep1.Text, "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI),
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                    HttpContext.Current.Session["assetuserid"].ToString());
            }
            if (lbrep2.Text != "")
            {
                Serv.Insert_tblquarter_rep(ddlyear.SelectedValue, ddlquarter.SelectedValue, lbrep2.Text, "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI),
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                    HttpContext.Current.Session["assetuserid"].ToString());
            }
            if (lbrep3.Text != "")
            {
                Serv.Insert_tblquarter_rep(ddlyear.SelectedValue, ddlquarter.SelectedValue, lbrep3.Text, "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", "Assign", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI),
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                    HttpContext.Current.Session["assetuserid"].ToString());
            }
            Response.Redirect("~/QuarterlyReport.aspx");
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/QuarterlyReport.aspx");
        }
    }
}