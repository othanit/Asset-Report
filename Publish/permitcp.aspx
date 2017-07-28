<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitcp.aspx.cs" Inherits="ptt_report.permitcp" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
        #menuleft06 {
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
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" />
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
             </h3>
            <div class="info_executive">
                <h3>Close Interval Potential Survey (CIPS)</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>รายละเอียด: </td>
                            <td class="auto-style1">

                                <textarea id="PermitCPCIPSDetail" runat="server" cols="20" rows="60"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">

                                <textarea id="PermitCPCIPSNote" runat="server" cols="20" rows="3"></textarea>

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

                                <textarea id="PermitCPDCVGDetail" runat="server" cols="20" rows="60"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">

                                <textarea id="PermitCPDCVGNote" runat="server" cols="20" rows="3"></textarea>

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

                                <textarea id="PermitCPPTSDetail" runat="server" cols="20" rows="60"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">

                                <textarea id="PermitCPPTSNote" runat="server" cols="20" rows="3"></textarea>

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

                                <textarea id="PermitCPROVDetail" runat="server" cols="20" rows="60"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ความเห็น : </td>
                            <td class="auto-style1">

                                <textarea id="PermitCPROVNote" runat="server" cols="20" rows="3"></textarea>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>



            <div>
                <asp:Button ID="PermitCPFormSaveSubmit" runat="server" Text="Save" class="btn" />
            </div>
        </div>
    </div>

</asp:Content>
