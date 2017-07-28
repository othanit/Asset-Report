<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ptt_report._default" %>

<!DOCTYPE html>
<!-- Bootstrap Core CSS -->
<link href="css/bootstrap.min.css" rel="stylesheet">

<!-- Custom CSS -->
<link href="css/styles.css" rel="stylesheet">

<!-- Custom Fonts -->
<link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
<!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divLogin">

            <img src="img/logo.png" />
            <br />

            <table>
                <tr>
                    <td>Domain
                        <asp:DropDownList ID="ddldomain" runat="server" CssClass="form-control"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Username
                        <asp:TextBox ID="txtusername" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>


                    <td>Password
                        <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:LinkButton ID="lnkforgot" runat="server" OnClick="lnkforgot_Click">Forgot password</asp:LinkButton>
                    </td>

                </tr>
                <tr>

                    <td>
                        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" class="btn btn-default btn-lg btn-block"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
