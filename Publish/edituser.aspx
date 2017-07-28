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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hddusername" runat="server" />
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">User Management</asp:LinkButton>
    -> Add user
    <div>
        <table>
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
                <td>*Password :
                </td>
                <td>
                    <asp:TextBox ID="txtpassword" TextMode="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>*Re-Password :
                </td>
                <td>
                    <asp:TextBox ID="txtconpassword" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>*Email :
                </td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <div>
            *Authorization
        </div>
        <table>
            <tr>
                <td>Visitor
                </td>
                <td>Reporter
                </td>
                <td>Approver
                </td>
                <td>Admin
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox3" runat="server" />
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox4" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <table>
            <tr>
                <td>Status :
                </td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Active" Checked="true" GroupName="status" /><asp:RadioButton ID="RadioButton2" runat="server" Text="Inactive" GroupName="status" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" />
    </div>
</asp:Content>
