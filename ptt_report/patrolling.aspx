<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="patrolling.aspx.cs" Inherits="ptt_report.patrolling" %>


<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <div class="bar_qr">
        <br />
        <br />
        Customer Type :
                   
      <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn" OnClick="btnHistory_Click" />

                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" CssClass="btn btn-info" />

    </div>

    <style>
        #menuleft02 {
            background: #0c7fd2;
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

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">Patrolling
                 <asp:HiddenField ID="hddpatolling_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />

            </h3>
            <div class="info_executive">
                <h3>3rd party Interface > Patrolling</h3>
                <div class="info_executive_in">
                    <table>



                        <tr>
                            <td>Ground Patrolling Result: </td>
                            <td class="auto-style1">
                                <asp:FileUpload ID="PatrollingUpload" BackColor="#99ff99" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>Aerial Result : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="PatrollingAerialResult" BackColor="#99ff99" runat="server" TextMode="MultiLine"></asp:TextBox></td>

                        </tr>
                        <tr>
                            <td>หมายเหตุ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="PatrollingNote" BackColor="#99ff99" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="PatrollingProblem" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="PatrollingFormFeedback" runat="server" TextMode="MultiLine" BackColor="#CCCCFF"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td class="auto-style1">
                                <asp:Button ID="PatrollingFormSaveSubmit" runat="server" Text="Save" OnClick="PatrollingFormSaveSubmit_Click1" CssClass="btn" />
                                <asp:Button ID="btnApprove" runat="server" Text="Approve Report" OnClick="btnApprove_Click" CssClass="btn" />
                                <span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH">
            <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" CssClass="btn" />
                                หมายเหตุ</span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span class="auto-style3">: </span><span class="auto-style3" lang="TH">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
