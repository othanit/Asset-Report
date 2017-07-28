<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="externalcorrosion.aspx.cs" Inherits="ptt_report.externalcorrosion" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft00 {
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
    <table>
        <tr>
            <td></td>
        </tr>
    </table>
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">External Corrosion
                 <asp:button id="btnImport" runat="server" text="Import Data" onclick="btnImport_Click" class="btn btn-info" />

            </h3>
            <div class="info_executive">
                <h3>External Corrosion</h3>
                <div class="info_executive_in">

                    <table>

                        

                        <tr>
                            <td style="width:200px;">ผลการดำเนินงาน : </td>
                            <td class="auto-style1">

                                <textarea cols="20" rows="2" runat="server" id="ECResult"></textarea>

                            </td>
                        </tr>
                        <tr>
                            <td>P/S Potential Survey : </td>
                            <td class="auto-style1">

                                <asp:textbox id="ECPSPercent" runat="server"></asp:textbox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Bond Box Inspection : </td>
                            <td class="auto-style1">

                                <asp:textbox id="ECBBIPercent" runat="server"></asp:textbox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Rectifier Inspection : </td>
                            <td class="auto-style1">

                                <asp:textbox id="ECRIPercent" runat="server"></asp:textbox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Insulating Joint :
                        <br />
                                or Flange Inspection </td>
                            <td class="auto-style1">

                                <asp:textbox id="ECIJPercent" runat="server"></asp:textbox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Cathodic Result: </td>
                            <td class="auto-style1">

                                <table class="table_da1">
                                    <tr>
                                        <td colspan="5">
                                            <asp:button id="ECCRCreate" runat="server" text="Create" class="btn btn-info"/>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Month</td>
                                        <td>InspectionType</td>
                                        <td>Region</td>
                                        <td>Progress</td>
                                        <td>Manage</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:textbox id="ECCRMonthText1" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="ECCRInspectionTypeText1" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="ECCRRegionText1" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="ECCRProgressText1" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>

                                        <td>
                                            <asp:button id="btnDelCathodic" runat="server" text="Delete" class="btn btn-danger" />
                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>

                        <tr>
                            <td>CIPS/DCVG Survey Status: </td>
                            <td class="auto-style1">

                                <table class="table_da1">
                                    <tr>
                                        <td colspan="5">
                                            <asp:button id="ECCDSSCreate" runat="server" text="Create" class="btn btn-info" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Route Code</td>
                                        <td>Pipeline name</td>
                                        <td>Status</td>
                                        <td>Manage</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:textbox id="ECCDSSRouteCodeText1" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="ECCDSSPipelineNameText1" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>
                                        <td>
                                            <asp:textbox id="ECCDSSStatusText1" backcolor="#99ff99" runat="server"></asp:textbox>
                                        </td>

                                        <td>
                                            <asp:button id="btnDelSurvey" runat="server" text="Delete" class="btn btn-danger" />
                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>

                        <tr>
                            <td>External Corrosion Result : </td>
                            <td class="auto-style1">

                                <asp:fileupload id="ECECRFileUpload" backcolor="#99ff99" runat="server" />

                            </td>
                        </tr>

                        <tr>
                            <td>Coating Defects Result : </td>
                            <td class="auto-style1">

                                <asp:fileupload id="ECCDRFileUpload" backcolor="#99ff99" runat="server" />

                            </td>
                        </tr>

                        <tr>
                            <td>การดำเนินงานในอนาคต : </td>
                            <td class="auto-style1">

                                <textarea cols="20" rows="2" runat="server" id="ECFuturePlan"></textarea>

                            </td>
                        </tr>

                        <tr>
                            <td>CIPS/DCVG Survey Status: </td>
                            <td class="auto-style1">

                                <table class="table_da1">
                                    <tr>
                                        <td colspan="5">
                                            <asp:button id="ECCDSS2Create" runat="server" text="Create" class="btn btn-info" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Activity</td>
                                        <td>Progress</td>
                                        <td>Estimate Plan</td>
                                        <td>Manage</td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <textarea id="ECCDSS2ActivityText1" runat="server" aria-multiline="True" aria-multiselectable="False" draggable="false" cols="20" rows="2"></textarea></td>
                                        <td>
                                            <textarea id="ECCDSS2ProgressText1" runat="server" aria-multiline="True" aria-multiselectable="False" draggable="false" cols="20" rows="2"></textarea></td>
                                        <td>
                                            <textarea id="ECCDSS2EstimatePlanText1" runat="server" aria-multiline="True" aria-multiselectable="False" draggable="false" cols="20" rows="2"></textarea></td>
                                        <td>
                                            <textarea id="ECCDSS2Manage1" runat="server" aria-multiline="True" aria-multiselectable="False" draggable="false" cols="20" rows="2"></textarea></td>
                                    </tr>
                                </table>

                            </td>
                        </tr>

                        <tr>
                            <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                            <td class="auto-style1">
                                <textarea cols="20" rows="2" runat="server" id="ECProblem"></textarea></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <textarea cols="20" rows="2" runat="server" id="ECFormFeedback"></textarea></td>
                        </tr>
                        <tr>
                            <td>
                                
                            </td>
                            <td class="auto-style1"><asp:button id="ECFormSaveSubmit" runat="server" text="Save" onclick="ECFormSaveSubmit_Click" class="btn"/></td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
