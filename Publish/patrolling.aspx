<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="patrolling.aspx.cs" Inherits="ptt_report.patrolling" %>


<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft02 {
            background: #0c7fd2;
        }
    </style>
    <div class="bar_qr">
        Customer Type :
                   
                    <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn" />
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" />
        <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn" />

    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">Patrolling
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" CssClass="btn btn-info" /></h3>
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
                                <textarea cols="20" rows="2" runat="server" id="PatrollingProblem"></textarea></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <textarea cols="20" rows="2" runat="server" id="PatrollingFormFeedback"></textarea></td>
                        </tr>
                        <tr>
                            <td>
                                </td>
                            <td class="auto-style1"><asp:Button ID="PatrollingFormSaveSubmit" runat="server" Text="Save" OnClick="PatrollingFormSaveSubmit_Click1" CssClass="btn" /></td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
