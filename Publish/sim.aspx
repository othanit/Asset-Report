<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="sim.aspx.cs" Inherits="ptt_report.sim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft13 {
            background: #0c7fd2;
        }

        input[type="text" i] {
            width: 100%;
        }
    </style>
    <div class="bar_qr">
        Customer Type :
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" />
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" />
        <asp:Button ID="btnHistory" runat="server" Text="History" class="btn" />

    </div>


    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <h3 class="barBlue">SIM
             <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />



        </h3>

        <div class="info_executive">
            <h3>งานประเมินความเสี่ยง และตรวจสภาพโครงสร้างแท่นพัก</h3>
            <div class="info_executive_in">
                <table>
                    <tr>
                        <td style="width:165px;">แผนงาน :</td>
                        <td>
                            <asp:TextBox ID="txtplanwork" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ผลการดำเนินงาน :</td>
                        <td>
                            <asp:TextBox ID="txtplanresult" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>การดำเนินงานในอนาคต :</td>
                        <td>
                            <asp:TextBox ID="txtfuturePlan" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ปัญหาอุปสรรค (ถ้ามี) :</td>
                        <td>
                            <asp:TextBox ID="txtproblem" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtRemark" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" class="btn" /></td>
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
                            <asp:TextBox ID="txtplanwork2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ผลการดำเนินงาน :</td>
                        <td>
                            <asp:TextBox ID="txtplanresult2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>การดำเนินงานในอนาคต :</td>
                        <td>
                            <asp:TextBox ID="txtfuturePlan2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ปัญหาอุปสรรค (ถ้ามี) :</td>
                        <td>
                            <asp:TextBox ID="txtproblem2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtRemark2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnsave2" runat="server" Text="Save" OnClick="btnsave2_Click" class="btn" /></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

</asp:Content>
