<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPagePIR.Master" AutoEventWireup="true" CodeBehind="pironshorepig.aspx.cs" Inherits="ptt_report.pironshorepig" %>


<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft02 {
            background: #0c7fd2;
        }
        .auto-style1 {
            height: 20px;
        }
        .auto-style2 {
            height: 24px;
        }
    </style>
    <div class="bar_qr">
        Customer Type :
                   
        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" OnClick="btnSaveVer_Click"  />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn"  OnClick="btnHistory_Click"/>

        <asp:HiddenField ID="hddpironsp_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />

    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">
                On Shore Pig
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
                            <td class="auto-style1" colspan="3">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save"  class="btn btn-gray"/>
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
                                <asp:HiddenField ID="ciiccsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="ciiccs1" GroupName="ciiccs" runat="server" OnCheckedChanged="ciiccs1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Yes
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="ciiccs2" GroupName="ciiccs" runat="server" OnCheckedChanged="ciiccs2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                         <tr>
                            <td>
                               Corrosion Coupon:
                                <asp:HiddenField ID="ccciccValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cciccs1" GroupName="cciccs" runat="server" OnCheckedChanged="cciccs1_CheckedChanged" />
                            </td>
                            <td>
                                Yes
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cciccs2" GroupName="cciccs" runat="server" OnCheckedChanged="cciccs2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>

                        <tr>
                            <td>
                               Corrosion Probe:
                                <asp:HiddenField ID="cpiccs" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cpiccs1" GroupName="cpiccs" runat="server" OnCheckedChanged="cpiccs1_CheckedChanged" />
                            </td>
                            <td>
                                Yes
                                
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="cpiccs2" GroupName="cpiccs" runat="server" OnCheckedChanged="cpiccs2_CheckedChanged" />
                            </td>
                            <td>
                                No
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
                            <td><asp:Button ID="Button3" runat="server" Text="Save" OnClick="Button3_Click" class="btn btn-gray"/></td>
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
                            <td><asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="lmacips"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Year of MFL PIG:</td>
                            <td><asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="lmamfl"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Year of GEO PIG:</td>
                            <td><asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="lmageo"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>ความเห็น :</td>
                            <td><asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="lmaopinion"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click"  class="btn btn-gray"  /></td>
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
                                No. of Stray current point:
                                <asp:HiddenField ID="nscpecraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="nscpecra1" GroupName="nscpecra" runat="server" OnCheckedChanged="nscpecra1_CheckedChanged" />
                            </td>
                            <td>
                                0
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="nscpecra2" GroupName="nscpecra" runat="server" OnCheckedChanged="nscpecra2_CheckedChanged" />
                            </td>
                            <td>
                                0-5
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="nscpecra3" GroupName="nscpecra" runat="server" OnCheckedChanged="nscpecra3_CheckedChanged" />
                            </td>
                            <td>
                                >5
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="nscpecra4" GroupName="nscpecra" runat="server" OnCheckedChanged="nscpecra4_CheckedChanged" />
                            </td>
                            <td>
                                Unknow
                            </td>
                        </tr>


                        <tr>
                            <td>
                                Coating defect survey:
                                <asp:HiddenField ID="cdsecraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cdsecra1" GroupName="cdsecra" runat="server" OnCheckedChanged="cdsecra1_CheckedChanged" />
                            </td>
                            <td>
                                No coating defect
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cdsecra2" GroupName="cdsecra" runat="server" OnCheckedChanged="cdsecra2_CheckedChanged" />
                            </td>
                            <td>
                                Minor (Category 1:1% < IR < 15%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cdsecra3" GroupName="cdsecra" runat="server" OnCheckedChanged="cdsecra3_CheckedChanged" />
                            </td>
                            <td>
                                Moderate (Category 2: 16% < IR < 35%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cdsecra4" GroupName="cdsecra" runat="server" OnCheckedChanged="cdsecra4_CheckedChanged" />
                            </td>
                            <td>
                                Major (Category 3: 36%< IR < 60%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cdsecra5" GroupName="cdsecra" runat="server" OnCheckedChanged="cdsecra5_CheckedChanged" />
                            </td>
                            <td>
                                Severe (Category 4: 61%< IR < 100%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cdsecra6" GroupName="cdsecra" runat="server" OnCheckedChanged="cdsecra6_CheckedChanged" />
                            </td>
                            <td>
                                Unknown
                            </td>
                        </tr>



                        <tr>
                            <td>
                                AC interference:
                                <asp:HiddenField ID="acecraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ac1" GroupName="ac" runat="server" OnCheckedChanged="ac1_CheckedChanged" />
                            </td>
                            <td>
                                No AC power line is within 1,000 ft of the pipeline
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ac2" GroupName="ac" runat="server" OnCheckedChanged="ac2_CheckedChanged" />
                            </td>
                            <td>
                                AC power line is nearby but preventive measures are taken
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="ac3" GroupName="ac" runat="server" OnCheckedChanged="ac3_CheckedChanged" />
                            </td>
                            <td>
                                AC power line is nearby, no preventive action
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ac4" GroupName="ac" runat="server" OnCheckedChanged="ac4_CheckedChanged" />
                            </td>
                            <td>
                                Unknown
                            </td>
                        </tr>
                        

                        <tr>
                            <td>
                                External corrosion defect by MFL PIG:
                                <asp:HiddenField ID="ecdmpecraValue" runat="server" />
                            </td>
                            <td></td>
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
                            <td> 
                                <asp:RadioButton ID="ecrpecra3" GroupName="ecrpecra" runat="server" OnCheckedChanged="ecrpecra3_CheckedChanged" />
                            </td>
                            <td>
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
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionecra"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button4" runat="server" Text="Save" OnClick="Button4_Click"  class="btn btn-gray" /></td>
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
                            <td></td>
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
                                <asp:HiddenField ID="wcmicraValue" runat="server" />
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
                                Dew Point Upset:
                                
                                 <asp:HiddenField ID="dewecraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="dewecra1" GroupName="dewecra" runat="server" OnCheckedChanged="dewecra1_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &gt; Dew Point</span></td>
                        </tr>
                        <tr>
                            <td>
                                 <asp:RadioButton ID="dewecra2" GroupName="dewecra" runat="server" OnCheckedChanged="dewecra2_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &lt; Dew Point (≤ 7 days per year)</span></td>
                        </tr>
                        <tr>
                            <td>
                                 <asp:RadioButton ID="dewecra3" GroupName="dewecra" runat="server" OnCheckedChanged="dewecra3_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &lt; Dew Point (≤ 30 days per year)</span></td>
                        </tr>
                        <tr>
                            <td>
                                 <asp:RadioButton ID="dewecra4" GroupName="dewecra" runat="server" OnCheckedChanged="dewecra4_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &lt; Dew Point (&gt; 30 days per year)<br />
                                </span>
                            </td>
                        </tr>


                        <tr>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">CO2 content:</span>
                                <asp:HiddenField ID="co2icraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                 <asp:RadioButton ID="co2icra1" GroupName="co2icra" runat="server" OnCheckedChanged="co2icra1_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">CO2 %mol &lt;=2</span></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="co2icra2" GroupName="co2icra" runat="server" OnCheckedChanged="co2icra2_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">CO2 %mol &gt;2</span></td>
                        </tr>








                        <tr>
                            <td>
                                H2S content:
                                <asp:HiddenField ID="h2sicraValue" runat="server" />
                            </td>
                            <td>


                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="h2sicra1" GroupName="h2sicra" runat="server" OnCheckedChanged="h2sicra1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                               Partial pressure H2S <= 0.05
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="h2sicra2" GroupName="h2sicra" runat="server" OnCheckedChanged="h2sicra2_CheckedChanged" />
                            </td>
                            <td>
                                Partial pressure H2S > 0.05
                            </td>
                        </tr>
                        


                        <tr>
                            <td>
                                Internal corrosion defect by MFL PIG:
                                <asp:HiddenField ID="icdmpValue" runat="server" />
                            </td>
                            <td>


                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="icdmp1" GroupName="icdmp" runat="server" OnCheckedChanged="icdmp1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                               depth > 60% w.t.
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icdmp2" GroupName="icdmp" runat="server" OnCheckedChanged="icdmp2_CheckedChanged" />
                            </td>
                            <td>
                                40 % w.t. < depth < 60 %w.t.
                            </td>
                        </tr>
                                                <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="icdmp3" GroupName="icdmp" runat="server" OnCheckedChanged="icdmp3_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                               20 % w.t. < depth < 40 %w.t. 
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="icdmp4" GroupName="icdmp" runat="server" OnCheckedChanged="icdmp4_CheckedChanged" />
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
                            <td>


                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="icrpicra1" GroupName="icrpicra" runat="server" OnCheckedChanged="icrpicra1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
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
                            <td class="auto-style1">
                                <asp:RadioButton ID="icrpicra3" GroupName="icrpicra" runat="server" OnCheckedChanged="icrpicra3_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
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
                            <td><asp:Button ID="Button5" runat="server" Text="Save" OnClick="Button5_Click"  class="btn btn-gray"/></td>
                        </tr>

                    </table>
                </div>
            </div>



            <div class="info_executive">
                <h3>Mechanical damage / Third party interference</h3>
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
                            <td class="auto-style1">
                                Concrete coating damage:
                                <asp:HiddenField ID="ccdmdValue" runat="server" />
                            </td>
                            <td class="auto-style1"></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ccdmd1" GroupName="ccdmd" runat="server" OnCheckedChanged="ccdmd1_CheckedChanged" />
                            </td>
                            <td>
                                yes</td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:RadioButton ID="ccdmd2" GroupName="ccdmd" runat="server" OnCheckedChanged="ccdmd2_CheckedChanged" />
                            </td>
                            <td class="auto-style2">
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
                            <td>
                                Activity Level:
                                <asp:HiddenField ID="almdValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="al1" GroupName="al" runat="server" OnCheckedChanged="al1_CheckedChanged" />
                            </td>
                            <td>
                                High activity level
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="al2" GroupName="al" runat="server" OnCheckedChanged="al2_CheckedChanged" />
                            </td>
                            <td>
                                Medium activity level
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="al3" GroupName="al" runat="server" OnCheckedChanged="al3_CheckedChanged" />
                            </td>
                            <td>
                                Low activity level
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="al4" GroupName="al" runat="server" OnCheckedChanged="al4_CheckedChanged" />
                            </td>
                            <td>
                                Non
                            </td>
                        </tr>

                        <tr>
                            <td>
                                ROW condition:
                                <asp:HiddenField ID="rowmdValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="rowmd1" GroupName="rowmd" runat="server" OnCheckedChanged="rowmd1_CheckedChanged" />
                            </td>
                            <td>
                                poor
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="rowmd2" GroupName="rowmd" runat="server" OnCheckedChanged="rowmd2_CheckedChanged" />
                            </td>
                            <td>
                                average
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="rowmd3" GroupName="rowmd" runat="server" OnCheckedChanged="rowmd3_CheckedChanged" />
                            </td>
                            <td>
                                good
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="rowmd4" GroupName="rowmd" runat="server" OnCheckedChanged="rowmd4_CheckedChanged" />
                            </td>
                            <td>
                                excellent
                            </td>
                        </tr>

                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailmd"></asp:TextBox>
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
                            <td><asp:Button ID="Button6" runat="server" Text="Save" OnClick="Button6_Click"  class="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>



            <div class="info_executive">
                <h3>Third party interference </h3>
                <asp:HiddenField ID="tpi_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                <asp:HiddenField ID="sumtpiValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="sumtpi1" GroupName="sumtpi" runat="server" OnCheckedChanged="sumtpi1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="sumtpi2" GroupName="sumtpi" runat="server" OnCheckedChanged="sumtpi2_CheckedChanged" />
                            </td>
                            <td>
                                High Risk
                            </td>
                        </tr>
                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detailtpi"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opiniontpi" ></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td> <asp:Button ID="Button7" runat="server" Text="Save" OnClick="Button7_Click"  class="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>




            <div class="info_executive">
                <h3>Loss of ground support</h3>
                <asp:HiddenField ID="lgs_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>
                                Summary result
                                <asp:HiddenField ID="sumlgsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="lgssum1" GroupName="lgssum" runat="server" OnCheckedChanged="lgssum1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                Yes
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="lgssum2" GroupName="lgssum" runat="server" OnCheckedChanged="lgssum2_CheckedChanged" />
                            </td>
                            <td>
                                No
                            </td>
                        </tr>
                         <tr>
                            <td>
                               Exposed pipeline section:

                                <asp:HiddenField ID="epslgsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="eps1" GroupName="eps" runat="server" OnCheckedChanged="eps1_CheckedChanged" />
                            </td>
                            <td>
                                All buried
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="eps2" GroupName="eps" runat="server" OnCheckedChanged="eps2_CheckedChanged" />
                            </td>
                            <td>
                                Some Areas Exposed
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="eps3" GroupName="eps" runat="server" OnCheckedChanged="eps3_CheckedChanged" />
                            </td>
                            <td>
                                Many Areas Exposed
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="eps4" GroupName="eps" runat="server" OnCheckedChanged="eps4_CheckedChanged" />
                            </td>
                            <td>
                                All Areas Exposed
                            </td>
                        </tr>


                        <tr>
                            <td>
                               Flooding susceptibility:
                                <asp:HiddenField ID="fslgsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="fs1" GroupName="fs" runat="server" OnCheckedChanged="fs1_CheckedChanged" />
                            </td>
                            <td>
                                Never
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="fs2" GroupName="fs" runat="server" OnCheckedChanged="fs2_CheckedChanged" />
                            </td>
                            <td>
                                possible
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="fs3" GroupName="fs" runat="server" OnCheckedChanged="fs3_CheckedChanged" />
                            </td>
                            <td>
                                yes
                            </td>
                        </tr>


                        <tr>
                            <td>
                               Soil stability:
                                <asp:HiddenField ID="sslgsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ss1" GroupName="ss" runat="server" OnCheckedChanged="ss1_CheckedChanged" />
                            </td>
                            <td>
                                Stable
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ss2" GroupName="ss" runat="server" OnCheckedChanged="ss2_CheckedChanged" />
                            </td>
                            <td>
                                Land movement possible
                            </td>
                        </tr>
                        <tr>
                            <td> 
                                <asp:RadioButton ID="ss3" GroupName="ss" runat="server" OnCheckedChanged="ss3_CheckedChanged" />
                            </td>
                            <td>
                                Measure strain increase
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ss4" GroupName="ss" runat="server" OnCheckedChanged="ss4_CheckedChanged" />
                            </td>
                            <td>
                                Land movement record
                            </td>
                        </tr>


                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="detaillgs"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" rows="2" TextMode="MultiLine" runat="server" id="opinionlgs"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td><asp:Button ID="Button8" runat="server" Text="Save" OnClick="Button8_Click"   class="btn btn-gray"/></td>
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
                            <td><asp:Button ID="Button10" runat="server" Text="Save" OnClick="Button10_Click"  class="btn btn-gray" /></td>
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
                            <td><asp:Button ID="Button9" runat="server" Text="Save" OnClick="Button9_Click"  class="btn btn-gray"  /></td>
                        </tr>

                    </table>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
