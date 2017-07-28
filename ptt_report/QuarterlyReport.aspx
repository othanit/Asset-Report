<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="QuarterlyReport.aspx.cs" Inherits="ptt_report.QuarterlyReport" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script language="javascript">
        function Confim() {
            var result = window.confirm('คุณต้องการลบใช่หรือไม่ ?');
               if (result == true)
                return true;
            else
                return false;
        }
    </script>

    <asp:HiddenField ID="hddfile_path" runat="server" />

    <h3 class="mini_head2">
        Quarterly Report
    </h3>
    <div class="serchRed">
        <table style="width:100%">
            <tr>
                <td style="width:4%">Year : 
                </td>
                <td style="width:6%">
                    <asp:DropDownList ID="ddlyear" runat="server" OnSelectedIndexChanged="ddlyear_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td style="width:6%">Quarter : 
                </td>
                <td style="width:3%">
                    <asp:DropDownList ID="ddlquarter" runat="server" OnSelectedIndexChanged="ddlquarter_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td style="width:10%">Customer Type : 
                </td>
                <td style="width:10%">
                    <asp:DropDownList ID="ddlcustype" runat="server" OnSelectedIndexChanged="ddlcustype_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td style="width:5%">Status : 
                </td>
                <td style="width:6%">
                    <asp:DropDownList ID="ddlstatus" runat="server" OnSelectedIndexChanged="ddlstatus_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td style="width:46%">
                </td>
                <td>
                    <asp:Button ID="btncreate" runat="server" Text="Create" OnClick="btncreate_Click" class="btn btn-gray" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:GridView ID="GridView_rep_list" runat="server" AutoGenerateColumns="False" AllowPaging="True"
            OnPageIndexChanging="GridView_rep_list_PageIndexChanging" OnRowDataBound="GridView_rep_list_RowDataBound" class="tb_red">
            <Columns>

                <asp:BoundField DataField="year" HeaderText="Year" />
                <asp:BoundField DataField="quarter" HeaderText="Quarter" />
                <asp:BoundField DataField="cus_type" HeaderText="Customer Type" />
                <asp:BoundField DataField="status" HeaderText="Status" Visible="False" />
                <asp:BoundField DataField="exe_status" HeaderText="Executive summary" Visible="False" />
                <asp:BoundField DataField="pm_cm_status" HeaderText="3rd party Interference" Visible="False" />
                <asp:BoundField DataField="external_status" HeaderText="Ext. Corrosion" Visible="False" />
                <asp:BoundField DataField="internal_status" HeaderText="Int. Corrosion" Visible="False" />
                <asp:BoundField DataField="piping" HeaderText="Piping" Visible="False" />
                <asp:BoundField DataField="offshore" HeaderText="Offshore" Visible="False" />
                <asp:BoundField DataField="other_pro" HeaderText="Other Projects" Visible="False" />
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Image ID="Image1" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Executive Summary">
                    <ItemTemplate>
                        <asp:Image ID="Image2" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("exe_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="3rd party Interference">
                    <ItemTemplate>
                        <asp:Image ID="Image3" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("pm_cm_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ext.Corrosion">
                    <ItemTemplate>
                        <asp:Image ID="Image4" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("external_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Int.Corrosion">
                    <ItemTemplate>
                        <asp:Image ID="Image5" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("internal_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Piping">
                    <ItemTemplate>
                        <asp:Image ID="Image6" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("piping")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Offshore">
                    <ItemTemplate>
                        <asp:Image ID="Image7" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("offshore")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Other Projects">
                    <ItemTemplate>
                        <asp:Image ID="Image8" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("other_pro")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Manage">
                    <ItemTemplate>
                        <asp:HiddenField ID="hddrepid" runat="server" Value='<%# Eval("id") %>' />
                        <asp:HiddenField ID="hddyear" runat="server" Value='<%# Eval("year") %>' />
                        <asp:HiddenField ID="hddquarter" runat="server" Value='<%# Eval("quarter") %>' />
                        <asp:HiddenField ID="hddcustype" runat="server" Value='<%# Eval("cus_type") %>' />

                        

                        <asp:Button ID="btnmanage" runat="server" Text="Manage" OnClick="btnmanage_Click" Visible="false" CssClass="btn btn-info" />
                        <asp:Button ID="btndownload" runat="server" Text="Download"  Visible="false" CssClass="btn btn-info" OnClick="btnDownload_Click"/>
                        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClientClick="return Confim();" OnClick="btndelete_Click" Visible="false" CssClass="btn btn-danger"  />
                    </ItemTemplate>
                    
                </asp:TemplateField>
            </Columns>
            <PagerSettings Mode="NumericFirstLast" PageButtonCount="4"  FirstPageText="First" LastPageText="Last"/>
        </asp:GridView>
        <div class="serchRed"
        <asp:Image ID="Image9" runat="server" ImageUrl="~/img_rep/Assign.png" />
        <asp:Image ID="Image13" runat="server" ImageUrl="~/img_rep/Assign.png" />
            &nbsp;Assign&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image10" runat="server" ImageUrl="~/img_rep/In Process.png" />
            In Process&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image11" runat="server" ImageUrl="~/img_rep/Approve.png" />
            Approve&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image12" runat="server" ImageUrl="~/img_rep/Reject.png" />
            Reject</div>
    </div>
</asp:Content>
