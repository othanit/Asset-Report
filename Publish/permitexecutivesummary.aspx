<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitexecutivesummary.aspx.cs" Inherits="ptt_report.permitexecutivesummary" %>



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

                                <textarea id="PermitExecutiveSummary" runat="server" cols="20" rows="40"></textarea>

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
                 <asp:Button ID="PermitExecutiveSumFormSaveApprove" runat="server" Text="Approve" class="btn" />
            </div>
        </div>
    </div>

</asp:Content>
