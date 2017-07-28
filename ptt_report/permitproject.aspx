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
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" OnClick="btnSaveVer_Click" class="btn" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" OnClick="btnExport_Click"  class="btn" />
        <asp:Button ID="Button1" runat="server" Text="History" class="btn" OnClick="Button1_Click" />

        <asp:HiddenField ID="hddpp_id" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        
    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
             <h3 class="barBlue">
                 Project
                 <asp:Button ID="btnImport" runat="server" Text="Create" OnClick="btnImport_Click" class="btn btn-info" />
 
            </h3>
            
            <div id="divOther1" runat="server" visible="true">
                <asp:HiddenField ID="project_sub_id1" runat="server" />
                <div class="info_executive">
                <h3>Other Project</h3>
                <div class="info_executive_in">
                        <table>

                            <tr>
                                <td class="auto-style1">ชื่อโครงการ : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectName1" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>รายละเอียด : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectDetail1" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>ความเห็น : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectOpinion1" runat="server" Columns="60"></asp:TextBox>

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

            <div id="divOther2" runat="server" visible="false">
                <asp:HiddenField ID="project_sub_id2" runat="server" />
                <div class="info_executive">
                <h3>Other Project </h3>
                <div class="info_executive_in">
                    <table>

                        <tr>
                            <td class="auto-style1">ชื่อโครงการ : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ProjectName2" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>รายละเอียด : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ProjectDetail2" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">

                                <asp:TextBox ID="ProjectOpinion2" runat="server" Columns="60"></asp:TextBox>

                            </td>
                        </tr>
                        <tr>
                            <td>
                               </td>
                            <td class="auto-style1"> <asp:Button ID="Button2" runat="server" Text="Save" class="btn" OnClick="Button2_Click" /></td>
                        </tr>

                    </table>
                </div>
            </div>

            </div>
            
            <div id="divOther3" runat="server" visible="false">
                <asp:HiddenField ID="project_sub_id3" runat="server" />
                <div class="info_executive">
                <h3>Other Project</h3>
                <div class="info_executive_in">
                        <table>

                            <tr>
                                <td class="auto-style1">ชื่อโครงการ : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectName3" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>รายละเอียด : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectDetail3" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>ความเห็น : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectOpinion3" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                   </td>
                                <td class="auto-style1"> <asp:Button ID="Button3" runat="server" Text="Save" class="btn" OnClick="Button3_Click" /></td>
                            </tr>

                        </table>
                    </div>
                </div>

            </div>
            
            <div id="divOther4" runat="server" visible="false">
                <asp:HiddenField ID="project_sub_id4" runat="server" />
                <div class="info_executive">
                <h3>Other Project</h3>
                <div class="info_executive_in">
                        <table>

                            <tr>
                                <td class="auto-style1">ชื่อโครงการ : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectName4" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>รายละเอียด : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectDetail4" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>ความเห็น : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectOpinion4" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                   </td>
                                <td class="auto-style1"> <asp:Button ID="Button4" runat="server" Text="Save" class="btn" OnClick="Button4_Click" /></td>
                            </tr>

                        </table>
                    </div>
                </div>

            </div>
            
            <div id="divOther5" runat="server" visible="false">
                <asp:HiddenField ID="project_sub_id5" runat="server" />
                <div class="info_executive">
                <h3>Other Project</h3>
                <div class="info_executive_in">
                        <table>

                            <tr>
                                <td class="auto-style1">ชื่อโครงการ : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectName5" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>รายละเอียด : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectDetail5" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>ความเห็น : </td>
                                <td class="auto-style1">

                                    <asp:TextBox ID="ProjectOpinion5" runat="server" Columns="60"></asp:TextBox>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                   </td>
                                <td class="auto-style1"> <asp:Button ID="Button5" runat="server" Text="Save" class="btn" OnClick="Button5_Click" /></td>
                            </tr>

                        </table>
                    </div>
                </div>

            </div>
                        
        </div>
    </div>

                 <asp:Button ID="btnApprove" runat="server" Text="Approve" class="btn" OnClick="btnApprove_Click" />
                 <asp:Button ID="btnReject" runat="server" Text="Reject" class="btn" OnClick="btnReject_Click" />
                    
</asp:Content>
