<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitappendixH.aspx.cs" Inherits="ptt_report.permitappendixH" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
        #menuleft09 {
            background: #0c7fd2;
        }
          .auto-style1 {
              height: 20px;
          }
          .info_executive_in input[type="submit"] {
            float:none;
        }
    </style>

   

    <div class="bar_qr">
        Year: 2559  Permit: กท2310027
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" OnClick="btnSaveVer_Click" class="btn" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" OnClick="btnExport_Click"  class="btn" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" OnClick="Button1_Click" />

        <asp:HiddenField ID="hddapdh_id" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">
                 ภาคผนวก จ.
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>ผลการลาดตระเวนตรวจแนวท่อส่งก๊าซธรรมชาติ</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td class="auto-style1" colspan="2">
                                <table>
                                    <tr>
                                        <td class="auto-style1" style="text-align:right;" colspan="2">
                                            <asp:Button ID="Button3" runat="server" Text="Create" OnClick="Button3_Click" class="btn btn-info" />
                                        </td>
                                    </tr>
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
                                                    <asp:TemplateField HeaderText="2 nd half year">
                                                        <ItemTemplate>
                                                            <asp:FileUpload ID="subsecondhalfyear" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="1 st half year">
                                                        <ItemTemplate>
                                                            <asp:FileUpload ID="subfirsthalfyear" runat="server" />
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

                                <asp:TextBox ID="AdphOpinion" runat="server" Columns="60"></asp:TextBox>

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
