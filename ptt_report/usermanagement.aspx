<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="usermanagement.aspx.cs" Inherits="ptt_report.usermanagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function clickButton(e, buttonid) {
            var evt = e ? e : window.event;
            var bt = document.getElementById(buttonid);
            if (bt) {
                if (evt.keyCode == 13) {
                    bt.click();
                    return false;
                }
            }
        }
        function next_tools(e, buttonid) {
            var evt = e ? e : window.event;
            var bt = document.getElementById(buttonid);
            if (bt) {
                if (evt.keyCode == 13) {
                    bt.focus();
                    return false;
                }
            }
        }
        function isNumberKey2AndEnter(event, buttonid)  // ตัวเลขอย่างเดียว
        {
            var charCode = (event.which) ? event.which : event.keyCode
            if (charCode != 13 && (charCode != 46) && (charCode != 08) && (charCode < 48 || charCode > 57)) {
                return false;
            }
            else {
                var evt = event ? event : window.event;
                var bt = document.getElementById(buttonid);
                if (bt) {
                    if (evt.keyCode == 13) {
                        bt.focus();
                        return false;
                    }
                }
                //return true;
            }
        }
    </script>
    <link rel="stylesheet" href="Style/chosen.css" />
    <style>
        #ContentPlaceHolder1_gridview_user_ptt {
            width:100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="width: 95px" class="bar bar2">
        <i class="fa fa-user fa-6" aria-hidden="true"></i>
        <br />
        <asp:Button ID="btnbsa" runat="server" Text="BSA" OnClick="btnbsa_Click" />
    </div>
    <div style="width: 95px" class="bar bar1">
        <i class="fa fa-file-text fa-6" aria-hidden="true"></i>
        <br />
        <asp:Button ID="btndepartment" runat="server" Text="Department" OnClick="btndepartment_Click" />
    </div>
    <div style="width: 861px; min-height: 132px;" class="barinfo">
        <h2 class="page_header">Account Management</h2>

        <div id="divbsa" runat="server" visible="false">
            <table>
                <tr>
                    <td>
                        <asp:TextBox ID="txtsearch" runat="server" class="form-control" placeholder="Username,Name,Last Name" style="    width: 300px;"></asp:TextBox>

                        <asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="Search" class="btn btn-info" />

                        <asp:Button ID="btnadd" runat="server" Text="Add" OnClick="btnadd_Click" class="btn btn-info" style="    float: right;" /></td>

                </tr>
            </table>


        </div>
        <div id="divptt" runat="server" visible="true">
            <table>
                <tr>
                    <td style="width: 100px;">Department: </td>
                    <td>
                        <div class="side-by-side clearfix">

                            <div>
                                <asp:DropDownList ID="ddldepartment" runat="server" class="chzn-select"  AutoPostBack="true" OnSelectedIndexChanged="ddldepartment_SelectedIndexChanged"></asp:DropDownList>

                            </div>
                        </div>
                        <script src="Scripts/jquery.min.js" type="text/javascript"></script>
                        <script src="Scripts/chosen.jquery.js" type="text/javascript"></script>
                        <script type="text/javascript"> $(".chzn-select").chosen(); $(".chzn-select-deselect").chosen({ allow_single_deselect: true }); </script>
                    </td>
                </tr>
                <tr>
                    <td style="width: 100px;">Employee: </td>
                    <td>
                        <asp:TextBox ID="txtsearch2" runat="server" class="form-control" placeholder="Employee ID, Name, Last Name" style=" width: 300px;"></asp:TextBox>
                        <asp:Button ID="btnSearch2" runat="server" OnClick="btnSearch2_Click" Text="Search" class="btn btn-info" /></td>
                </tr>

            </table>

        </div>

    </div>




    <br clear="all" />
    <h3 class="mini_head">User</h3>
    <asp:GridView ID="gridview_user_ptt" runat="server" AutoGenerateColumns="False" AllowPaging="True"
        OnPageIndexChanging="gridview_user_ptt_PageIndexChanging" OnRowDataBound="gridview_user_ptt_RowDataBound" PageSize="20">
        <Columns>

            <asp:BoundField DataField="code" HeaderText="Employee ID" />
            <asp:BoundField DataField="name" HeaderText="Employee" />
            <asp:BoundField DataField="posname" HeaderText="Position" />

            <asp:TemplateField HeaderText="Visitor">
                <ItemTemplate>
                    <asp:HiddenField ID="hddcode" Value='<%# Eval("CODE") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize1" Value='<%# Eval("autho1") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize2" Value='<%# Eval("autho2") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize3" Value='<%# Eval("autho3") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize4" Value='<%# Eval("autho4") %>' runat="server" />
                    <asp:RadioButton ID="chkAutho1" runat="server" GroupName="autho" OnCheckedChanged="chkAutho1_CheckedChanged" AutoPostBack="true" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Reporter">
                <ItemTemplate>
                    <asp:RadioButton ID="chkAutho2" runat="server" GroupName="autho" OnCheckedChanged="chkAutho2_CheckedChanged" AutoPostBack="true" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Approver">
                <ItemTemplate>
                    <asp:RadioButton ID="chkAutho3" runat="server" GroupName="autho" OnCheckedChanged="chkAutho3_CheckedChanged" AutoPostBack="true" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Admin">
                <ItemTemplate>
                    <asp:RadioButton ID="chkAutho4" runat="server" GroupName="autho" OnCheckedChanged="chkAutho4_CheckedChanged" AutoPostBack="true" />
                </ItemTemplate>
            </asp:TemplateField>


        </Columns>
    </asp:GridView>
    <asp:GridView ID="gridview_user_bas" runat="server" AutoGenerateColumns="false" AllowPaging="true"
        OnPageIndexChanging="gridview_user_bas_PageIndexChanging" OnRowDataBound="gridview_user_bas_RowDataBound"
        ShowFooter="false" PageSize="20" CssClass="table table-bordered table-striped">
        <Columns>

            <asp:TemplateField HeaderText="Username">
                <ItemTemplate>
                    <asp:HiddenField ID="hdduserid" Value='<%# Eval("userid") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize1" Value='<%# Eval("authorize1") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize2" Value='<%# Eval("authorize2") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize3" Value='<%# Eval("authorize3") %>' runat="server" />
                    <asp:HiddenField ID="hddauthorize4" Value='<%# Eval("authorize4") %>' runat="server" />
                    <asp:HiddenField ID="hddusername" Value='<%# Eval("username") %>' runat="server" />
                    <asp:LinkButton ID="lnkusername" runat="server" Text='<%# Eval("username") %>' OnClick="lnkusername_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Employee">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkemployee" runat="server" Text='<%# Eval("employee") %>' OnClick="lnkemployee_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Visitor">
                <ItemTemplate>
                    <asp:RadioButton ID="chkAutho1" runat="server" GroupName="autho" Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Reporter">
                <ItemTemplate>
                    <asp:RadioButton ID="chkAutho2" runat="server" GroupName="autho" Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Approver">
                <ItemTemplate>
                    <asp:RadioButton ID="chkAutho3" runat="server" GroupName="autho" Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Admin">
                <ItemTemplate>
                    <asp:RadioButton ID="chkAutho4" runat="server" GroupName="autho" Enabled="false" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Manage">
                <ItemTemplate>
                    <asp:Button ID="btndelbas" runat="server" Text="Delete" OnClick="btndelbas_Click" CssClass="btn btn-danger" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="update_date" HeaderText="Last Update" />

        </Columns>
    </asp:GridView>
</asp:Content>
