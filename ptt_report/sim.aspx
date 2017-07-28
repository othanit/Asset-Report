﻿<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="sim.aspx.cs" Inherits="ptt_report.sim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft13 {
            background: #0c7fd2;
        }

        input[type="text" i] {
            width: 100%;
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
    
        <asp:HiddenField ID="hddsim_id" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />

    
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">

    
<div class="bar_qr">
        <br />
        Customer Type :
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" />
        <asp:Button ID="btnHistory" runat="server" Text="History" class="btn" OnClick="btnHistory_Click" />
             <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />



</div>

        <h3 class="barBlue">SIM
             


        </h3>

        <div class="info_executive">
            <h3>งานประเมินความเสี่ยง และตรวจสภาพโครงสร้างแท่นพัก</h3>
            <div class="info_executive_in">
                <table>
                    <tr>
                        <td style="width:165px;">แผนงาน :</td>
                        <td>
                            <asp:TextBox ID="txtplanwork" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ผลการดำเนินงาน :</td>
                        <td>
                            <asp:TextBox ID="txtplanresult" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>การดำเนินงานในอนาคต :</td>
                        <td>
                            <asp:TextBox ID="txtfuturePlan" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ปัญหาอุปสรรค (ถ้ามี) :</td>
                        <td>
                            <asp:TextBox ID="txtproblem" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtRemark" TextMode="MultiLine" runat="server" BackColor="#CCCCFF"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" class="btn" /><span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH">หมายเหตุ</span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span class="auto-style3">: </span><span class="auto-style3" lang="TH">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="info_executive">
            <h3>งานซ่อมคืนสภาพโครงสร้างแท่น</h3>
            <div class="info_executive_in">
                <table>
                    <tr>
                        <td style="width:165px;">แผนงาน :</td>
                        <td>
                            <asp:TextBox ID="txtplanwork2" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ผลการดำเนินงาน :</td>
                        <td>
                            <asp:TextBox ID="txtplanresult2" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>การดำเนินงานในอนาคต :</td>
                        <td>
                            <asp:TextBox ID="txtfuturePlan2" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ปัญหาอุปสรรค (ถ้ามี) :</td>
                        <td>
                            <asp:TextBox ID="txtproblem2" TextMode="MultiLine" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtRemark2" TextMode="MultiLine" runat="server" BackColor="#CCCCFF"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnsave2" runat="server" Text="Save" OnClick="btnsave2_Click" class="btn" /><span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH">

                                <asp:button id="btnApprove" runat="server" text="Approve Report" onclick="btnApprove_Click" cssclass="btn" />
            <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" CssClass="btn" />
                                หมายเหตุ</span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span class="auto-style3">: </span><span class="auto-style3" lang="TH">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

</asp:Content>
