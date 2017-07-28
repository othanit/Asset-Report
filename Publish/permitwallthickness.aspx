<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitwallthickness.aspx.cs" Inherits="ptt_report.permitwallthickness" %>



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
                <h3>การตรวจสภาพท่อส่งก๊าซธรรมชาติด้วยวิธีตรวจวัดความหนาท่อ (Wall thickness monitoring)</h3>
                <div class="info_executive_in">
                    <table>

                        <tr>
                            <th colspan="2"></th>
                        </tr>

                        <tr>
                            <td>ผลการตรวจสอบ: </td>
                            <td class="auto-style1">

                                <textarea id="PermitWallThicknessResult" runat="server" cols="20"  rows="2" style="background-color: #99FF99"></textarea>

                            </td>
                        </tr>
                        <tr>

                            <td class="auto-style1" colspan="2">

                                <table>
                                    <tr>
                                        <td>
                                            ท่อ:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox1" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            สถานี:     
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox2" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            ตำแหน่งท่อ: 
                                        </td>
                                        <td>
                                            <asp:TextBox ID="TextBox3" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>

                            </td>

                        </tr>
                        <tr>
                            <td>ผลสรุป : </td>
                            <td class="auto-style1">

                                <table>
                                    <tr>
                                        <td colspan="8">
                                            <asp:Button ID="Button2" runat="server" Text="Create" />   
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                           BV Station
                                        </td>    
                                        <td>
                                           Route Code
                                        </td>   
                                        <td>
                                           Inspection Date
                                        </td>   
                                        <td>
                                           Point
                                        </td>   
                                        <td>
                                           Diameter
                                        </td>   
                                        <td>
                                           Tavg(mm)
                                        </td>   
                                        <td>
                                           Tmin(mm)
                                        </td>   
                                        <td>
                                            Management
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="TextBox4" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>    
                                        <td>
                                           <asp:TextBox ID="TextBox5" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>   
                                        <td>
                                           <asp:TextBox ID="TextBox6" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>   
                                        <td>
                                           <asp:TextBox ID="TextBox7" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>   
                                        <td>
                                           <asp:TextBox ID="TextBox8" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>   
                                        <td>
                                           <asp:TextBox ID="TextBox9" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>   
                                        <td>
                                           <asp:TextBox ID="TextBox10" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>   
                                        <td>
                                            <asp:Button ID="Button3" runat="server" Text="Delete" />
                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="PermitCerfNumber" runat="server" Columns="20" TextMode="MultiLine"></asp:TextBox>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div>
                 <asp:Button ID="PermitFormSaveSubmit" runat="server" Text="Save" class="btn" />
            </div>
        </div>
    </div>

</asp:Content>
