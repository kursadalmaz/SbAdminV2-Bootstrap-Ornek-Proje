<%@ Page Title="" Language="C#" MasterPageFile="~/AdminLayout.Master" AutoEventWireup="true" CodeBehind="Urunlistele.aspx.cs" Inherits="WebFormOdev.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <table class="table table-striped table-hover">
    <thead>

        <tr>
            <th scope="col">UrunAdi</th>
            <th scope="col">Tedarikci</th>
            <th scope="col">Kategori</th>
            <th scope="col">birimfiyat</th>
        </tr>
    </thead>
    <tbody>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>

                <tr>
                    <th scope="row">1</th>
                    <td><%#Eval("urunadi")%> </td>
                       <td><%#Eval("TedarikciID")%> </td>
                       <td><%#Eval("KategoriID")%> </td>
                       <td><%#Eval("BirimFiyati")%> </td>
                    <td>
                        <a href="UrunSil.aspx?urunid=<%#Eval("Urunid") %>" class="btn btn-danger btn-icon-split">
                            <span class="icon text-white-50">
                                <i class="fas fa-trash"></i>
                            </span>
                            <span class="text">Sil </span>
                        </a>
                    </td>
                </tr>

            </ItemTemplate>
        </asp:Repeater>
    </tbody>
        </table>
</asp:Content>
