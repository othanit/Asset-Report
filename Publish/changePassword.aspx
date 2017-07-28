<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="ptt_report.changePassword" %>
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
     <div class="col-lg-12">
        <h3 class="mini_head">Change Password
        </h3>
    </div>
   
    <div class="Hbg">
        <table id="ChangePassTable">
            <tr>
                <td style="text-align:right">*Old password :
                </td>
                <td>
                    <asp:TextBox ID="txtoldpassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align:right">*New password :
                </td>
                <td>
                    <asp:TextBox ID="txtnewpassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    กรุณากรอก Password อย่างน้อย 8 อักษร ประกอบด้วย A-Z, a-z, 0-9,!@#$%
                </td>
            </tr>
            <tr>
                <td style="text-align:right">*Confirm new password :
                </td>
                <td>
                    <asp:TextBox ID="txtConpassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    กรุณากรอก Password อย่างน้อย 8 อักษร ประกอบด้วย A-Z, a-z, 0-9,!@#$%
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnConfirm" runat="server" Text="Submit" OnClick="btnConfirm_Click" class="btn btn-info" />
                    <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" class="btn btn-info" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
