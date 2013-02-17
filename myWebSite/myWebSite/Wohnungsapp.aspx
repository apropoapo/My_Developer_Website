<%@ Page Title="" Language="C#" MasterPageFile="~/myMaster.Master" AutoEventWireup="true" CodeBehind="Wohnungsapp.aspx.cs" Inherits="myWebSite.Wohnungsapp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Mein Wohnungsapp-Projekt kann man zur Zeit in folgende Teilprojekte unterteilen
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Left">
    <asp:Table ID="Table1" runat="server" CellPadding="10" GridLines="Both" HorizontalAlign="Left">
    <asp:TableHeaderRow><asp:TableHeaderCell>% Anteil an<br />Gesamtapp</asp:TableHeaderCell><asp:TableHeaderCell>Bezeichnung</asp:TableHeaderCell><asp:TableHeaderCell>% Done</asp:TableHeaderCell></asp:TableHeaderRow>
    <asp:TableRow><asp:TableCell>30</asp:TableCell><asp:TableCell>Windows Phone App selber</asp:TableCell><asp:TableCell>0</asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell>20</asp:TableCell><asp:TableCell>Windows Phone Pushzeugs</asp:TableCell><asp:TableCell>15</asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell>20</asp:TableCell><asp:TableCell>Backgroundworker</asp:TableCell><asp:TableCell>12</asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell>20</asp:TableCell><asp:TableCell>WCF Service</asp:TableCell><asp:TableCell>17</asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell>10</asp:TableCell><asp:TableCell>Datenbank</asp:TableCell><asp:TableCell>9</asp:TableCell></asp:TableRow>
    </asp:Table>
    </asp:Panel>
    <br />
    <div>
        "Anteil" beschreibt den geschätzten Arbeitsaufwandanteil am Gesamtaufwand der App. "Done" sagt 
    </div>
</asp:Content>
