<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="rov.aspx.cs" Inherits="ptt_report.rov" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
        #menuleft06 {
            background: #0c7fd2;
        }
    </style>

    <div class="bar_qr">
                    Customer Type :
                    <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
                    <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" />
                    <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" />
                    <asp:Button ID="btnHistory" runat="server" Text="History" class="btn" />
                    
                </div>
    <table>
        <tr>
            <td>
                
            </td>
        </tr>
    </table>
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">ROV
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>3rd party Interface > ROV</h3>
                <div class="info_executive_in">
            <table>

                <tr>
                    <th colspan="2"></th>
                </tr>

                <tr>
                    <td>แผนงาน: </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="ROVWorkPlan"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>ผลการดำเนินงาน : </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="ROVResult"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>การดำเนินงานในอนาคต : </td>
                    <td class="auto-style1">

                       <textarea cols="20" rows="2" runat="server" id="ROVFuturePlan"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                    <td class="auto-style1"><textarea cols="20" rows="2" runat="server" id="ROVProblem"></textarea></td>
                </tr>
                <tr>
                    <td>ความเห็น : </td>
                    <td class="auto-style1"><textarea cols="20" rows="2" runat="server" id="ROVFormFeedback"></textarea></td>
                </tr>
                <tr>
                    <td>
                       </td>
                    <td class="auto-style1"> <asp:Button ID="ROVFormSaveSubmit" runat="server" Text="Save" OnClick="ROVFormSaveSubmit_Click" class="btn" /></td>
                </tr>

            </table>
                    </div>
                </div>
        </div>
    </div>

</asp:Content>
