<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitproject.aspx.cs" Inherits="ptt_report.permitproject" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
        #menuleft06 {
            background: #0c7fd2;
        }
          .auto-style1 {
              height: 20px;
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
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" />
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">

                 <asp:Button ID="btnImport" runat="server" Text="Create" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>Other Project</h3>
                <div class="info_executive_in">
                    <table>

                        <tr>
                            <td class="auto-style1">ชื่อโครงการ : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitProjectName" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>รายละเอียด : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitPipeLine" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitCerfNumber" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                               </td>
                            <td class="auto-style1"> <asp:Button ID="PermitFormSaveSubmit" runat="server" Text="Save" class="btn" OnClick="PermitFormSaveSubmit_Click" /></td>
                        </tr>

                    </table>
                </div>
            </div>

             <div class="info_executive">
                <h3>Other Project  <asp:Button ID="Button3" runat="server"  Text="Delete" BackColor="Red" ForeColor="White" /></h3>
                <div class="info_executive_in">
                    <table>

                        <tr>
                            <td class="auto-style1">ชื่อโครงการ : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="TextBox1" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>รายละเอียด : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="TextBox2" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="TextBox3" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                               </td>
                            <td class="auto-style1"> <asp:Button ID="Button2" runat="server" Text="Save" class="btn" OnClick="PermitFormSaveSubmit_Click" /></td>
                        </tr>

                    </table>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
