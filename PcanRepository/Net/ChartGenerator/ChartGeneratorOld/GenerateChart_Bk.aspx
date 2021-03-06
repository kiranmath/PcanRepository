﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateChart_Bk.aspx.cs" Inherits="ChartGenerator.GenerateChart_SoC_Bk" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


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
       <highcharts:LineChart ID="hcVendas" Width="600" Height="300" runat="server" RenderType="line" />
    </div>
        <div id ="footer"></div>
    </form>
</body>
</html>
