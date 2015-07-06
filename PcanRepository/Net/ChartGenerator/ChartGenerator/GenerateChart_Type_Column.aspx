<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateChart_Type_Column.aspx.cs" Inherits="ChartGenerator.GenerateChart_Type_Column" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Daily Grab</title>
    
            <!-- REQUIRED -->
        <script src="http://code.jquery.com/jquery-1.7.min.js" type="text/javascript"></script>
        <!-- END REQUIRED -->

        <!-- NOT REQUIRED scripts of SyntaxHighlighter -->
        <link href="/Resources/Css/shCoreDefault.css" rel="stylesheet" type="text/css" />    
        <script type="text/javascript" src="/Resources/Scripts/shCore.js"></script>
        <script type="text/javascript" src="/Resources/Scripts/shBrushCSharp.js"></script>   
        <script type="text/javascript" src="/Resources/Scripts/shBrushXml.js"></script>   
   
        <!-- END NOT REQUIRED SyntaxHighlighter -->

      

        <!-- NOT REQUIRED layout of demo website -->
        <link href="/Resources/css/layout.css" rel="stylesheet" />      
        <!-- END NOT REQUIRED layout of demo website -->

</head>
<body>
    <form id="form1" runat="server">
    <div>
       <highcharts:ColumnChart id="hcFrutas" Width="500" Height="250" runat="server">
       </highcharts:ColumnChart>
    </div>
   <div id ="footer"></div>
    </form>
</body>
</html>