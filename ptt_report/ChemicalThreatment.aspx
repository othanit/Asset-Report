<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="ChemicalThreatment.aspx.cs" Inherits="ptt_report.ChemicalThreatment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft10 {
            background: #0c7fd2;
        }
        #ContentPlaceHolder1_ChildContent2_txtdetail,
        #ContentPlaceHolder1_ChildContent2_txtComment {
            width:100%;
        }
        .auto-style4 {
            font-size: medium;
            color: #FF0000;
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
    

        <asp:HiddenField ID="hddct_id" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
     <div class="bar_qr">
         <br />
        Customer Type :
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" class="btn" OnClick="btnHistory_Click" />

    </div>   
        <h3 class="barBlue">Chemical Treatment


        </h3>

        <div class="info_executive">
            <h3>
                <asp:LinkButton ID="lnkBack" runat="server" OnClick="lnkBack_Click">Inaternal Corrosion</asp:LinkButton>
                > Chemical Treatment</h3>
            <div class="info_executive_in">

                <table>
                    <tr>
                        <td>Detail :</td>
                        <td>
                            <asp:TextBox ID="txtdetail" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtComment" TextMode="MultiLine" runat="server" BackColor="#CCCCFF"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSave" runat="server" Text="Save" class="btn" OnClick="btnSave_Click" />
                            <span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH">
                          <asp:Button ID="btnApprove" runat="server" Text="Approve Report" OnClick="btnApprove_Click" CssClass="btn" />

            <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" CssClass="btn" />
                            หมายเหตุ</span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span class="auto-style3">: </span><span class="auto-style3" lang="TH">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></td>
                    </tr>
                </table>

            </div>
        </div>
    </div>
</asp:Content>
