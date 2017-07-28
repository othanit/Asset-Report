<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitwallthickness.aspx.cs" Inherits="ptt_report.permitwallthickness" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
        #menuleft05 {
            background: #0c7fd2;
        }
          .auto-style1 {
              height: 20px;
          }
          input[type="text" i] {
              width:50px;
          }
    </style>

    <table>
        <tr>
            <td>
                
            </td>
        </tr>
    </table>

    <div class="bar_qr">
        Year: 2559  Permit: กท2310027
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" OnClick="btnSaveVer_Click" class="btn" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" OnClick="btnExport_Click"  class="btn" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" OnClick="Button1_Click" />

                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
 
        <asp:HiddenField ID="hddwn_id" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">

                 &nbsp;</h3>
            <div class="info_executive">
                <h3>การตรวจสภาพท่อส่งก๊าซธรรมชาติด้วยวิธีตรวจวัดความหนาท่อ (Wall thickness monitoring)</h3>
                <div class="info_executive_in">
                    <table>

                        <tr>
                            <th colspan="2"></th>
                        </tr>

                        <tr>
                            <td>ผลการตรวจสอบ: </td>
                            <td class="auto-style1">

                                <asp:TextBox id="PermitWallThicknessResult" TextMode="MultiLine" runat="server" cols="20"  rows="2" style="background-color: #99FF99"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>

                            <td class="auto-style1" colspan="2">

                                <table>
                                    <tr>
                                        <td>
                                            ท่อ:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="wtnpipe" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            สถานี:     
                                        </td>
                                        <td>
                                            <asp:TextBox ID="wtnstation" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            ตำแหน่งท่อ: 
                                        </td>
                                        <td>
                                            <asp:TextBox ID="wtnpipeposition" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>

                            </td>

                        </tr>
                        <tr>
                            <td>ผลสรุป : </td>
                            <td class="auto-style1">

                                <table>
                                    <tr>
                                        <td colspan="8">
                                            <asp:Button ID="Button2" runat="server" Text="Create" OnClick="Button2_Click"  CssClass="btn btn-info"/>   
                                        </td>
                                    </tr>
                                    <tr>
                                         <td>

                                          <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="gv" ShowFooter="false" >
                                                <Columns>
                                                    <asp:TemplateField HeaderText="BV Station">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="hddid" runat="server" Value='<%# Eval("id") %>' />
                                                            <asp:TextBox ID="subbvstation" runat="server" Text='<%# Eval("bvstation") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Route Code">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subroutecode" runat="server" Text='<%# Eval("routecode") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Inspection Date">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subinspectiondate" runat="server" Text='<%# Eval("inspectiondate") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Point">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subpoint" runat="server" Text='<%# Eval("point") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Diameter">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subdiameter" runat="server" Text='<%# Eval("diameter") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Tavg(mm)">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subtavg" runat="server" Text='<%# Eval("tavg") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Tmin(mm)">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="subtmin" runat="server" Text='<%# Eval("tmin") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Manage">
                                                        <ItemTemplate>
                                                            <asp:Button ID="btndal" runat="server" Text="Delete" CssClass="btn btn-danger" />
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

                                <asp:TextBox ID="wtnopinion" runat="server" Columns="20" TextMode="MultiLine"></asp:TextBox>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div>
                 <asp:Button ID="PermitFormSaveSubmit" runat="server" Text="Save" class="btn" OnClick="PermitFormSaveSubmit_Click1" />
                 <asp:Button ID="btnApprove" runat="server" Text="Approve" class="btn" OnClick="btnApprove_Click" />
                 <asp:Button ID="btnReject" runat="server" Text="Reject" class="btn" OnClick="btnReject_Click" />
            </div>
        </div>
    </div>

</asp:Content>
