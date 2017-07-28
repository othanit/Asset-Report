<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="edituser.aspx.cs" Inherits="ptt_report.edituser" %>

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
    <style>
        .page_header {
            background-color: #bee9f7;
        }

        .wrapper input[type="text" i], .wrapper input[type="password" i] {
            width: 260px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hdduserid" runat="server" />
    <asp:HiddenField ID="hddusername" runat="server" />

    <h2 class="page_header" style="width: 1050px; background-color: #bee9f7; padding: 11px 50px;">Account Management</h2>
    <br class="all" />
    <h3 class="mini_head">
        <asp:Label ID="lbtitle" runat="server" Text="Add User"></asp:Label>
    </h3>

    <div class="boxUser">

        <div>
            <table class="formAddRep">
                <tr>
                    <td>*Name :
                </td>
                    <td>
                        <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                    </td>
                    <td>*Last Name :
                </td>
                    <td>
                        <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>*Username :
                </td>
                    <td>
                        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                    </td>
                    <td>*Email :
                </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>*Password :
                    </td>
                    <td>
                        <asp:TextBox ID="txtpassword" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="กรุณากรอก Password อย่างน้อย 8 อักษร ประกอบด้วย A-Z, a-z, 0-9,!@#$%"></asp:Label>
                    </td>
                    <td>*Re-Password :
                </td>
                    <td>
                        <asp:TextBox ID="txtconpassword" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" ForeColor="Black" Text="กรุณากรอก Password อย่างน้อย 8 อักษร ประกอบด้วย A-Z, a-z, 0-9,!@#$%"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td>*Authorization</td>
                    <td colspan="3">
                        <asp:RadioButton ID="CheckBox1" runat="server" GroupName="author" />
                        Visitor
                    <asp:RadioButton ID="CheckBox2" runat="server" GroupName="author"/>
                        Reporter
                    <asp:RadioButton ID="CheckBox3" runat="server" GroupName="author" />
                        Approver
                    <asp:RadioButton ID="CheckBox4" runat="server" GroupName="author"/>
                        Admin


                    </td>
                </tr>
                <tr>
                    <td>Status :</td>
                    <td colspan="3">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Active" Checked="true" GroupName="status" /><asp:RadioButton ID="RadioButton2" runat="server" Text="Inactive" GroupName="status" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="3">
                        <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" CssClass="btn btn-gray" />
                        <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CssClass="btn btn-danger" />
                    </td>
                </tr>
            </table>
        </div>


        <div>
        </div>
    </div>
</asp:Content>
