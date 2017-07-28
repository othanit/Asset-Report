<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="t_p_rep.aspx.cs" Inherits="ptt_report.t_p_rep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btn {
            width: 80px;
            margin: 2px 0px;
        }
    </style>

    <script src="Scripts/jquery.min.js" type="text/javascript"></script>

    <script src="Scripts/jquery.searchabledropdown-1.0.8.min.js" type="text/javascript"></script>

    <script type="text/javascript">
     $(document).ready(function () {
         $(".ddlpermit").searchable();
    });
    </script>


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
    
    
    <h3 class="mini_head2">ธ.พ. Report
    </h3>
    <div class="serchRed">
        <table style="width:100%">
            <tr>
                <td>Year : 
                </td>
                <td>
                    <asp:DropDownList ID="ddlyear" runat="server" OnSelectedIndexChanged="ddlyear_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>

                <td>Permit : 
                </td>
                <td>
                    <asp:DropDownList ID="ddlpermit" CssClass="ddlpermit" runat="server" OnSelectedIndexChanged="ddlpermit_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" class="btn btn-gray" />
                </td>
                <td style="width:60%">
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
                <asp:BoundField DataField="permit" HeaderText="Permit" />
                <asp:BoundField DataField="status" HeaderText="Status" Visible="False" />
                <asp:BoundField DataField="patrolling_status" HeaderText="Patrolling" Visible="False" />
                <asp:BoundField DataField="cp_status" HeaderText="CP" Visible="False" />
                <asp:BoundField DataField="ilipig_status" HeaderText="ILI PIG" Visible="False" />
                <asp:BoundField DataField="wall_thick_status" HeaderText="Wall thickness" Visible="False" />
                <asp:BoundField DataField="project_status" HeaderText="Project" Visible="False" />
                <asp:BoundField DataField="apendixB_status" HeaderText="ภาคผนวก  ข." Visible="False" />
                <asp:BoundField DataField="apendixD_status" HeaderText="ภาคผนวก  ง." Visible="False" />
                <asp:BoundField DataField="apendixH_status" HeaderText="ภาคผนวก  จ." Visible="False" />
                <asp:BoundField DataField="apendixI_status" HeaderText="ภาคผนวก  ฉ." Visible="False" />

                 <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Image ID="Image1" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Patroling">
                    <ItemTemplate>
                        <asp:Image ID="Image2" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("patrolling_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CP">
                    <ItemTemplate>
                        <asp:Image ID="Image3" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("cp_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ILI PIG">
                    <ItemTemplate>
                        <asp:Image ID="Image4" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("ilipig_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Wall thickness">
                    <ItemTemplate>
                        <asp:Image ID="Image5" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("wall_thick_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Project">
                    <ItemTemplate>
                        <asp:Image ID="Image6" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("project_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ภาคผนวก ข.">
                    <ItemTemplate>
                        <asp:Image ID="Image7" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("apendixB_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ภาคผนวก ง.">
                    <ItemTemplate>
                        <asp:Image ID="Image8" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("apendixD_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ภาคผนวก จ.">
                    <ItemTemplate>
                        <asp:Image ID="Image9" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("apendixH_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ภาคผนวก ฉ.">
                    <ItemTemplate>
                        <asp:Image ID="Image10" Height = "30" Width = "30" runat="server" ImageUrl='<%# "~/img_rep/" + Convert.ToString(Eval("apendixI_status")) +".png" %>'  />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Manage">
                    <ItemTemplate>
                        <asp:HiddenField ID="hddrepid" runat="server" Value='<%# Eval("id") %>' />
                        <asp:HiddenField ID="hddyear" runat="server" Value='<%# Eval("year") %>' />
                        <asp:HiddenField ID="hddpermit" runat="server" Value='<%# Eval("permit") %>' />

                        <asp:Button ID="btnEditPremit" runat="server" Text="Edit Premit" OnClick="btnEditPremit_Click" Visible="false" class="btn btn-info" />
                        <asp:Button ID="btnmanage" runat="server" Text="Manage" OnClick="btnmanage_Click" Visible="false" class="btn btn-info" />
                        <asp:Button ID="btndownload" runat="server" Text="Download" Visible="false" OnClick="btndownloadTP_Click" class="btn btn-info" />
                        <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" OnClientClick="return Confim();" Visible="false" class="btn btn-danger" />
                    </ItemTemplate>
                </asp:TemplateField>



            </Columns>
            <PagerSettings Mode="NumericFirstLast" PageButtonCount="4" FirstPageText="First" LastPageText="Last" />
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
