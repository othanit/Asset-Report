<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterPage1.master" AutoEventWireup="true" CodeBehind="piping.aspx.cs" Inherits="ptt_report.piping" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ChildContent2" runat="server">
    <style>
        #menuleft11 {
            background: #0c7fd2;
        }

        table {
            border-collapse: collapse;
        }
        .auto-style4 {
            font-size: medium;
            color: #FF0000;
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>

    <asp:hiddenfield id="hddmas_rep_id" runat="server" />
    <asp:hiddenfield id="hddpiping_id" runat="server" />
    <asp:hiddenfield id="hddfile_path" runat="server" />



    <div id="thirdPartyInterfaceForm" style="background-color: #FFFFFF">
        <div id="patrolFormTable">



    <div class="bar_qr">
        Customer Type :
        <asp:label id="lbCustype" runat="server" text="-"></asp:label>
        <asp:button id="btnSaveVer" runat="server" text="Save Version" onclick="btnSaveVer_Click" class="btn" />
        <asp:button id="btnExport" runat="server" text="Export Report" onclick="btnExport_Click" class="btn" />
        <asp:button id="btnHistory" runat="server" text="History" onclick="btnHistory_Click" class="btn" />

                <asp:button id="btnImport" runat="server" text="Import Data" onclick="btnImport_Click" class="btn btn-info" />

    </div>
            <h3 class="barBlue">Piping
               
                </h3>
            <div class="info_executive">
                <h3>Quarterly Plan</h3>
                <div class="info_executive_in">


                    <table>
                        <tr>
                        
                            <td>
                                <table border="1">
                                    <tr>
                                        <td rowspan="5">
                                            <asp:label id="lbQuarter" runat="server" text="-"></asp:label>
                                        </td>
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
                                            <asp:label id="lbM1" runat="server" text="-"></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm111" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm112" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm121" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm122" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm131" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm132" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm141" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm142" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm151" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm152" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm161" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm162" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm171" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm172" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm181" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm182" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm191" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm192" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm101" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm102" runat="server" text=""></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:label id="lbM2" runat="server" text="-"></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm211" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm212" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm221" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm222" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm231" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm232" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm241" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm242" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm251" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm252" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm261" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm262" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm271" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm272" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm281" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm282" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm291" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm292" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm201" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm202" runat="server" text=""></asp:label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:label id="lbM3" runat="server" text="-"></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm311" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm312" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm321" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm322" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm331" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm332" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm341" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm342" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm351" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm352" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm361" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm362" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm371" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm372" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm381" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm382" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm391" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm392" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm301" runat="server" text=""></asp:label>
                                        </td>
                                        <td>
                                            <asp:label id="lbm302" runat="server" text=""></asp:label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            
                            <td>
                                <div>Wall Thickness Inspection</div>

                            </td>
                        </tr>



                    </table>


                </div>
            </div>


            <div class="info_executive">
                <h3>Preventive maintenance PM
                    <asp:button id="btnCreate1" runat="server" text="Create" class="btn btn btn-gray btn-right" OnClick="btnCreate1_Click" />
                </h3>
                <div class="info_executive_in">

                    <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="pipingPM" ShowFooter="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Region">
                                <ItemTemplate>
                                    <asp:HiddenField ID="pipingPMId" runat="server" Value='<%# Eval("id") %>' />
                                    <asp:TextBox ID="pmRegion" runat="server" Text='<%# Eval("l5") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Criteria">
                                <ItemTemplate>
                                    <label>Avg</label>
                                    <br />
                                    <asp:TextBox ID="pmCAvg" runat="server" Text='<%# Eval("l6") %>'></asp:TextBox>
                                    <br />
                                    <label>Min</label>
                                    <br />
                                    <asp:TextBox ID="pmCMin" runat="server" Text='<%# Eval("l7") %>'></asp:TextBox>
                                    <br />
                                    <label>CorrRate(mm/yr)</label>
                                    <br />
                                    <asp:TextBox ID="pmCorrRate" runat="server" Text='<%# Eval("l8") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status">
                                <ItemTemplate>
                                    <asp:TextBox ID="pmStatus" runat="server" Text='<%# Eval("l9") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Manage">
                                <ItemTemplate>
                                    <asp:Button ID="btndal1" runat="server" Text="Delete" OnClick="btndel1_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>



                </div>
            </div>


            <div class="info_executive">
                <h3>Coating Inspection
                    <asp:button id="btnCreate2" runat="server" text="Create" class="btn btn btn-gray btn-right" OnClick="btnCreate2_Click" />
                </h3>
                <div class="info_executive_in">
                    
                    <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="pipingCI" ShowFooter="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Region">
                                <ItemTemplate>
                                    <asp:HiddenField ID="pipingCIId" runat="server" Value='<%# Eval("id") %>' />
                                    <asp:TextBox ID="ciRegion" runat="server" Text='<%# Eval("l10") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Criteria">
                                <ItemTemplate>
                                    <label>Pipe support condition / สภาพท่อใต้ Support </label>
                                    <br />
                                    <asp:TextBox ID="ciCoat" runat="server" Text='<%# Eval("l11") %>'></asp:TextBox>
                                    <br />
                                    <label>Corrosion condition / สภาพการเกิด Corrosion </label>
                                    <br />
                                    <asp:TextBox ID="ciCorr" runat="server" Text='<%# Eval("l12") %>'></asp:TextBox>
                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Station">
                                <ItemTemplate>
                                    <asp:TextBox ID="ciStation" runat="server" Text='<%# Eval("l13") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Manage">
                                <ItemTemplate>
                                    <asp:Button ID="btndal1" runat="server" Text="Delete" OnClick="btndel2_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>



                </div>

            </div>

            <div class="info_executive">
                <h3>Corrosion Under Pipe Support
                   
                    <asp:button id="btnCreate3" runat="server" text="Create" class="btn btn btn-gray btn-right" OnClick="btnCreate3_Click" />
                </h3>
                <div class="info_executive_in">
                    
                    <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="pipingCUPS" ShowFooter="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Region">
                                <ItemTemplate>
                                    <asp:HiddenField ID="pipingCUPSId" runat="server" Value='<%# Eval("id") %>' />
                                    <asp:TextBox ID="cupsRegion" runat="server" Text='<%# Eval("l14") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Criteria">
                                <ItemTemplate>
                                    <label>Pipe support condition / สภาพท่อใต้ Support </label>
                                    <br />
                                    <asp:TextBox ID="cupsCoat" runat="server" Text='<%# Eval("l15") %>'></asp:TextBox>
                                    <br />
                                    <label>Corrosion condition / สภาพการเกิด Corrosion </label>
                                    <br />
                                    <asp:TextBox ID="cupsCorr" runat="server" Text='<%# Eval("l16") %>'></asp:TextBox>
                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Station">
                                <ItemTemplate>
                                    <asp:TextBox ID="cupsStation" runat="server" Text='<%# Eval("l17") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Manage">
                                <ItemTemplate>
                                    <asp:Button ID="btndal1" runat="server" Text="Delete" OnClick="btndel3_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>



                </div>
            </div>

            <div class="info_executive">
                <h3>Soil to Air Inspection
                   <asp:button id="btnCreate4" runat="server" text="Create" class="btn btn btn-gray btn-right" OnClick="btnCreate4_Click" />

                </h3>
                <div class="info_executive_in">

                    <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="pipingSAI" ShowFooter="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Region">
                                <ItemTemplate>
                                    <asp:HiddenField ID="pipingSAIId" runat="server" Value='<%# Eval("id") %>' />
                                    <asp:TextBox ID="saiRegion" runat="server" Text='<%# Eval("l18") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Criteria">
                                <ItemTemplate>
                                    <label>Pipe support condition / สภาพท่อใต้ Support </label>
                                    <br />
                                    <asp:TextBox ID="saiCoat" runat="server" Text='<%# Eval("l19") %>'></asp:TextBox>
                                    <br />
                                    <label>Corrosion condition / สภาพการเกิด Corrosion </label>
                                    <br />
                                    <asp:TextBox ID="saiCorr" runat="server" Text='<%# Eval("l20") %>'></asp:TextBox>
                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Station">
                                <ItemTemplate>
                                    <asp:TextBox ID="saiStation" runat="server" Text='<%# Eval("l21") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Manage">
                                <ItemTemplate>
                                    <asp:Button ID="btndal1" runat="server" Text="Delete" OnClick="btndel4_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                </div>
            </div>

            <div class="info_executive">
                <h3>Corrosion Under Insulation
                   <asp:button id="btnCreate5" runat="server" text="Create" class="btn btn btn-gray btn-right" OnClick="btnCreate5_Click" />

                </h3>
                <div class="info_executive_in">
                    

                    <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="pipeCUI" ShowFooter="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Region">
                                <ItemTemplate>
                                    <asp:HiddenField ID="pipingCUIId" runat="server" Value='<%# Eval("id") %>' />
                                    <asp:TextBox ID="cuiRegion" runat="server" Text='<%# Eval("l22") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Criteria">
                                <ItemTemplate>
                                    <label>Pipe support condition / สภาพท่อใต้ Support </label>
                                    <br />
                                    <asp:TextBox ID="cuiCoat" runat="server" Text='<%# Eval("l23") %>'></asp:TextBox>
                                    <br />
                                    <label>Corrosion condition / สภาพการเกิด Corrosion </label>
                                    <br />
                                    <asp:TextBox ID="cuiCorr" runat="server" Text='<%# Eval("l24") %>'></asp:TextBox>
                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Station">
                                <ItemTemplate>
                                    <asp:TextBox ID="cuiStation" runat="server" Text='<%# Eval("l25") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Manage">
                                <ItemTemplate>
                                    <asp:Button ID="btndal1" runat="server" Text="Delete" OnClick="btndel5_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>


                </div>
            </div>

            <div class="info_executive">
                <h3>Corrective maintenance CM
          
                     <asp:button id="btnCreate6" runat="server" text="Create" class="btn btn btn-gray btn-right" OnClick="btnCreate6_Click" />

                </h3>
                <div class="info_executive_in">
                    
                    <asp:GridView Width="100%" DataKeyNames="id" AutoGenerateColumns="false" runat="server" ID="pipingCMCM" ShowFooter="false">
                        <Columns>
                            <asp:TemplateField HeaderText="Region">
                                <ItemTemplate>
                                    <asp:HiddenField ID="pipingCMCMd" runat="server" Value='<%# Eval("id") %>' />
                                    <asp:TextBox ID="cmcmRegion" runat="server" Text='<%# Eval("l26") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Inspection">
                                <ItemTemplate>
                                    <asp:TextBox ID="cmcmInspection" runat="server" Text='<%# Eval("l27") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="CM Station">
                                <ItemTemplate>
                                    <asp:TextBox ID="cmcmStation" runat="server" Text='<%# Eval("l28") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Date">
                                <ItemTemplate>
                                    <asp:TextBox ID="cmcmDate" runat="server" Text='<%# Eval("l29") %>'></asp:TextBox>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Manage">
                                <ItemTemplate>
                                    <asp:Button ID="btndal1" runat="server" Text="Delete" OnClick="btndel6_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                </div>
            </div>

            <div class="info_executive">
                <h3>แผนงานในอนาคต
                     

                </h3>
                <div class="info_executive_in">
                    <table class="table_da1">
                        <tr>
                            <td rowspan="5">
                                <asp:label id="lbQuarter2" runat="server" text="-"></asp:label>
                            </td>
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
                                <asp:label id="lbM1_" runat="server" text="-"></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm111_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm112_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm121_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm122_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm131_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm132_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm141_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm142_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm151_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm152_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm161_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm162_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm171_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm172_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm181_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm182_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm191_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm192_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm101_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm102_" runat="server" text=""></asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:label id="lbM2_" runat="server" text="-"></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm211_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm212_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm221_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm222_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm231_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm232_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm241_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm242_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm251_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm252_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm261_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm262_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm271_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm272_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm281_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm282_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm291_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm292_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm201_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm202_" runat="server" text=""></asp:label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:label id="lbM3_" runat="server" text="-"></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm311_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm312_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm321_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm322_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm331_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm332_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm341_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm342_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm351_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm352_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm361_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm362_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm371_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm372_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm381_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm382_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm391_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm392_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm301_" runat="server" text=""></asp:label>
                            </td>
                            <td>
                                <asp:label id="lbm302_" runat="server" text=""></asp:label>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table>

                        <tr>
                            <td>ความเห็น :</td>
                            <td>
                                <asp:textbox id="txtComment" runat="server" TextMode="MultiLine" BackColor="#CCCCFF"></asp:textbox>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td>
                                <asp:button id="btnSave" runat="server" text="Save" onclick="btnSave_Click" cssclass="btn .btn-info" />

                                <asp:button id="btnApprove" runat="server" text="Approve Report" onclick="btnApprove_Click" cssclass="btn" />
                                <span class="auto-style4" lang="TH" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH">
            <asp:Button ID="btnReject" runat="server" Text="Reject" OnClick="btnReject_Click" CssClass="btn" />
                                หมายเหตุ</span><span class="auto-style2" style="font-family: &quot;Cordia New&quot;,sans-serif; mso-fareast-font-family: &quot;Times New Roman&quot;; mso-ansi-language: EN-US; mso-fareast-language: EN-US; mso-bidi-language: TH"><span class="auto-style3">: </span><span class="auto-style3" lang="TH">การให้ความเห็นจะไม่แสดงในเล่มรายงาน</span></span></td>
                        </tr>
                    </table>
                </div>
            </div>


        </div>
</asp:Content>
