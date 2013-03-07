<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wohnungslogs.aspx.cs" Inherits="myWebSite.Wohnungslogs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="/Shared/Style_Whg_App.css" />
    <title>Wohnungslog</title>
</head>
<body>
<h1>Wohnungslogs</h1>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="myDatalst" runat="server" CellPadding="0" CellSpacing="0" Width="100%">
            <ItemTemplate>
                <tr>
                    <td>
                    <a  href='<%# DataBinder.Eval(Container.DataItem, "Link")%>'>
                        <div id="line" />
                        <div id="header">
                            <%# DataBinder.Eval(Container.DataItem, "Header")%></div>
                        <asp:Image ID="Bild" runat="server" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "Bild")%>' />
                        <table id="table" align="center" frame="void" >
                            <tr class="contentTableRow">
                                <td>Kaltemiete:</td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Kaltmiete")%></td>
                            </tr>
                            <tr class="contentTableRow">
                                <td>Wohnflaeche:</td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Wohnflaeche")%></td>
                            </tr>
                            <tr class="contentTableRow">
                                <td>Zimmer:</td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Zimmer")%></td>      
                            </tr>
                            <tr class="contentTableRow">
                                <td>Ausstattung:</td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Ausstattung1")%></td>
                            </tr>
                            <tr>
                                <td></td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Ausstattung2")%></td>
                            </tr>
                            <tr class="contentTableRow">
                                <td></td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Ausstattung3")%></td>
                            </tr>
                            <tr class="contentTableRow">
                                <td></td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Ausstattung4")%></td>
                            </tr>
                            <tr class="contentTableRow">
                                <td>Lage:</td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Lage")%></td>
                            </tr>
                            <tr class="contentTableRow">
                                <td>Anzeige seit:</td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Zeit")%></td>
                            </tr>
 </a>
                        </table>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
