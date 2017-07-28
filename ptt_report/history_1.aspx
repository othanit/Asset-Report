<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="history_1.aspx.cs" Inherits="ptt_report.history_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <div class="boxhis">
        <h3>HISTORY</h3>
        <hr />
        <asp:HiddenField ID="hddrep_type" runat="server" />



        <asp:GridView ID="gridview_rep_tmp" runat="server" AutoGenerateColumns="False" AllowPaging="True"
            OnPageIndexChanging="gridview_rep_tmp_PageIndexChanging" CellPadding="4" ForeColor="#333333" GridLines="None" Width="870px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>

                <asp:BoundField DataField="last_update" HeaderText="Last Update" />
                <asp:BoundField DataField="filename" HeaderText="Doc file" />
                <asp:BoundField DataField="createid" HeaderText="Update By" />
                <asp:TemplateField HeaderText="Download">
                    <ItemTemplate>
                        <asp:HiddenField ID="hddfile_path" Value='<%# Eval("uri") %>' runat="server" />
                        <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
                    </ItemTemplate>
                </asp:TemplateField>


            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
</asp:Content>
