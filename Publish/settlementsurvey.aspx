<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="settlementsurvey.aspx.cs" Inherits="ptt_report.settlementsurvey" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft05 {
            background: #0c7fd2;
        }
    </style>


    <div class="bar_qr">
        Customer Type :
                   
                    <asp:label id="lbCustype" runat="server" text="-"></asp:label>
        <asp:button id="btnExport" runat="server" text="Export Report" class="btn" />
        <asp:button id="btnSaveVer" runat="server" text="Save Version" class="btn" />
        <asp:button id="btnHistory" runat="server" text="History" class="btn"/>

    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">Settlelment Survey
                 <asp:button id="btnImport" runat="server" text="Import Data" onclick="btnImport_Click" class="btn btn-info" />
            </h3>
            <div class="info_executive">
                <h3>3rd party Interface > Settlelment Survey</h3>
                <div class="info_executive_in">
                    <table>

                        
                        <tr>
                            <td style="width:165px;">แผนงาน: </td>
                            <td class="auto-style1">

                                <table class="table_da1">

                                    <tr>
                                        <td colspan="7">
                                            <asp:button id="SSWorkPlanAddNewPlan" runat="server" text="Create"  class="btn btn-info" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>เขต</td>
                                        <td>เส้นท่อ</td>
                                        <td>สถานี</td>
                                        <td>Action</td>
                                        <td>Progress</td>
                                        <td>Remark</td>
                                        <td>Manage</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:textbox id="SSWorkPlanDistrict" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="SSWorkPlanPipePosition" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="SSWorkPlanDigMaintance" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="SSWorkPlanLength" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="SSWorkPlanActual" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="SSWorkPlanStatus" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:button id="SSWorkPlanDelete" runat="server" text="Delete"   class="btn btn-danger"/>
                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>
                        <tr>
                            <td>ผลการดำเนินงาน : </td>
                            <td class="auto-style1">

                                <textarea cols="20" rows="2" runat="server" id="SSResult"></textarea>

                            </td>
                        </tr>
                        <tr>
                            <td>การดำเนินงานในอนาคต : </td>
                            <td class="auto-style1">
                                <asp:textbox id="SSFuturePlan" runat="server" backcolor="#99ff99" textmode="MultiLine"></asp:textbox>

                            </td>
                        </tr>
                        <tr>
                            <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                            <td class="auto-style1">
                                <textarea cols="20" rows="2" runat="server" id="SSProblem"></textarea></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <textarea cols="20" rows="2" runat="server" id="SSFormFeedback"></textarea></td>
                        </tr>
                        <tr>
                            <td>
                               
                            </td>
                            <td class="auto-style1"> <asp:button id="SSFormSaveSubmit" runat="server" text="Save" onclick="SSFormSaveSubmit_Click" class="btn" /></td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
