<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage2.Master" AutoEventWireup="true" CodeBehind="permitappendixI.aspx.cs" Inherits="ptt_report.permitappendixI" %>



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
                            <td class="auto-style1" colspan="2">
                                <table>
                                    <tr>
                                        <td class="auto-style1" style="text-align:right;" colspan="2">
                                            <asp:Button ID="Button3" runat="server" Text="Create" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <th>RouteCode</th>
                                        <th>Period</th>
                                        <th>Rectifier Voltage (Volt)</th>
                                        <th>Rectifier Current (Amp.)</th>
                                        <th>Manage</th>
                                    </tr>    
                                    <tr>
                                        <td rowspan="13">
                                            <asp:TextBox ID="PermitAppendixLRouteCode" runat="server" BackColor="#99FF99"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:TextBox ID="PermitPeriod1" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:FileUpload ID="PermitRVFileUpload1" runat="server" BackColor="#99FF99" />
                                        </td>
                                        <td>
                                            <asp:FileUpload ID="PermitRCFileUpload1" runat="server" BackColor="#99FF99" />
                                        </td>
                                        <td>
                                            <asp:Button ID="PermitRCFDel1" runat="server" Text="Delete" class="btn btn-danger" />
                                        </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod2" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload2" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload2" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel2" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                                                        <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod3" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload3" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload3" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel3" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod4" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload4" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload4" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel4" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                                                        <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod5" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload5" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload5" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel5" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod6" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload6" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload6" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel6" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod7" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload7" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload7" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel7" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod8" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload8" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload8" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel8" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod9" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload9" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload9" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel9" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod10" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload10" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload10" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel10" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod11" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload11" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload11" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel11" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload12" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload12" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel12" runat="server" Text="Delete" class="btn btn-danger" />
	                                    </td>
                                    </tr>
                                    <tr>
	                                    <td>
		                                    <asp:TextBox ID="PermitPeriod12" runat="server"></asp:TextBox>
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRVFileUpload13" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:FileUpload ID="PermitRCFileUpload13" runat="server" BackColor="#99FF99" />
	                                    </td>
	                                    <td>
		                                    <asp:Button ID="PermitRCFDel13" runat="server" Text="Delete" class="btn btn-danger" />
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
