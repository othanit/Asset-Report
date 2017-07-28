using ptt_report.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ptt_report
{
    public partial class usermanagement : System.Web.UI.Page
    {
        CultureInfo ThCI = new System.Globalization.CultureInfo("th-TH");
        CultureInfo EngCI = new System.Globalization.CultureInfo("en-US");
        usermanagementDLL Serv = new usermanagementDLL();
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
                    txtsearch.Attributes.Add("onkeypress", "return clickButton(event,'" + btnsearch.ClientID + "')");
                    txtsearch2.Attributes.Add("onkeypress", "return clickButton(event,'" + btnSearch2.ClientID + "')");

                    HttpContext.Current.Session["menu"] = "2";

                    bind_default();
                    bind_data();
                }
            }
        }

        protected void bind_default()
        {
            var depart = Serv.GetDepartment();
            if (depart.Rows.Count != 0)
            {
                ddldepartment.DataTextField = "department";
                ddldepartment.DataValueField = "unitcode";
                ddldepartment.DataSource = depart;
                ddldepartment.DataBind();
            }
            else
            {
                ddldepartment.DataSource = null;
                ddldepartment.DataBind();
            }
            ddldepartment.Items.Insert(0, new ListItem("หน่วยงานทั้งหมด",""));

        }

        protected void btndepartment_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["menu"] = "1";
            bind_data();
        }

        protected void btnbsa_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["menu"] = "2";
            bind_data();

        }

        protected void bind_data()
        {
            if (HttpContext.Current.Session["menu"].ToString() == "1")
            {
                divbsa.Visible = false;
                divptt.Visible = true;

                gridview_user_bas.DataSource = null;
                gridview_user_bas.DataBind();
                gridview_user_bas.Visible = false;

                DataTable dt = new DataTable();
                dt.Columns.Add("code");
                dt.Columns.Add("name");
                dt.Columns.Add("posname");
                dt.Columns.Add("autho1");
                dt.Columns.Add("autho2");
                dt.Columns.Add("autho3");
                dt.Columns.Add("autho4");

                var u_ptt = Serv.GetUserPTT(ddldepartment.SelectedValue,txtsearch2.Text );
                if(u_ptt.Rows.Count != 0)
                {

                    for(int i =0; i<= u_ptt.Rows.Count -1; i++)
                    {
                        DataRow row1 = dt.NewRow();
                        
                        row1["code"] = u_ptt.Rows[i]["code"].ToString();
                        row1["name"] = u_ptt.Rows[i]["name"].ToString();
                        row1["posname"] = u_ptt.Rows[i]["POSNAME"].ToString();

                        var autho = Serv.GetPtt_AuTho(u_ptt.Rows[i]["code"].ToString());
                        if (autho.Rows.Count != 0)
                        {
                            row1["autho1"] = autho.Rows[0]["authorize1"].ToString();
                            row1["autho2"] = autho.Rows[0]["authorize2"].ToString();
                            row1["autho3"] = autho.Rows[0]["authorize3"].ToString();
                            row1["autho4"] = autho.Rows[0]["authorize4"].ToString();
                        }
                        else
                        {
                            row1["autho1"] = "n";
                            row1["autho2"] = "n";
                            row1["autho3"] = "n";
                            row1["autho4"] = "n";
                        }

                        dt.Rows.Add(row1);
                    }
                    
                    if(dt.Rows.Count != 0)
                    {
                        gridview_user_ptt.DataSource = dt;
                        gridview_user_ptt.DataBind();

                        gridview_user_ptt.Visible = true;
                    }
                    else
                    {
                        gridview_user_ptt.DataSource = null;
                        gridview_user_ptt.DataBind();
                    }
                }
                else
                {
                    gridview_user_ptt.DataSource = null;
                    gridview_user_ptt.DataBind();
                }

            }
            else
            {
                divbsa.Visible = true;
                divptt.Visible = false;

                gridview_user_ptt.DataSource = null;
                gridview_user_ptt.DataBind();
                gridview_user_ptt.Visible = false;

                
                var u = Serv.GetUserBASByUsername(txtsearch.Text);
                if (u.Rows.Count != 0)
                {
                    gridview_user_bas.DataSource = u;
                    gridview_user_bas.DataBind();

                    gridview_user_bas.Visible = true;
                }
                else
                {
                    gridview_user_bas.DataSource = null;
                    gridview_user_bas.DataBind();
                }
            }
        }

        protected void btndel_Click(object sender, EventArgs e)
        {

        }
        protected void btndelbas_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddusername = (HiddenField)row.FindControl("hddusername");
            HiddenField hdduserid = (HiddenField)row.FindControl("hdduserid");

            var du = Serv.GetDelUserByUserid(hdduserid.Value);
            if (du.Rows.Count != 0)
            {
                Serv.UpdateDelUser(hdduserid.Value);
            }
            else
            {
                Serv.InsertDelUser(hddusername.Value, "n", "n", "n", "n", "n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:dd", EngCI), HttpContext.Current.Session["assetuserid"].ToString(),hdduserid.Value);
            }
            bind_data();
        }


        protected void gridview_user_bas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridview_user_bas.PageIndex = e.NewPageIndex;
            this.bind_data();
        }

        protected void gridview_user_ptt_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridview_user_ptt.PageIndex = e.NewPageIndex;
            this.bind_data();
        }

        protected void lnkemployee_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddusername = (HiddenField)row.FindControl("hddusername");
            HiddenField hdduserid = (HiddenField)row.FindControl("hdduserid");

            Response.Redirect("~/edituser.aspx?param=" + hdduserid.Value);
        }

        protected void lnkusername_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            HiddenField hddusername = (HiddenField)row.FindControl("hddusername");
            HiddenField hdduserid = (HiddenField)row.FindControl("hdduserid");

            Response.Redirect("~/edituser.aspx?param=" + hdduserid.Value);
        }

        protected void gridview_user_bas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HiddenField hddusername = (HiddenField)(e.Row.FindControl("hddusername"));
                HiddenField hddauthorize1 = (HiddenField)(e.Row.FindControl("hddauthorize1"));
                HiddenField hddauthorize2 = (HiddenField)(e.Row.FindControl("hddauthorize2"));
                HiddenField hddauthorize3 = (HiddenField)(e.Row.FindControl("hddauthorize3"));
                HiddenField hddauthorize4 = (HiddenField)(e.Row.FindControl("hddauthorize4"));

                CheckBox chkAutho1 = (CheckBox)(e.Row.FindControl("chkAutho1"));
                CheckBox chkAutho2 = (CheckBox)(e.Row.FindControl("chkAutho2"));
                CheckBox chkAutho3 = (CheckBox)(e.Row.FindControl("chkAutho3"));
                CheckBox chkAutho4 = (CheckBox)(e.Row.FindControl("chkAutho4"));


                Button btndelbas = (Button)(e.Row.FindControl("btndelbas"));

                if (hddauthorize1.Value == "y")
                {
                    chkAutho1.Checked = true;
                }
                if (hddauthorize2.Value == "y")
                {
                    chkAutho2.Checked = true;
                }
                if (hddauthorize3.Value == "y")
                {
                    chkAutho3.Checked = true;
                }
                if (hddauthorize4.Value == "y")
                {
                    chkAutho4.Checked = true;
                }

                btndelbas.Attributes.Add("onclick", "return confirm('!!! ท่านต้องการลบหรือไม่ !!!');");
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/edituser.aspx");
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            bind_data();
        }

        protected void gridview_user_ptt_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                HiddenField hddauthorize1 = (HiddenField)(e.Row.FindControl("hddauthorize1"));
                HiddenField hddauthorize2 = (HiddenField)(e.Row.FindControl("hddauthorize2"));
                HiddenField hddauthorize3 = (HiddenField)(e.Row.FindControl("hddauthorize3"));
                HiddenField hddauthorize4 = (HiddenField)(e.Row.FindControl("hddauthorize4"));

                RadioButton chkAutho1 = (RadioButton)(e.Row.FindControl("chkAutho1"));
                RadioButton chkAutho2 = (RadioButton)(e.Row.FindControl("chkAutho2"));
                RadioButton chkAutho3 = (RadioButton)(e.Row.FindControl("chkAutho3"));
                RadioButton chkAutho4 = (RadioButton)(e.Row.FindControl("chkAutho4"));

                if (hddauthorize1.Value == "y")
                {
                    chkAutho1.Checked = true;
                }
                else
                {
                    chkAutho1.Checked = false ;

                }
                if (hddauthorize2.Value == "y")
                {
                    chkAutho2.Checked = true;
                }
                else
                {
                    chkAutho2.Checked = false ;
                }
                if (hddauthorize3.Value == "y")
                {
                    chkAutho3.Checked = true;
                }
                else
                {
                    chkAutho3.Checked = false;
                }
                if (hddauthorize4.Value == "y")
                {
                    chkAutho4.Checked = true;
                }
                else
                {
                    chkAutho4.Checked = false;
                }

            }
        }

        protected void ddldepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_data();
        }

        protected void btnSearch2_Click(object sender, EventArgs e)
        {
            bind_data();
        }

        protected void chkAutho1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            HiddenField hddcode = (HiddenField)row.FindControl("hddcode");//
            var u = Serv.GetPtt_AuTho(hddcode.Value);
            if(u.Rows.Count != 0)
            {
                Serv.UpdatetblpttAutho("y", "n", "n", "n", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }
            else
            {
                Serv.InserttblpttAutho("y", "n", "n", "n", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }

        }

        protected void chkAutho2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            HiddenField hddcode = (HiddenField)row.FindControl("hddcode");//
            var u = Serv.GetPtt_AuTho(hddcode.Value);
            if (u.Rows.Count != 0)
            {
                Serv.UpdatetblpttAutho("n", "y", "n", "n", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }
            else
            {
                Serv.InserttblpttAutho("n", "y", "n", "n", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }
        }

        protected void chkAutho3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            HiddenField hddcode = (HiddenField)row.FindControl("hddcode");//
            var u = Serv.GetPtt_AuTho(hddcode.Value);
            if (u.Rows.Count != 0)
            {
                Serv.UpdatetblpttAutho("n", "n", "y", "n", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }
            else
            {
                Serv.InserttblpttAutho("n", "n", "y", "n", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }
        }

        protected void chkAutho4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            HiddenField hddcode = (HiddenField)row.FindControl("hddcode");//
            var u = Serv.GetPtt_AuTho(hddcode.Value);
            if (u.Rows.Count != 0)
            {
                Serv.UpdatetblpttAutho("n", "n", "n", "y", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }
            else
            {
                Serv.InserttblpttAutho("n", "n", "n", "y", hddcode.Value, HttpContext.Current.Session["assetuserid"].ToString());
            }
        }
    }
}