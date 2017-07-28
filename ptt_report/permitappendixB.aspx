<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitappendixB.aspx.cs" Inherits="ptt_report.permitappendixB" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft07 {
            background: #0c7fd2;
        }

        .auto-style1 {
            height: 20px;
        }
        .info_executive_in input[type="submit"] {
            float:none;
        }
    </style>

    <table>
        <tr>
            <td></td>
        </tr>
    </table>

    <div class="bar_qr">
        Year: 2559  Permit: กท2310027
                   
       

        <asp:label id="lbCustype" runat="server" text="-"></asp:label>
        <asp:button id="btnSaveVer" runat="server" text="Save Version" OnClick="btnSaveVer_Click" class="btn" />
        <asp:button id="btnExport" runat="server" text="Export Report" OnClick="btnExport_Click"  class="btn" />
        <asp:button id="Button1" runat="server" text="History" class="btn" OnClick="Button1_Click" />


        <asp:HiddenField ID="hddapdb_id" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />


    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">
                 ภาคผนวก ข.
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>ผลการลาดตระเวนตรวจแนวท่อส่งก๊าซธรรมชาติ</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td class="auto-style1" style="text-align:right;" colspan="2">
                                <asp:Button ID="Button3" runat="server" Text="Create" OnClick="Button3_Click"  class="btn btn-info"/>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="2">
                                <table>
                                    <tr>
                                        <td>

                                            <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="gv" ShowFooter="false" >
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Route Code">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="hddid" runat="server" Value='<%# Eval("id") %>' />
                                                            <asp:TextBox ID="subroutecode" runat="server" Text='<%# Eval("routecode") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="งานก่อสร้าง">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subbuildingwork" runat="server" Text='<%# Eval("buildingwork") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="กัดเซาะ">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subscour" runat="server" Text='<%# Eval("scour") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="ป้ายหาย / ติดตั้งใหม่">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="sublabel" runat="server" Text='<%# Eval("label") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Test Post หาย / ชำรุด">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subtestpost" runat="server" Text='<%# Eval("testpost") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="รุกล้ำ">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subtrespass" runat="server" Text='<%# Eval("trespass") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="การรั่วไหลของก๊าซ">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subgasleak" runat="server" Text='<%# Eval("gasleak") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="ผลรวมสิ่งผิดปกติ">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subabnormal" runat="server" Text='<%# Eval("abnormal") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Manage">
                                                        <ItemTemplate>
                                                            <asp:Button ID="btndal" runat="server" Text="Delete" class="btn btn-danger" />
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
                            <td>ความเห็น : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ApdbOpinion" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>

            <div>
                <asp:Button ID="PermitFormSaveSubmit" runat="server" Text="Save" class="btn" OnClick="PermitFormSaveSubmit_Click" />
                 <asp:Button ID="btnApprove" runat="server" Text="Approve" class="btn" OnClick="btnApprove_Click" />
                 <asp:Button ID="btnReject" runat="server" Text="Reject" class="btn" OnClick="btnReject_Click" />
            </div>

        </div>
    </div>

</asp:Content>
