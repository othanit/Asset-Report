<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="reptmp.aspx.cs" Inherits="ptt_report.reptmp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btn {
            width:100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="page_header" style="width:1050px;;background-color: #bee9f7;    padding: 11px 50px;">Report Template Management</h2>
    <br clear="all">
    <h3 class="mini_head">
        <asp:DropDownList ID="ddlRepType" runat="server" OnSelectedIndexChanged="ddlRepType_SelectedIndexChanged"  AutoPostBack="true"></asp:DropDownList>
        <asp:Button ID="btnAddTmp" runat="server" Text="Add Template" OnClick="btnAddTmp_Click" class="btn btn-gray" style="float: right;" />
    </h3>
    <div>
        <asp:GridView ID="gridview_rep_tmp" runat="server" AutoGenerateColumns="false" AllowPaging="true" ShowFooter="false" OnRowDataBound="gridview_rep_tmp_RowDataBound" OnPageIndexChanging="gridview_rep_tmp_PageIndexChanging">
            <Columns>

                <asp:BoundField DataField="lastupdate" HeaderText="Last Update" />
                <asp:BoundField DataField="report_name" HeaderText="Doc file" />
                <asp:BoundField DataField="updateby" HeaderText="Update By" />

                <asp:TemplateField HeaderText="Download">
                    <ItemTemplate>
                        <asp:HiddenField ID="hddfile_path" Value='<%# Eval("file_path") %>' runat="server" />
                        <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" CssClass="btn btn-info" />
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:HiddenField ID="hddflag_active" Value='<%# Eval("flag_active") %>' runat="server" />
                        <%--<asp:Button ID="Button2" runat="server" Text="Active" CssClass="btn btn-green"  />
                        <asp:Button ID="Button1" runat="server" Text="In-Active" CssClass="btn btn-danger"  />--%>

                        <asp:Label ID="statusLabel" runat="server"></asp:Label>

                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
