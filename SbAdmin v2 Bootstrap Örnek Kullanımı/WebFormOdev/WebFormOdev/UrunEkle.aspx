<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="UrunEkle.aspx.cs" Inherits="WebFormOdev.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server" style="height: 197px">
    Ürün ekleme sayfası<br />
    <table class="w-100" style="height: 125px">
        <tr>
            <td style="width: 295px">Ürün Adı</td>
            <td>
                <asp:TextBox ID="TxtUrunAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 295px">Tedarikçi ID</td>
            <td>
                <asp:DropDownList ID="DdTedarik" runat="server" DataSourceID="SqlDataSource3" DataTextField="TedarikciID" DataValueField="TedarikciID">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:sirketConnectionString %>" SelectCommand="SELECT [TedarikciID] FROM [Urunler]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sirketConnectionString %>" SelectCommand="SELECT [UrunAdi] FROM [Urunler]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 295px">Kategori ID</td>
            <td>
                <asp:DropDownList ID="DdKategori" runat="server" DataSourceID="SqlDataSource2" DataTextField="TedarikciID" DataValueField="TedarikciID">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:sirketConnectionString %>" SelectCommand="SELECT [TedarikciID] FROM [Tedarikciler]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td style="width: 295px; height: 4px">Birim Fiyat</td>
            <td style="height: 4px">
                <br />
                <br />
                <asp:TextBox ID="TxtFiyat1" runat="server" Height="32px" Width="173px"></asp:TextBox>
                <asp:Button ID="BtnEntitie" runat="server" OnClick="BtnEntitie_Click" Text="Entitie İle Ekle" />
                <br />
                <asp:Button ID="BtnEkle" runat="server" Height="25px" Text="Ekle" Width="73px" OnClick="BtnEkle_Click" />
                <br />
            </td>
        </tr>
    </table>
&nbsp;</form>
</asp:Content>
