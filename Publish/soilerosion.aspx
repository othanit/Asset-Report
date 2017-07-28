<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="soilerosion.aspx.cs" Inherits="ptt_report.soilerosion" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft04 {
            background: #0c7fd2;
        }
        </style>
       <div class="bar_qr">
                    Customer Type :
                   
                    <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
                    <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn"/>
                    <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" />
                    <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn" />
                    
                </div>
   
   
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">Soil Erosion
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" CssClass="btn btn-info" /></h3>
            <div class="info_executive">
                <h3>3rd party Interface > Soil Erosion</h3>
                <div class="info_executive_in">
           
            <table>
                <tr>
                    <td style="width:165px;">รายละเอียดงาน : </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="SEProjectDetail"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>แผนงาน: </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="SEWorkPlan"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>แผนงาน: </td>
                    <td class="auto-style1">

                        <table  class="table_da1">

                            <tr>
                                <td colspan="7">
                                    <asp:Button ID="SEWorkPlanAddNewPlan" runat="server" Text="Create" CssClass="btn btn-info" /></td>
                            </tr>
                            <tr>
                                <td>เขต</td>
                                <td>เส้นท่อ, ตำแหน่ง</td>
                                <td>ขุดซ่อมเนื่องจาก</td>
                                <td>Length (m)</td>
                                <td>%Actual</td>
                                <td>Plan/Status</td>
                                <td>Manage</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="SEWorkPlanDistrict" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="SEWorkPlanPipePosition" runat="server"></asp:TextBox></td>
                                <td>
                                    <asp:TextBox ID="SEWorkPlanDigMaintance" runat="server"></asp:TextBox></td>
                                <td>
                                    <asp:TextBox ID="SEWorkPlanLength" runat="server"></asp:TextBox></td>
                                <td>
                                    <asp:TextBox ID="SEWorkPlanActual" runat="server"></asp:TextBox></td>
                                <td>
                                    <asp:TextBox ID="SEWorkPlanStatus" runat="server"></asp:TextBox></td>
                                <td>
                                    <asp:Button ID="SEWorkPlanDelete" runat="server" Text="Delete" CssClass="btn btn-danger" /></td>
                            </tr>
                        </table>

                    </td>
                </tr>
                <tr>
                    <td>ผลการดำเนินงาน : </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="SEResult"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>การดำเนินงานในอนาคต : </td>
                    <td class="auto-style1">

                        <textarea cols="20" rows="2" runat="server" id="SEFuturePlan"></textarea>

                    </td>
                </tr>
                <tr>
                    <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                    <td class="auto-style1">
                        <textarea cols="20" rows="2" runat="server" id="SEProblem"></textarea></td>
                </tr>
                <tr>
                    <td>ความเห็น : </td>
                    <td class="auto-style1">
                        <textarea cols="20" rows="2" runat="server" id="SEFormFeedback"></textarea></td>
                </tr>
                <tr>
                    <td>
                        </td>
                    <td class="auto-style1"><asp:Button ID="SEFormSaveSubmit" runat="server" Text="Save" OnClick="SEFormSaveSubmit_Click" CssClass="btn" /></td>
                </tr>

            </table>
                    </div>
                </div>
            
        </div>
    </div>

</asp:Content>
