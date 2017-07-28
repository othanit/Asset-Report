<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitilipig.aspx.cs" Inherits="ptt_report.permitilipig" %>



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
                <h3>การตรวจสภาพท่อส่งก๊าซธรรมชาติด้วย in Line Inspection PIG (ILI PIG) :</h3>
                <div class="info_executive_in">
                    <table>

                        <tr>
                            <th colspan="2"></th>
                        </tr>

                        <tr>
                            <td>External Metal Loss: </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitILIPigEML" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Internal Metal loss : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitILIPigIML" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>Mechanical Damage : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitILIPigMD" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>Remark : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitCerfNumber" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitILIPigNote" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div>
                <asp:Button ID="PermitILIPigFormSaveSubmit" runat="server" Text="Save" class="btn" />
            </div>
        </div>
    </div>

</asp:Content>
