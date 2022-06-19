<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="UrunAra.aspx.cs" Inherits="WebFormOdev.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Ürün arama sayfası<br />
        <table class="w-100">
            <tr>
                <td style="width: 327px">Ürün Adı</td>
                <td>
                    <asp:TextBox ID="TxtAra" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 327px">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnAra" runat="server" OnClick="BtnAra_Click" Text="Arama Yap" />
                    <br />
                    <br />
                    <br />
                    <asp:GridView ID="GrdSonuc" runat="server">
                    </asp:GridView>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
&nbsp;</form>
</asp:Content>
