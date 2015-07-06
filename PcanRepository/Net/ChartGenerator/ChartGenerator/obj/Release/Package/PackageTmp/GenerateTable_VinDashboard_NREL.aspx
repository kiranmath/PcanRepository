<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateTable_VinDashboard_NREL.aspx.cs" Inherits="ChartGenerator.GenerateTable_VinDashboard_NREL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NREL Reports</title>
       <link type="text/css" rel="stylesheet" href="Content/TabData.css" />
</head>
<body>
    <form id="NRELReports" runat="server">
    <div>
    

        <table border="0">

       <tr>
           <td colspan="3">
               <label runat="server" id="lblHead" ><b> Daily Grab Automated Reports</b> </label> &nbsp;&nbsp; <label id="lblDate" runat="server"> </label>
            </td>

       </tr>

       <tr>
           <td colspan="3">
               <label id="lblVin" runat="server"> </label>
            </td>

       </tr>
  
       <tr>
           <td class="gettop" rowspan="2">
                 <asp:GridView ID="GridView1" runat="server"
                                    AutoGenerateColumns="False" 
                                    GridLines="None"  
                                    AllowPaging="false"  
                                    CssClass="mGrid"  
                                    PagerStyle-CssClass="pgr"  
                                    AlternatingRowStyle-CssClass="alt">
                         <Columns>
                                     <asp:TemplateField HeaderText="Operational Overview Data">
                                         <HeaderStyle HorizontalAlign="left" />
                                         <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Signal") %>'></asp:Label>
                                         </ItemTemplate>  
                                         </asp:TemplateField>
                                     <asp:TemplateField HeaderText="">
                                     <ItemTemplate>
                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("Val") %>'></asp:Label>
                                     </ItemTemplate>
                                                  <ItemStyle CssClass="gvItemRight" />
                                     </asp:TemplateField>

                                      <asp:TemplateField HeaderText="">
                                    <ItemTemplate>
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Units") %>'></asp:Label>
                                     </ItemTemplate>
                                     </asp:TemplateField>
                         </Columns>
                        </asp:GridView>             

           </td>
            <td class="gettop" rowspan="2">&nbsp;</td>
            <td class="gettop">             
            
                 <asp:GridView ID="GridView3" runat="server"
                                AutoGenerateColumns="False" 
                                GridLines="None"  
                                AllowPaging="false"  
                                CssClass="mGrid"  
                                PagerStyle-CssClass="pgr"  
                                AlternatingRowStyle-CssClass="alt">
                     <Columns>
                                 <asp:TemplateField HeaderText="HVAC Operation Modes">

                                     <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Signal") %>'></asp:Label>
                                     </ItemTemplate>         
             
                                     </asp:TemplateField>
                                 <asp:TemplateField HeaderText="">
                                      <HeaderStyle HorizontalAlign="left" />
                                     <ItemTemplate>
                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("Val") %>'></asp:Label>
                                     </ItemTemplate>
                                     <ItemStyle CssClass="gvItemRight" />
                                     </asp:TemplateField>

                                     <asp:TemplateField HeaderText="">
                                     <ItemTemplate>
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Units") %>'></asp:Label>
                                     </ItemTemplate>
                                 </asp:TemplateField>
                     </Columns>
                </asp:GridView>
            </td>

        </tr>
            <tr>

               <td class="gettop">
                  <asp:GridView ID="GridView4" runat="server"
                                AutoGenerateColumns="False" 
                                GridLines="None"  
                                AllowPaging="false"  
                                CssClass="mGrid"  
                                PagerStyle-CssClass="pgr"  
                                AlternatingRowStyle-CssClass="alt">
                     <Columns>
                                 <asp:TemplateField HeaderText="System Data">
                                     <HeaderStyle HorizontalAlign="left" />
                                     <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Signal") %>'></asp:Label>
                                     </ItemTemplate>         
             
                                     </asp:TemplateField>
                                 <asp:TemplateField HeaderText="">
                                     <ItemTemplate>
                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("Val") %>'></asp:Label>
                                     </ItemTemplate>
                                     <ItemStyle CssClass="gvItemRight" />
                                     </asp:TemplateField>

                                     <asp:TemplateField HeaderText="">
                                     <ItemTemplate>
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Units") %>'></asp:Label>
                                     </ItemTemplate>
                                 </asp:TemplateField>
                     </Columns>
                </asp:GridView>

            </td>
           </tr>
            <tr>

                  <td >

       
               <asp:GridView ID="GV_DailyTempData1" runat="server"
                                            AutoGenerateColumns="false" 
                                            GridLines="None"  
                                            AllowPaging="false"  
                                            CssClass="mGrid"  
                                            PagerStyle-CssClass="pgr"  
                                            AlternatingRowStyle-CssClass="alt" Visible="false">
                                 <Columns>

                            
                                         <asp:TemplateField HeaderText="">
                                                 <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>
                                                    <asp:Label ID="Label_TempData" runat="server" Text='<%# Bind("TempData", "{0:M/dd/yyyy}") %>'></asp:Label>
                                                 </ItemTemplate>  
                                                 </asp:TemplateField>
                                            
                                              <asp:TemplateField HeaderText="Min[C]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>
                                                 <asp:Label ID="Label_MinTemp" runat="server" Text='<%# Bind("MinTemp") %>'></asp:Label>
                                             </ItemTemplate>
                                                          <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>

                                              <asp:TemplateField HeaderText="Max[C]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label_MaxTemp" runat="server" Text='<%# Bind("MaxTemp") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>


                                              <asp:TemplateField HeaderText="Avg[C]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label_AvgTemp" runat="server" Text='<%# Bind("AvgTemp") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>                                           
    
                                       

                                 </Columns>
                                </asp:GridView>


           </td>
                <td></td>
           <td class="gettop"> 




                     <asp:GridView ID="GridView5" runat="server"
                                AutoGenerateColumns="False" 
                                GridLines="None"  
                                AllowPaging="false"  
                                CssClass="mGrid"  
                                PagerStyle-CssClass="pgr"  
                                AlternatingRowStyle-CssClass="alt">
                     <Columns>
                                 <asp:TemplateField HeaderText="Efficiency Data">
                                     <HeaderStyle HorizontalAlign="left" />
                                     <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Signal") %>'></asp:Label>
                                     </ItemTemplate>         
             
                                     </asp:TemplateField>
                                 <asp:TemplateField HeaderText="">
                                     <ItemTemplate>
                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("Val") %>'></asp:Label>
                                     </ItemTemplate>
                                     <ItemStyle CssClass="gvItemRight" />
                                     </asp:TemplateField>

                                     <asp:TemplateField HeaderText="">
                                     <ItemTemplate>
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Units") %>'></asp:Label>
                                     </ItemTemplate>
                                 </asp:TemplateField>
                     </Columns>
                </asp:GridView>


            </td>
       </tr>

            <tr>
           <td colspan=" 3">


                 <asp:GridView ID="GV_DailyChargingData" runat="server"
                                            AutoGenerateColumns="False" 
                                            GridLines="None"  
                                            AllowPaging="false"  
                                            CssClass="mGrid"  
                                            PagerStyle-CssClass="pgr"  
                                            AlternatingRowStyle-CssClass="alt" Visible="true">
                                 <Columns>

                            
                                             <asp:TemplateField HeaderText="Date">
                                                 <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>                                                                                                         
                                                    <asp:Label ID="Label1" runat="server"  Width="110px"  Text='<%# Bind("ProcessDate", "{0:M/dd/yyyy}") %>'></asp:Label>
                                                 </ItemTemplate>  
                                                 </asp:TemplateField>
                                            
                                              <asp:TemplateField HeaderText="Runtime [hr] ">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>
                                                 <asp:Label ID="Label2" runat="server"  Width="90px" Text='<%# Bind("Runtime") %>'></asp:Label>
                                             </ItemTemplate>
                                                          <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>

                                              <asp:TemplateField HeaderText="Charges [#] ">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Width="90px"  Text='<%# Bind("ChargeCount") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>



                                            

                                            <asp:TemplateField HeaderText="Distance [mi] ">
                                                   <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Width="90px"  Text='<%# Bind("Distance") %>'></asp:Label>
                                             </ItemTemplate>
                                                  <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>


                                           
                                              <asp:TemplateField HeaderText="Charged Energy [kWh] ">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server"  Width="90px" Text='<%# Bind("ChargedEnergy") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>


                                             <asp:TemplateField HeaderText="Total Energy [kWh] ">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server"  Width="90px" Text='<%# Bind("TotalEnergy") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>

                                 </Columns>
                                </asp:GridView>             
                         



           </td>
           
       </tr>

            
            </table>



    </div>
         <div id ="footer"></div>

    </form>
</body>
</html>
