<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="externalcorrosion.aspx.cs" Inherits="ptt_report.externalcorrosion" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft00 {
            background: #0c7fd2;
        }
        .auto-style4 {
            font-size: medium;
            color: #FF0000;
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>


   
        <asp:HiddenField ID="hddec_id" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
    
    <table>
        <tr>
            <td></td>
        </tr>
    </table>
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
     <div class="bar_qr">
        Customer Type :
                   
       

        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" class="btn" OnClick="btnHistory_Click" />
                
               

                <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />

</div>
    
            <h3 class="barBlue">External Corrosion
                
               

                </h3>
            <div class="info_executive">
                <h3>External Corrosion</h3>
                <div class="info_executive_in">

                    <table>



                        <tr>
                            <td style="width: 200px;">ผลการดำเนินงาน : </td>
                            <td class="auto-style1">

                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="ECResultBox"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>P/S Potential Survey : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ECPSPercent" runat="server"></asp:TextBox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Bond Box Inspection : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ECBBIPercent" runat="server"></asp:TextBox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Rectifier Inspection : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ECRIPercent" runat="server"></asp:TextBox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Insulating Joint :
                       
                               

                                <br />
                                or Flange Inspection </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ECIJPercent" runat="server"></asp:TextBox>
                                %

                            </td>
                        </tr>
                        <tr>
                            <td>Cathodic Result: </td>
                            <td class="auto-style1">

                                <table class="table_da1">
                                    <tr>
                                        <td>
                                            <asp:Button ID="ECCRCreate" runat="server" Text="Create" class="btn btn-info" OnClick="ECCRCreate_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>

                                            <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false"
                                                runat="server" ID="gvCathodic" ShowFooter="false">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Month">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="HddCathodicId" runat="server" Value='<%# Eval("id") %>' />
                                                            <asp:TextBox ID="gvCathodicMonth" runat="server" Text='<%# Eval("month") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="InspectionType">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="gvCathodicInspectionType" runat="server" Text='<%# Eval("inspectiontype") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Region">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="gvCathodicRegion" runat="server" Text='<%# Eval("region") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Progress">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="gvCathodicProgress" runat="server" Text='<%# Eval("progress") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Manage">
                                                        <ItemTemplate>
                                                            <asp:Button ID="btndal1" runat="server" Text="Delete" OnClick="btndal1_Click" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>

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
                                        <td>
                                            <asp:Button ID="ECCDSSCreate" runat="server" Text="Create" class="btn btn-info" OnClick="ECCDSSCreate_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>

                                            <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false"
                                                runat="server" ID="gvCIPSStatus" ShowFooter="false">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Route Code">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="HddCIPSStatusId" runat="server" Value='<%# Eval("id") %>' />
                                                            <asp:TextBox ID="gvCIPSStatusRouteCode" runat="server" Text='<%# Eval("routecode") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Pipeline name">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="gvCIPSStatusPipeLineName" runat="server" Text='<%# Eval("pipelinename") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Status">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="gvCIPSStatusStatus" runat="server" Text='<%# Eval("status") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Manage">
                                                        <ItemTemplate>
                                                            <asp:Button ID="btndal2" runat="server" Text="Delete" OnClick="btndal2_Click" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>

                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>

                        <tr>
                            <td>External Corrosion Result : </td>
                            <td class="auto-style1">

                                <asp:FileUpload ID="ECECRFileUpload" BackColor="#99ff99" runat="server" />

                            </td>
                        </tr>

                        <tr>
                            <td>Coating Defects Result : </td>
                            <td class="auto-style1">

                                <asp:FileUpload ID="CCDRFileUpload" BackColor="#99ff99" runat="server" />

                            </td>
                        </tr>

                        <tr>
                            <td>การดำเนินงานในอนาคต : </td>
                            <td class="auto-style1">

                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="ECFuturePlanBox"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td>CIPS/DCVG Survey Status: </td>
                            <td class="auto-style1">

                                <table class="table_da1">
                                    <tr>
                                        <td>
                                            <asp:Button ID="ECCDSS2Create" runat="server" Text="Create" class="btn btn-info" OnClick="ECCDSS2Create_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>

                                            <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false"
                                                runat="server" ID="gvCIPSStatusActivity" ShowFooter="false">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Route Code">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="HddCIPSStatusActivityId" runat="server" Value='<%# Eval("id") %>' />
                                                            <asp:TextBox ID="gvCIPSStatusActivityActivity" runat="server" Text='<%# Eval("activity") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Pipeline name">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="gvCIPSStatusActivityProgress" runat="server" Text='<%# Eval("progress") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Status">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="gvCIPSStatusActivityEstimatePlan" runat="server" Text='<%# Eval("estimateplan") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Manage">
                                                        <ItemTemplate>
                                                            <asp:Button ID="btndal3" runat="server" Text="Delete" OnClick="btndal3_Click" />
                                                        </ItemTemplate>
                                                        <%--<ItemTemplate>
                                                            <asp:TextBox ID="gvCIPSStatusActivityManage" runat="server" Text='<%# Eval("manage") %>'></asp:TextBox>
                                                        </ItemTemplate>--%>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>

                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>

                        <tr>
                            <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                            <td class="auto-style1">
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="ECProblemBox"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="ECFormFeedbackBox" BackColor="#CCCCFF"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td class="auto-style1">
                                <asp:Button ID="ECFormSaveSubmit" runat="server" Text="Save" OnClick="ECFormSaveSubmit_Click" class="btn" />
                                <asp:Button ID="btnApprove" runat="server" Text="Approve Report" OnClick="btnApprove_Click" CssClass="btn" />
                                <span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH">
            <asp:Button ID="btnReject" runat="server" Text="Reject"  CssClass="btn" OnClick="btnReject_Click" />
                                หมายเหตุ</span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span class="auto-style3">: </span><span class="auto-style3" lang="TH">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
