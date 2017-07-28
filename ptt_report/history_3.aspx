<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPagePIR.master" AutoEventWireup="true" CodeBehind="history_3.aspx.cs" Inherits="ptt_report.history_3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
        <h3>HISTORY</h3>     
        <hr />
    <asp:HiddenField ID="hddrep_type" runat="server" />
    <asp:GridView ID="gridview_rep_tmp" runat="server" AutoGenerateColumns="false" AllowPaging="true" ShowFooter="false"
        OnPageIndexChanging="gridview_rep_tmp_PageIndexChanging" >
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
    </asp:GridView>
</asp:Content>
