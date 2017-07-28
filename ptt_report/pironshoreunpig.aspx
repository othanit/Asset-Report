<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPagePIR.Master" AutoEventWireup="true" CodeBehind="pironshoreunpig.aspx.cs" Inherits="ptt_report.pironshoreunpig" %>


<asp:Content ID="es_form" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
 
        .auto-style1 {
            height: 20px;
        }

        .auto-style2 {
            height: 8px;
        }

        .auto-style3 {
            width: 500px;
        }

        .auto-style4 {
            height: 20px;
            width: 500px;
        }

        #menuleft01 {
            background: #0c7fd2;
        }
    </style>
    <div class="bar_qr">
        Permit :
                   
       

        <asp:Label ID="lbCustype" runat="server" Text="-"></asp:Label>
        <asp:Button ID="btnSaveVer" runat="server" Text="Save Version" CssClass="btn" OnClick="btnSaveVer_Click" />
        <asp:Button ID="btnExport" runat="server" Text="Export Report" CssClass="btn" OnClick="btnExport_Click" />
        <asp:Button ID="btnHistory" runat="server" Text="History" CssClass="btn" OnClick="btnHistory_Click" />

                <asp:Button ID="btnImport" runat="server" Text="Import Data" OnClick="btnImport_Click" CssClass="btn btn-info" />

        <asp:HiddenField ID="hddpironsu_id" runat="server" />
        <asp:HiddenField ID="hddfile_path" runat="server" />
        <asp:HiddenField ID="hddmas_rep_id" runat="server" />

    </div>

    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">
            <h3 class="barBlue">
                &nbsp;<asp:Label ID="lbTypeShore" runat="server" Text="-"></asp:Label>
            </h3>
            <div class="info_executive">
                <h3>PIPELINE</h3>
                <div class="info_executive_in">
                    <table class="col4">
                        <asp:HiddenField ID="pipeline_id" runat="server" />
                        <tr>
                            <td>Startup year: </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
                            </td>
                            <td>Design Presure: 
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Station : </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox>
                            </td>
                            <td>MAOP (PSI): </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox4"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Length (KM):
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox14"></asp:TextBox>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Wall Thickness (inches):
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox5"></asp:TextBox>
                            </td>
                            <td></td>
                            <td></td>
                        </tr>

                        <tr>
                            <td>Material Spec. : </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox6"></asp:TextBox>
                            </td>
                            <td>Design Life : </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox7"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>External Coathing : </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox8"></asp:TextBox>
                            </td>
                            <td>Cathodic Protection :</td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox9"></asp:TextBox>
                            </td>
                        </tr>
                    </table>


                    <table class="col4">
                        <tr>
                            <th colspan="2">PIPELINE OPERATING DATA
                            </th>
                        </tr>

                        <tr>
                            <td>Operating presure (psig): </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox10"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>Operating Temperature (oC): </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox11"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>Gas Flow rate (MMSCFD): </td>
                            <td>
                                <asp:TextBox runat="server" ID="TextBox12"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>ความเห็น</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="TextBox13"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>

                                <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" CssClass="btn btn-gray" />

                            </td>
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
                            <td>Summary result
                               
                                <asp:HiddenField ID="ecrasumValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="summaryLow" GroupName="sumecra" runat="server" OnCheckedChanged="summaryLow_CheckedChanged" />

                            </td>
                            <td>Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="summaryHigh" GroupName="sumecra" runat="server" OnCheckedChanged="summaryHigh_CheckedChanged" />
                            </td>
                            <td class="auto-style1">High Risk
                            </td>
                        </tr>
                        <tr>
                            <td>CP level:
                               
                                <asp:HiddenField ID="cplevelValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style2">
                                <asp:RadioButton ID="cp1" GroupName="cp" runat="server" OnCheckedChanged="cp1_CheckedChanged" />
                            </td>
                            <td class="auto-style2">Within criteria
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cp2" GroupName="cp" runat="server" OnCheckedChanged="cp2_CheckedChanged" />
                            </td>
                            <td>Under criteria
                            </td>
                        </tr>
                        <tr>
                            <td>No. of Stray current point:
                               
                                <asp:HiddenField ID="nscpValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="nscp1" GroupName="nscp" runat="server" OnCheckedChanged="nscp1_CheckedChanged1" />
                            </td>
                            <td>0
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="nscp2" GroupName="nscp" runat="server" OnCheckedChanged="nscp2_CheckedChanged" />
                            </td>
                            <td>0-5
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="nscp3" GroupName="nscp" runat="server" OnCheckedChanged="nscp3_CheckedChanged" />
                            </td>
                            <td>>5
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="nscp4" GroupName="nscp" runat="server" OnCheckedChanged="nscp4_CheckedChanged" />
                            </td>
                            <td>Unknow
                            </td>
                        </tr>


                        <tr>
                            <td>Coating defect survey:
                               
                                <asp:HiddenField ID="cdsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cds1" GroupName="cds" runat="server" OnCheckedChanged="cds1_CheckedChanged" />
                            </td>
                            <td>No coating defect
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cds2" GroupName="cds" runat="server" OnCheckedChanged="cds2_CheckedChanged" />
                            </td>
                            <td>Minor (Category 1:1% < IR < 15%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cds3" GroupName="cds" runat="server" OnCheckedChanged="cds3_CheckedChanged" />
                            </td>
                            <td>Moderate (Category 2: 16% < IR < 35%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cds4" GroupName="cds" runat="server" OnCheckedChanged="cds4_CheckedChanged" />
                            </td>
                            <td>Major (Category 3: 36%< IR < 60%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cds5" GroupName="cds" runat="server" OnCheckedChanged="cds5_CheckedChanged" />
                            </td>
                            <td>Severe (Category 4: 61%< IR < 100%)
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="cds6" GroupName="cds" runat="server" OnCheckedChanged="cds6_CheckedChanged" />
                            </td>
                            <td>Unknown
                            </td>
                        </tr>



                        <tr>
                            <td>AC interference:
                               
                                <asp:HiddenField ID="acValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ac1" GroupName="ac" runat="server" OnCheckedChanged="ac1_CheckedChanged" />
                            </td>
                            <td>No AC power line is within 1,000 ft of the pipeline
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ac2" GroupName="ac" runat="server" OnCheckedChanged="ac2_CheckedChanged" />
                            </td>
                            <td>AC power line is nearby but preventive measures are taken
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ac3" GroupName="ac" runat="server" OnCheckedChanged="ac3_CheckedChanged" />
                            </td>
                            <td>AC power line is nearby, no preventive action
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ac4" GroupName="ac" runat="server" OnCheckedChanged="ac4_CheckedChanged" />
                            </td>
                            <td>Unknown
                            </td>
                        </tr>



                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="ecraDetail"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="ecraOpinion"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Text="Save" OnClick="Button2_Click"   CssClass="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>
            
            <div class="info_executive">
                <h3>Internal Corrosion Risk Assessment</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td class="auto-style3">Summary result
                               
                                <asp:HiddenField ID="icra_id" runat="server" />
                                <asp:HiddenField ID="sumicraValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:RadioButton ID="lowicra" GroupName="sumicra" runat="server" OnCheckedChanged="lowicra_CheckedChanged" />
                            </td>
                            <td class="auto-style1">Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="highicra" GroupName="sumicra" runat="server" OnCheckedChanged="highicra_CheckedChanged" />
                            </td>
                            <td>High Risk
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Water content monitor:
                               
                                <asp:HiddenField ID="wcmValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="wcm1" GroupName="wcmicra" runat="server" OnCheckedChanged="wcm1_CheckedChanged" />
                            </td>
                            <td>&lt;7 lb/MMscfd</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="wcm2" GroupName="wcmicra" runat="server" OnCheckedChanged="wcm2_CheckedChanged" />
                            </td>
                            <td>&gt; 7 lb/MMscfd</td>
                        </tr>
                        <tr>
                            <td class="auto-style3">Dew Point Upset:
                               
                                <asp:HiddenField ID="dpuValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="dewicra1" GroupName="dewicra" runat="server" OnCheckedChanged="dewicra1_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &gt; Dew Point</span></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="dewicra2" GroupName="dewicra" runat="server" OnCheckedChanged="dewicra2_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &lt; Dew Point (≤ 7 days per year)</span></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="dewicra3" GroupName="dewicra" runat="server" OnCheckedChanged="dewicra3_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &lt; Dew Point (≤ 30 days per year)</span></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="dewicra4" GroupName="dewicra" runat="server" OnCheckedChanged="dewicra4_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Min Operating Temperature &lt; Dew Point (&gt; 30 days per year)<br />
                                </span>
                            </td>
                        </tr>


                        <tr>
                            <td class="auto-style3">
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">CO2 content:</span>
                                <asp:HiddenField ID="coValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="co1" GroupName="coicra" runat="server" OnCheckedChanged="co1_CheckedChanged" />
                            </td>
                            <td>
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">CO2 %mol &lt;=2</span></td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:RadioButton ID="co2" GroupName="coicra" runat="server" OnCheckedChanged="co2_CheckedChanged" />
                            </td>
                            <td class="auto-style1">
                                <span style="color: rgb(0, 0, 0); font-family: arial, sans, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: pre-wrap; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">CO2 %mol &gt;2</span></td>
                        </tr>



                        <tr>
                            <td class="auto-style3">H2S content:
                               
                                <asp:HiddenField ID="h2sValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:RadioButton ID="h2s1" GroupName="h2sicra" runat="server" OnCheckedChanged="h2s1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">Partial pressure H2S <= 0.05
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:RadioButton ID="h2s2" GroupName="h2sicra" runat="server" OnCheckedChanged="h2s2_CheckedChanged" />
                            </td>
                            <td>Partial pressure H2S > 0.05
                            </td>
                        </tr>



                        <tr>
                            <td class="auto-style3">Detail :</td>
                            <td>

                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="icradetail" />

                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style3">ความเห็น :</td>
                            <td>

                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="icraopinion"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style3"></td>
                            <td>
                                <asp:Button ID="Button3" runat="server" Text="Save" OnClick="Button3_Click"  CssClass="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>



            <div class="info_executive">
                <h3>Mechanical damage / Third party interference</h3>

                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>Summary result
                               
                                <asp:HiddenField ID="md_id" runat="server" />
                                <asp:HiddenField ID="summdValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="md1" GroupName="summd" runat="server" OnCheckedChanged="md1_CheckedChanged" />
                            </td>
                            <td class="auto-style1">Low Risk
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="md2" GroupName="summd" runat="server" OnCheckedChanged="md2_CheckedChanged" />
                            </td>
                            <td>High Risk
                            </td>
                        </tr>
                        <tr>
                            <td>Concrete coating damage:
                               
                                <asp:HiddenField ID="ccdValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ccdyes" GroupName="ccdmd" runat="server" OnCheckedChanged="ccdyes_CheckedChanged" />
                            </td>
                            <td>yes</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="ccdno" GroupName="ccdmd" runat="server" OnCheckedChanged="ccdno_CheckedChanged" />
                            </td>
                            <td>No    
                            </td>
                        </tr>
                        <tr>
                            <td>Activity Level:
                               
                                <asp:HiddenField ID="alValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="al1" GroupName="almd" runat="server" OnCheckedChanged="al1_CheckedChanged" />
                            </td>
                            <td>High activity level
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="al2" GroupName="almd" runat="server" OnCheckedChanged="al2_CheckedChanged" />
                            </td>
                            <td>Medium activity level
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="al3" GroupName="almd" runat="server" OnCheckedChanged="al3_CheckedChanged" />
                            </td>
                            <td>Low activity level
                            </td>
                        </tr>
                        <tr>
                            <td>Detail :</td>
                            <td>

                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="detailmd"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>

                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="opinionmd"></asp:TextBox>

                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="Button4" runat="server" Text="Save" OnClick="Button4_Click"  CssClass="btn btn-gray"  /></td>
                        </tr>

                    </table>
                </div>

            </div>

            <div class="info_executive">
                <h3>Loss of ground support</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>Summary result
                               
                                <asp:HiddenField ID="lgs_id" runat="server" />
                                <asp:HiddenField ID="sumlgsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="lgsyes" GroupName="sumlgs" runat="server" OnCheckedChanged="lgsyes_CheckedChanged" />
                            </td>
                            <td class="auto-style1">Yes
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="lgsno" GroupName="sumlgs" runat="server" OnCheckedChanged="lgsno_CheckedChanged" />
                            </td>
                            <td>No
                            </td>
                        </tr>
                        <tr>
                            <td>Exposed pipeline section:
                               
                                <asp:HiddenField ID="epsValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="eps1" GroupName="epslgs" runat="server" OnCheckedChanged="eps1_CheckedChanged" />
                            </td>
                            <td>All buried
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="eps2" GroupName="epslgs" runat="server" OnCheckedChanged="eps2_CheckedChanged" />
                            </td>
                            <td>Some Areas Exposed
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="eps3" GroupName="epslgs" runat="server" OnCheckedChanged="eps3_CheckedChanged" />
                            </td>
                            <td>Many Areas Exposed
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="eps4" GroupName="epslgs" runat="server" OnCheckedChanged="eps4_CheckedChanged" />
                            </td>
                            <td>All Areas Exposed
                            </td>
                        </tr>
                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="detaillgs"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="opinionlgs"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="Button5" runat="server" Text="Save" OnClick="Button5_Click"   CssClass="btn btn-gray"  /></td>
                        </tr>

                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>Pipeline Repair History</h3>
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>Summary result
                               
                                <asp:HiddenField ID="prh_id" runat="server" />
                                <asp:HiddenField ID="prhsumValue" runat="server" />
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <asp:RadioButton ID="prhyes" GroupName="sumprh" runat="server" OnCheckedChanged="prhyes_CheckedChanged" />
                            </td>
                            <td class="auto-style1">Yes, see more in detail
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:RadioButton ID="prhno" GroupName="sumprh" runat="server" OnCheckedChanged="prhno_CheckedChanged" />
                            </td>
                            <td>No
                            </td>
                        </tr>
                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="detailprh"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="opinionprh"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="Button6" runat="server" Text="Save" OnClick="Button6_Click"   CssClass="btn btn-gray" /></td>
                        </tr>

                    </table>
                </div>
            </div>

            <div class="info_executive">
                <h3>Recommendation</h3>
                <asp:HiddenField ID="rc_id" runat="server" />
                <div class="info_executive_in">
                    <table>
                        <tr>
                            <td>Detail :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="detailrc"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:TextBox cols="20" Rows="2" TextMode="MultiLine" runat="server" ID="opinionrc"></asp:TextBox>
                            </td>
                        </tr>

                        <tr>
                            <td></td>
                            <td>
                                <asp:Button ID="Button7" runat="server" Text="Save" OnClick="Button7_Click"  CssClass="btn btn-gray"  /></td>
                        </tr>

                    </table>
                    <br />
                                <asp:Button ID="btnApprove" runat="server" Text="Approve" OnClick="btnApprove_Click"  CssClass="btn btn-gray"  />
                                <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click"  CssClass="btn btn-gray"  />
                </div>
            </div>

        </div>
    </div>

</asp:Content>
