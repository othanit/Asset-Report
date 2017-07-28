<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="soilerosion.aspx.cs" Inherits="ptt_report.soilerosion" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <div class="bar_qr">
        <br />
        <br />
        Customer Type :
                   
      <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn" OnClick="btnHistory_Click" />

                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" CssClass="btn btn-info"  />

    </div>
    <h3 class="barBlue">Soil Erosion
                 <asp:HiddenField ID="hddmas_rep_id" runat="server" />

        <asp:HiddenField ID="hddfile_path" runat="server" />

        <asp:HiddenField ID="hddsoil_id" runat="server" />
        </h3>
    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <div class="info_executive">
                <h3>3rd party Interface > Soil Erosion</h3>
                <div class="info_executive_in">

                    <table>
                        <tr>
                            <td style="width: 165px;">รายละเอียดงาน : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtd1" TextMode="MultiLine" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>แผนงาน: </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtd2" TextMode="MultiLine" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>แผนงาน: </td>
                            <td class="auto-style1">

                                <table class="table_da1">

                                    <tr>
                                        <td>
                                            <asp:Button ID="SEWorkPlanAddNewPlan" runat="server" Text="Create" CssClass="btn btn-info" OnClick="SEWorkPlanAddNewPlan_Click" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" utoGenerateColumns="false"
                                                runat="server" ID="gv" ShowFooter="false">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="เขต">
                                                        <ItemTemplate>
                                                            <asp:HiddenField ID="hddid" runat="server" Value='<%# Eval("id") %>' />
                                                            <asp:TextBox ID="txtd3" runat="server" Text='<%# Eval("d3") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="เส้นท่อ,ตำแหน่ง">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtd4" runat="server" Text='<%# Eval("d4") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="ขุดซ่อมเนื่องจาก">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtd5" runat="server" Text='<%# Eval("d5") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Length(m)">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtd6" runat="server" Text='<%# Eval("d6") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="% Actual">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtd7" runat="server" Text='<%# Eval("d7") %>'></asp:TextBox>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Plan/Status">
                                                        <ItemTemplate>
                                                            <asp:TextBox ID="txtd8" runat="server" Text='<%# Eval("d8") %>'></asp:TextBox>
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
                                <asp:TextBox ID="txtd9" TextMode="MultiLine" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>การดำเนินงานในอนาคต : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtd10" TextMode="MultiLine" runat="server"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>ปัญหาอุปสรรค (ถ้ามี) : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtd11" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="txtd12" TextMode="MultiLine" runat="server" BackColor="#CCCCFF"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td class="auto-style1">
                                <asp:Button ID="SEFormSaveSubmit" runat="server" Text="Save" OnClick="SEFormSaveSubmit_Click" CssClass="btn" />
                                <asp:Button ID="btnApprove" runat="server" Text="Approve Report" OnClick="btnApprove_Click" CssClass="btn" />

                                <span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH; color: #FF0000;"><span style="font-size: medium">
            <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" CssClass="btn" />
                                หมายเหตุ</span></span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span style="font-size: medium"><span class="auto-style3" style="color: #FF0000">: </span></span><span class="auto-style3" lang="TH" style="color: #FF0000"><span style="font-size: medium">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></span></td>
                        </tr>

                    </table>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
