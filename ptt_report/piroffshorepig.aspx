<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPagePIR.Master" AutoEventWireup="true" CodeBehind="piroffshorepig.aspx.cs" Inherits="ptt_report.piroffshorepig" %>


<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft03 {
            background: #0c7fd2;
        }
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            height: 97px;
        }
        .auto-style3 {
            height: 24px;
        }
    </style>
    <div class="bar_qr">
        Customer Type :
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn"  OnClick="btnHistory_Click"/>

        <asp:HiddenField ID="hddpiroffsp_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />

    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">
                Off Shore Pig
                 <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" CssClass="btn btn-info" /></h3>
            <div class="info_executive">
                <h3>PIPELINE</h3>
                <asp:HiddenField ID="pipeline_id" runat="server" />
                <div class="info_executive_in">
                    <table class="col4">

                        <tr>
                            <td>Startup year: </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox1"></asp:TextBox>
                            </td>
                            <td>
                                Design Presure: 
                            </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Station : </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox3"></asp:TextBox>
                            </td>
                            <td>MAOP (PSI): </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox4"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                Length (KM):
                            </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox5"></asp:TextBox>
                            </td>
                            <td>
                                MAOP Design (PSI):
                            </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox6"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>
                                Wall Thickness (inches):
                            </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox7"></asp:TextBox>
                            </td>
                            <td>
                                Original Location class:
                            </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox8"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>Material Spec. : </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox9"></asp:TextBox>
                            </td>
                            <td>Design Life : </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox10"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>External Coathing : </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox11"></asp:TextBox>
                            </td>
                            <td>Cathodic Protection :</td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox12"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                
                
                    <table class="col4">
                        <tr>
                            <th colspan="2">
                                PIPELINE OPERATING DATA
                            </th>
                        </tr>

                        <tr>
                            <td>Operating presure (psig): </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox13"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>Operating Temperature (oC): </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox14"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>Gas Flow rate (MMSCFD): </td>
                            <td>
                                <asp:TextBox runat="server" id="TextBox15"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td></td>
                        </tr>

                    </table>



                    <table class="col4">
                        <tr>
                            <th colspan="4">
                                INTEGRITY ASSESSMENT RESULTS
                            </th>
                        </tr>

                        <tr>
                            <td>Last ILI PIG:: </td>
                            <td><asp:TextBox runat="server" id="TextBox16"></asp:TextBox></td>
                            <td>CR used for Rem. Life (Need for 1st repair): </td>
                            <td><asp:TextBox runat="server" id="TextBox17"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>Prob. of Failure: </td>
                            <td><asp:TextBox runat="server" id="TextBox18"></asp:TextBox></td>
                            <td>Assessment date: </td>
                            <td><asp:TextBox runat="server" id="TextBox19"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>Overall Integrity Status(Remaining life):</td>
                            <td><asp:TextBox runat="server" id="TextBox26"></asp:TextBox></td>
                            <td>Remaining Life (Yrs): </td>
                            <td><asp:TextBox runat="server" id="TextBox27"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>Overall Integrity Status(Design life):</td>
                            <td><asp:TextBox runat="server" id="TextBox20"></asp:TextBox></td>
                            <td>Inspection year: </td>
                            <td><asp:TextBox runat="server" id="TextBox21"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>Safe pressure B31G (PSI): </td>
                            <td><asp:TextBox runat="server" id="TextBox22"></asp:TextBox></td>
                            <td>Burst pressure: </td>
                            <td><asp:TextBox runat="server" id="TextBox23"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>ERF:</td>
                            <td><asp:TextBox runat="server" id="TextBox24"></asp:TextBox></td>
                            <td> </td>
                            <td></td>
                        </tr>

                        <tr>
                            <td class="auto-style1">ความเห็น</td>
                            <td class="auto-style1" colspan="3"><asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="TextBox25"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td></td>
                            <td colspan="3">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save"  class="btn btn-gray" />
                            </td>
                        </tr>

                    </table>


                </div>
            </div>
        

            <div class="info_executive">
                <h3>Internal corrosion control system</h3>
                <asp:HiddenField ID="iccs_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Corrosion Inhibitor:
                                <asp:HiddenField ID="ciValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="ciyes" GroupName="ciiccs" runat="server" OnCheckedChanged="ciyes_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Yes
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="cino" GroupName="ciiccs" runat="server" OnCheckedChanged="cino_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Comment:
                            </td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="ciiccscomment"></asp:TextBox>
                            </td>
                        </tr>
                         <tr>
                            <td>
                               Corrosion Coupon:
                                <asp:HiddenField ID="ccValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ccyes" GroupName="cciccs" runat="server" OnCheckedChanged="ccyes_CheckedChanged" />
                            </td>
                            <td>
                                Yes
                                
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="ccno" GroupName="cciccs" runat="server" OnCheckedChanged="ccno_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                Comment:
                            </td>
                            <td class="auto-style2">
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="cciccscomment"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                               Corrosion Probe:
                                <asp:HiddenField ID="cpValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cp1" GroupName="cpiccs" runat="server" OnCheckedChanged="cp1_CheckedChanged" />
                            </td>
                            <td>
                                Yes
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="cp2" GroupName="cpiccs" runat="server" OnCheckedChanged="cp2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Comment:
                            </td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="cpiccscomment"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinioniccs"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click"  class="btn btn-gray"/></td>
                        </tr>

                    </table>
                </div>
            </div>


            <div class="info_executive">
                <h3>Latest maintainance activities</h3>
                <asp:HiddenField ID="lma_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>Year of CIPS/DCVG:</td>
                            <td>
                                 <asp:TextBox runat="server" id="lmacips"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Year of MFL PIG:</td>
                            <td>
                                <asp:TextBox runat="server" id="lmamfl"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Year of GEO PIG:</td>
                            <td>
                                <asp:TextBox runat="server" id="lmageo"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="lmaopinion"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button3" runat="server" Text="Save" OnClick="Button3_Click" /></td>
                        </tr>

                    </table>
                </div>
            </div>

        
            <div class="info_executive">
                <h3>External Corrosion Risk Assessment</h3>
                <asp:HiddenField ID="ecra_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                <asp:HiddenField ID="sumecraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="sumecra1" GroupName="sumecra" runat="server" OnCheckedChanged="sumecra1_CheckedChanged" />
                            </td>
                            <td>
                                Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="sumecra2" GroupName="sumecra" runat="server" OnCheckedChanged="sumecra2_CheckedChanged" />
                            </td>
                            <td>
                                High Risk
                            </td>
                        </tr>
                         <tr>
                            <td>
                                CP level:
                                <asp:HiddenField ID="cpecraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cpecra1" GroupName="cpecra" runat="server" OnCheckedChanged="cpecra1_CheckedChanged" />
                            </td>
                            <td>
                                Within criteria
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cpecra2" GroupName="cpecra" runat="server" OnCheckedChanged="cpecra2_CheckedChanged" />
                            </td>
                            <td>
                                Under criteria
                            </td>
                        </tr>
                        <tr>
                            <td>
                                External corrosion defect by MFL PIG:
                                <asp:HiddenField ID="ecdmpecraValue" runat="server" />
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ecdmpecra1" GroupName="ecdmpecra" runat="server" OnCheckedChanged="ecdmpecra1_CheckedChanged" />
                            </td>
                            <td>
                                depth > 60% w.t.
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ecdmpecra2" GroupName="ecdmpecra" runat="server" OnCheckedChanged="ecdmpecra2_CheckedChanged" />
                            </td>
                            <td>
                                40 % w.t. < depth < 60 %w.t.
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="ecdmpecra3" GroupName="ecdmpecra" runat="server" OnCheckedChanged="ecdmpecra3_CheckedChanged" />
                            </td>
                            <td>
                                20 % w.t. < depth < 40 %w.t.
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ecdmpecra4" GroupName="ecdmpecra" runat="server" OnCheckedChanged="ecdmpecra4_CheckedChanged" />
                            </td>
                            <td>
                                depth < 20 % w.t. 
                            </td>
                        </tr>


                        <tr>
                            <td>
                                External corrosion rate by PIG:
                                <asp:HiddenField ID="ecraecrpValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ecrpecra1" GroupName="ecrpecra" runat="server" OnCheckedChanged="ecrpecra1_CheckedChanged" />
                            </td>
                            <td>
                                < 0.13 mm / yr
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ecrpecra2" GroupName="ecrpecra" runat="server" OnCheckedChanged="ecrpecra2_CheckedChanged" />
                            </td>
                            <td>
                                0.13 – 0.2 mm / yr
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3"> 
                                <asp:RadioButton ID="ecrpecra3" GroupName="ecrpecra" runat="server" OnCheckedChanged="ecrpecra3_CheckedChanged" />
                            </td>
                            <td class="auto-style3">
                                0.21 – 0.38 mm / yr
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ecrpecra4" GroupName="ecrpecra" runat="server" OnCheckedChanged="ecrpecra4_CheckedChanged" />
                            </td>
                            <td>
                                > 0.38 mm/yr
                            </td>
                        </tr>


                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailecra"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>MFL PIG result :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="mflresultecra"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionecra"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button4" runat="server" Text="Save" OnClick="Button4_Click" CssClass="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>Internal Corrosion Risk Assessment</h3>
                <asp:HiddenField ID="icra_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                <asp:HiddenField ID="sumicraValue" runat="server" />
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="sumicra1" GroupName="sumicra" runat="server" OnCheckedChanged="sumicra1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="sumicra2" GroupName="sumicra" runat="server" OnCheckedChanged="sumicra2_CheckedChanged" />
                            </td>
                            <td>
                                High Risk
                            </td>
                        </tr>
                         <tr>
                            <td>
                                Water content monitor:
                                <asp:HiddenField ID="wcmicraVale" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="wcmicra1" GroupName="wcmicra" runat="server" OnCheckedChanged="wcmicra1_CheckedChanged" />
                            </td>
                            <td>
                                &lt;7 lb/MMscfd</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="wcmicra2" GroupName="wcmicra" runat="server" OnCheckedChanged="wcmicra2_CheckedChanged" />
                            </td>
                            <td>
                                &gt; 7 lb/MMscfd</td>
                        </tr>
                        
                        
                        <tr>
                            <td>
                                Internal corrosion defect by MFL PIG:
                                <asp:HiddenField ID="icdmpicraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icdmpicra1" GroupName="icdmpicra" runat="server" OnCheckedChanged="icdmpicra1_CheckedChanged" />
                            </td>
                            <td>
                                depth > 60% w.t.
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icdmpicra2" GroupName="icdmpicra" runat="server" OnCheckedChanged="icdmpicra2_CheckedChanged" />
                            </td>
                            <td>
                                40 % w.t. < depth < 60 %w.t.
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="icdmpicra3" GroupName="icdmpicra" runat="server" OnCheckedChanged="icdmpicra3_CheckedChanged" />
                            </td>
                            <td>
                                20 % w.t. < depth < 40 %w.t.
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icdmpicra4" GroupName="icdmpicra" runat="server" OnCheckedChanged="icdmpicra4_CheckedChanged" />
                            </td>
                            <td>
                                depth < 20 % w.t. 
                            </td>
                        </tr>


                        <tr>
                            <td>
                                Internal corrosion rate by PIG:
                                <asp:HiddenField ID="icrpicraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icrpicra1" GroupName="icrpicra" runat="server" OnCheckedChanged="icrpicra1_CheckedChanged" />
                            </td>
                            <td>
                                < 0.13 mm / yr
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icrpicra2" GroupName="icrpicra" runat="server" OnCheckedChanged="icrpicra2_CheckedChanged" />
                            </td>
                            <td>
                                0.13 – 0.2 mm / yr
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="icrpicra3" GroupName="icrpicra" runat="server" OnCheckedChanged="icrpicra3_CheckedChanged" />
                            </td>
                            <td>
                                0.21 – 0.38 mm / yr
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icrpicra4" GroupName="icrpicra" runat="server" OnCheckedChanged="icrpicra4_CheckedChanged" />
                            </td>
                            <td>
                                > 0.38 mm/yr
                            </td>
                        </tr>


                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailicra"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionicra"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button5" runat="server" Text="Save" OnClick="Button5_Click" class="btn btn-gray"  /></td>
                        </tr>

                    </table>
                </div>
            </div>



            <div class="info_executive">
                <h3>Mechanical damage</h3>
                <asp:HiddenField ID="md_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                 <asp:HiddenField ID="summdValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="summd1" GroupName="summd" runat="server" OnCheckedChanged="summd1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="summd2" GroupName="summd" runat="server" OnCheckedChanged="summd2_CheckedChanged" />
                            </td>
                            <td>
                                High Risk
                            </td>
                        </tr>
                         <tr>
                            <td>
                                Concrete coating damage:
                                <asp:HiddenField ID="ccdmdValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ccdmd1" GroupName="ccdmd" runat="server" OnCheckedChanged="ccdmd1_CheckedChanged" />
                            </td>
                            <td>
                                yes</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ccdmd2" GroupName="ccdmd" runat="server" OnCheckedChanged="ccdmd2_CheckedChanged" />
                            </td>
                            <td>
                                No    
                            </td>
                        </tr>

                        <tr>
                            <td>
                                Dent (Detected by GEO PIG):
                                <asp:HiddenField ID="dentmdValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="dentmd1" GroupName="dentmd" runat="server" OnCheckedChanged="dentmd1_CheckedChanged" />
                            </td>
                            <td>
                                yes</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="dentmd2" GroupName="dentmd" runat="server" OnCheckedChanged="dentmd2_CheckedChanged" />
                            </td>
                            <td>
                                No    
                            </td>
                        </tr>

                       

                        <tr>
                            <td>Detail :</td>
                            <td>
                                 <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailmd"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>Manual Detail: </td>
                            <td>
                                 <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="manualdetailmd"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                 <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionmd"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button6" runat="server" Text="Save" OnClick="Button6_Click" class="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>



            <div class="info_executive">
                <h3>Free span Risk Assessment </h3>
                <asp:HiddenField ID="fsra_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                <asp:HiddenField ID="sumfsraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="sumfsra1" GroupName="sumfsra" runat="server" OnCheckedChanged="sumfsra1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="sumfsra2" GroupName="sumfsra" runat="server" OnCheckedChanged="sumfsra2_CheckedChanged" />
                            </td>
                            <td>
                                High Risk
                            </td>
                        </tr>
                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailfsra"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td><asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionfsra"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button7" runat="server" Text="Save" OnClick="Button7_Click" class="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>




            <div class="info_executive">
                <h3>Leakage </h3>
                <asp:HiddenField ID="leakage_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                <asp:HiddenField ID="sumleakageValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="sumleakage1" GroupName="sumleakage" runat="server" OnCheckedChanged="sumleakage1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Yes
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="sumleakage2" GroupName="sumleakage" runat="server" OnCheckedChanged="sumleakage2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                         <tr>
                            <td>
                               Leakage @ Subsea pipeline:
                                <asp:HiddenField ID="lspleakageValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="lspleakage1" GroupName="lspleakage" runat="server" OnCheckedChanged="lspleakage1_CheckedChanged" />
                            </td>
                            <td>
                                Yes
                                
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="lspleakage2" GroupName="lspleakage" runat="server" OnCheckedChanged="lspleakage2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="lspleakage3" GroupName="lspleakage" runat="server" OnCheckedChanged="lspleakage3_CheckedChanged" />
                            </td>
                            <td>
                                N/A
                            </td>
                        </tr>
                        <tr>
                            <td>
                               Leakage @ PLEM:
                                <asp:HiddenField ID="lplemleakageValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="lplemleakage1" GroupName="lplemleakage" runat="server" OnCheckedChanged="lplemleakage1_CheckedChanged" />
                            </td>
                            <td>
                                Yes
                                
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="lplemleakage2" GroupName="lplemleakage" runat="server" OnCheckedChanged="lplemleakage2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="lplemleakage3" GroupName="lplemleakage" runat="server" OnCheckedChanged="lplemleakage3_CheckedChanged" />
                            </td>
                            <td>
                                N/A
                            </td>
                        </tr>


                        <tr>
                            <td>
                               Leakage @Launcher or Receiver:
                                <asp:HiddenField ID="llrleakageValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="llrleakage1" GroupName="llrleakage" runat="server" OnCheckedChanged="llrleakage1_CheckedChanged" />
                            </td>
                            <td>
                                Yes
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1"> 
                                <asp:RadioButton ID="llrleakage2" GroupName="llrleakage" runat="server" OnCheckedChanged="llrleakage2_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                No
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="llrleakage3" GroupName="llrleakage" runat="server" OnCheckedChanged="llrleakage3_CheckedChanged" />
                            </td>
                            <td>
                                N/A
                            </td>
                        </tr>


                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailleakage"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionleakage"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button8" runat="server" Text="Save" OnClick="Button8_Click" class="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>Pipeline Repair History</h3>
                <asp:HiddenField ID="prh_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                <asp:HiddenField ID="sumprhValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="sumprh1" GroupName="sumprh" runat="server" OnCheckedChanged="sumprh1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Yes, see more in detail
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="sumprh2" GroupName="sumprh" runat="server" OnCheckedChanged="sumprh2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailprh"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionprh"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button9" runat="server" Text="Save" OnClick="Button9_Click" class="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>Recommendation</h3>
                <asp:HiddenField ID="comment_id" runat="server" />

                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailcomment"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinioncomment"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button10" runat="server" Text="Save" OnClick="Button10_Click" class="btn btn-gray"/></td>
                        </tr>

                    </table>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
