<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permit.aspx.cs" Inherits="ptt_report.permit" %>



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

                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>Permit</h3>
                <div class="info_executive_in">
            <table>

                <tr>
                    <th colspan="2"></th>
                </tr>

                <tr>
                    <td>การบำรุงรักษาระบบท่อส่งก๊าซธรรมชาติปี: </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="PermitGas" runat="server" Columns="60" BackColor="#99FF99"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">ชื่อโครงการ : </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="PermitProjectName" runat="server" Columns="60" BackColor="#99FF99"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>เส้นทางท่อ : </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="PermitPipeLine" runat="server" Columns="60"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>เลขที่ใบอนุญาต : </td>
                    <td class="auto-style1">

                        <asp:TextBox ID="PermitCerfNumber" runat="server" Columns="60" BackColor="#99FF99"></asp:TextBox>

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
        </div>
    </div>

</asp:Content>
