<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateTable_VinDashboard_Tabular.aspx.cs" Inherits="ChartGenerator.GenerateTable_VinDashboard_Tabular" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link type="text/css" rel="stylesheet" href="Content/TabData.css" />
</head>
<body>
    <form id="form1" runat="server">
   

          <table border="0">
               <tr>
                   <td class="gettop">
                         <asp:GridView ID="GV_DailyChargingData" runat="server"
                                            AutoGenerateColumns="False" 
                                            GridLines="None"  
                                            AllowPaging="false"  
                                            CssClass="mGrid"  
                                            PagerStyle-CssClass="pgr"  
                                            AlternatingRowStyle-CssClass="alt" Visible="false">
                                 <Columns>

                            
                                             <asp:TemplateField HeaderText="Date">
                                                 <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProcessDate", "{0:M/dd/yyyy}") %>'></asp:Label>
                                                 </ItemTemplate>  
                                                 </asp:TemplateField>
                                            
                                              <asp:TemplateField HeaderText="Runtime[hr]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>
                                                 <asp:Label ID="Label2" runat="server" Text='<%# Bind("Runtime") %>'></asp:Label>
                                             </ItemTemplate>
                                                          <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>

                                              <asp:TemplateField HeaderText="Charges[#]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("ChargeCount") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>


                                              <asp:TemplateField HeaderText="Charged Energy[kWh]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("ChargedEnergy") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>

                                            

                                            <asp:TemplateField HeaderText="Distance[mi]">
                                                   <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("Distance") %>'></asp:Label>
                                             </ItemTemplate>
                                                  <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>

                                 </Columns>
                                </asp:GridView>             
                         
                         <asp:GridView ID="GV_DailyTempData" runat="server"
                                            AutoGenerateColumns="False" 
                                            GridLines="None"  
                                            AllowPaging="false"  
                                            CssClass="mGrid"  
                                            PagerStyle-CssClass="pgr"  
                                            AlternatingRowStyle-CssClass="alt" Visible="false">
                                 <Columns>

                                             <asp:TemplateField HeaderText="">
                                                 <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("TempData", "{0:M/dd/yyyy}") %>'></asp:Label>
                                                 </ItemTemplate>  
                                                 </asp:TemplateField>
                                            
                                              <asp:TemplateField HeaderText="Min[C]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                                 <ItemTemplate>
                                                 <asp:Label ID="Label2" runat="server" Text='<%# Bind("MinTemp") %>'></asp:Label>
                                             </ItemTemplate>
                                                          <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>

                                              <asp:TemplateField HeaderText="Max[C]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("MaxTemp") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>


                                              <asp:TemplateField HeaderText="Avg[C]">
                                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                            <ItemTemplate>
                                             <asp:Label ID="Label3" runat="server" Text='<%# Bind("AvgTemp") %>'></asp:Label>
                                             </ItemTemplate>
                                                    <ItemStyle CssClass="gvItemRight" />
                                             </asp:TemplateField>                                           

                                       

                                 </Columns>
                                </asp:GridView> 
                   
                        <asp:GridView ID="GV_DailyBatteryData" runat="server"
                                AutoGenerateColumns="False" 
                                GridLines="None"  
                                AllowPaging="false"  
                                CssClass="mGrid"  
                                PagerStyle-CssClass="pgr"  
                                AlternatingRowStyle-CssClass="alt" Visible="false">
                                <Columns>

                                 <asp:TemplateField HeaderText="Battery Pack  ">
                                     <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                     <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("BatteryPack") %>'></asp:Label>
                                     </ItemTemplate>  
                                     </asp:TemplateField>

                                  <asp:TemplateField HeaderText="dSoC    ">
                                         <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                     <ItemTemplate>
                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("dSoC") %>'></asp:Label>
                                 </ItemTemplate>
                                              <ItemStyle CssClass="gvItemRight" />
                                 </asp:TemplateField>

                                  <asp:TemplateField HeaderText="I_Min    ">
                                         <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("I_Min") %>'></asp:Label>
                                 </ItemTemplate>
                                        <ItemStyle CssClass="gvItemRight" />
                                 </asp:TemplateField>


                                  <asp:TemplateField HeaderText="I_Max    ">
                                         <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("I_Max") %>'></asp:Label>
                                 </ItemTemplate>
                                        <ItemStyle CssClass="gvItemRight" />
                                 </asp:TemplateField>          

                                 <asp:TemplateField HeaderText="T_Min   ">
                                         <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("T_Min") %>'></asp:Label>
                                 </ItemTemplate>
                                        <ItemStyle CssClass="gvItemRight" />
                                 </asp:TemplateField>


                                  <asp:TemplateField HeaderText="T_Max   ">
                                         <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("T_Max") %>'></asp:Label>
                                 </ItemTemplate>
                                        <ItemStyle CssClass="gvItemRight" />
                                 </asp:TemplateField>          
      
                                <asp:TemplateField HeaderText="SoC Range   ">
                                         <HeaderStyle HorizontalAlign="left" Wrap="False" />
                                <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("SOC_Range") %>'></asp:Label>
                                 </ItemTemplate>
                                        <ItemStyle CssClass="gvItemRight" />
                                 </asp:TemplateField>          
 
                                </Columns>
                                </asp:GridView>
                   
                   
                   
                   </td>
           </tr>
     </table>




 <div id ="footer"></div>

    </form>
</body>
</html>
