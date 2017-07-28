<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="settlementsurvey.aspx.cs" Inherits="ptt_report.settlementsurvey" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft05 {
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


        <asp:HiddenField ID="hddss_id" runat="server" />


        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">


    <div class="bar_qr">
        Customer Type :
                   
        <asp:label id="lbCustype" runat="server" text="-"></asp:label>
        <asp:button id="btnSaveVer" runat="server" text="Save Version" class="btn" OnClick="btnSaveVer_Click" />
        <asp:button id="btnExport" runat="server" text="Export Report" class="btn" OnClick="btnExport_Click" />
        <asp:button id="btnHistory" runat="server" text="History" class="btn" OnClick="btnHistory_Click"/>

                 <asp:button id="btnImport" runat="server" text="Import Data" onclick="btnImport_Click" class="btn btn-info" />

    </div>

            <h3 class="barBlue">Settlelment Survey
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
                                        <td>
                                            <asp:button id="SSWorkPlanAddNewPlan" runat="server" text="Create"  class="btn btn-info" OnClick="SSWorkPlanAddNewPlan_Click" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>

                                          <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="gv" ShowFooter="false" >
                                                <Columns>
                                                    <asp:TemplateField HeaderText="เขต">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="hddid" runat="server" Value='<%# Eval("id") %>' />
                                                            <asp:TextBox ID="subarea" runat="server" Text='<%# Eval("area") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="เส้นท่อ">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subpipe" runat="server" Text='<%# Eval("pipe") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="สถานี">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="substation" runat="server" Text='<%# Eval("station") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Action">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subaction" runat="server" Text='<%# Eval("action") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Progress">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subprogress" runat="server" Text='<%# Eval("progress") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Remark">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subremark" runat="server" Text='<%# Eval("remark") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Manage">
                                                        <ItemTemplate>
                                                            <asp:Button ID="btndal" runat="server" Text="Delete" OnClick="btndal_Click" />
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
                            <td>ผลการดำเนินงาน : </td>
                            <td class="auto-style1">

                                <asp:TextBox TextMode="MultiLine" runat="server" id="SSResultBox"></asp:TextBox>

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
                                <asp:textbox runat="server" id="SSProblemBox" TextMode="MultiLine"></asp:textbox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:textbox runat="server" id="SSFormFeedbackBox"  TextMode="MultiLine" BackColor="#CCCCFF"></asp:textbox></td>
                        </tr>
                        <tr>
                            <td>
                               
                            </td>
                            <td class="auto-style1"> <asp:button id="SSFormSaveSubmit" runat="server" text="Save" onclick="SSFormSaveSubmit_Click" class="btn" />
                                <asp:Button ID="btnApprove" runat="server" Text="Approve Report" OnClick="btnApprove_Click" CssClass="btn" />
                                <span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH">
            <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" CssClass="btn" />
                                หมายเหตุ</span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span class="auto-style3">: </span><span class="auto-style3" lang="TH">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
