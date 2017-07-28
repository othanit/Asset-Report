<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="ilipig.aspx.cs" Inherits="ptt_report.ilipig" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft09 {
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


    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <h3 class="barBlue">ILI PIG
            <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />



        </h3>

        <div class="info_executive">
            <h3>
                <asp:LinkButton ID="lnkBack" runat="server" OnClick="lnkBack_Click">Inaternal Corrosion</asp:LinkButton>
                > ILI PIG</h3>
            <div class="info_executive_in">

                <table>
                    <tr>
                        <td style="width:165px;">แผนงาน :</td>
                        <td>
                            <table class="table_da1">
                                <tr>
                                    <th>Routecode</th>
                                    <th>Dimeter</th>
                                    <th>Pipeline Section</th>
                                    <th>Number of pig</th>
                                    <th>Planning</th>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRoutecode" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDimeter" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPipeline" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNumberOfPig" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPlanning" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>ผลการดำเนินงาน :</td>
                        <td>
                            <table class="table_da1">
                                <tr>
                                    <th>Routecode</th>
                                    <th>Pipeline Section</th>
                                    <th>Result</th>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRoutecode2" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtPipelineSection2" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtResult2" runat="server" TextMode="MultiLine"></asp:TextBox>
                                    </td>

                                </tr>
                            </table>
                                 <br />
                        </td>
                    </tr>
                    <tr>
                        <td>การดำเนินงานในอนาคต :</td>
                        <td>
                            <table class="table_da1">
                                <tr>
                                    <th>Routecode</th>
                                    <th>Dimeter</th>
                                    <th>Pipeline Section</th>
                                    <td>Number of pig</td>
                                    <th>Planning</th>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtF_Routecode" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtF_Dimeter" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtF_Pipeline" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtF_NumberOfPig" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtF_Planning" runat="server" BackColor="#99ff99"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                                 <br />
                        </td>
                    </tr>
                    <tr>
                        <td>ปัญหาอุปสรรค (ถ้ามี)  :</td>
                        <td>
                            <asp:TextBox ID="txtProblem" runat="server" BackColor="#99ff99"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSave" runat="server" Text="Save" class="btn" />
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </div>
</asp:Content>
