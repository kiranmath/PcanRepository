<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateTable_VinDashboard_Battery.aspx.cs" Inherits="ChartGenerator.GenerateTable_VinDashboard_Battery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Battery Reports</title>
       <link type="text/css" rel="stylesheet" href="Content/TabData.css" />
    <style>
    FIELDSET
{
   padding:20px;
   border-color:greenyellow;
   -moz-border-radius: 8px;
   border-radius: 8px; 
   -webkit-border-radius: 8px;
}

LEGEND
{
    text-transform:uppercase;
}
</style>
</head>
<body>
    <form id="BatteryReports" runat="server">
    <div>
    

        <table border="0">

     
       <tr>
           <td colspan="3">
               <label id="lblDt" runat="server"> </label>
            </td>

       </tr>
  
       <tr>
           <td class="gettop" rowspan="2">
               <fieldset>
  <legend id="CustName" runat="server">Personalia:</legend>
                 <asp:GridView ID="gvBattery" runat="server"
                                    AutoGenerateColumns="False" 
                                    GridLines="None"  
                                    AllowPaging="false"  
                                    CssClass="mGrid"  
                                    PagerStyle-CssClass="pgr"  
                                    AlternatingRowStyle-CssClass="alt">
                                        <Columns>

                                                   <asp:TemplateField HeaderText="">
                                         <HeaderStyle HorizontalAlign="center" />
                                         <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("RowID") %>'></asp:Label>
                                         </ItemTemplate>  
                                         <ItemStyle CssClass="gvItemRight" />
                                                           <ItemStyle Width="80" />
                                         </asp:TemplateField>


                                     <asp:TemplateField HeaderText="Bus">
                                         <HeaderStyle HorizontalAlign="center" />
                                         <ItemTemplate>
                                              <div style="overflow: hidden; width:80px; ">
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Bus") %>'></asp:Label>
                                                  </div>
                                         </ItemTemplate>  
                                         <ItemStyle CssClass="gvItemRight" width="80px" />
                                        
                                         </asp:TemplateField>




                                     <asp:TemplateField HeaderText="MinPackI_a">



                                     <ItemTemplate>
                                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("MinPackI_a") %>'></asp:Label>
                                     </ItemTemplate>
                                                  <ItemStyle CssClass="gvItemRight" width="80px" />
                                             <ItemStyle Width="80" />
                                     </asp:TemplateField>

                                      <asp:TemplateField HeaderText="MaxPackI_a">
                                    <ItemTemplate>
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("MaxPackI_a") %>'></asp:Label>
                                     </ItemTemplate>
                                          <ItemStyle CssClass="gvItemRight" width="80px" />
                                              <ItemStyle Width="80" />
                                     </asp:TemplateField>

                                       <asp:TemplateField HeaderText="Temp">
                                    <ItemTemplate>
                                        <div style="overflow: hidden; width:80px; ">
                                              <div style="overflow: hidden; width:80px; ">
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Temp") %>'></asp:Label>
                                                  </div>
                                            </div>
                                     </ItemTemplate>
                                           <ItemStyle CssClass="gvItemRight" width="200px" />
                                              
                                     </asp:TemplateField>

                                        <asp:TemplateField HeaderText="SoC%">
                                    <ItemTemplate>
                                         <div style="overflow: hidden; width:80px; ">
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Soc") %>'></asp:Label>
                                             </div>
                                     </ItemTemplate>
                                            <ItemStyle CssClass="gvItemRight" width="200px"/>
                                               
                                     </asp:TemplateField>

                                           <asp:TemplateField HeaderText="Drive(hr)">
                                    <ItemTemplate>
                                     <asp:Label ID="Label3" runat="server" Text='<%# Bind("Drive_h") %>'></asp:Label>
                                     </ItemTemplate>
                                               <ItemStyle CssClass="gvItemRight"  />
                                              <ItemStyle Width="80" />
                                     </asp:TemplateField>
                         </Columns>
                        </asp:GridView>  
                   
                      </fieldset> 
           </td>           
       </tr>
            
            </table>



    </div>
         <div id ="footer"></div>

    </form>
</body>
</html>
