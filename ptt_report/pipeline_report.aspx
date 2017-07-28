<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pipeline_report.aspx.cs" Inherits="ptt_report.pipeline_report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btn {
            width:80px;
            margin:2px 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="mini_head2">Pipeline Integrity Report
    </h3>
    <div class="serchRed">
        <table>
            <tr>
                <td>Year : 
                </td>
                <td>
                    <asp:DropDownList ID="ddlyear" runat="server" OnSelectedIndexChanged="ddlyear_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td>Type : 
                </td>
                <td>
                    <asp:DropDownList ID="ddltype" runat="server" OnSelectedIndexChanged="ddltype_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td>Permit : 
                </td>
                <td>
                    <asp:DropDownList ID="ddlpermit" runat="server" OnSelectedIndexChanged="ddlpermit_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" class="btn btn-gray" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:GridView ID="GridView_rep_list" runat="server" AutoGenerateColumns="False" AllowPaging="True"
            OnPageIndexChanging="GridView_rep_list_PageIndexChanging" OnRowDataBound="GridView_rep_list_RowDataBound" class="tb_red">
            <Columns>

                <asp:BoundField DataField="year" HeaderText="Year" />
                <asp:BoundField DataField="type" HeaderText="Type" />
                <asp:BoundField DataField="permit" HeaderText="Permit" />
                <asp:BoundField DataField="status" HeaderText="Status" Visible="False" />
                <asp:BoundField DataField="pipeline_status" HeaderText="Pipline" Visible="False" />
                <asp:BoundField DataField="external_corrosion_status" HeaderText="External Corrosion" Visible="False" />
                <asp:BoundField DataField="internal_status" HeaderText="Internal corrosion control system" Visible="False" />
                <asp:BoundField DataField="mechanical_status" HeaderText="Mechanical damage" Visible="False" />
                <asp:BoundField DataField="loss_status" HeaderText="Loss of ground support " Visible="False" />
                <asp:BoundField DataField="pipeline_repair_status" HeaderText="Pipeline Repair History" Visible="False" />
                 
                <asp:BoundField DataField="last_maintenance_status" HeaderText="Latest maintenance activities" Visible="False" />
                <asp:BoundField DataField="internal_corrosion_status" HeaderText="Internal Corrosion" Visible="False" />
                <asp:BoundField DataField="third_party_status" HeaderText="Third party interference " Visible="False" />
                 
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Image ID="Image1" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Pipline">
                    <ItemTemplate>
                        <asp:Image ID="Image2" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("pipeline_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Internal corrosion control system">
                    <ItemTemplate>
                        <asp:Image ID="Image3" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("internal_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Internal Corrosion">
                    <ItemTemplate>
                        <asp:Image ID="Image6" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("internal_corrosion_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="External Corrosion">
                    <ItemTemplate>
                        <asp:Image ID="Image5" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("external_corrosion_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Latest maintenance activities">
                    <ItemTemplate>
                        <asp:Image ID="Image4" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("last_maintenance_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Mechanical damage">
                    <ItemTemplate>
                        <asp:Image ID="Image7" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("mechanical_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Third party interference">
                    <ItemTemplate>
                        <asp:Image ID="Image8" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("third_party_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Loss of ground support">
                    <ItemTemplate>
                        <asp:Image ID="Image9" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("loss_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Pipeline Repair History">
                    <ItemTemplate>
                        <asp:Image ID="Image10" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("pipeline_repair_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Manage">
                    <ItemTemplate>
                        <asp:HiddenField ID="hddrepid" runat="server" Value='<%# Eval("id") %>' />
                        <asp:HiddenField ID="hddyear" runat="server" Value='<%# Eval("year") %>' />
                        <asp:HiddenField ID="hddtype" runat="server" Value='<%# Eval("type") %>' />
                        <asp:HiddenField ID="hddpermit" runat="server" Value='<%# Eval("permit") %>' />

                        <asp:Button ID="btnEditPremit" runat="server" Text="Edit Premit" OnClick="btnEditPremit_Click" Visible="false" class="btn btn-info" />
                        <asp:Button ID="btnmanage" runat="server" Text="Manage" OnClick="btnmanage_Click" Visible="false" class="btn btn-info" />
                        <asp:Button ID="btndownload" runat="server" Text="Download" Visible="false" class="btn btn-info" />
                        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" Visible="false" class="btn btn-danger" />
                    </ItemTemplate>
                </asp:TemplateField>



            </Columns>
            <PagerSettings Mode="NumericFirstLast" PageButtonCount="4" FirstPageText="First" LastPageText="Last" />
        </asp:GridView>
        <div class="serchRed"
        <asp:Image ID="Image14" runat="server" ImageUrl="~/img_rep/Assign.png" />
        <asp:Image ID="Image13" runat="server" ImageUrl="~/img_rep/Assign.png" />
            &nbsp;Assign&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image15" runat="server" ImageUrl="~/img_rep/In Process.png" />
            In Process&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image11" runat="server" ImageUrl="~/img_rep/Approve.png" />
            Approve&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image12" runat="server" ImageUrl="~/img_rep/Reject.png" />
            Reject</div>
    </div>
</asp:Content>
