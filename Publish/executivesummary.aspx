<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.Master" AutoEventWireup="true" CodeBehind="executivesummary.aspx.cs" Inherits="ptt_report.executivesummary" %>



<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft01 {
            background: #0c7fd2;
        }
    </style>
    <div class="bar_qr">
        Customer Type :
                   
      <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn" OnClick="btnHistory_Click" />

    </div>

    <asp:HiddenField ID="hddexecutivesummary_id" runat="server" />
    <asp:HiddenField ID="hddmas_rep_id" runat="server" />
    <asp:HiddenField ID="hddfile_path" runat="server" />

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">Executive summary
                <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" CssClass="btn btn-info" /></h3>


            <div class="info_executive">
                <h3>3rd party Interface</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน Patrolling : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="patrolingPercent" BackColor="#99ff99" runat="server" Width="27px"></asp:TextBox>
                                % เทียบแผนทั้งปี </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="BasicAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="PatrollingObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="PatrollingFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="PatrollingFormSubmit" runat="server" Text="Save Patrolling Part" OnClick="PatrollingFormSubmit_Click" class="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>
                    </table>
                </div>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน ROV : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="RovPercent" runat="server" Width="27px"></asp:TextBox>
                                % เทียบแผนทั้งปี </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="RovAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="RovObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="RovFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="RovFormSubmit" runat="server" Text="Save ROV Part" OnClick="RovFormSubmit_Click" class="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>
                    </table>
                </div>


                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน งานขุดซ่อม : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="DigPercent" BackColor="#99ff99" runat="server" Width="27px"></asp:TextBox>
                                % เทียบแผนทั้งปี </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปและวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="DigAnalysis" BackColor="#99ff99" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="DigObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="DigFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="DigFormSubmit" runat="server" Text="Save DA Part" OnClick="DigFormSubmit_Click" class="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>
                    </table>
                </div>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>งานแก้ไขจุดกัดเซาะ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ErosionPercent" runat="server" Width="27px"></asp:TextBox>
                                % เทียบแผนทั้งปี </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ErosionAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ErosionObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ErosionFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="ErosionFormSubmit" runat="server" Text="Save Erosion Part" OnClick="ErosionFormSubmit_Click" class="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>
                    </table>
                </div>
                <div class="info_executive_in">

                    <table>
                        <tr>
                            <td>การทรุดตัวของท่อ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="SubsidePercent" runat="server" Width="27px"></asp:TextBox>
                                % เทียบแผนทั้งปี </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="SubsideAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="SubsideObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="SubsideFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="SubsideFormSubmit" runat="server" Text="Save Subside Part" OnClick="SubsideFormSubmit_Click" class="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>

                    </table>
                </div>





            </div>

        </div>
    </div>


    <div id="externalCorotionForm" style="background-color: #FFFFFF">
        <div id="externalCorotionFormTable">


            <div class="info_executive">
                <h3>External Corrosion</h3>

                <div class="info_executive_in">
                    <table>



                        <tr>
                            <td>CP system : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="CPSystemPercent" BackColor="#99ff99" runat="server" Width="27px"></asp:TextBox>
                                % เทียบแผนทั้งปี </td>
                        </tr>
                        <tr>
                            <td>CIPS / DCVG : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="CIPSPercent" runat="server" BackColor="#99ff99" Width="27px"></asp:TextBox>
                                % เทียบแผนทั้งปี </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ECAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ECObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ECFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="ECFormSubmit" runat="server" Text="Save EC Part" OnClick="ECFormSubmit_Click" CssClass="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
    </div>

    <div id="internalCorotionForm" style="background-color: #FFFFFF">
        <div id="internalCorotionFormTable">

            <div class="info_executive">
                <h3>Internal Corrosion</h3>

                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>Cleaning PIG : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ICCPIGPercent" BackColor="#99ff99" runat="server" Width="27px"></asp:TextBox>
                                % </td>
                        </tr>
                        <tr>
                            <td>ILI PIG : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ICILIPIGPercent" BackColor="#99ff99" runat="server" Width="27px"></asp:TextBox>
                                % </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ICAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ICObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="ICFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="ICFormSubmit" runat="server" Text="Save Internal Corrosion Part" OnClick="ICFormSubmit_Click" CssClass="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>

    <div id="mtpgForm" style="background-color: #FFFFFF">
        <div id="mtpgFormTable">
            <div class="info_executive">
                <h3>งานบำรุงรักษาท่อภายในสถานีก๊าซ</h3>
                <div class="info_executive_in">
                    <table>

                        <tr>
                            <td>ความครบถ้วนตามแผนงาน  : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MTPGPercent" BackColor="#99ff99" runat="server" Width="27px"></asp:TextBox>
                                % </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MTPGAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MTPGObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="MTPGFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="MTPGFormSubmit" runat="server" Text="Save DA Part" OnClick="MTPGFormSubmit_Click" CssClass="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>

    <div id="OffShorePipeForm" style="background-color: #FFFFFF">
        <div id="OffShorePipeFormTable">
            <div class="info_executive">
                <h3>งานบำรุงรักษาท่อบนแท่นพักท่อก๊าซในทะเล</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <th colspan="2"></th>
                        </tr>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน  : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="OffShorePipePercent" runat="server" Width="27px"></asp:TextBox>
                                % </td>
                        </tr>
                        <tr>
                            <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="OffShorePipeAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="OffShorePipeObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น : </td>
                            <td class="auto-style1">
                                <asp:TextBox ID="OffShorePipeFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="OffShorePipeFormSubmit" runat="server" OnClick="OffShorePipeFormSubmit_Click" Text="Save Offshore Part" CssClass="btn" /></td>
                            <td class="auto-style1"></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>

    <div id="OffShoreBaseForm" style="background-color: #FFFFFF">
        <div id="OffShoreBaseFormTable">
            <div id="OffShorePipeFormTable" runat="server">
                <div class="info_executive">
                    <h3>งานบำรุงรักษาโครงสร้างแท่นพักของท่อในทะเล</h3>
                    <div class="info_executive_in">
                        <table>

                            <tr>
                                <td>ความครบถ้วนตามแผนงาน  : </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="OffShoreBasePercent" runat="server" Width="27px"></asp:TextBox>
                                    % </td>
                            </tr>
                            <tr>
                                <td>ผลสรุปวิเคราะห์เบื้องต้น : </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="OffShoreBaseAnalysis" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>ประเด็นปัญหา / อุปสรรค์ : </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="OffShoreBaseObstruction" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>ความเห็น : </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="OffShoreBaseFeedback" TextMode="MultiLine" runat="server" ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="OffShoreBaseFormSubmit" OnClick="OffShoreBaseFormSubmit_Click" runat="server" Text="Save Offshore Part" CssClass="btn" /></td>
                                <td class="auto-style1"></td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id="OtherProjectForm" style="background-color: #FFFFFF">
        <div id="OtherProjectFormTable1" runat="server" visible="false">
            <div class="info_executive">
                <h3>Other Project </h3>
                <asp:Button ID="btndelother1" runat="server" Text="Delete" OnClick="btndelother1_Click" />
                <asp:HiddenField ID="hdd_idother1" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ชื่อโครงการ :</td>
                            <td>
                                <asp:TextBox ID="txtother_info1" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน : </td>
                            <td>
                                <asp:TextBox ID="txtother_info2" runat="server"></asp:TextBox>
                                %</td>
                        </tr>
                        <tr>
                            <td>ผลสรุปและวิเคราะห์เบื้องต้น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info3" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา/อุปสรรค :</td>
                            <td>
                                <asp:TextBox ID="txtother_info4" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info5" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btnSaveOther1" runat="server" Text="Save" OnClick="btnSaveOther1_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>

        <div id="OtherProjectFormTable2" runat="server" visible="false">
            <div class="info_executive">
                <h3>Other Project </h3>
                <asp:Button ID="btndelother2" runat="server" Text="Delete" OnClick="btndelother2_Click" />
                <asp:HiddenField ID="hdd_idother2" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ชื่อโครงการ :</td>
                            <td>
                                <asp:TextBox ID="txtother_info12" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน : </td>
                            <td>
                                <asp:TextBox ID="txtother_info22" runat="server"></asp:TextBox>
                                %</td>
                        </tr>
                        <tr>
                            <td>ผลสรุปและวิเคราะห์เบื้องต้น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info32" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา/อุปสรรค :</td>
                            <td>
                                <asp:TextBox ID="txtother_info42" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info52" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btnSaveOther2" runat="server" Text="Save" OnClick="btnSaveOther2_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>

        <div id="OtherProjectFormTable3" runat="server" visible="false">
            <div class="info_executive">
                <h3>Other Project </h3>
                <asp:Button ID="btndelother3" runat="server" Text="Delete" OnClick="btndelother3_Click" />
                <asp:HiddenField ID="hdd_idother3" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ชื่อโครงการ :</td>
                            <td>
                                <asp:TextBox ID="txtother_info13" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน : </td>
                            <td>
                                <asp:TextBox ID="txtother_info23" runat="server"></asp:TextBox>
                                %</td>
                        </tr>
                        <tr>
                            <td>ผลสรุปและวิเคราะห์เบื้องต้น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info33" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา/อุปสรรค :</td>
                            <td>
                                <asp:TextBox ID="txtother_info43" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info53" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btnSaveOther3" runat="server" Text="Save" OnClick="btnSaveOther3_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>

        <div id="OtherProjectFormTable4" runat="server" visible="false">
            <div class="info_executive">
                <h3>Other Project </h3>
                <asp:Button ID="btndelother4" runat="server" Text="Delete" OnClick="btndelother4_Click" />
                <asp:HiddenField ID="hdd_idother4" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ชื่อโครงการ :</td>
                            <td>
                                <asp:TextBox ID="txtother_info14" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน : </td>
                            <td>
                                <asp:TextBox ID="txtother_info24" runat="server"></asp:TextBox>
                                %</td>
                        </tr>
                        <tr>
                            <td>ผลสรุปและวิเคราะห์เบื้องต้น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info34" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา/อุปสรรค :</td>
                            <td>
                                <asp:TextBox ID="txtother_info44" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info54" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btnSaveOther4" runat="server" Text="Save" OnClick="btnSaveOther4_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>

        <div id="OtherProjectFormTable5" runat="server" visible="false">
            <div class="info_executive">
                <h3>Other Project </h3>
                <asp:Button ID="btndelother5" runat="server" Text="Delete" OnClick="btndelother5_Click" />
                <asp:HiddenField ID="hdd_idother5" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>ชื่อโครงการ :</td>
                            <td>
                                <asp:TextBox ID="txtother_info15" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความครบถ้วนตามแผนงาน : </td>
                            <td>
                                <asp:TextBox ID="txtother_info25" runat="server"></asp:TextBox>
                                %</td>
                        </tr>
                        <tr>
                            <td>ผลสรุปและวิเคราะห์เบื้องต้น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info35" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ประเด็นปัญหา/อุปสรรค :</td>
                            <td>
                                <asp:TextBox ID="txtother_info45" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox ID="txtother_info55" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="btnSaveOther5" runat="server" Text="Save" OnClick="btnSaveOther5_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <div id="OtherProjectAddButton">
            <asp:Button ID="AddOtherProject" runat="server" Text="Add Other Project" OnClick="AddOtherProject_Click" CssClass="btn" />
        </div>
    </div>
</asp:Content>
