<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ChartGenerator.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Proterra <br />
        1 Whitlee Ct.<br />
        Greenville, SC 29607<br />

      
        <abbr title="Phone">P:</abbr> 864.438.0000
        <abbr title="Fax">F:</abbr> 864.281.1894
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:kmath@proterra.com">kmath@proterra.com</a><br />
        
    </address>
</asp:Content>
