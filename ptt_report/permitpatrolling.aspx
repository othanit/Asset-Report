<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitpatrolling.aspx.cs" Inherits="ptt_report.permitpatrolling" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
      <style>
        #menuleft02 {
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
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" class="btn" OnClick="btnSaveVer_Click"/>
        <asp:Button ID="btnExport" runat="server" Text="Export Report" class="btn" OnClick="btnExport_Click" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" OnClick="Button1_Click" />

        <asp:HiddenField ID="hddtpprotrolling_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">
                 Patrolling
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            <div class="info_executive">
                <h3>Patrolling</h3>
                <div class="info_executive_in">
                        <table>

                            <tr>
                                <th colspan="3" style="text-align:left">จากการลาดตระเวน และตรวจสอบ</th>
                            </tr>

                            <tr>
                                <td>ตรวจการรั่วไหลของก๊าซฯ ด้วยเครื่อง Gas Detector: </td>
                                <td class="auto-style1" colspan="2">

                                    <asp:TextBox ID="PermitPatrolGasDetector" runat="server" Columns="40" BackColor="#99FF99"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">งานก่อสร้างใกล้แนวท่อส่งก๊าซธรรมชาติ จำนวน : </td>
                                <td>

                                    <asp:TextBox ID="PermitPatrolWorkNearPipe" runat="server" Columns="5" BackColor="#99FF99"></asp:TextBox> งาน 

                                </td>
                                <td>
                                   <asp:TextBox ID="PermitPatrolWorkNearPipeNote" runat="server" Columns="40"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">ป้ายเตือนชำรุดเสียหาย และถูกขโมย จำนวน : </td>
                                <td>

                                    <asp:TextBox ID="PermitPatrolNotiLabelAmount" runat="server" Columns="5" BackColor="#99FF99"></asp:TextBox> ป้าย 

                                </td>
                                <td>
                                   <asp:TextBox ID="PermitPatrolNotiLabelNote" runat="server" Columns="40"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Test post ชำรุดเสียหาย จำนวน: </td>
                                <td>

                                    <asp:TextBox ID="PermitPatrolTestPostAmount" runat="server" Columns="5" BackColor="#99FF99"></asp:TextBox> ต้น

                                </td>
                                <td>
                                   <asp:TextBox ID="PermitPatrolTestPostNote" runat="server" Columns="40"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">พื้นที่จดกัดเซาะบนแนวท่อ จำนวน: </td>
                                <td>

                                    <asp:TextBox ID="PermitPatrolAreaScourPipeAmount" runat="server" Columns="5" BackColor="#99FF99"></asp:TextBox> จุด

                                </td>
                                <td>
                                   <asp:TextBox ID="PermitPatrolAreadScourNote" runat="server" Columns="40" BackColor="#99FF99"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">การลุกล้ำ สิ่งปลูกสร้างและต้นไม้ยืนต้น <br /> ในบริเวณแนวท่อส่งก๊าซธรรมชาติ จำนวน: </td>
                                <td>

                                    <asp:TextBox ID="PermitPatrolPoachAmount" runat="server" Columns="5" BackColor="#99FF99"></asp:TextBox> จุด

                                </td>
                                <td>
                                   <asp:TextBox ID="PermitPatrolPoachNote" runat="server" Columns="40"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">จากการสำรวจ ROV ตรวจพบ Free Span จำนวน: </td>
                                <td>

                                    <asp:TextBox ID="PermitPatrolROVAmount" runat="server" Columns="5" BackColor="#99FF99"></asp:TextBox> จุด

                                </td>
                                <td>
                                   <asp:TextBox ID="PermitPatrolROVNote" runat="server" Columns="40"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">ความเห็น: </td>
                                <td colspan="2">

                                    <asp:TextBox ID="PermitPatrolFeedback" runat="server" Columns="40"></asp:TextBox>

                                </td>
                            </tr>
                        </table>
                    </div>
                    <div>
                        <asp:Button ID="PermitPatrolFormSaveSubmit" runat="server" Text="Save" class="btn" OnClick="PermitPatrolFormSaveSubmit_Click" />
                 <asp:Button ID="btnApprove" runat="server" Text="Approve" class="btn" OnClick="btnApprove_Click" />
                 <asp:Button ID="btnReject" runat="server" Text="Reject" class="btn" OnClick="btnReject_Click" />
                    </div>
            </div>
        </div>
    </div>

</asp:Content>
