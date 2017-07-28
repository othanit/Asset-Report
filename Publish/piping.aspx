<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="piping.aspx.cs" Inherits="ptt_report.piping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <table>
        <tr>
            <td>
                <div>
                    Customer Type :
                    <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
                    <asp:Button ID="btnExport" runat="server" Text="Export Report" />
                    <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" />
                    <asp:Button ID="btnHistory" runat="server" Text="History" />
                    <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" />
                </div>
            </td>
        </tr>
        <tr>
            <td>Piping
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Quarterly Plan :</td>
                        <td>
                            <table>
                                <tr>
                                    <td rowspan="5">
                                        <asp:Label ID="lbQuarter" runat="server" Text="-"></asp:Label></td>
                                    <td>Region</td>
                                    <td colspan="2">1</td>
                                    <td colspan="2">2</td>
                                    <td colspan="2">3</td>
                                    <td colspan="2">4</td>
                                    <td colspan="2">5</td>
                                    <td colspan="2">6</td>
                                    <td colspan="2">7</td>
                                    <td colspan="2">8</td>
                                    <td colspan="2">9</td>
                                    <td colspan="2">10</td>
                                </tr>
                                <tr>
                                    <td>Progress</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbM1" runat="server" Text="-"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm111" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm112" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm121" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm122" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm131" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm132" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm141" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm142" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm151" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm152" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm161" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm162" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm171" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm172" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm181" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm182" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm191" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm192" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm101" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm102" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbM2" runat="server" Text="-"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm211" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm212" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm221" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm222" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm231" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm232" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm241" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm242" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm251" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm252" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm261" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm262" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm271" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm272" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm281" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm282" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm291" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm292" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm201" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm202" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbM3" runat="server" Text="-"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm311" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm312" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm321" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm322" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm331" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm332" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm341" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm342" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm351" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm352" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm361" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm362" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm371" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm372" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm381" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm382" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm391" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm392" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm301" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm302" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>Preventive maintenance PM :</td>
                        <td>
                            <div>Wall Thickness Inspection</div>
                            <asp:Button ID="btnCreate1" runat="server" Text="Create" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td>Region</td>
                                    <td>Criteria</td>
                                    <td>Status</td>
                                    <td>Management</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
                                    </td>
                                    <td>Avg
                                        <br />
                                        <asp:TextBox ID="txtAVG" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtstation" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDel1" runat="server" Text="Delete" /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>Min
                                        <br />
                                        <asp:TextBox ID="txtmin" runat="server"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>CorrRate(mm/yr)
                                        <br />
                                        <asp:TextBox ID="txtCorr" runat="server"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <div>Coating Inspection</div>
                            <asp:Button ID="btnCreate2" runat="server" Text="Create" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td>Region</td>
                                    <td>Criteria</td>
                                    <td>Status</td>
                                    <td>Management</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRegion2" runat="server"></asp:TextBox>
                                    </td>
                                    <td>Coating condition / สภาพ Coating
                                        <br />
                                        <asp:TextBox ID="txtCoatingCondition" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtstation2" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDel2" runat="server" Text="Delete" /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>Corrosion condition / สภาพการเกิด Corrosion
                                        <br />
                                        <asp:TextBox ID="txtCorrosion" runat="server"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <div>Corrosion Under Pipe Support</div>
                            <asp:Button ID="btnCreate3" runat="server" Text="Create" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td>Region</td>
                                    <td>Criteria</td>
                                    <td>Station</td>
                                    <td>Management</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRegion3" runat="server"></asp:TextBox>
                                    </td>
                                    <td>Pipe support condition / สภาพท่อใต้ Support
                                        <br />
                                        <asp:TextBox ID="txtPipeSup" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtstation3" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDel3" runat="server" Text="Delete" /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>Corrosion condition / สภาพการเกิด Corrosion
                                        <br />
                                        <asp:TextBox ID="txtCorrosion2" runat="server"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <div>Soil to Air Inspection</div>
                            <asp:Button ID="btnCreate4" runat="server" Text="Create" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td>Region</td>
                                    <td>Criteria</td>
                                    <td>Station</td>
                                    <td>Management</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRegion4" runat="server"></asp:TextBox>
                                    </td>
                                    <td>Coating condition / สภาพ Coating
                                        <br />
                                        <asp:TextBox ID="txtCoating4" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtstation4" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDel4" runat="server" Text="Delete" /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>Corrosion condition / สภาพการเกิด Corrosion
                                        <br />
                                        <asp:TextBox ID="txtCorrosion4" runat="server"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <div>Corrosion Under Insulation</div>
                            <asp:Button ID="btnCreate5" runat="server" Text="Create" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td>Region</td>
                                    <td>Criteria</td>
                                    <td>Station</td>
                                    <td>Management</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRegion5" runat="server"></asp:TextBox>
                                    </td>
                                    <td>Insulation condition / สภาพ Insulation
                                        <br />
                                        <asp:TextBox ID="txtInsulation" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtstation5" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDel5" runat="server" Text="Delete" /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>Corrosion condition / สภาพการเกิด Corrosion
                                        <br />
                                        <asp:TextBox ID="txtCorrosion5" runat="server"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>Corrective maintenance CM :</td>
                        <td>
                            <asp:Button ID="btnCreate6" runat="server" Text="Create" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <table>
                                <tr>
                                    <td>Region</td>
                                    <td>Inspection</td>
                                    <td>CM Station</td>
                                    <td>Date</td>
                                    <td>Management</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtRegion6" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtInspection" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtCMStation" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDel6" runat="server" Text="Delete" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>แผนงานในอนาคต :</td>
                        <td>
                            <table>
                                <tr>
                                    <td rowspan="5">
                                        <asp:Label ID="lbQuarter2" runat="server" Text="-"></asp:Label></td>
                                    <td>Region</td>
                                    <td colspan="2">1</td>
                                    <td colspan="2">2</td>
                                    <td colspan="2">3</td>
                                    <td colspan="2">4</td>
                                    <td colspan="2">5</td>
                                    <td colspan="2">6</td>
                                    <td colspan="2">7</td>
                                    <td colspan="2">8</td>
                                    <td colspan="2">9</td>
                                    <td colspan="2">10</td>
                                </tr>
                                <tr>
                                    <td>Progress</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                    <td>Plan</td>
                                    <td>Act</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbM1_" runat="server" Text="-"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm111_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm112_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm121_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm122_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm131_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm132_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm141_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm142_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm151_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm152_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm161_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm162_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm171_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm172_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm181_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm182_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm191_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm192_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm101_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm102_" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbM2_" runat="server" Text="-"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm211_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm212_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm221_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm222_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm231_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm232_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm241_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm242_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm251_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm252_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm261_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm262_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm271_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm272_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm281_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm282_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm291_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm292_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm201_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm202_" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lbM3_" runat="server" Text="-"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm311_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm312_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm321_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm322_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm331_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm332_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm341_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm342_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm351_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm352_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm361_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm362_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm371_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm372_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm381_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm382_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm391_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm392_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm301_" runat="server" Text=""></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lbm302_" runat="server" Text=""></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>ความเห็น :</td>
                        <td>
                            <asp:TextBox ID="txtComment" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSave" runat="server" Text="Save" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
