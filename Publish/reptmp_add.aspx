<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reptmp_add.aspx.cs" Inherits="ptt_report.reptmp_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hddfile_path" runat="server" />
    <asp:HiddenField ID="hddTmpid" runat="server" />
    <table>
        <tr>
            <td>Report type : 
            </td>
            <td>
                <asp:DropDownList ID="ddlRepType" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Template :
            </td>
            <td>
                <asp:Label ID="lbFileName" runat="server" Text=""></asp:Label>
                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
            </td>
        </tr>
        <tr>
            <td>File :
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
