<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitappendixB.aspx.cs" Inherits="ptt_report.permitappendixB" %>



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
                <h3>ผลการลาดตระเวนตรวจแนวท่อส่งก๊าซธรรมชาติ</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td class="auto-style1" style="text-align:right;" colspan="2">
                                <asp:Button ID="Button3" runat="server" Text="Create" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="2">
                                <table>
                                    <tr>
                                        <th>Route Code</th>
                                        <th>งานก่อสร้าง</th>
                                        <th>กัดเซาะ</th>
                                        <th>ป้ายหาย / ติดตั้งใหม่</th>
                                        <th>Test Post หาย / ชำรุด</th>
                                        <th>รุกล้ำ</th>
                                        <th>การรั่วไหลของก๊าซ</th>
                                        <th>ผลรวมสิ่งผิดปกติ</th>
                                        <th>Management</th>
                                    </tr>    
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBRouteCode" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBBuildingWork" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBScour" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBLabel" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBTestPost" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBTrespass" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBReflux" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitAppendixBAbnormal" runat="server" BackColor="#CCCCCC"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Button ID="Button2" runat="server" Text="Delete" class="btn btn-danger" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitCerfNumber" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>

            <div>
                <asp:Button ID="PermitFormSaveSubmit" runat="server" Text="Save" class="btn" OnClick="PermitFormSaveSubmit_Click" />
            </div>

        </div>
    </div>

</asp:Content>
