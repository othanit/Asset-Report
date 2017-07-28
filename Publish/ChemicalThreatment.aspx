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
    </style>
    <div class="bar_qr">
        Customer Type :
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" />
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" />
        <asp:Button ID="btnHistory" runat="server" Text="History" class="btn" />
        
    </div>
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <h3 class="barBlue">Chemical Treatment
            <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />



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
                            <asp:TextBox ID="txtdetail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSave" runat="server" Text="Save" class="btn" />
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </div>
</asp:Content>
