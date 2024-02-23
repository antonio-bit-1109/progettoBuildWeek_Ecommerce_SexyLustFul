<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AcquistoAbbonamento.aspx.cs" Inherits="U4_BW1_LL.AcquistoAbbonamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="sexyPink2">
            <p id="p1" runat="server"></p>
            <p id="p2" runat="server"></p>
            <p id="p3" runat="server"></p>
        </div>
        <h4 class="sexyPink2">Vuoi Procedere? </h4>
        <asp:Button ID="confermaAcquisto" runat="server" Text="Si "  OnClick="confermaAcquistoAbbonamento_Click"/>
        <asp:Button ID="rifiutaAcquisto" runat="server" Text="No"  OnClick="confermaAcquistoAbbonamento_Click"/>
    </div>

    <asp:Button Text="checkSessione" runat="server" OnClick="controlloSessione" />
</asp:Content>
