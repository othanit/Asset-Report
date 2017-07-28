<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="freespan.aspx.cs" Inherits="ptt_report.freespan" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft07 {
            background: #0c7fd2;
        }
    </style>


    <div class="bar_qr">
        Customer Type :
                    <asp:label id="lbCustype" runat="server" text="-"></asp:label>
        <asp:button id="btnExport" runat="server" text="Export Report" class="btn" />
        <asp:button id="btnSaveVer" runat="server" text="Save Version" class="btn" />
        <asp:button id="btnHistory" runat="server" text="History" class="btn" />

    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">Free Span
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>3rd party Interface > Free Span</h3>
                <div class="info_executive_in">
            <table>

                <tr>
                    <td>แผนงาน: </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="FSWorkPlan"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>ผลการดำเนินงาน : </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="FSResult"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>การดำเนินงานในอนาคต : </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="FSFuturePlan"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                    <td class="auto-style1">
                        <textarea cols="20" rows="2" runat="server" id="FSProblem"></textarea></td>
                </tr>
                <tr>
                    <td>ความเห็น : </td>
                    <td class="auto-style1">
                        <textarea cols="20" rows="2" runat="server" id="FSFormFeedback"></textarea></td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                    <td class="auto-style1"><asp:button id="FSFormSaveSubmit" runat="server" text="Save" onclick="FSFormSaveSubmit_Click"  class="btn"/></td>
                </tr>

            </table>
                    </div>
                </div>
        </div>
    </div>

</asp:Content>
