<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitexecutivesummary.aspx.cs" Inherits="ptt_report.permitexecutivesummary" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
       
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
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" OnClick="btnExport_Click" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" OnClick="Button1_Click" />

        <asp:HiddenField ID="hddtpexecutivesummary_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">
                 Executive summary
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>Executive summary</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td style="text-align: left;">การบำรุงรักษาระบบท่อส่งก๊าซธรรมชาติปี: </td>
                        </tr>
                        <tr>
                            <td class="auto-style1"  style="text-align: center;">


                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="PermitExecutiveSummaryBox"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1"></td>
                        </tr>

                    </table>
                    </div>
            </div>
            <div>
                 <asp:Button ID="PermitExecutiveSumFormSaveSubmit" runat="server" Text="Save" class="btn" OnClick="PermitExecutiveSumFormSaveSubmit_Click" />
            </div>
        </div>
    </div>

</asp:Content>
