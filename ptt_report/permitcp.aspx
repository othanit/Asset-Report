<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitcp.aspx.cs" Inherits="ptt_report.permitcp" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
        #menuleft03 {
            background: #0c7fd2;
        }
          .auto-style1 {
              height: 20px;
          }
    </style>

    <table>
        <tr>
            <td>
                
            </td>
        </tr>
    </table>

    <div class="bar_qr">
        Year: 2559  Permit: กท2310027
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" OnClick="btnSaveVer_Click" class="btn" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" OnClick="btnExport_Click" class="btn" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" OnClick="Button1_Click" />

        <asp:HiddenField ID="hddtpcp_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">
                 CP
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
             </h3>
            <div class="info_executive">
                <h3>Close Interval Potential Survey (CIPS)</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>รายละเอียด: </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPCIPSDetailBox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPCIPSNoteBox"></asp:TextBox>


                            </td>
                        </tr>
                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>Direct Current Voltage Gradient (DCVG)</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>รายละเอียด: </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPDCVGDetailBox"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPDCVGNoteBox"></asp:TextBox>


                            </td>
                        </tr>
                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>Pipe to soil</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>รายละเอียด: </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPPTSDetailBox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPPTSNoteBox"></asp:TextBox>


                            </td>
                        </tr>
                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>ROV</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>รายละเอียด: </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPROVDetailBox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox TextMode="MultiLine" runat="server" id="PermitCPROVNoteBox"></asp:TextBox>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>



            <div>
                <asp:Button ID="PermitCPFormSaveSubmit" runat="server" Text="Save" OnClick="PermitCPFormSaveSubmit_Click" class="btn" />
                 <asp:Button ID="btnApprove" runat="server" Text="Approve" class="btn" OnClick="btnApprove_Click" />
                 <asp:Button ID="btnReject" runat="server" Text="Reject" class="btn" OnClick="btnReject_Click" />
            </div>
        </div>
    </div>

</asp:Content>
